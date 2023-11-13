
namespace helloGastro1._0
{
    partial class frmTables
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
            this.dgvAllTables = new System.Windows.Forms.DataGridView();
            this.btnConslt = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnOpenTable = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.txtTableNumb = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblWaiterName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTables
            // 
            this.dgvAllTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTables.GridColor = System.Drawing.Color.Lavender;
            this.dgvAllTables.Location = new System.Drawing.Point(272, 445);
            this.dgvAllTables.Name = "dgvAllTables";
            this.dgvAllTables.Size = new System.Drawing.Size(694, 162);
            this.dgvAllTables.TabIndex = 4;
            // 
            // btnConslt
            // 
            this.btnConslt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConslt.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConslt.ForeColor = System.Drawing.Color.Lavender;
            this.btnConslt.Location = new System.Drawing.Point(17, 143);
            this.btnConslt.Name = "btnConslt";
            this.btnConslt.Size = new System.Drawing.Size(249, 35);
            this.btnConslt.TabIndex = 8;
            this.btnConslt.Text = "CONSULTAR";
            this.btnConslt.UseVisualStyleBackColor = true;
            this.btnConslt.Click += new System.EventHandler(this.btnConslt_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Lavender;
            this.btnEdit.Location = new System.Drawing.Point(17, 193);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(249, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "EDITAR";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTable.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTable.ForeColor = System.Drawing.Color.Lavender;
            this.btnCloseTable.Location = new System.Drawing.Point(17, 333);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(249, 73);
            this.btnCloseTable.TabIndex = 10;
            this.btnCloseTable.Text = "CERRAR MESA";
            this.btnCloseTable.UseVisualStyleBackColor = true;
            this.btnCloseTable.Click += new System.EventHandler(this.btnCloseTable_Click);
            // 
            // btnOpenTable
            // 
            this.btnOpenTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTable.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTable.ForeColor = System.Drawing.Color.Lavender;
            this.btnOpenTable.Location = new System.Drawing.Point(17, 245);
            this.btnOpenTable.Name = "btnOpenTable";
            this.btnOpenTable.Size = new System.Drawing.Size(249, 73);
            this.btnOpenTable.TabIndex = 12;
            this.btnOpenTable.Text = "ABRIR MESA";
            this.btnOpenTable.UseVisualStyleBackColor = true;
            this.btnOpenTable.Click += new System.EventHandler(this.btnOpenTable_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lavender;
            this.btnClose.Location = new System.Drawing.Point(965, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.GridColor = System.Drawing.Color.Lavender;
            this.dgvTable.Location = new System.Drawing.Point(272, 45);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(694, 363);
            this.dgvTable.TabIndex = 3;
            // 
            // txtTableNumb
            // 
            this.txtTableNumb.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTableNumb.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableNumb.ForeColor = System.Drawing.Color.Lavender;
            this.txtTableNumb.Location = new System.Drawing.Point(176, 45);
            this.txtTableNumb.Name = "txtTableNumb";
            this.txtTableNumb.Size = new System.Drawing.Size(90, 88);
            this.txtTableNumb.TabIndex = 5;
            // 
            // lblTable
            // 
            this.lblTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTable.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.Violet;
            this.lblTable.Location = new System.Drawing.Point(3, 62);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(167, 71);
            this.lblTable.TabIndex = 7;
            this.lblTable.Text = "MESA";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaiterName
            // 
            this.lblWaiterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWaiterName.Font = new System.Drawing.Font("Agency FB", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiterName.ForeColor = System.Drawing.Color.Violet;
            this.lblWaiterName.Location = new System.Drawing.Point(512, 0);
            this.lblWaiterName.Name = "lblWaiterName";
            this.lblWaiterName.Size = new System.Drawing.Size(289, 42);
            this.lblWaiterName.TabIndex = 11;
            this.lblWaiterName.Text = "waiterName";
            this.lblWaiterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(12, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 162);
            this.label1.TabIndex = 13;
            this.label1.Text = "MESAS ABIERTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1000, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenTable);
            this.Controls.Add(this.lblWaiterName);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConslt);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.txtTableNumb);
            this.Controls.Add(this.dgvAllTables);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTables";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllTables;
        private System.Windows.Forms.Button btnConslt;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnOpenTable;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox txtTableNumb;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblWaiterName;
        private System.Windows.Forms.Label label1;
    }
}