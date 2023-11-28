using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodedSuskevits
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ToodeDb;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooriat();
        }

       //public void Lisa_kategooriat(object sender, EventArgs e)
       // {

       // }
        private void Button1_Click(object sender, System.EventArgs e)
        {


            try
            {
                command = new SqlCommand("Insert Into Kategooriatabel(Kategooria_nimetus)VALUES(@kat)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@kat", comboBox1.Text);
                command.ExecuteNonQuery();
                connect.Close();
                comboBox1.Items.Clear();
                NaitaKategooriat();
             }
            catch (Exception)
            {
                MessageBox.Show("Andmebaasid viga!");
            }

        }

        private void Uuendabtn_Click(object sender, System.EventArgs e)
        {
            if (Todebox.Text.Trim() != string.Empty && kogusBox.Text.Trim() != string.Empty && HindBox.Text.Trim() != string.Empty && comboBox1.SelectedItem != null)
            {
                try
                {
                    connect.Open();

                    command = new SqlCommand("SELECT Id FROM Kategooriatabel WHERE Kategooria_nimetus = @kat", connect);
                    command.Parameters.AddWithValue("@kat", comboBox1.Text);
                    int Id = Convert.ToInt32(command.ExecuteScalar());

                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilte, Kategooriat) VALUES (@toode, @kogus, @hind, @pilt, @kat)", connect);
                    command.Parameters.AddWithValue("@toode", Todebox.Text);
                    command.Parameters.AddWithValue("@kogus", Convert.ToInt32(kogusBox.Text));
                    command.Parameters.AddWithValue("@hind", Convert.ToDouble(HindBox.Text));
                    command.Parameters.AddWithValue("@pilt", Todebox.Text + ".jpg");
                    command.Parameters.AddWithValue("@kat", Id);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Andmebaasid viga: " + ex.Message);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                        NaitaAndmed();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sisestage andmeid!");
            }
        }
    

        public void NaitaKategooriat()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("Select Kategooria_nimetus FROM Kategooriatabel", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);

            foreach (DataRow item in dt_kat.Rows)
            {
                string kategooria_nimetus = item["Kategooria_nimetus"].ToString();

                if (!comboBox1.Items.Contains(kategooria_nimetus))
                {
                    comboBox1.Items.Add(kategooria_nimetus);
                }
            }

            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                try
                {
                    string val_kat = comboBox1.SelectedItem.ToString();
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ToodeDb;Integrated Security=True"))
                    {
                        connect.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Kategooriatabel WHERE Kategooria_nimetus = @kat", connect);
                        command.Parameters.AddWithValue("@kat", val_kat);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.Items.Clear();
                    }
                    NaitaKategooriat();
                    MessageBox.Show("Ma kustuan! @kat");
                }
            }
        }



        public void NaitaAndmed()
        {
            connect.Open();

            DataTable dt_toode = new DataTable();
            DataTable table = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toodetabel.Id, Toodetabel.Toodenimetus, Toodetabel.Kogus,Toodetabel.Hind, Toodetabel.Pilte," +
                " Kategooriatabel.Kategooria_nimetus FROM Toodetabel JOIN Kategooriatabel ON Toodetabel.Kategooriat = Kategooriatabel.Id;", connect);
            adapter_toode.Fill(dt_toode);
            table.Columns.Add("Nimetus");
            table.Columns.Add("Kogus");
            table.Columns.Add("Hind");
            table.Columns.Add("Pilt");
            DataGridViewComboBoxColumn dgvcb = new DataGridViewComboBoxColumn();
            foreach  (DataRow item in dt_toode.Rows)
            {
                if (!dgvcb.Items.Contains(item["Kategooria_nimetus"]))
                {
                    dgvcb.Items.Add(item["Kategooria_nimetus"]);
                }
            }
            foreach  (DataRow item in dt_toode.Rows)
            {
                table.Rows.Add(item["Toodenimetus"], item["Kogus"], item["Hind"], item["Pilte"]);
            }
            dgv.DataSource = table;
            dgv.Columns.Add(dgvcb);
            connect.Close();
        }
    }
}
