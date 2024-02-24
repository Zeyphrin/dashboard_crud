namespace DashboardCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_id = new Label();
            textBox_id = new TextBox();
            label_namaDepan = new Label();
            textBox_namaDepan = new TextBox();
            label_namaBelakang = new Label();
            textBox_namaBelakang = new TextBox();
            label_nilai = new Label();
            textBox_nilai = new TextBox();
            dataGridView = new DataGridView();
            button_create = new Button();
            button_clear = new Button();
            button3 = new Button();
            button_delete = new Button();
            button_printPDF = new Button();
            button_close = new Button();
            textBox_search = new TextBox();
            button_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(55, 82);
            label_id.Name = "label_id";
            label_id.Size = new Size(18, 15);
            label_id.TabIndex = 0;
            label_id.Text = "ID";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(156, 79);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(142, 23);
            textBox_id.TabIndex = 1;
            textBox_id.TextChanged += textBox_id_TextChanged;
            // 
            // label_namaDepan
            // 
            label_namaDepan.AutoSize = true;
            label_namaDepan.Location = new Point(55, 125);
            label_namaDepan.Name = "label_namaDepan";
            label_namaDepan.Size = new Size(76, 15);
            label_namaDepan.TabIndex = 0;
            label_namaDepan.Text = "Nama Depan";
            // 
            // textBox_namaDepan
            // 
            textBox_namaDepan.Location = new Point(156, 122);
            textBox_namaDepan.Name = "textBox_namaDepan";
            textBox_namaDepan.Size = new Size(142, 23);
            textBox_namaDepan.TabIndex = 1;
            textBox_namaDepan.TextChanged += textBox_namaDepan_TextChanged;
            // 
            // label_namaBelakang
            // 
            label_namaBelakang.AutoSize = true;
            label_namaBelakang.Location = new Point(55, 172);
            label_namaBelakang.Name = "label_namaBelakang";
            label_namaBelakang.Size = new Size(90, 15);
            label_namaBelakang.TabIndex = 0;
            label_namaBelakang.Text = "Nama Belakang";
            // 
            // textBox_namaBelakang
            // 
            textBox_namaBelakang.Location = new Point(156, 169);
            textBox_namaBelakang.Name = "textBox_namaBelakang";
            textBox_namaBelakang.Size = new Size(142, 23);
            textBox_namaBelakang.TabIndex = 1;
            textBox_namaBelakang.TextChanged += textBox_namaBelakang_TextChanged;
            // 
            // label_nilai
            // 
            label_nilai.AutoSize = true;
            label_nilai.Location = new Point(55, 220);
            label_nilai.Name = "label_nilai";
            label_nilai.Size = new Size(31, 15);
            label_nilai.TabIndex = 0;
            label_nilai.Text = "Nilai";
            // 
            // textBox_nilai
            // 
            textBox_nilai.Location = new Point(156, 217);
            textBox_nilai.Name = "textBox_nilai";
            textBox_nilai.Size = new Size(142, 23);
            textBox_nilai.TabIndex = 1;
            textBox_nilai.TextChanged += textBox_nilai_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(397, 70);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(391, 230);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // button_create
            // 
            button_create.Location = new Point(32, 372);
            button_create.Name = "button_create";
            button_create.Size = new Size(75, 23);
            button_create.TabIndex = 3;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(113, 372);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 23);
            button_clear.TabIndex = 3;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button3
            // 
            button3.Location = new Point(194, 372);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(275, 372);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_printPDF
            // 
            button_printPDF.Location = new Point(356, 372);
            button_printPDF.Name = "button_printPDF";
            button_printPDF.Size = new Size(75, 23);
            button_printPDF.TabIndex = 3;
            button_printPDF.Text = "Print PDF";
            button_printPDF.UseVisualStyleBackColor = true;
            button_printPDF.Click += button_printPDF_Click;
            // 
            // button_close
            // 
            button_close.Location = new Point(656, 372);
            button_close.Name = "button_close";
            button_close.Size = new Size(75, 23);
            button_close.TabIndex = 3;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(397, 41);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(309, 23);
            textBox_search.TabIndex = 4;
            // 
            // button_search
            // 
            button_search.Location = new Point(712, 41);
            button_search.Name = "button_search";
            button_search.Size = new Size(75, 23);
            button_search.TabIndex = 5;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(button_close);
            Controls.Add(button_printPDF);
            Controls.Add(button_delete);
            Controls.Add(button3);
            Controls.Add(button_clear);
            Controls.Add(button_create);
            Controls.Add(dataGridView);
            Controls.Add(textBox_nilai);
            Controls.Add(label_nilai);
            Controls.Add(textBox_namaBelakang);
            Controls.Add(label_namaBelakang);
            Controls.Add(textBox_namaDepan);
            Controls.Add(label_namaDepan);
            Controls.Add(textBox_id);
            Controls.Add(label_id);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_id;
        private TextBox textBox_id;
        private Label label_namaDepan;
        private TextBox textBox_namaDepan;
        private Label label_namaBelakang;
        private TextBox textBox_namaBelakang;
        private Label label_nilai;
        private TextBox textBox_nilai;
        private DataGridView dataGridView;
        private Button button_create;
        private Button button_clear;
        private Button button3;
        private Button button_delete;
        private Button button_printPDF;
        private Button button_close;
        private TextBox textBox_search;
        private Button button_search;
    }
}