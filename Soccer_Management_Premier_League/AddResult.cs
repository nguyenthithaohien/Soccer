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
using System.IO;

namespace Soccer_Management_Premier_League
{
    public partial class AddResult : Form
    {
        public AddResult()
        {
            InitializeComponent();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            LoadResult();
        }

        public void LoadResult()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KBHC686\SQLEXPRESS;Initial Catalog=QLDB;Integrated Security=True"))
            {
                connection.Open();
                string query = "Select IDMatch, T1.PIC,T1.CLBNAME,SCORED1,SCORED2,T2.PIC,T2.CLBNAME, DATE,TIME, STAYDIUM from CLUB as T1, CLUB as T2, MATCH1 as M where M.CLB1 = T1.IDCLB and " +
                    "M.CLB2 = T2.IDCLB";

                SqlDataAdapter ada = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                DataGridView_match.DataSource = dt;

                DataGridView_match.Columns[0].HeaderText = "ID";
                DataGridView_match.Columns[1].HeaderText = "";
                DataGridView_match.Columns[2].HeaderText = "Host team";
                DataGridView_match.Columns[3].HeaderText = "Score";
                DataGridView_match.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DataGridView_match.Columns[4].HeaderText = "";
                DataGridView_match.Columns[5].HeaderText = "";
                DataGridView_match.Columns[6].HeaderText = "Visit team";
                DataGridView_match.Columns[7].HeaderText = "Date";
                DataGridView_match.Columns[8].HeaderText = "Time";
                DataGridView_match.Columns[9].HeaderText = "Stadium";

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DataGridView_match.Columns[1];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                DataGridViewImageColumn imageColumn1 = new DataGridViewImageColumn();
                imageColumn1 = (DataGridViewImageColumn)DataGridView_match.Columns[5];
                imageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;

                DataGridView_match.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                DataGridView_match.Columns[8].DefaultCellStyle.Format = @"hh\:mm";

                DataGridView_match.Columns[0].Width = 70;
                DataGridView_match.Columns[1].Width = 50;
                DataGridView_match.Columns[2].Width = 170;
                DataGridView_match.Columns[3].Width = 50;
                DataGridView_match.Columns[4].Width = 50;
                DataGridView_match.Columns[5].Width = 50;
                DataGridView_match.Columns[6].Width = 170;
                DataGridView_match.Columns[7].Width = 130;
                DataGridView_match.Columns[8].Width = 100;
                DataGridView_match.Columns[9].Width = 140;


                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                Result result = new Result(this);

                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Black;
                formBackground.WindowState = FormWindowState.Maximized;
                formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                result.Owner = formBackground;

                result.ID_txt.Text = DataGridView_match.CurrentRow.Cells[0].Value.ToString();
                result.Club_cbx.Text = DataGridView_match.CurrentRow.Cells[2].Value.ToString();
                result.Club_cbx1.Text = DataGridView_match.CurrentRow.Cells[6].Value.ToString();

                result.dateTimePicker1.Value = (DateTime)DataGridView_match.CurrentRow.Cells[7].Value;
                var dt = result.dateTimePicker1.Value.Add((TimeSpan)DataGridView_match.CurrentRow.Cells[8].Value);
                result.dateTimePicker1.Value = dt;

                result.Stadium_cbx.Text = DataGridView_match.CurrentRow.Cells[9].Value.ToString();

                result.ShowDialog();
                
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
    }
}
