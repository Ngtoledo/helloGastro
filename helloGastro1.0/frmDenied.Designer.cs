﻿
namespace helloGastro1._0
{
    partial class frmDenied
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
            this.btnConslt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConslt
            // 
            this.btnConslt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConslt.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConslt.ForeColor = System.Drawing.Color.Lavender;
            this.btnConslt.Location = new System.Drawing.Point(84, 125);
            this.btnConslt.Name = "btnConslt";
            this.btnConslt.Size = new System.Drawing.Size(228, 35);
            this.btnConslt.TabIndex = 13;
            this.btnConslt.Text = "CERRAR";
            this.btnConslt.UseVisualStyleBackColor = true;
            this.btnConslt.Click += new System.EventHandler(this.btnConslt_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 82);
            this.label1.TabIndex = 12;
            this.label1.Text = "NO TIENE ACCESO O SU CONTRASEÑA ES INVÁLIDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDenied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnConslt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDenied";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDenied";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConslt;
        private System.Windows.Forms.Label label1;
    }
}