namespace Modifier_Dimensions
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbHauteur = new System.Windows.Forms.TextBox();
            this.cbHauteur = new System.Windows.Forms.CheckBox();
            this.cbLargeur = new System.Windows.Forms.CheckBox();
            this.txbLargeur = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butModifier = new System.Windows.Forms.Button();
            this.butCheck = new System.Windows.Forms.Button();
            this.butAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbHauteur
            // 
            this.txbHauteur.Location = new System.Drawing.Point(82, 10);
            this.txbHauteur.Name = "txbHauteur";
            this.txbHauteur.Size = new System.Drawing.Size(133, 20);
            this.txbHauteur.TabIndex = 0;
            this.txbHauteur.Text = "0";
            // 
            // cbHauteur
            // 
            this.cbHauteur.AutoSize = true;
            this.cbHauteur.Checked = true;
            this.cbHauteur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHauteur.Location = new System.Drawing.Point(12, 12);
            this.cbHauteur.Name = "cbHauteur";
            this.cbHauteur.Size = new System.Drawing.Size(70, 17);
            this.cbHauteur.TabIndex = 1;
            this.cbHauteur.Text = "Hauteur :";
            this.cbHauteur.UseVisualStyleBackColor = true;
            // 
            // cbLargeur
            // 
            this.cbLargeur.AutoSize = true;
            this.cbLargeur.Checked = true;
            this.cbLargeur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLargeur.Location = new System.Drawing.Point(12, 38);
            this.cbLargeur.Name = "cbLargeur";
            this.cbLargeur.Size = new System.Drawing.Size(68, 17);
            this.cbLargeur.TabIndex = 3;
            this.cbLargeur.Text = "Largeur :";
            this.cbLargeur.UseVisualStyleBackColor = true;
            // 
            // txbLargeur
            // 
            this.txbLargeur.Location = new System.Drawing.Point(82, 36);
            this.txbLargeur.Name = "txbLargeur";
            this.txbLargeur.Size = new System.Drawing.Size(133, 20);
            this.txbLargeur.TabIndex = 2;
            this.txbLargeur.Text = "0";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(12, 62);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(35, 25);
            this.butOk.TabIndex = 4;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.ButOk_Click);
            // 
            // butModifier
            // 
            this.butModifier.Location = new System.Drawing.Point(53, 61);
            this.butModifier.Name = "butModifier";
            this.butModifier.Size = new System.Drawing.Size(60, 25);
            this.butModifier.TabIndex = 5;
            this.butModifier.Text = "Modifier";
            this.butModifier.UseVisualStyleBackColor = true;
            this.butModifier.Click += new System.EventHandler(this.MyDimModify);
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCheck.Location = new System.Drawing.Point(119, 61);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(50, 25);
            this.butCheck.TabIndex = 6;
            this.butCheck.Text = "☒/☐";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.MyChecked);
            // 
            // butAnnuler
            // 
            this.butAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAnnuler.Location = new System.Drawing.Point(175, 61);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(50, 25);
            this.butAnnuler.TabIndex = 7;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.ButAnnuler_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.butOk;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butAnnuler;
            this.ClientSize = new System.Drawing.Size(227, 88);
            this.Controls.Add(this.butAnnuler);
            this.Controls.Add(this.butCheck);
            this.Controls.Add(this.butModifier);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.cbLargeur);
            this.Controls.Add(this.txbLargeur);
            this.Controls.Add(this.cbHauteur);
            this.Controls.Add(this.txbHauteur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Modification Dimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHauteur;
        private System.Windows.Forms.CheckBox cbHauteur;
        private System.Windows.Forms.CheckBox cbLargeur;
        private System.Windows.Forms.TextBox txbLargeur;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butModifier;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Button butAnnuler;
    }
}

