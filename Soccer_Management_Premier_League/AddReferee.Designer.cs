namespace Soccer_Management_Premier_League
{
    partial class AddReferee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.la_birth = new System.Windows.Forms.Label();
            this.text_type = new System.Windows.Forms.TextBox();
            this.text_nation = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.la_nation = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.la_type = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(226)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 49);
            this.panel1.TabIndex = 149;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(245)))), ((int)(((byte)(195)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(245)))), ((int)(((byte)(195)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(730, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 29);
            this.guna2ControlBox1.TabIndex = 2;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Soccer_Management_Premier_League.Properties.Resources.CgZFMkJFMzY;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Referee";
            // 
            // date_birth
            // 
            this.date_birth.CustomFormat = "dd/MM/yyyy";
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_birth.Location = new System.Drawing.Point(581, 132);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(140, 26);
            this.date_birth.TabIndex = 160;
            // 
            // la_birth
            // 
            this.la_birth.AutoSize = true;
            this.la_birth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_birth.Location = new System.Drawing.Point(457, 133);
            this.la_birth.Name = "la_birth";
            this.la_birth.Size = new System.Drawing.Size(178, 30);
            this.la_birth.TabIndex = 159;
            this.la_birth.Text = "Date Of Birth :";
            // 
            // text_type
            // 
            this.text_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_type.Location = new System.Drawing.Point(581, 68);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(140, 26);
            this.text_type.TabIndex = 158;
            // 
            // text_nation
            // 
            this.text_nation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_nation.Location = new System.Drawing.Point(146, 128);
            this.text_nation.Name = "text_nation";
            this.text_nation.Size = new System.Drawing.Size(140, 26);
            this.text_nation.TabIndex = 157;
            // 
            // text_name
            // 
            this.text_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_name.Location = new System.Drawing.Point(146, 70);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(140, 26);
            this.text_name.TabIndex = 156;
            // 
            // la_nation
            // 
            this.la_nation.AutoSize = true;
            this.la_nation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_nation.Location = new System.Drawing.Point(28, 128);
            this.la_nation.Name = "la_nation";
            this.la_nation.Size = new System.Drawing.Size(155, 30);
            this.la_nation.TabIndex = 154;
            this.la_nation.Text = "Nationality :";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_name.Location = new System.Drawing.Point(28, 68);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(101, 30);
            this.la_name.TabIndex = 152;
            this.la_name.Text = "Name :";
            // 
            // la_type
            // 
            this.la_type.AutoSize = true;
            this.la_type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_type.Location = new System.Drawing.Point(457, 68);
            this.la_type.Name = "la_type";
            this.la_type.Size = new System.Drawing.Size(83, 30);
            this.la_type.TabIndex = 151;
            this.la_type.Text = "Type :";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(87)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(623, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 163;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(99)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(501, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 162;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddReferee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.la_birth);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.text_nation);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.la_nation);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.la_type);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(380, 230);
            this.Name = "AddReferee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddReferee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Label la_birth;
        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.TextBox text_nation;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label la_nation;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}