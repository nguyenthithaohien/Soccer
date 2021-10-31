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
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }

        public void LoadCoach()
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KBHC686\SQLEXPRESS;Initial Catalog=QLDB;Integrated Security=True"))
            {
                connection.Open();
                string query = "Select IDCOACH, C1.IDCLB, C.CLBNAME, COACHNAME, NATIONALITY, DAY_BORN, TYPE_COACH from COACH as C1,CLUB as C where C1.IDCLB = C.IDCLB";
                SqlDataAdapter ada = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataGridView_coach.DataSource = dt;
                DataGridView_coach.Columns[0].HeaderText = "ID";
                DataGridView_coach.Columns[1].HeaderText = "IDCLB";
                DataGridView_coach.Columns[2].HeaderText = "CLB Name";
                DataGridView_coach.Columns[3].HeaderText = "Coach Name";
                DataGridView_coach.Columns[4].HeaderText = "Nationality";
                DataGridView_coach.Columns[5].HeaderText = "Birthday";
                DataGridView_coach.Columns[6].HeaderText = "Type";

                DataGridView_coach.Columns[0].Width = 60;
                DataGridView_coach.Columns[1].Width = 60;
                DataGridView_coach.Columns[2].Width = 130;
                DataGridView_coach.Columns[3].Width = 130;
                DataGridView_coach.Columns[4].Width = 130;
                DataGridView_coach.Columns[5].Width = 80;
                DataGridView_coach.Columns[6].Width = 40;

                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                AddCoach form1 = new AddCoach(this);

                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Black;
                formBackground.WindowState = FormWindowState.Maximized;
                //formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                form1.Owner = formBackground;
                form1.ShowDialog();

                formBackground.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void Coach_Load(object sender, EventArgs e)
        {
            LoadCoach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                if (DataGridView_coach.Rows.Count != 0)
                {
                    EditCoach form1 = new EditCoach(this);

                    //form1.ID_Txt.Text = DataGridView_coach.CurrentRow.Cells[1].Value.ToString();
                    //form1.Name_Txt.Text = DataGridView_coach.CurrentRow.Cells[3].Value.ToString();
                    //form1.Nation_Txt.Text = DataGridView_coach.CurrentRow.Cells[4].Value.ToString();
                    //form1.Birth_Date.Value = (DateTime)DataGridView_coach.CurrentRow.Cells[5].Value;
                    //form1.Type_Txt.Text = DataGridView_coach.CurrentRow.Cells[6].Value.ToString();
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    form1.Owner = formBackground;
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No coach. Please add coach");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void DataGridView_coach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
