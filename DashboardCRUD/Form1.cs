using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DashboardCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bind_data();

        }
        SqlConnection conn = new SqlConnection("Data Source=LUCIA;Initial Catalog=materi2;Integrated Security=True");
        DataGridViewRow selectedRow;

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("select noid,namadepan As namadepan,namabelakang As namabelakang,nilai from materi2", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11, FontStyle.Bold);

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert into materi2(noid,namadepan,namabelakang,nilai)Values(@noid,@namadepan,@namabelakang,@nilai)", conn);
            cmd2.Parameters.AddWithValue("noid", textBox_id.Text);
            cmd2.Parameters.AddWithValue("namadepan", textBox_namaDepan.Text);
            cmd2.Parameters.AddWithValue("namabelakang", textBox_namaBelakang.Text);
            cmd2.Parameters.AddWithValue("nilai", textBox_nilai.Text);
            conn.Open();

            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_namaDepan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_namaBelakang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nilai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_namaBelakang.Clear();
            textBox_namaDepan.Clear();
            textBox_nilai.Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            selectedRow = dataGridView.Rows[index];
            textBox_id.Text = selectedRow.Cells[0].Value.ToString();
            textBox_namaDepan.Text = selectedRow.Cells[1].Value.ToString();
            textBox_namaBelakang.Text = selectedRow.Cells[2].Value.ToString();
            textBox_nilai.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                string selectedNoID = dataGridView.Rows[selectedRowIndex].Cells["noid"].Value.ToString();

                using (SqlConnection conn = new SqlConnection("Data Source=LUCIA;Initial Catalog=materi2;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmdDelete = new SqlCommand("DELETE FROM materi2 WHERE noid = @noid", conn);
                        cmdDelete.Parameters.AddWithValue("@noid", selectedNoID);
                        cmdDelete.ExecuteNonQuery();

                        bind_data();
                        MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count == 0 || string.IsNullOrWhiteSpace(textBox_id.Text))
                {
                    MessageBox.Show("Choose the Cell you want to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedRowIndex = dataGridView.SelectedRows[0].Index; // Ambil Index Yang kita Pilih
                int selectedRowID = Convert.ToInt32(dataGridView.Rows[selectedRowIndex].Cells["noid"].Value); // Ambil data "noid" dari Index yang sudah kita pilih

                int idToUpdate = Convert.ToInt32(textBox_id.Text); // Ambil "noid" Di dalam TextBox

                if (idToUpdate != selectedRowID)
                {
                    MessageBox.Show("ID Can't be Changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlCommand command = new SqlCommand("UPDATE materi2 SET namadepan = @namadepan, namabelakang = @namabelakang, nilai = @nilai WHERE noid = @noid", conn))
                {
                    command.Parameters.AddWithValue("@noid", selectedRowID);
                    command.Parameters.AddWithValue("@namadepan", textBox_namaDepan.Text);
                    command.Parameters.AddWithValue("@namabelakang", textBox_namaBelakang.Text);
                    command.Parameters.AddWithValue("@nilai", textBox_nilai.Text);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
                bind_data();
                MessageBox.Show("Data Succesfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            bind_data();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void button_printPDF_Click(object sender, EventArgs e)
        {
            // Create a Document object
            Document doc = new Document(PageSize.A4);

            try
            {
                // Create SaveFileDialog
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files (.pdf)|.pdf";
                saveDialog.FileName = "output.pdf"; // default file name

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path chosen by the user
                    string filePath = saveDialog.FileName;

                    // Create a PdfWriter instance to write the document content to the file path
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Create a PdfPTable with the same number of columns as the DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);

                    // Add column headers from the DataGridView to the PdfPTable
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        pdfTable.AddCell(new Phrase(dataGridView.Columns[i].HeaderText));
                    }

                    // Add rows from the DataGridView to the PdfPTable
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        for (int column = 0; column < dataGridView.Columns.Count; column++)
                        {
                            if (dataGridView[column, rows].Value != null)
                            {
                                pdfTable.AddCell(new Phrase(dataGridView[column, rows].Value.ToString()));
                            }
                        }
                    }

                    doc.Add(pdfTable);
                    MessageBox.Show("PDF file has been saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }
    }
    }
