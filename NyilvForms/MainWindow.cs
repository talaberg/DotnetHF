using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net;
using System.Data.Entity;
using NyilvLib;
using NyilvLib.Entities;

namespace NyilvForms
{
    public partial class MainWindow : Form
    {
        bool dataGridViewCellChanged;
        TreeNode currentnode;
        int currentCegID = 1;
        public MainWindow()
        {
            InitializeComponent();

            


            //Init ComboBox parameteres
                //Make ComboBoxes not editable
            comboBoxFindElement.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFindCondiditon.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBoxFindElementInit();
            comboBoxFindCondiditon.ValueMember = "Name";

            dataGridViewCellChanged = false;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Event functions ----------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------


        //      Main menu  ----------------------------------------------------------------------------------------------------------------------------------------------
        private void importalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdImport.ShowDialog();
        }
        private void ofdImport_FileOk(object sender, CancelEventArgs e)
        {
            using (var client = new WebClient())
            {

                string s = ofdImport.FileName;
                client.UploadFileAsync(new Uri(ControllerImport.ControllerUrl), ofdImport.FileName.ToString());

                /* resp.EnsureSuccessStatusCode();

                 var adat = resp.Content.ReadAsAsync<Alapadatok>().Result;
                 alapadatokBindingSource.Add(adat as Alapadatok);*/
            }
        }
        private void aremelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aremeles a = new Aremeles();
            a.ShowDialog();
            if (a.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Aremeles(a.Emeles);                
            }
        }

        //      Database  ----------------------------------------------------------------------------------------------------------------------------------------------
        private void btFind_Click(object sender, EventArgs e)
        {
            RunFindQUery();
        }

        //      UI event  ----------------------------------------------------------------------------------------------------------------------------------------------

        private void buttonLoadAll_Click(object sender, EventArgs e)
        {
            List<Alapadatok> ClientList = GetAllAlapadat();
            UpdateAlapadatokField(ClientList);
            UpdateCegadatok(ClientList.First().CegID);
            UpdateDokumentumok(ClientList.First().CegID);
        }

        private void alapadatokDataGridView_CellSwitch(object sender, EventArgs e)
        {
            int index = alapadatokDataGridView.CurrentCell.RowIndex;
            if (index >= 0)
            {
                int ID = (int)alapadatokDataGridView.Rows[index].Cells[0].Value;
                currentCegID = ID;
                UpdateCegadatok(ID);
                UpdateDokumentumok(ID);
            }
        }

        private void comboBoxFindElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxElementItem Item = (ComboBoxElementItem)comboBoxFindElement.SelectedItem;
            System.TypeCode ItemTypeCode = Type.GetTypeCode(Item.Type);

