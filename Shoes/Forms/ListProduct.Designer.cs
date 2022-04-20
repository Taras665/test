namespace Shoes
{
    partial class ListProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(743, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.37884F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtAdd, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.86568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13433F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 458);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shoes.Resource1.ak12_gus_5808_free_13355_1080;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelList
            // 
            this.flowLayoutPanelList.AutoSize = true;
            this.flowLayoutPanelList.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelList.Location = new System.Drawing.Point(136, 128);
            this.flowLayoutPanelList.Name = "flowLayoutPanelList";
            this.flowLayoutPanelList.Size = new System.Drawing.Size(740, 283);
            this.flowLayoutPanelList.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TbName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.CbStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CbCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(136, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 119);
            this.panel1.TabIndex = 3;
            // 
            // TbName
            // 
            this.TbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbName.Location = new System.Drawing.Point(538, 80);
            this.TbName.Multiline = true;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(193, 32);
            this.TbName.TabIndex = 8;
            this.TbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(740, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(602, 53);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(72, 24);
            this.Name.TabIndex = 7;
            this.Name.Text = "Статус";
            // 
            // CbStatus
            // 
            this.CbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Items.AddRange(new object[] {
            "Все",
            "Присутствует",
            "Отсутствует"});
            this.CbStatus.Location = new System.Drawing.Point(282, 80);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(193, 32);
            this.CbStatus.TabIndex = 5;
            this.CbStatus.SelectedIndexChanged += new System.EventHandler(this.CbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(339, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Категории";
            // 
            // CbCategory
            // 
            this.CbCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Items.AddRange(new object[] {
            "Все",
            "Сапоги",
            "Туфли",
            "Кеды"});
            this.CbCategory.Location = new System.Drawing.Point(5, 80);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(193, 32);
            this.CbCategory.TabIndex = 2;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список товаров";
            // 
            // BtAdd
            // 
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAdd.Location = new System.Drawing.Point(3, 128);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(127, 63);
            this.BtAdd.TabIndex = 5;
            this.BtAdd.Text = "Добавить товар";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Visible = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(895, 497);
            this.Name = "ListProducts";
            this.Text = "Список товаров";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtAdd;
    }
}