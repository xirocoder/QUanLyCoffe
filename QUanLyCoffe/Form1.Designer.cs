namespace QuanLyQuanCafe
{
    partial class QTV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvFood);
            this.panel1.Location = new System.Drawing.Point(562, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 374);
            this.panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(667, 374);
            this.dtgvFood.TabIndex = 0;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(90, 376);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(379, 33);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodName.Location = new System.Drawing.Point(133, 175);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(336, 30);
            this.txbFoodName.TabIndex = 1;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodPrice.Location = new System.Drawing.Point(90, 573);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(379, 30);
            this.nmFoodPrice.TabIndex = 2;
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.Color.Transparent;
            this.btnShowFood.FlatAppearance.BorderSize = 0;
            this.btnShowFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFood.Location = new System.Drawing.Point(585, 554);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(216, 106);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // txbFoodID
            // 
            this.txbFoodID.BackColor = System.Drawing.Color.White;
            this.txbFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodID.Location = new System.Drawing.Point(90, 175);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(37, 30);
            this.txbFoodID.TabIndex = 4;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Location = new System.Drawing.Point(1051, 547);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(212, 110);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFood.FlatAppearance.BorderSize = 0;
            this.btnDeleteFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.Location = new System.Drawing.Point(819, 544);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(214, 116);
            this.btnDeleteFood.TabIndex = 6;
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1238, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 57);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.Tên_món__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txbFoodID);
            this.Controls.Add(this.btnShowFood);
            this.Controls.Add(this.nmFoodPrice);
            this.Controls.Add(this.txbFoodName);
            this.Controls.Add(this.cbFoodCategory);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "QTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnExit;
    }
}