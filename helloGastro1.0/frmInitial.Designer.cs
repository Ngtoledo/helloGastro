
namespace helloGastro1._0
{
    partial class frmInitial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitial));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnFinish = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.btnMoves = new FontAwesome.Sharp.IconButton();
            this.btnProducts = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.btnSuppliers = new FontAwesome.Sharp.IconButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnLog = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOrchid;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblUserName);
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 69);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lavender;
            this.btnClose.Location = new System.Drawing.Point(1160, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Navy;
            this.lblUserName.Location = new System.Drawing.Point(841, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(252, 50);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User_Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblDate.Location = new System.Drawing.Point(193, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(320, 50);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "13/10/2023 - 16:15";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.SlateBlue;
            this.panelSide.Controls.Add(this.btnFinish);
            this.panelSide.Controls.Add(this.btnCustomer);
            this.panelSide.Controls.Add(this.btnStart);
            this.panelSide.Controls.Add(this.btnReports);
            this.panelSide.Controls.Add(this.btnTable);
            this.panelSide.Controls.Add(this.btnMoves);
            this.panelSide.Controls.Add(this.btnProducts);
            this.panelSide.Controls.Add(this.btnEmployee);
            this.panelSide.Controls.Add(this.btnSuppliers);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 69);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 631);
            this.panelSide.TabIndex = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFinish.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnFinish.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFinish.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFinish.IconSize = 42;
            this.btnFinish.Location = new System.Drawing.Point(0, 560);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(200, 70);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "CERRAR TURNO";
            this.btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btnCustomer.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCustomer.Location = new System.Drawing.Point(0, 350);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 70);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "CLIENTES";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnStart.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 70);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "ABRIR TURNO";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnReports.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnReports.IconSize = 50;
            this.btnReports.Location = new System.Drawing.Point(0, 490);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 70);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "REPORTES";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnTable.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTable.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTable.Location = new System.Drawing.Point(0, 70);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(200, 70);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "MESAS";
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnMoves
            // 
            this.btnMoves.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoves.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoves.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMoves.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnMoves.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMoves.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMoves.Location = new System.Drawing.Point(0, 140);
            this.btnMoves.Name = "btnMoves";
            this.btnMoves.Size = new System.Drawing.Size(200, 70);
            this.btnMoves.TabIndex = 0;
            this.btnMoves.Text = "MOVIMIENTOS";
            this.btnMoves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoves.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            this.btnProducts.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnProducts.Location = new System.Drawing.Point(0, 210);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 70);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "PRODUCTOS";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnEmployee.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEmployee.Location = new System.Drawing.Point(0, 420);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 70);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "EMPLEADOS";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSuppliers.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.btnSuppliers.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSuppliers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 280);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(200, 70);
            this.btnSuppliers.TabIndex = 0;
            this.btnSuppliers.Text = "PROVEEDORES";
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Lavender;
            this.lblUser.Location = new System.Drawing.Point(266, 187);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(189, 50);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USUARIO:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Lavender;
            this.lblPassword.Location = new System.Drawing.Point(266, 242);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(189, 50);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "CONTRASEÑA";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(461, 187);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(221, 39);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(461, 249);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(221, 39);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btnLog);
            this.panelContainer.Controls.Add(this.txtPass);
            this.panelContainer.Controls.Add(this.txtUser);
            this.panelContainer.Controls.Add(this.lblPassword);
            this.panelContainer.Controls.Add(this.lblUser);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 69);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1000, 631);
            this.panelContainer.TabIndex = 0;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLog.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnLog.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLog.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLog.Location = new System.Drawing.Point(380, 339);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(200, 70);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "INGRESAR";
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInitial_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelSide;
        private FontAwesome.Sharp.IconButton btnFinish;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnTable;
        private FontAwesome.Sharp.IconButton btnMoves;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private FontAwesome.Sharp.IconButton btnSuppliers;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private FontAwesome.Sharp.IconButton btnLog;
        private System.Windows.Forms.Panel panelContainer;
    }
}