            ComboBoxFindConditionUpdate(ItemTypeCode);

        }
        private void textBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RunFindQUery();
            }
        }
        private void alapadatokDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCellChanged = true;
        }

        private void alapadatokDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCellChanged)
            {
                UpdateDatabase((Alapadatok)alapadatokDataGridView.Rows[e.RowIndex].DataBoundItem);
                dataGridViewCellChanged = false;
            }
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            RemoveAlapadatokElement(currentCegID);
            RemoveCegadatokElement(currentCegID);
        }
        private void buttonCegadatFrissit_Click(object sender, EventArgs e)
        {
            Cegadatok c = (Cegadatok)cegadatokBindingSource.Current;
            if (c != null)
            {
                UpdateDatabase(c);
            }
        }
        // Dokumentumok Tree View ------
        private void treeViewDokumentumok_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);

                // Get the node that the user has clicked.
                TreeNode node = treeViewDokumentumok.GetNodeAt(p);
                if (node != null)
                {
                    currentnode = node;
                    contextMenuDokumentumokNode.Show(Control.MousePosition);
                    treeViewDokumentumok.SelectedNode = node;
                }
            }
        }
        private void hozzaadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumentumok doc = new Dokumentumok{
                CegID = currentCegID,
                 Dokumentum_tipus = currentnode.Parent != null ? currentnode.Parent.Text : currentnode.Text,
            };

            ManageDocument m = new ManageDocument(doc);
            m.ShowDialog();
            if (m.DialogResult == DialogResult.OK)
            {
                UpdateDatabase(m.Document);
                UpdateDokumentumok(currentCegID);
            }

        }
        private void modositasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DokumentumokModify();
        }
        private void eltavolitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentnode.Parent != null)
	        {
		        RemoveDokumentumokElement((int)currentnode.Tag);
                UpdateDokumentumok(currentCegID);
	        }
            
        }
        //-----------------------------


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        // UI update functions ------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void UpdateAlapadatokField(Alapadatok adat)
        {
            alapadatokBindingSource.Clear();
            alapadatokBindingSource.Add(adat as Alapadatok);
        }
        private void UpdateAlapadatokField(List<Alapadatok> ClientList)
        {
            alapadatokBindingSource.Clear();
            foreach (Alapadatok client in ClientList)
            {
                alapadatokBindingSource.Add(client);
            }
        }
        private void UpdateCegadatokField(Cegadatok ceg)
        {
            cegadatokBindingSource.Clear();
            cegadatokBindingSource.Add(ceg);
        }

        private void UpdateDokumentumokField(List<Dokumentumok> documents)
        {
            treeViewDokumentumok.Nodes.Clear();
            documents.OrderBy(c => c.Dokumentum_tipus);
            if (documents.Count != 0)
            {
                foreach (Dokumentumok doc in documents)
                {
                    TreeNode t;
                    if (treeViewDokumentumok.Nodes.ContainsKey(doc.Dokumentum_tipus))
                    {
                        t = treeViewDokumentumok.Nodes.Find(doc.Dokumentum_tipus, false)[0];
                    }
                    else
                    {
                        t = new TreeNode(doc.Dokumentum_tipus) { Name = doc.Dokumentum_tipus };
                        treeViewDokumentumok.Nodes.Add(t);
                    }

                    t.Nodes.Add(new TreeNode(doc.Datum.ToString()) { ToolTipText = doc.Megjegyzes, Tag = doc.DokumentumID });
                }
            }
            else
            { 
                treeViewDokumentumok.Nodes.Add(new TreeNode("<Nincs megjelenítendő dokumentum>"));
            }

        }
        void UpdateCegadatok(int ID)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(ControllerGetCegadatokById.ControllerUrl(ID)).Result;

                var adat = resp.Content.ReadAsAsync<Cegadatok>().Result;

                if (adat == null) adat = new Cegadatok { CegID = ID };
                UpdateCegadatokField(adat);
            }
        }
        void UpdateDokumentumok(int ID)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(ControllerGetDokumentumokById.ControllerUrl(ID)).Result;

                var adat = resp.Content.ReadAsAsync<List<Dokumentumok>>().Result;

                UpdateDokumentumokField(adat);
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Other functions ----------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        List<Alapadatok> GetAllAlapadat()
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(ControllerGetAlapadatAll.ControllerUrl).Result;
                resp.EnsureSuccessStatusCode();

                var adat = resp.Content.ReadAsAsync<List<Alapadatok>>().Result;

                return adat;
            } 
        }

        void RunFindQUery()
        {
            if (textBoxFind.Text != "")
            {
                ComboBoxElementItem Item = (ComboBoxElementItem)comboBoxFindElement.SelectedItem;
                ComboBoxConditionItem ItemCondition = (ComboBoxConditionItem)comboBoxFindCondiditon.SelectedItem;

                var query = new MyQuery() { Item2Find = Item.Name, Condition = ItemCondition.Condition, Value = textBoxFind.Text };

                using (var client = new HttpClient())
                {
                    var resp = client.PutAsJsonAsync(ControllerFindAlapadat.ControllerUrl, query).Result;
                    resp.EnsureSuccessStatusCode();

                    var adat = resp.Content.ReadAsAsync<List<Alapadatok>>().Result;
                    
                    
                    if(adat.Count != 0) 
                    {
                        UpdateAlapadatokField(adat);
                        UpdateCegadatok(adat.First().CegID);
                        UpdateDokumentumok(adat.First().CegID); 
                    }
                    else
                    {
                        treeViewDokumentumok.Nodes.Clear();
                        alapadatokBindingSource.Clear();
                        cegadatokBindingSource.Clear();
                    }
                        
                }
            }
        }

        void ComboBoxFindElementInit()
        {
            foreach (var prop in new Alapadatok().GetType().GetProperties())
            {
                var element = new ComboBoxElementItem(){ Name = prop.Name, Type = prop.PropertyType };
                comboBoxFindElement.Items.Add(element);
            }
            comboBoxFindElement.ValueMember = "Name";
            comboBoxFindElement.SelectedIndex = 0;
        }

        void ComboBoxFindConditionUpdate(TypeCode ItemTypeCode)
        {
            comboBoxFindCondiditon.Items.Clear();
            switch (ItemTypeCode)
            {
                case TypeCode.Boolean:                  
                    comboBoxFindCondiditon.Items.Add(new ComboBoxConditionItem() { Name = "Igen", Condition = MyQuery.TrueCondition });
                    comboBoxFindCondiditon.Items.Add(new ComboBoxConditionItem() { Name = "Nem", Condition = MyQuery.FalseCondition });
                    break;
                case TypeCode.String:
                    comboBoxFindCondiditon.Items.Add(new ComboBoxConditionItem() { Name = "Tartalmazza", Condition = MyQuery.ContainsCondition });
                    comboBoxFindCondiditon.Items.Add(new ComboBoxConditionItem() { Name = "Pontosan", Condition = MyQuery.EqualsCondition });
                    break;
                case TypeCode.Int32:
                    comboBoxFindCondiditon.Items.Add(new ComboBoxConditionItem() { Name = "Egyenlő", Condition = MyQuery.EqualsCondition });
                    break;
                default:
                    comboBoxFindCondiditon.Items.Add(new ComboBoxConditionItem() { Name = "Egyenlő", Condition = MyQuery.EqualsCondition });
                    break;
            }

            comboBoxFindCondiditon.SelectedIndex = 0;
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        void UpdateDatabase(Alapadatok data)
        {
            using (var client = new HttpClient())
            {
                var resp = client.PostAsJsonAsync(ControllerUpdateAlapadat.ControllerUrl, data).Result;
                resp.EnsureSuccessStatusCode();
            } 
        }

        void UpdateDatabase(Cegadatok data)
        {
            using (var client = new HttpClient())
            {
                var resp = client.PostAsJsonAsync(ControllerUpdateCegadatok.ControllerUrl, data).Result;
                resp.EnsureSuccessStatusCode();
            }
        }
        void UpdateDatabase(Dokumentumok data)
        {
            using (var client = new HttpClient())
            {
                var resp = client.PostAsJsonAsync(ControllerUpdateDokumentumok.ControllerUrl, data).Result;
                resp.EnsureSuccessStatusCode();
            }
        }

        void RemoveAlapadatokElement(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(new Uri(ControllerDeleteAlapadatById.ControllerUrl(id))).Result;
                resp.EnsureSuccessStatusCode();
            }
        }
        void RemoveCegadatokElement(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(new Uri(ControllerDeleteCegadatokById.ControllerUrl(id))).Result;
                resp.EnsureSuccessStatusCode();
            }
        }
        void RemoveDokumentumokElement(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(new Uri(ControllerDeleteDokumentumokById.ControllerUrl(id))).Result;
                resp.EnsureSuccessStatusCode();
            }
        }
        void DokumentumokModify()
        {
            Dokumentumok doc;
            if (currentnode.Parent != null) // child clicked
            {
                doc = new Dokumentumok
                {
                    DokumentumID = (int)currentnode.Tag,
                    CegID = currentCegID,
                    Dokumentum_tipus = currentnode.Parent.Text,
                    Megjegyzes = currentnode.ToolTipText,
                    Datum = DateTime.Parse(currentnode.Text)
                };
            }
            else //category clicked
            {
                doc = new Dokumentumok
                {
                    CegID = currentCegID,
                    Dokumentum_tipus = currentnode.Text
                };
            }
            ManageDocument m = new ManageDocument(doc);
            m.ShowDialog();
            if (m.DialogResult == DialogResult.OK)
            {
                UpdateDatabase(m.Document);
                UpdateDokumentumok(currentCegID);
            }

        }

        private void Aremeles(double p)
        {
            using (var client = new HttpClient())
            {
                var resp = client.PostAsJsonAsync(ControllerAremeles.ControllerUrl, p).Result;
                resp.EnsureSuccessStatusCode();

                if (alapadatokDataGridView.CurrentCell.RowIndex != null)
                {
                    UpdateCegadatok(currentCegID);
                }
            }
        }


    }
}
