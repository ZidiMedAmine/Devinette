namespace Devinette
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
            this.LabTxt = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.LabRes = new System.Windows.Forms.Label();
            this.bntR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabTxt
            // 
            this.LabTxt.AutoSize = true;
            this.LabTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTxt.Location = new System.Drawing.Point(12, 36);
            this.LabTxt.Name = "LabTxt";
            this.LabTxt.Size = new System.Drawing.Size(242, 20);
            this.LabTxt.TabIndex = 0;
            this.LabTxt.Text = "Entrez un nombre etre 0 et 100 ! ";
            this.LabTxt.Click += new System.EventHandler(this.LabTxt_Click);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.Menu;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(261, 33);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(57, 26);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(29, 125);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(80, 35);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "Deviner";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // LabRes
            // 
            this.LabRes.AutoSize = true;
            this.LabRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRes.Location = new System.Drawing.Point(138, 90);
            this.LabRes.Name = "LabRes";
            this.LabRes.Size = new System.Drawing.Size(0, 20);
            this.LabRes.TabIndex = 4;
            this.LabRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntR
            // 
            this.bntR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntR.Location = new System.Drawing.Point(204, 123);
            this.bntR.Name = "bntR";
            this.bntR.Size = new System.Drawing.Size(80, 35);
            this.bntR.TabIndex = 5;
            this.bntR.Text = "Rejouer";
            this.bntR.UseVisualStyleBackColor = true;
            this.bntR.Click += new System.EventHandler(this.bntR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 170);
            this.Controls.Add(this.bntR);
            this.Controls.Add(this.LabRes);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.LabTxt);
            this.Name = "Form1";
            this.Text = "Devinette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabTxt;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label LabRes;
        private System.Windows.Forms.Button bntR;
    }
}

