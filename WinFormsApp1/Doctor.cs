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
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Doctor : Form
    {
        //public static HmsContext HmsContext = new HmsContext();
        public Doctor()
        {
            InitializeComponent();
            DisplayDoctor();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mac\Documents\dms.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDoctor()
        {
            try
            {
                con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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
        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == " " || doctorNameTextBox.Text == " " || GenderComboBox.Text == " " || expTextBox.Text == " " || licenceTextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Doctor Values(' " + textBox2.Text + " ', ' " + doctorNameTextBox.Text + " ' , ' " + GenderComboBox.Text + " ' , ' " + expTextBox.Text + " ' , ' " + licenceTextBox.Text + " ' )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Enterd Successfully");
                    DisplayDoctor();

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

        private void Doctor_Load(object sender, EventArgs e)
        {
            DisplayDoctor();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            doctorNameTextBox.Text = " ";
            GenderComboBox.Text = " ";
            expTextBox.Text = " ";
            licenceTextBox.Text = " ";
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == " ")
                {
                    MessageBox.Show("Enter the Doctor Id");
                }
                else
                {
                    con.Open();
                    string query = "delete from Doctor where Id ='" + textBox2.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted successfully");
                    DisplayDoctor();
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == " " || doctorNameTextBox.Text == " " || GenderComboBox.Text == " " || expTextBox.Text == " " || licenceTextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update Doctor set DocName =@DocName , DocGen= @DocGen , Experience=@Experience, Licensce= @Licensce where Id =@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DocName", doctorNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@DocGen", GenderComboBox.Text);
                    cmd.Parameters.AddWithValue("@Experience", expTextBox.Text);
                    cmd.Parameters.AddWithValue("@Licensce", licenceTextBox.Text);
                    cmd.Parameters.AddWithValue("@Id", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record update successfully");
                    DisplayDoctor();

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
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                doctorNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                GenderComboBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                expTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                licenceTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
