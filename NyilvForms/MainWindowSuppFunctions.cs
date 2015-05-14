﻿using NyilvLib;
using NyilvLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyilvForms
{
    public partial class MainWindow : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        // UI update supplementary functions ----------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
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


                    if (adat.Count != 0)
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
                var element = new ComboBoxElementItem() { Name = prop.Name, Type = prop.PropertyType };
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
            }
        }
        void RemoveCegadatokElement(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(new Uri(ControllerDeleteCegadatokById.ControllerUrl(id))).Result;
            }
        }
        void RemoveDokumentumokElement(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(new Uri(ControllerDeleteDokumentumokById.ControllerUrl(id))).Result;
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

                if (alapadatokDataGridView.CurrentCell != null)
                {
                    UpdateCegadatok(currentCegID);
                }
            }
        }
    }
}