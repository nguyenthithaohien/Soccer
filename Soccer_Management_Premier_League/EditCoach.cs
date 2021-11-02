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

namespace Soccer_Management_Premier_League
{
    public partial class EditCoach : Form
    {
        Coach coach;
        public EditCoach(Coach c)
        {
            InitializeComponent();
            coach = c;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KBHC686\SQLEXPRESS;Initial Catalog=QLDB;Integrated Security=True"))
            {
                string id = ID_Txt.Text;
                string name = Name_Txt.Text;
                string type = Type_Txt.Text;
                string quocGia = Nation_Txt.Text;
                DateTime dateTime = Birth_Date.Value;

                connection.Open();
                string query = "Update COACH set IDCLB = @id, COACHNAME = @name,NATIONALITY = @quocGia, DAY_BORN = @dateTime, TYPE_COACH = @type where COACHNAME = '" + name + "'";

                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@quocGia", quocGia);
                command.Parameters.AddWithValue("@dateTime", dateTime);
                command.Parameters.AddWithValue("@type", type);
               
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                    coach.LoadCoach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this coach", "Remove Coach", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KBHC686\SQLEXPRESS;Initial Catalog=QLDB;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "Delete from COACH where COACHNAME = '" + Name_Txt.Text + "'";

                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Coach Removed", "Remove coach", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        coach.LoadCoach();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
            }
        }
    }
}
