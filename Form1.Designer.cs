namespace lab6
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_rozmir = new System.Windows.Forms.NumericUpDown();
            this.BClose = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BСreateGrid = new System.Windows.Forms.Button();
            this.B_vector_dgv = new System.Windows.Forms.DataGridView();
            this.X_vector_dgv = new System.Windows.Forms.DataGridView();
            this.C_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.A_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(844, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Вктор Х";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Вектор В";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Матриця С коефіцієнтів LU розкладу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Матриця А коефіцієнтів СЛАР";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Оберіть розмір матриці А";
            // 
            // NUD_rozmir
            // 
            this.NUD_rozmir.Location = new System.Drawing.Point(271, 42);
            this.NUD_rozmir.Margin = new System.Windows.Forms.Padding(2);
            this.NUD_rozmir.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_rozmir.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_rozmir.Name = "NUD_rozmir";
            this.NUD_rozmir.Size = new System.Drawing.Size(90, 20);
            this.NUD_rozmir.TabIndex = 20;
            this.NUD_rozmir.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_rozmir.ValueChanged += new System.EventHandler(this.NUD_rozmir_ValueChanged);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(648, 474);
            this.BClose.Margin = new System.Windows.Forms.Padding(2);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(180, 41);
            this.BClose.TabIndex = 19;
            this.BClose.Text = "Вихід";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(648, 428);
            this.BClear.Margin = new System.Windows.Forms.Padding(2);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(180, 41);
            this.BClear.TabIndex = 18;
            this.BClear.Text = "Очистити";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BСreateGrid
            // 
            this.BСreateGrid.Location = new System.Drawing.Point(648, 382);
            this.BСreateGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BСreateGrid.Name = "BСreateGrid";
            this.BСreateGrid.Size = new System.Drawing.Size(180, 41);
            this.BСreateGrid.TabIndex = 17;
            this.BСreateGrid.Text = "Розв\'язати";
            this.BСreateGrid.UseVisualStyleBackColor = true;
            this.BСreateGrid.Click += new System.EventHandler(this.BСreateGrid_Click);
            // 
            // B_vector_dgv
            // 
            this.B_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B_vector_dgv.ColumnHeadersVisible = false;
            this.B_vector_dgv.Location = new System.Drawing.Point(545, 158);
            this.B_vector_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.B_vector_dgv.Name = "B_vector_dgv";
            this.B_vector_dgv.RowHeadersVisible = false;
            this.B_vector_dgv.RowHeadersWidth = 51;
            this.B_vector_dgv.RowTemplate.Height = 24;
            this.B_vector_dgv.Size = new System.Drawing.Size(180, 151);
            this.B_vector_dgv.TabIndex = 16;
            // 
            // X_vector_dgv
            // 
            this.X_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.X_vector_dgv.ColumnHeadersVisible = false;
            this.X_vector_dgv.Location = new System.Drawing.Point(766, 158);
            this.X_vector_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.X_vector_dgv.Name = "X_vector_dgv";
            this.X_vector_dgv.ReadOnly = true;
            this.X_vector_dgv.RowHeadersVisible = false;
            this.X_vector_dgv.RowHeadersWidth = 51;
            this.X_vector_dgv.RowTemplate.Height = 24;
            this.X_vector_dgv.Size = new System.Drawing.Size(180, 151);
            this.X_vector_dgv.TabIndex = 15;
            // 
            // C_matrix_dgv
            // 
            this.C_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_matrix_dgv.ColumnHeadersVisible = false;
            this.C_matrix_dgv.Location = new System.Drawing.Point(45, 344);
            this.C_matrix_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.C_matrix_dgv.Name = "C_matrix_dgv";
            this.C_matrix_dgv.RowHeadersVisible = false;
            this.C_matrix_dgv.RowHeadersWidth = 51;
            this.C_matrix_dgv.RowTemplate.Height = 24;
            this.C_matrix_dgv.Size = new System.Drawing.Size(442, 193);
            this.C_matrix_dgv.TabIndex = 14;
            // 
            // A_matrix_dgv
            // 
            this.A_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_matrix_dgv.ColumnHeadersVisible = false;
            this.A_matrix_dgv.Location = new System.Drawing.Point(45, 117);
            this.A_matrix_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.A_matrix_dgv.Name = "A_matrix_dgv";
            this.A_matrix_dgv.RowHeadersVisible = false;
            this.A_matrix_dgv.RowHeadersWidth = 51;
            this.A_matrix_dgv.RowTemplate.Height = 24;
            this.A_matrix_dgv.Size = new System.Drawing.Size(442, 193);
            this.A_matrix_dgv.TabIndex = 13;
            this.A_matrix_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_matrix_dgv_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Метод L/U перетворення",
            "Метод Гауса"});
            this.comboBox1.Location = new System.Drawing.Point(693, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Оберіть метод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 552);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_rozmir);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BСreateGrid);
            this.Controls.Add(this.B_vector_dgv);
            this.Controls.Add(this.X_vector_dgv);
            this.Controls.Add(this.C_matrix_dgv);
            this.Controls.Add(this.A_matrix_dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "НЮ Лаб_6";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_rozmir;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BСreateGrid;
        private System.Windows.Forms.DataGridView B_vector_dgv;
        private System.Windows.Forms.DataGridView X_vector_dgv;
        private System.Windows.Forms.DataGridView C_matrix_dgv;
        private System.Windows.Forms.DataGridView A_matrix_dgv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

