using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        ModelBook modelbook;

        public Form1()
        {
            InitializeComponent();
            modelbook = new ModelBook();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<BookType> types = modelbook.BookTypes.ToList();
            FillDatatoCombobox(types);

            List<Book> books = modelbook.Books.ToList();
            FillDataToDataGridView(books);
        }

        public void FillDatatoCombobox(List<BookType> types)
        {
            comboBox1.DataSource = types;
            comboBox1.DisplayMember = "TypeName";
            comboBox1.ValueMember = "ID";
        }

        public void FillDataToDataGridView(List<Book> books)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = (i + 1).ToString();
                dataGridView1.Rows[index].Cells[1].Value = books[i].Tittle;
                dataGridView1.Rows[index].Cells[2].Value = books[i].Author;
                dataGridView1.Rows[index].Cells[3].Value = books[i].BookType.TypeName;
                dataGridView1.Rows[index].Cells[4].Value = books[i].Publisher;
                dataGridView1.Rows[index].Cells[5].Value = books[i].Pages;
                dataGridView1.Rows[index].Cells[6].Value = books[i].Rate;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                {
                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    comboBox1.SelectedIndex = comboBox1.FindStringExact(dataGridView1.
                        SelectedRows[0].Cells[3].Value.ToString());
                    textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book bk = new Book();
                bk.Tittle = textBox1.Text;
                bk.Author = textBox2.Text;
                bk.TypeID = int.Parse(comboBox1.SelectedValue.ToString());
                bk.Publisher = textBox3.Text;
                bk.Pages = int.Parse(textBox4.Text);
                bk.Rate = float.Parse(textBox5.Text);
                modelbook.Books.Add(bk);
                modelbook.SaveChanges();
                FillDataToDataGridView(modelbook.Books.ToList());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Book bk = modelbook.Books.FirstOrDefault(s => s.Tittle.CompareTo(
                      textBox1.Text) == 0);
            if (bk == null)
            {
                MessageBox.Show("Book is not exsit!");
            }
            else
            {
                bk.Author = textBox2.Text;
                bk.TypeID = int.Parse(comboBox1.SelectedValue.ToString());
                bk.Publisher = textBox3.Text;
                bk.Pages = int.Parse(textBox4.Text);
                bk.Rate = float.Parse(textBox5.Text);
                modelbook.SaveChanges();
                FillDataToDataGridView(modelbook.Books.ToList());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                {
                    string tittle = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    Book bk = modelbook.Books.FirstOrDefault(s => s.Tittle.CompareTo(tittle) == 0);
                    if (bk == null)
                    {
                        MessageBox.Show("sv khong ton tai");
                    }
                    else
                    {
                        modelbook.Books.Remove(bk);
                        modelbook.SaveChanges();
                        FillDataToDataGridView(modelbook.Books.ToList());
                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            List<Book> authors = new List<Book>();
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                books = modelbook.Books.ToList();
            }
            else
            {
                books = modelbook.Books.Where(s =>
                        s.Tittle.ToUpper().Contains(textBox6.Text.ToUpper())).ToList();
            }
            FillDataToDataGridView(books);
        }
    }
}
