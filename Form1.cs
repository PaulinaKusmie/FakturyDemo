using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class form1 : Form
    {
        
        
            
        public form1()
        {
            InitializeComponent();
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            //okno informujace użytkownika o błędzie przy wpisaniu nie poprawnej wartośći w NUMER FAKTURY
            int Num;
            bool isNum = int.TryParse(textNumerFaktury.Text.Trim(), out Num);

            if (!isNum)
            {
                MessageBox.Show("W tym oknie numer faktury wpisz tylko cyfry");
            }

            //okno informujące o tym, że pole nie może pozostać puste textbox numer faktury

            if (textNumerFaktury.Text.Length < 0)
            {
                MessageBox.Show("Nie możesz zostawić pola numer faktury pustego");
            }

            //okno informujace użytkownika o błędzie przy wpisaniu nie poprawnej wartośći w textbox cena

            float Num1;
            bool isNum1 = float.TryParse(textCena.Text.Trim(), out Num1);

            if (!isNum1)
            {
                MessageBox.Show("W tym oknie numer faktury wpisz tylko cyfry, odzielajac je przecinkikem");
            }

            //okno informujące o tym, że pole nie może pozostać puste textbox cena

            if (textCena.Text.Length < 0)
            {
                MessageBox.Show("Nie możesz zostawić pola cena pustego");
            }

            //okno informujące o tym, że pole nie może pozostać puste textbox kontrahent

            if (cbKontrahent.Text.Length < 0)
            {
                MessageBox.Show("Nie możesz zostawić pola kontrahent pustego");
            }


            //połaczenie z bazą danych 

            string connectionString = "Data Source=DESKTOP-VHNI52T\\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";

            string sqlQuery = "Insert into test34567(Numerfaktury,Datawystawienia ,Cena,Kontrahent) values(' " + textNumerFaktury.Text.ToString()+" ',' " +dateTimePicker1.Value.ToString("yyyy-MM-dd") + " ',' " + textCena.Text.ToString() + " ',' " +cbKontrahent.Text.ToString()+" ')";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            { 
          
               
             SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
                MessageBox.Show("Dane dodane");

            }
            else
            {
                MessageBox.Show("Coś poszło nie tak, spróbuj ponownie");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'tESTDataSet.test34567'.
            this.test34567TableAdapter.Fill(this.tESTDataSet.test34567);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        //tworzenie wydruku na bitmapie
        Bitmap bitmap;
        private void btnWydrukuj_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;


        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {

            e.Graphics.DrawImage(bitmap, 0, 0);
        }



        private void btnUsun_Click(object sender, EventArgs e)
        {

            //usuwanie rekordów

            if (MessageBox.Show("Czy na pewno chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }

            }
        }



        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            //odświezanie rekordów

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHNI52T\\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
            SqlCommand com = new SqlCommand("Select * from test34567", con);
            SqlDataAdapter d = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        public void dataselect()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHNI52T\\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT (Numerfaktury, Cena, Kontrahent) * FROM test34567", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.Row.Clear();
            //DataGridViewRowCollection.Clear();
            ((DataTable)dataGridView1.DataSource).Rows.Clear();




            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[1].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
            }

        }
            

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnAktualizujdane_Click(object sender, EventArgs e)

            //aktaulizuje dane po ich wcześniejszej edycji!!!!
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHNI52T\\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");


            string sqlQuery = ("Update [test34567] set Numerfaktury = ' " + textNumerFaktury.Text.ToString() + " 'Cena= ' " + textCena.Text.ToString() + " 'Kontrahent=' " + cbKontrahent.Text.ToString() + "' Where Numerfaktury =' " + textNumerFaktury.Text.ToString() + "'");

           

            
            if (con.State == System.Data.ConnectionState.Open)
            {


                SqlCommand sc = new SqlCommand(sqlQuery, con);
                sc.ExecuteNonQuery();
                con.Close();
                dataselect();
                MessageBox.Show(" Rekord zaktualizowany!");

            }
            else
            {
                MessageBox.Show("Coś poszło nie tak, spróbuj ponownie");
            }

        }

        private void btnEdytujdane_Click_1(object sender, EventArgs e)
        {
            textNumerFaktury.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textCena.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();          
            cbKontrahent.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
