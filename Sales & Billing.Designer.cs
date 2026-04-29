namespace Jewelry_Shop_Management
{
    partial class Sales___Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales___Billing));
            this.label12 = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnAddItemToBill = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.linkLabelProducts = new System.Windows.Forms.LinkLabel();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.richBoxInvoice = new System.Windows.Forms.RichTextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(272, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(686, 59);
            this.label12.TabIndex = 89;
            this.label12.Text = "Sales And Billing Management";
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Cornsilk;
            this.btnInvoice.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInvoice.Location = new System.Drawing.Point(858, 355);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(273, 47);
            this.btnInvoice.TabIndex = 87;
            this.btnInvoice.Text = "Generate Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBill.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvBill.ColumnHeadersHeight = 28;
            this.dgvBill.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvBill.Location = new System.Drawing.Point(91, 494);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 62;
            this.dgvBill.RowTemplate.Height = 28;
            this.dgvBill.Size = new System.Drawing.Size(621, 117);
            this.dgvBill.TabIndex = 86;
            // 
            // btnAddItemToBill
            // 
            this.btnAddItemToBill.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddItemToBill.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemToBill.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAddItemToBill.Location = new System.Drawing.Point(244, 435);
            this.btnAddItemToBill.Name = "btnAddItemToBill";
            this.btnAddItemToBill.Size = new System.Drawing.Size(304, 40);
            this.btnAddItemToBill.TabIndex = 76;
            this.btnAddItemToBill.Text = "Add Items To Bill";
            this.btnAddItemToBill.UseVisualStyleBackColor = false;
            this.btnAddItemToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(-15, 659);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1325, 74);
            this.panel4.TabIndex = 75;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 498);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(21, 188);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 485);
            this.panel6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-123, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1661, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.linkLabelHome);
            this.panel1.Controls.Add(this.linkLabelLogin);
            this.panel1.Controls.Add(this.linkLabelProducts);
            this.panel1.Controls.Add(this.linkLabelAbout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-18, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 118);
            this.panel1.TabIndex = 74;
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHome.LinkColor = System.Drawing.Color.Cornsilk;
            this.linkLabelHome.Location = new System.Drawing.Point(722, 51);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(78, 27);
            this.linkLabelHome.TabIndex = 16;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Cornsilk;
            this.linkLabelLogin.Location = new System.Drawing.Point(1088, 51);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(72, 27);
            this.linkLabelLogin.TabIndex = 15;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabelProducts
            // 
            this.linkLabelProducts.AutoSize = true;
            this.linkLabelProducts.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelProducts.LinkColor = System.Drawing.Color.Cornsilk;
            this.linkLabelProducts.Location = new System.Drawing.Point(842, 51);
            this.linkLabelProducts.Name = "linkLabelProducts";
            this.linkLabelProducts.Size = new System.Drawing.Size(103, 27);
            this.linkLabelProducts.TabIndex = 14;
            this.linkLabelProducts.TabStop = true;
            this.linkLabelProducts.Text = "Products";
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAbout.LinkColor = System.Drawing.Color.Cornsilk;
            this.linkLabelAbout.Location = new System.Drawing.Point(980, 51);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(76, 27);
            this.linkLabelAbout.TabIndex = 13;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "TWIN SISTERS JEWELRY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 498);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(21, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 485);
            this.panel2.TabIndex = 8;
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.Black;
            this.cmbItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(363, 336);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(214, 28);
            this.cmbItem.TabIndex = 91;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Black;
            this.txtQuantity.ForeColor = System.Drawing.Color.Cornsilk;
            this.txtQuantity.Location = new System.Drawing.Point(363, 388);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(214, 26);
            this.txtQuantity.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(226, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 92;
            this.label3.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(226, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(226, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 95;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(822, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 97;
            this.label5.Text = "Total Bill:";
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.Color.Black;
            this.txtBill.ForeColor = System.Drawing.Color.Cornsilk;
            this.txtBill.Location = new System.Drawing.Point(934, 287);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(239, 26);
            this.txtBill.TabIndex = 96;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richBoxInvoice
            // 
            this.richBoxInvoice.BackColor = System.Drawing.Color.Goldenrod;
            this.richBoxInvoice.ForeColor = System.Drawing.Color.Black;
            this.richBoxInvoice.Location = new System.Drawing.Point(731, 419);
            this.richBoxInvoice.Name = "richBoxInvoice";
            this.richBoxInvoice.Size = new System.Drawing.Size(480, 218);
            this.richBoxInvoice.TabIndex = 99;
            this.richBoxInvoice.Text = "";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.Black;
            this.cmbCustomer.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(363, 284);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(214, 28);
            this.cmbCustomer.TabIndex = 90;
            // 
            // Sales___Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1237, 729);
            this.Controls.Add(this.richBoxInvoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnAddItemToBill);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Sales___Billing";
            this.Text = "Sales___Billing";
            this.Load += new System.EventHandler(this.Sales___Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnAddItemToBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelHome;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.LinkLabel linkLabelProducts;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.RichTextBox richBoxInvoice;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}