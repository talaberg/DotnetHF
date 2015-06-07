namespace NyilvForms
{
    partial class ManageDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label dokumentum_tipusLabel;
            System.Windows.Forms.Label megjegyzesLabel;
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dokumentum_tipusTextBox = new System.Windows.Forms.TextBox();
            this.megjegyzesTextBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dokumentumokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            datumLabel = new System.Windows.Forms.Label();
            dokumentum_tipusLabel = new System.Windows.Forms.Label();
            megjegyzesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentumokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(61, 27);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 1;
            datumLabel.Text = "Dátum:";
            // 
            // dokumentum_tipusLabel
            // 
            dokumentum_tipusLabel.AutoSize = true;
            dokumentum_tipusLabel.Location = new System.Drawing.Point(61, 52);
            dokumentum_tipusLabel.Name = "dokumentum_tipusLabel";
            dokumentum_tipusLabel.Size = new System.Drawing.Size(100, 13);
            dokumentum_tipusLabel.TabIndex = 3;
            dokumentum_tipusLabel.Text = "Dokumentum típus:";
            // 
            // megjegyzesLabel
            // 
            megjegyzesLabel.AutoSize = true;
            megjegyzesLabel.Location = new System.Drawing.Point(61, 78);
            megjegyzesLabel.Name = "megjegyzesLabel";
            megjegyzesLabel.Size = new System.Drawing.Size(66, 13);
            megjegyzesLabel.TabIndex = 5;
            megjegyzesLabel.Text = "Megjegyzés:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dokumentumokBindingSource, "Datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(165, 23);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 2;
            // 
            // dokumentum_tipusTextBox
            // 
            this.dokumentum_tipusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokumentumokBindingSource, "Dokumentum_tipus", true));
            this.dokumentum_tipusTextBox.Location = new System.Drawing.Point(165, 49);
            this.dokumentum_tipusTextBox.Name = "dokumentum_tipusTextBox";
            this.dokumentum_tipusTextBox.Size = new System.Drawing.Size(200, 20);
            this.dokumentum_tipusTextBox.TabIndex = 4;
            // 
            // megjegyzesTextBox
            // 
            this.megjegyzesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokumentumokBindingSource, "Megjegyzes", true));
            this.megjegyzesTextBox.Location = new System.Drawing.Point(165, 75);
            this.megjegyzesTextBox.Name = "megjegyzesTextBox";
            this.megjegyzesTextBox.Size = new System.Drawing.Size(200, 20);
            this.megjegyzesTextBox.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(127, 122);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(249, 122);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dokumentumokBindingSource
            // 
            this.dokumentumokBindingSource.DataSource = typeof(NyilvLib.Entities.Dokumentumok);
            // 
            // ManageDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 157);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(dokumentum_tipusLabel);
            this.Controls.Add(this.dokumentum_tipusTextBox);
            this.Controls.Add(megjegyzesLabel);
            this.Controls.Add(this.megjegyzesTextBox);
            this.MaximumSize = new System.Drawing.Size(440, 184);
            this.MinimumSize = new System.Drawing.Size(440, 184);
            this.Name = "ManageDocument";
            this.Text = "ManageDocument";
            ((System.ComponentModel.ISupportInitialize)(this.dokumentumokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dokumentumokBindingSource;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox dokumentum_tipusTextBox;
        private System.Windows.Forms.TextBox megjegyzesTextBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}