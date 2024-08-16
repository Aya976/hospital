using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            DisplayPatient();
        }
        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mac\Documents\dms.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayPatient()
        {
            try
            {
                con.Open();
                string Query = "select * from Patient";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into patient Values(' " + textBox1.Text + " ', ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ' , ' " + textBox4.Text + " ' , ' " + textBox5.Text + " ' , ' " + comboBox1.Text + " ' , '" + comboBox2.Text + " ' , ' " + textBox6.Text + " ' )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Enterd Successfully");
                    DisplayPatient();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void patient_Load(object sender, EventArgs e)
        {
            DisplayPatient();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }

                else
                {
                    con.Open();
                    string query = "update Patient set PName =@PocName , PAddress= @PAddress , PAge=@PAge, PPhone= @PPhone, PGen=@PGen, BloodGroup=@BloodGroup, MajorDisease=@MajorDisease where PId =@PId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PAddress", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PAge", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PPhone", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PGen", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@MajorDisease", textBox6.Text);
                    cmd.Parameters.AddWithValue("@PId", textBox1.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record update successfully");
                    DisplayPatient();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter the Patient Id");
                }
                else
                {
                    con.Open();
                    string query = "delete from Patient where PId ='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted successfully");
                    //DisplayPatient();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox6.Text = " ";
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                textBox6.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
