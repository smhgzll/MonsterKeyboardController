namespace MonsterKeyboardCC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vs_1_red = new System.Windows.Forms.VScrollBar();
            this.vs_1_green = new System.Windows.Forms.VScrollBar();
            this.vs_1_blue = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_dim1 = new System.Windows.Forms.RadioButton();
            this.rb_dim2 = new System.Windows.Forms.RadioButton();
            this.rb_dim3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vs_2_red = new System.Windows.Forms.VScrollBar();
            this.vs_2_green = new System.Windows.Forms.VScrollBar();
            this.vs_2_blue = new System.Windows.Forms.VScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vs_3_red = new System.Windows.Forms.VScrollBar();
            this.vs_3_green = new System.Windows.Forms.VScrollBar();
            this.vs_3_blue = new System.Windows.Forms.VScrollBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vs_4_red = new System.Windows.Forms.VScrollBar();
            this.vs_4_green = new System.Windows.Forms.VScrollBar();
            this.vs_4_blue = new System.Windows.Forms.VScrollBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.vs_master_red = new System.Windows.Forms.VScrollBar();
            this.vs_master_green = new System.Windows.Forms.VScrollBar();
            this.vs_master_blue = new System.Windows.Forms.VScrollBar();
            this.rb_dim4 = new System.Windows.Forms.RadioButton();
            this.rb_dim0 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // vs_1_red
            // 
            this.vs_1_red.Location = new System.Drawing.Point(11, 28);
            this.vs_1_red.Maximum = 255;
            this.vs_1_red.Name = "vs_1_red";
            this.vs_1_red.Size = new System.Drawing.Size(28, 139);
            this.vs_1_red.TabIndex = 0;
            this.vs_1_red.Value = 255;
            this.vs_1_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_1_red_Scroll);
            // 
            // vs_1_green
            // 
            this.vs_1_green.Location = new System.Drawing.Point(54, 28);
            this.vs_1_green.Maximum = 255;
            this.vs_1_green.Name = "vs_1_green";
            this.vs_1_green.Size = new System.Drawing.Size(28, 139);
            this.vs_1_green.TabIndex = 1;
            this.vs_1_green.Value = 255;
            this.vs_1_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_1_green_Scroll);
            // 
            // vs_1_blue
            // 
            this.vs_1_blue.Location = new System.Drawing.Point(97, 28);
            this.vs_1_blue.Maximum = 255;
            this.vs_1_blue.Name = "vs_1_blue";
            this.vs_1_blue.Size = new System.Drawing.Size(28, 139);
            this.vs_1_blue.TabIndex = 2;
            this.vs_1_blue.Value = 255;
            this.vs_1_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_1_blue_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Brightness";
            // 
            // rb_dim1
            // 
            this.rb_dim1.AutoSize = true;
            this.rb_dim1.Location = new System.Drawing.Point(580, 207);
            this.rb_dim1.Name = "rb_dim1";
            this.rb_dim1.Size = new System.Drawing.Size(37, 21);
            this.rb_dim1.TabIndex = 5;
            this.rb_dim1.TabStop = true;
            this.rb_dim1.Text = "1";
            this.rb_dim1.UseVisualStyleBackColor = true;
            this.rb_dim1.CheckedChanged += new System.EventHandler(this.rb_dim1_CheckedChanged);
            // 
            // rb_dim2
            // 
            this.rb_dim2.AutoSize = true;
            this.rb_dim2.Location = new System.Drawing.Point(623, 207);
            this.rb_dim2.Name = "rb_dim2";
            this.rb_dim2.Size = new System.Drawing.Size(37, 21);
            this.rb_dim2.TabIndex = 6;
            this.rb_dim2.TabStop = true;
            this.rb_dim2.Text = "2";
            this.rb_dim2.UseVisualStyleBackColor = true;
            this.rb_dim2.CheckedChanged += new System.EventHandler(this.rb_dim2_CheckedChanged);
            // 
            // rb_dim3
            // 
            this.rb_dim3.AutoSize = true;
            this.rb_dim3.Location = new System.Drawing.Point(666, 207);
            this.rb_dim3.Name = "rb_dim3";
            this.rb_dim3.Size = new System.Drawing.Size(37, 21);
            this.rb_dim3.TabIndex = 6;
            this.rb_dim3.TabStop = true;
            this.rb_dim3.Text = "3";
            this.rb_dim3.UseVisualStyleBackColor = true;
            this.rb_dim3.CheckedChanged += new System.EventHandler(this.rb_dim3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vs_1_red);
            this.groupBox1.Controls.Add(this.vs_1_green);
            this.groupBox1.Controls.Add(this.vs_1_blue);
            this.groupBox1.Location = new System.Drawing.Point(160, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vs_2_red);
            this.groupBox2.Controls.Add(this.vs_2_green);
            this.groupBox2.Controls.Add(this.vs_2_blue);
            this.groupBox2.Location = new System.Drawing.Point(308, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 189);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section 2";
            // 
            // vs_2_red
            // 
            this.vs_2_red.Location = new System.Drawing.Point(11, 28);
            this.vs_2_red.Maximum = 255;
            this.vs_2_red.Name = "vs_2_red";
            this.vs_2_red.Size = new System.Drawing.Size(28, 139);
            this.vs_2_red.TabIndex = 0;
            this.vs_2_red.Value = 255;
            this.vs_2_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_2_red_Scroll);
            // 
            // vs_2_green
            // 
            this.vs_2_green.Location = new System.Drawing.Point(54, 28);
            this.vs_2_green.Maximum = 255;
            this.vs_2_green.Name = "vs_2_green";
            this.vs_2_green.Size = new System.Drawing.Size(28, 139);
            this.vs_2_green.TabIndex = 1;
            this.vs_2_green.Value = 255;
            this.vs_2_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_2_green_Scroll);
            // 
            // vs_2_blue
            // 
            this.vs_2_blue.Location = new System.Drawing.Point(97, 28);
            this.vs_2_blue.Maximum = 255;
            this.vs_2_blue.Name = "vs_2_blue";
            this.vs_2_blue.Size = new System.Drawing.Size(28, 139);
            this.vs_2_blue.TabIndex = 2;
            this.vs_2_blue.Value = 255;
            this.vs_2_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_2_blue_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vs_3_red);
            this.groupBox3.Controls.Add(this.vs_3_green);
            this.groupBox3.Controls.Add(this.vs_3_blue);
            this.groupBox3.Location = new System.Drawing.Point(456, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 189);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Section 3";
            // 
            // vs_3_red
            // 
            this.vs_3_red.Location = new System.Drawing.Point(11, 28);
            this.vs_3_red.Maximum = 255;
            this.vs_3_red.Name = "vs_3_red";
            this.vs_3_red.Size = new System.Drawing.Size(28, 139);
            this.vs_3_red.TabIndex = 0;
            this.vs_3_red.Value = 255;
            this.vs_3_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_3_red_Scroll);
            // 
            // vs_3_green
            // 
            this.vs_3_green.Location = new System.Drawing.Point(54, 28);
            this.vs_3_green.Maximum = 255;
            this.vs_3_green.Name = "vs_3_green";
            this.vs_3_green.Size = new System.Drawing.Size(28, 139);
            this.vs_3_green.TabIndex = 1;
            this.vs_3_green.Value = 255;
            this.vs_3_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_3_green_Scroll);
            // 
            // vs_3_blue
            // 
            this.vs_3_blue.Location = new System.Drawing.Point(97, 28);
            this.vs_3_blue.Maximum = 255;
            this.vs_3_blue.Name = "vs_3_blue";
            this.vs_3_blue.Size = new System.Drawing.Size(28, 139);
            this.vs_3_blue.TabIndex = 2;
            this.vs_3_blue.Value = 255;
            this.vs_3_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_3_blue_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vs_4_red);
            this.groupBox4.Controls.Add(this.vs_4_green);
            this.groupBox4.Controls.Add(this.vs_4_blue);
            this.groupBox4.Location = new System.Drawing.Point(604, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 189);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Section 4";
            // 
            // vs_4_red
            // 
            this.vs_4_red.Location = new System.Drawing.Point(11, 28);
            this.vs_4_red.Maximum = 255;
            this.vs_4_red.Name = "vs_4_red";
            this.vs_4_red.Size = new System.Drawing.Size(28, 139);
            this.vs_4_red.TabIndex = 0;
            this.vs_4_red.Value = 255;
            this.vs_4_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_4_red_Scroll);
            // 
            // vs_4_green
            // 
            this.vs_4_green.Location = new System.Drawing.Point(54, 28);
            this.vs_4_green.Maximum = 255;
            this.vs_4_green.Name = "vs_4_green";
            this.vs_4_green.Size = new System.Drawing.Size(28, 139);
            this.vs_4_green.TabIndex = 1;
            this.vs_4_green.Value = 255;
            this.vs_4_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_4_green_Scroll);
            // 
            // vs_4_blue
            // 
            this.vs_4_blue.Location = new System.Drawing.Point(97, 28);
            this.vs_4_blue.Maximum = 255;
            this.vs_4_blue.Name = "vs_4_blue";
            this.vs_4_blue.Size = new System.Drawing.Size(28, 139);
            this.vs_4_blue.TabIndex = 2;
            this.vs_4_blue.Value = 255;
            this.vs_4_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_4_blue_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.vs_master_red);
            this.groupBox5.Controls.Add(this.vs_master_green);
            this.groupBox5.Controls.Add(this.vs_master_blue);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 189);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Master";
            // 
            // vs_master_red
            // 
            this.vs_master_red.Location = new System.Drawing.Point(11, 28);
            this.vs_master_red.Maximum = 255;
            this.vs_master_red.Name = "vs_master_red";
            this.vs_master_red.Size = new System.Drawing.Size(28, 139);
            this.vs_master_red.TabIndex = 0;
            this.vs_master_red.Value = 255;
            this.vs_master_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_master_red_Scroll);
            // 
            // vs_master_green
            // 
            this.vs_master_green.Location = new System.Drawing.Point(54, 28);
            this.vs_master_green.Maximum = 255;
            this.vs_master_green.Name = "vs_master_green";
            this.vs_master_green.Size = new System.Drawing.Size(28, 139);
            this.vs_master_green.TabIndex = 1;
            this.vs_master_green.Value = 255;
            this.vs_master_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_master_green_Scroll);
            // 
            // vs_master_blue
            // 
            this.vs_master_blue.Location = new System.Drawing.Point(97, 28);
            this.vs_master_blue.Maximum = 255;
            this.vs_master_blue.Name = "vs_master_blue";
            this.vs_master_blue.Size = new System.Drawing.Size(28, 139);
            this.vs_master_blue.TabIndex = 2;
            this.vs_master_blue.Value = 255;
            this.vs_master_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vs_master_blue_Scroll);
            // 
            // rb_dim4
            // 
            this.rb_dim4.AutoSize = true;
            this.rb_dim4.Location = new System.Drawing.Point(709, 207);
            this.rb_dim4.Name = "rb_dim4";
            this.rb_dim4.Size = new System.Drawing.Size(37, 21);
            this.rb_dim4.TabIndex = 6;
            this.rb_dim4.TabStop = true;
            this.rb_dim4.Text = "4";
            this.rb_dim4.UseVisualStyleBackColor = true;
            this.rb_dim4.CheckedChanged += new System.EventHandler(this.rb_dim4_CheckedChanged);
            // 
            // rb_dim0
            // 
            this.rb_dim0.AutoSize = true;
            this.rb_dim0.Location = new System.Drawing.Point(534, 207);
            this.rb_dim0.Name = "rb_dim0";
            this.rb_dim0.Size = new System.Drawing.Size(37, 21);
            this.rb_dim0.TabIndex = 8;
            this.rb_dim0.TabStop = true;
            this.rb_dim0.Text = "0";
            this.rb_dim0.UseVisualStyleBackColor = true;
            this.rb_dim0.CheckedChanged += new System.EventHandler(this.rb_dim0_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 23);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 237);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_dim0);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rb_dim4);
            this.Controls.Add(this.rb_dim3);
            this.Controls.Add(this.rb_dim2);
            this.Controls.Add(this.rb_dim1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monster Notebook Keyboard Light Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vs_1_red;
        private System.Windows.Forms.VScrollBar vs_1_green;
        private System.Windows.Forms.VScrollBar vs_1_blue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_dim1;
        private System.Windows.Forms.RadioButton rb_dim2;
        private System.Windows.Forms.RadioButton rb_dim3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.VScrollBar vs_2_red;
        private System.Windows.Forms.VScrollBar vs_2_green;
        private System.Windows.Forms.VScrollBar vs_2_blue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.VScrollBar vs_3_red;
        private System.Windows.Forms.VScrollBar vs_3_green;
        private System.Windows.Forms.VScrollBar vs_3_blue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.VScrollBar vs_4_red;
        private System.Windows.Forms.VScrollBar vs_4_green;
        private System.Windows.Forms.VScrollBar vs_4_blue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.VScrollBar vs_master_red;
        private System.Windows.Forms.VScrollBar vs_master_green;
        private System.Windows.Forms.VScrollBar vs_master_blue;
        private System.Windows.Forms.RadioButton rb_dim4;
        private System.Windows.Forms.RadioButton rb_dim0;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

