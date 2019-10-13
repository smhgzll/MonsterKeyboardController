using MonsterNotebook.ControlCenter;
using MonsterNotebook.ControlCenter.Models;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MonsterKeyboardCC
{
    public partial class Form1 : Form
    {
        private MQTTDatsService mQTTDatsService = MQTTDatsService.GetInstance();

        private ColorBuffer Section1 = new ColorBuffer(0, 0, 0);
        private ColorBuffer Section2 = new ColorBuffer(0, 0, 0);
        private ColorBuffer Section3 = new ColorBuffer(0, 0, 0);
        private ColorBuffer Section4 = new ColorBuffer(0, 0, 0);

        private string Dim = "4";

        public void ChangeKeyboard()
        {
            var colors = new ColorBuffer[] {
                                Section1,
                                Section2,
                                Section3,
                                Section4
                            };

            KeyboardModel myKeyboardModel = new KeyboardModel
            {
                function = "SetEffectALL",
                mode = "Lighting",
                effect = "Single",
                light = Dim,
                speed = "0",
                direction = "None",
                nv_save = "NOT_SAVE",
                backgroundcolor = 1,
                alphabet = "",
                solution = 0,
                level = 0,
                powerstatus = 1,
                type = 0,
                color = new Color()
                {
                    isCircular = true,
                    ColorBlocks = colors.Count(),
                    ColorBuffer = colors
                }
            };

            mQTTDatsService.PublishTopic("Keyboard/Ctrl", myKeyboardModel);
        }

        public Form1()
        {
            InitializeComponent();
        }

 
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vs_1_red_Scroll(object sender, ScrollEventArgs e)
        {
            Section1.R = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_1_green_Scroll(object sender, ScrollEventArgs e)
        {
            Section1.G = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_1_blue_Scroll(object sender, ScrollEventArgs e)
        {
            Section1.B = 255 - e.NewValue;
            ChangeKeyboard();
        }
               
        private void vs_2_red_Scroll(object sender, ScrollEventArgs e)
        {
            Section2.R = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_2_green_Scroll(object sender, ScrollEventArgs e)
        {
            Section2.G = 255 - e.NewValue;
            ChangeKeyboard();

        }

        private void vs_2_blue_Scroll(object sender, ScrollEventArgs e)
        {
            Section2.B = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_3_red_Scroll(object sender, ScrollEventArgs e)
        {
            Section3.R = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_3_green_Scroll(object sender, ScrollEventArgs e)
        {
            Section3.G = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_3_blue_Scroll(object sender, ScrollEventArgs e)
        {
            Section3.B = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_4_red_Scroll(object sender, ScrollEventArgs e)
        {
            Section4.R = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_4_green_Scroll(object sender, ScrollEventArgs e)
        {
            Section4.G = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_4_blue_Scroll(object sender, ScrollEventArgs e)
        {
            Section4.B = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_master_red_Scroll(object sender, ScrollEventArgs e)
        {
            Section1.R = 255 - e.NewValue;
            Section2.R = 255 - e.NewValue;
            Section3.R = 255 - e.NewValue;
            Section4.R = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_master_green_Scroll(object sender, ScrollEventArgs e)
        {
            Section1.G = 255 - e.NewValue;
            Section2.G = 255 - e.NewValue;
            Section3.G = 255 - e.NewValue;
            Section4.G = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void vs_master_blue_Scroll(object sender, ScrollEventArgs e)
        {
            Section1.B = 255 - e.NewValue;
            Section2.B = 255 - e.NewValue;
            Section3.B = 255 - e.NewValue;
            Section4.B = 255 - e.NewValue;
            ChangeKeyboard();
        }

        private void rb_dim1_CheckedChanged(object sender, EventArgs e)
        {
            Dim = "1";
            ChangeKeyboard();
        }

        private void rb_dim2_CheckedChanged(object sender, EventArgs e)
        {
            Dim = "2";
            ChangeKeyboard();
        }

        private void rb_dim3_CheckedChanged(object sender, EventArgs e)
        {
            Dim = "3";
            ChangeKeyboard();
        }

        private void rb_dim4_CheckedChanged(object sender, EventArgs e)
        {
            Dim = "4";
            ChangeKeyboard();
        }

        private void rb_dim0_CheckedChanged(object sender, EventArgs e)
        {
            Dim = "0";
            ChangeKeyboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            var result = colorDialog1.Color;
            panel1.BackColor = result;
            Section1 = Section2 = Section3 = Section4 = new ColorBuffer(result.R, result.G, result.B);
            Thread.Sleep(200);
            ChangeKeyboard();
        }
    }
}
