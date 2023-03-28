namespace credite
{
    partial class FrmCredite
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
            System.Windows.Forms.Label durataLabel;
            System.Windows.Forms.Label rataDobandaLabel;
            System.Windows.Forms.Label valoareLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.lblAfisare = new System.Windows.Forms.Label();
            this.tbDur = new System.Windows.Forms.TextBox();
            this.tbDob = new System.Windows.Forms.TextBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.creditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            durataLabel = new System.Windows.Forms.Label();
            rataDobandaLabel = new System.Windows.Forms.Label();
            valoareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salveaza Credit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAfisare
            // 
            this.lblAfisare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAfisare.Location = new System.Drawing.Point(95, 43);
            this.lblAfisare.Name = "lblAfisare";
            this.lblAfisare.Size = new System.Drawing.Size(361, 63);
            this.lblAfisare.TabIndex = 7;
            // 
            // durataLabel
            // 
            durataLabel.AutoSize = true;
            durataLabel.Location = new System.Drawing.Point(146, 152);
            durataLabel.Name = "durataLabel";
            durataLabel.Size = new System.Drawing.Size(40, 13);
            durataLabel.TabIndex = 9;
            durataLabel.Text = "durata:";
            // 
            // tbDur
            // 
            this.tbDur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "durata", true));
            this.tbDur.Location = new System.Drawing.Point(222, 149);
            this.tbDur.Name = "tbDur";
            this.tbDur.Size = new System.Drawing.Size(100, 20);
            this.tbDur.TabIndex = 10;
            // 
            // rataDobandaLabel
            // 
            rataDobandaLabel.AutoSize = true;
            rataDobandaLabel.Location = new System.Drawing.Point(141, 178);
            rataDobandaLabel.Name = "rataDobandaLabel";
            rataDobandaLabel.Size = new System.Drawing.Size(75, 13);
            rataDobandaLabel.TabIndex = 11;
            rataDobandaLabel.Text = "rata Dobanda:";
            // 
            // tbDob
            // 
            this.tbDob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "rataDobanda", true));
            this.tbDob.Location = new System.Drawing.Point(222, 175);
            this.tbDob.Name = "tbDob";
            this.tbDob.Size = new System.Drawing.Size(100, 20);
            this.tbDob.TabIndex = 12;
            // 
            // valoareLabel
            // 
            valoareLabel.AutoSize = true;
            valoareLabel.Location = new System.Drawing.Point(141, 204);
            valoareLabel.Name = "valoareLabel";
            valoareLabel.Size = new System.Drawing.Size(45, 13);
            valoareLabel.TabIndex = 13;
            valoareLabel.Text = "valoare:";
            // 
            // tbVal
            // 
            this.tbVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "valoare", true));
            this.tbVal.Location = new System.Drawing.Point(222, 201);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(100, 20);
            this.tbVal.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Creeaza Credit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // creditBindingSource
            // 
            this.creditBindingSource.DataSource = typeof(credite.Credit);
            // 
            // FrmCredite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(durataLabel);
            this.Controls.Add(this.tbDur);
            this.Controls.Add(rataDobandaLabel);
            this.Controls.Add(this.tbDob);
            this.Controls.Add(valoareLabel);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.lblAfisare);
            this.Controls.Add(this.button1);
            this.Name = "FrmCredite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credite";
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAfisare;
        private System.Windows.Forms.TextBox tbDur;
        private System.Windows.Forms.BindingSource creditBindingSource;
        private System.Windows.Forms.TextBox tbDob;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.Button button2;
    }
}