using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Management_Premier_League
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            Panel_Club.Visible = false;
            Panel_MatchSchedule.Visible = false;
            Panel_Ranking.Visible = false;
            Panel_Result.Visible = false;
            Panel_Referee.Visible = false;
            
        }
        private void hideSubmenu()
        {
            if (Panel_Club.Visible == true)
                Panel_Club.Visible = false;
            if (Panel_MatchSchedule.Visible == true)
                Panel_MatchSchedule.Visible = false;
            if (Panel_Ranking.Visible == true)
                Panel_Ranking.Visible = false;
            if (Panel_Result.Visible == true)
                Panel_Result.Visible = false;
            if (Panel_Referee.Visible == true)
                Panel_Referee.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Club_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_Club);
        }

        private void Btn_MatchSchedule_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_MatchSchedule);
        }

        private void Btn_Ranking_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_Ranking);
        }

        private void Btn_Referee_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_Referee);
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_Result);
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Btn_Registration_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Registration());
            hideSubmenu();
        }

        private void Btn_ManageClub_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageClub());
            hideSubmenu();
        }

        private void Btn_UpdateClub_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagePlayer());
            hideSubmenu();
        }

        private void Btn_AddMatch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddMatch());
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageMatch());
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
