namespace credite
{
    partial class FrmMeniu
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
            System.Windows.Forms.Label cnpLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            this.btAd = new System.Windows.Forms.Button();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.cbCred = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdaugaClient = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cnpLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAd
            // 
            this.btAd.Location = new System.Drawing.Point(419, 309);
            this.btAd.Name = "btAd";
            this.btAd.Size = new System.Drawing.Size(168, 48);
            this.btAd.TabIndex = 0;
            this.btAd.Text = "Adauga Credit";
            this.btAd.UseVisualStyleBackColor = true;
            this.btAd.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnpLabel
            // 
            cnpLabel.AutoSize = true;
            cnpLabel.Location = new System.Drawing.Point(119, 118);
            cnpLabel.Name = "cnpLabel";
            cnpLabel.Size = new System.Drawing.Size(28, 13);
            cnpLabel.TabIndex = 2;
            cnpLabel.Text = "cnp:";
            // 
            // tbCnp
            // 
            this.tbCnp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "cnp", true));
            this.tbCnp.Location = new System.Drawing.Point(176, 115);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(211, 20);
            this.tbCnp.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(119, 144);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email:";
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "email", true));
            this.tbEmail.Location = new System.Drawing.Point(176, 141);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(211, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(119, 170);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(36, 13);
            numeLabel.TabIndex = 6;
            numeLabel.Text = "nume:";
            // 
            // tbNume
            // 
            this.tbNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "nume", true));
            this.tbNume.Location = new System.Drawing.Point(176, 167);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(211, 20);
            this.tbNume.TabIndex = 7;
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(119, 196);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(51, 13);
            prenumeLabel.TabIndex = 8;
            prenumeLabel.Text = "prenume:";
            // 
            // tbPrenume
            // 
            this.tbPrenume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "prenume", true));
            this.tbPrenume.Location = new System.Drawing.Point(176, 193);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(211, 20);
            this.tbPrenume.TabIndex = 9;
            // 
            // cbCred
            // 
            this.cbCred.FormattingEnabled = true;
            this.cbCred.Location = new System.Drawing.Point(176, 227);
            this.cbCred.Name = "cbCred";
            this.cbCred.Size = new System.Drawing.Size(211, 21);
            this.cbCred.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "credit:";
            // 
            // btAdaugaClient
            // 
            this.btAdaugaClient.Location = new System.Drawing.Point(176, 309);
            this.btAdaugaClient.Name = "btAdaugaClient";
            this.btAdaugaClient.Size = new System.Drawing.Size(152, 48);
            this.btAdaugaClient.TabIndex = 12;
            this.btAdaugaClient.Text = "Adauga Client";
            this.btAdaugaClient.UseVisualStyleBackColor = true;
            this.btAdaugaClient.Click += new System.EventHandler(this.btAdaugaClient_Click);
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.Control;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista.Location = new System.Drawing.Point(432, 113);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(290, 130);
            this.lista.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierToolStripMenuItem,
            this.restaurareDinFisierToolStripMenuItem,
            this.deserializeazaToolStripMenuItem,
            this.serializeazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 92);
            // 
            // salveazaInFisierToolStripMenuItem
            // 
            this.salveazaInFisierToolStripMenuItem.Name = "salveazaInFisierToolStripMenuItem";
            this.salveazaInFisierToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.salveazaInFisierToolStripMenuItem.Text = "Salveaza in fisier";
            this.salveazaInFisierToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierToolStripMenuItem_Click);
            // 
            // restaurareDinFisierToolStripMenuItem
            // 
            this.restaurareDinFisierToolStripMenuItem.Name = "restaurareDinFisierToolStripMenuItem";
            this.restaurareDinFisierToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.restaurareDinFisierToolStripMenuItem.Text = "Restaurare din fisier";
            this.restaurareDinFisierToolStripMenuItem.Click += new System.EventHandler(this.restaurareDinFisierToolStripMenuItem_Click);
            // 
            // deserializeazaToolStripMenuItem
            // 
            this.deserializeazaToolStripMenuItem.Name = "deserializeazaToolStripMenuItem";
            this.deserializeazaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deserializeazaToolStripMenuItem.Text = "Deserializeaza";
            this.deserializeazaToolStripMenuItem.Click += new System.EventHandler(this.deserializeazaToolStripMenuItem_Click);
            // 
            // serializeazaToolStripMenuItem
            // 
            this.serializeazaToolStripMenuItem.Name = "serializeazaToolStripMenuItem";
            this.serializeazaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.serializeazaToolStripMenuItem.Text = "Serializeaza";
            this.serializeazaToolStripMenuItem.Click += new System.EventHandler(this.serializeazaToolStripMenuItem_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(credite.Client);
            // 
            // FrmMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btAdaugaClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCred);
            this.Controls.Add(cnpLabel);
            this.Controls.Add(this.tbCnp);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.btAd);
            this.Name = "FrmMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAd;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.ComboBox cbCred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdaugaClient;
        private System.Windows.Forms.Label lista;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeazaToolStripMenuItem;
    }
}