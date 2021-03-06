﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViper
{
    public partial class attempt1 : Form
    {
        public attempt1()
        {
            InitializeComponent();
        }

        private void attempt1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            beginWoods.Start();
            downloadTimer.Start();
            Cursor.Show();
        }

        private void beginWoods_Tick(object sender, EventArgs e)
        {
            beginWoods.Stop();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "woods.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.PlayLooping();
        }

        private void downloadTimer_Tick(object sender, EventArgs e)
        {
            downloadBar.Value++;
            if (downloadBar.Value >= 70)
            {
                label2.Text = "Your computer is in danger";
                Cursor.Current = Cursors.AppStarting;
            }
            if (downloadBar.Value >= 90)
            {
                label2.Text = "";
            }
            if (downloadBar.Value >= 140)
            {
                label4.Text = "An error has occured 0xc00000e9";
            }
            if (downloadBar.Value >= 155)
            {
                label4.Text = "...Resolving issue...";
            }
            if (downloadBar.Value >= 157)
            {
                label4.Text = "  eRrror has occur23091340+|/ 0xc00000e9";
            }
            if (downloadBar.Value >= 165)
            {
                label4.Text = "";
            }
            if (downloadBar.Value >= 170)
            {
                label4.Text = "An error has occured 0xc00000e9";
            }
            if (downloadBar.Value >= 175)
            {
                label4.Text = "";
            }
            if (downloadBar.Value >= 180)
            {
                label4.Text = "An error has occured 0xc00000e9";
            }
            if (downloadBar.Value >= 185)
            {
                label4.Text = "";
            }
            if (downloadBar.Value >= 200)
            {
                label5.Text = "Something went wrong10100- INTERNAL ZIP FILE DOESN'T EXIST";
            }
            if (downloadBar.Value >= 233)
            {
                label5.Text = "Close program now";
            }
            if (downloadBar.Value >= 236)
            {
                label5.Text = "01101011110010001";
            }
            if (downloadBar.Value >= 240)
            {
                label5.Text = "Terminate progr  a  m";
            }
            if (downloadBar.Value >= 248)
            {
                label5.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            }
            if (downloadBar.Value >= 250)
            {
                label5.Text = "";
                label6.Text = "Warning your files are being corrupted";
                Cursor.Current = Cursors.WaitCursor;
            }
            if (downloadBar.Value >= 255)
            {
                label2.Text = "11001001Cri ical aler t";
            }
            if (downloadBar.Value >= 265)
            {
                label6.Text = "";
            }
            if (downloadBar.Value >= 275)
            {
                label2.Text = "";
                label7.Text = "Critical alert e xit no01101001001011";
            }
            if (downloadBar.Value >= 300)
            {
                label1.Text = "";
                label3.Text = "";
            }
            if (downloadBar.Value >= 340)
            {
                this.BackColor = System.Drawing.Color.Black;
                label7.Text = "";
            }
            if (downloadBar.Value >= 341)
            {
                this.BackColor = System.Drawing.Color.White;
            }
            if (downloadBar.Value >= 343)
            {
                this.BackColor = System.Drawing.Color.Black;
            }
            if (downloadBar.Value >= 360)
            {
                label8.Text = "Completing download shortly";
            }
            if (downloadBar.Value >= 372)
            {
                this.BackColor = System.Drawing.Color.CornflowerBlue;
                label8.ForeColor = Color.Red;
                label9.Text = "Please be patient.";
            }
            if (downloadBar.Value >= 450)
            {
                label8.Text = "";
                label9.Text = "";
            }
            if (downloadBar.Value >= 470)
            {
                label1.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label2.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label3.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label4.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label5.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label6.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label7.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label8.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label9.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
            }
            if (downloadBar.Value >= 475)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
            if (downloadBar.Value >= 480)
            {
                label1.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label2.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label3.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label4.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label5.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label6.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label7.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label8.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label9.Text = "ⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧⓧ";
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
            }
            if (downloadBar.Value >= 490)
            {
                label1.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label2.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label3.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label4.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label5.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label6.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label7.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label8.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label9.Text = "☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠☠";
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
            }
            if (downloadBar.Value >= 500)
            {
                label1.Text = "Please be patient.";
                label2.Text = "Please be patient.";
                label3.Text = "Please be patient.";
                label4.Text = "Please be patient.";
                label5.Text = "Please be patient.";
                label6.Text = "Please be patient.";
                label7.Text = "Please be patient.";
                label8.Text = "Please be patient.";
                label9.Text = "Please be patient.";
            }
            if (downloadBar.Value >= 520)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                
            }
            if (downloadBar.Value >= 560)
            {
                label1.Text = "REM EMBERR EMEMBERREMEMBER REMEMBE R";
                label2.Text = "REM EM BERREMEM BERREMEMBERREMEMBER";
                label3.Text = "REMEMBERREMEM BERRE MEMBE  RREMEMBER";
                label4.Text = "REMEM BE RREMEMBERREMEMB ERREMEMBER";
                label5.Text = "REM EMBERREMEMBERREMEMBERREMEMBER";
                label6.Text = "REMEMBERR EMEMB  ERR EMEMBERREMEMBER";
                label7.Text = "RE MEMBERREMEMBERREMEMBE RREMEMBER";
                label8.Text = "REMEMB ERREMEMBERREMEMBERREM  EMBER";
                label9.Text = "REMEMBERREMEMB ERREMEMBERREMEMBER";
                this.BackColor = System.Drawing.Color.Red;
            }
            if (downloadBar.Value >= 563)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
            if (downloadBar.Value >= 566)
            {
                label1.Text = "REM EMBERR EMEMBERREMEMBER REMEMBE R";
                label2.Text = "REM EM BERREMEM BERREMEMBERREMEMBER";
                label3.Text = "REMEMBERREMEM BERRE MEMBE  RREMEMBER";
                label4.Text = "REMEM BE RREMEMBERREMEMB ERREMEMBER";
                label5.Text = "REM EMBERREMEMBERREMEMBERREMEMBER";
                label6.Text = "REMEMBERR EMEMB  ERR EMEMBERREMEMBER";
                label7.Text = "RE MEMBERREMEMBERREMEMBE RREMEMBER";
                label8.Text = "REMEMB ERREMEMBERREMEMBERREM  EMBER";
                label9.Text = "REMEMBERREMEMB ERREMEMBERREMEMBER";
            }
            if (downloadBar.Value >= 569)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
            if (downloadBar.Value >= 572)
            {
                label1.Text = "REM EMBERR EMEMBERREMEMBER REMEMBE R";
                label2.Text = "REM EM BERREMEM BERREMEMBERREMEMBER";
                label3.Text = "REMEMBERREMEM BERRE MEMBE  RREMEMBER";
                label4.Text = "REMEM BE RREMEMBERREMEMB ERREMEMBER";
                label5.Text = "REM EMBERREMEMBERREMEMBERREMEMBER";
                label6.Text = "REMEMBERR EMEMB  ERR EMEMBERREMEMBER";
                label7.Text = "RE MEMBERREMEMBERREMEMBE RREMEMBER";
                label8.Text = "REMEMB ERREMEMBERREMEMBERREM  EMBER";
                label9.Text = "REMEMBERREMEMB ERREMEMBERREMEMBER";
            }
            if (downloadBar.Value >= 580)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                this.BackColor = System.Drawing.Color.Black;
            }
            //end 
            if (downloadBar.Value == 600)
            {
                notifyIcon1.Text = "1000100 1001001 1000101 100000 1000100 1001001 1000101 100000";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Microsoft is detecting a possible threat. Please consider troubleshooting...";
                notifyIcon1.BalloonTipTitle = "WARNING!!!";
                notifyIcon1.ShowBalloonTip(1000);
                downloadTimer.Stop();
                spook.Start();
                Cursor.Current = Cursors.No;
                label10.Text = "3";
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "halt.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
            }
        }

        private void spook_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.dankeem;
            backToAlpha.Start();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "spookynoise1.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
        }

        private void backToAlpha_Tick(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "halt.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
            spook.Stop();
            backToAlpha.Stop();
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void attempt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                beginWoods.Stop();
                downloadTimer.Stop();
                spook.Stop();
                backToAlpha.Stop();
                returnEscapeFail.Stop();
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "halt.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                Hide();
                Alpha form = new Alpha();
                form.ShowDialog();
                Close();
            } else
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void returnEscapeFail_Tick(object sender, EventArgs e)
        {
            returnEscapeFail.Stop();
            escapefailure.Text = "";
            escapefailure2.Text = "";
        }
    }
}
