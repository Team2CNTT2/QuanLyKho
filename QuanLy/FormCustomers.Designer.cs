namespace QuanLy
{
    partial class FormSuppliers
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxtCusSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtCusSearch = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCusEmail = new System.Windows.Forms.TextBox();
            this.TxtCusPhone = new System.Windows.Forms.TextBox();
            this.TxtCusAddress = new System.Windows.Forms.TextBox();
            this.TxtCusName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvCus = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtCusCreate = new System.Windows.Forms.ToolStripButton();
            this.BtCusEdit = new System.Windows.Forms.ToolStripButton();
            this.BtCusDelete = new System.Windows.Forms.ToolStripButton();
            this.BtCusBack = new System.Windows.Forms.ToolStripButton();
            this.BtCusSave = new System.Windows.Forms.ToolStripButton();
            this.CmbCus = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCus)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtCusSearch,
            this.BtCusSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TxtCusSearch
            // 
            this.TxtCusSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtCusSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCusSearch.Margin = new System.Windows.Forms.Padding(380, 0, 1, 0);
            this.TxtCusSearch.Name = "TxtCusSearch";
            this.TxtCusSearch.Size = new System.Drawing.Size(100, 25);
            this.TxtCusSearch.Text = "Fill information";
            this.TxtCusSearch.Click += new System.EventHandler(this.TxtCusSearch_Click);
            // 
            // BtCusSearch
            // 
            this.BtCusSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtCusSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCusSearch.Name = "BtCusSearch";
            this.BtCusSearch.Size = new System.Drawing.Size(46, 22);
            this.BtCusSearch.Text = "Search";
            this.BtCusSearch.Click += new System.EventHandler(this.BtCusSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.TxtCusEmail);
            this.groupBox1.Controls.Add(this.TxtCusPhone);
            this.groupBox1.Controls.Add(this.TxtCusAddress);
            this.groupBox1.Controls.Add(this.TxtCusName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(515, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail of Customer";
            // 
            // TxtCusEmail
            // 
            this.TxtCusEmail.Enabled = false;
            this.TxtCusEmail.Location = new System.Drawing.Point(139, 144);
            this.TxtCusEmail.Name = "TxtCusEmail";
            this.TxtCusEmail.Size = new System.Drawing.Size(241, 22);
            this.TxtCusEmail.TabIndex = 12;
            // 
            // TxtCusPhone
            // 
            this.TxtCusPhone.Enabled = false;
            this.TxtCusPhone.Location = new System.Drawing.Point(139, 107);
            this.TxtCusPhone.Name = "TxtCusPhone";
            this.TxtCusPhone.Size = new System.Drawing.Size(241, 22);
            this.TxtCusPhone.TabIndex = 8;
            // 
            // TxtCusAddress
            // 
            this.TxtCusAddress.Enabled = false;
            this.TxtCusAddress.Location = new System.Drawing.Point(139, 71);
            this.TxtCusAddress.Name = "TxtCusAddress";
            this.TxtCusAddress.Size = new System.Drawing.Size(241, 22);
            this.TxtCusAddress.TabIndex = 7;
            // 
            // TxtCusName
            // 
            this.TxtCusName.Enabled = false;
            this.TxtCusName.Location = new System.Drawing.Point(139, 38);
            this.TxtCusName.Name = "TxtCusName";
            this.TxtCusName.Size = new System.Drawing.Size(241, 22);
            this.TxtCusName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.DgvCus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 251);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Customers";
            // 
            // DgvCus
            // 
            this.DgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCus.Location = new System.Drawing.Point(25, 35);
            this.DgvCus.Name = "DgvCus";
            this.DgvCus.Size = new System.Drawing.Size(474, 199);
            this.DgvCus.TabIndex = 0;
            this.DgvCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCus_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(512, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 56);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtCusCreate,
            this.BtCusEdit,
            this.BtCusDelete,
            this.BtCusBack,
            this.BtCusSave});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(474, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtCusCreate
            // 
            this.BtCusCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtCusCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCusCreate.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.BtCusCreate.Name = "BtCusCreate";
            this.BtCusCreate.Size = new System.Drawing.Size(50, 22);
            this.BtCusCreate.Text = "Create";
            this.BtCusCreate.Visible = false;
            this.BtCusCreate.Click += new System.EventHandler(this.BtCusCreate_Click);
            // 
            // BtCusEdit
            // 
            this.BtCusEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtCusEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCusEdit.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtCusEdit.Name = "BtCusEdit";
            this.BtCusEdit.Size = new System.Drawing.Size(34, 22);
            this.BtCusEdit.Text = "Edit";
            this.BtCusEdit.Visible = false;
            this.BtCusEdit.Click += new System.EventHandler(this.BtCusEdit_Click);
            // 
            // BtCusDelete
            // 
            this.BtCusDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCusDelete.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtCusDelete.Name = "BtCusDelete";
            this.BtCusDelete.Size = new System.Drawing.Size(44, 22);
            this.BtCusDelete.Text = "Delete";
            this.BtCusDelete.Visible = false;
            this.BtCusDelete.Click += new System.EventHandler(this.BtCusDelete_Click);
            // 
            // BtCusBack
            // 
            this.BtCusBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCusBack.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtCusBack.Name = "BtCusBack";
            this.BtCusBack.Size = new System.Drawing.Size(36, 22);
            this.BtCusBack.Text = "Back";
            this.BtCusBack.Click += new System.EventHandler(this.BtCusBack_Click);
            // 
            // BtCusSave
            // 
            this.BtCusSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCusSave.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtCusSave.Name = "BtCusSave";
            this.BtCusSave.Size = new System.Drawing.Size(39, 22);
            this.BtCusSave.Text = "Fresh";
            this.BtCusSave.Visible = false;
            this.BtCusSave.Click += new System.EventHandler(this.BtCusSave_Click);
            // 
            // CmbCus
            // 
            this.CmbCus.FormattingEnabled = true;
            this.CmbCus.Items.AddRange(new object[] {
            "ID of Customer",
            "Name of Customer",
            "Address"});
            this.CmbCus.Location = new System.Drawing.Point(257, 1);
            this.CmbCus.Name = "CmbCus";
            this.CmbCus.Size = new System.Drawing.Size(121, 21);
            this.CmbCus.TabIndex = 9;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(992, 300);
            this.Controls.Add(this.CmbCus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSuppliers";
            this.Text = "FormCustomers";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TxtCusSearch;
        private System.Windows.Forms.ToolStripButton BtCusSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCusEmail;
        private System.Windows.Forms.TextBox TxtCusPhone;
        private System.Windows.Forms.TextBox TxtCusAddress;
        private System.Windows.Forms.TextBox TxtCusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvCus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtCusCreate;
        private System.Windows.Forms.ToolStripButton BtCusEdit;
        private System.Windows.Forms.ToolStripButton BtCusDelete;
        private System.Windows.Forms.ToolStripButton BtCusBack;
        private System.Windows.Forms.ToolStripButton BtCusSave;
        private System.Windows.Forms.ComboBox CmbCus;
    }
}