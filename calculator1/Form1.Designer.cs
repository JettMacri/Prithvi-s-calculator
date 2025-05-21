namespace calculator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            calulatordisplay = new Label();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Button1 = new Button();
            SuspendLayout();
            // 
            // calulatordisplay
            // 
            calulatordisplay.BackColor = SystemColors.ActiveCaptionText;
            calulatordisplay.BorderStyle = BorderStyle.Fixed3D;
            calulatordisplay.Font = new Font("Segoe UI", 30F);
            calulatordisplay.ForeColor = SystemColors.ButtonFace;
            calulatordisplay.Location = new Point(12, 9);
            calulatordisplay.Name = "calulatordisplay";
            calulatordisplay.Size = new Size(507, 79);
            calulatordisplay.TabIndex = 0;
            calulatordisplay.Text = "0";
            calulatordisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 30F);
            button16.Location = new Point(370, 361);
            button16.Name = "button16";
            button16.Size = new Size(149, 82);
            button16.TabIndex = 33;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += buttonDivison;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 30F);
            button15.Location = new Point(370, 273);
            button15.Name = "button15";
            button15.Size = new Size(149, 82);
            button15.TabIndex = 32;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonMultiply;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 30F);
            button14.Location = new Point(370, 185);
            button14.Name = "button14";
            button14.Size = new Size(149, 82);
            button14.TabIndex = 31;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonMinus;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 30F);
            button13.Location = new Point(370, 97);
            button13.Name = "button13";
            button13.Size = new Size(149, 82);
            button13.TabIndex = 30;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonPlus;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 30F);
            button12.Location = new Point(251, 361);
            button12.Name = "button12";
            button12.Size = new Size(113, 82);
            button12.TabIndex = 29;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonEqual;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 20F);
            button11.Location = new Point(11, 361);
            button11.Name = "button11";
            button11.Size = new Size(113, 82);
            button11.TabIndex = 28;
            button11.Text = "AC";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonClear;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(132, 361);
            button10.Name = "button10";
            button10.Size = new Size(113, 82);
            button10.TabIndex = 27;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20F);
            button9.Location = new Point(13, 97);
            button9.Name = "button9";
            button9.Size = new Size(113, 82);
            button9.TabIndex = 26;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(132, 97);
            button8.Name = "button8";
            button8.Size = new Size(113, 82);
            button8.TabIndex = 25;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(251, 97);
            button7.Name = "button7";
            button7.Size = new Size(113, 82);
            button7.TabIndex = 24;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(13, 185);
            button6.Name = "button6";
            button6.Size = new Size(113, 82);
            button6.TabIndex = 23;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(132, 185);
            button5.Name = "button5";
            button5.Size = new Size(113, 82);
            button5.TabIndex = 22;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(251, 185);
            button4.Name = "button4";
            button4.Size = new Size(113, 82);
            button4.TabIndex = 21;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(251, 273);
            button3.Name = "button3";
            button3.Size = new Size(113, 82);
            button3.TabIndex = 20;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(132, 273);
            button2.Name = "button2";
            button2.Size = new Size(113, 82);
            button2.TabIndex = 19;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 20F);
            Button1.Location = new Point(13, 273);
            Button1.Name = "Button1";
            Button1.Size = new Size(113, 82);
            Button1.TabIndex = 18;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(533, 450);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Button1);
            Controls.Add(calulatordisplay);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Label calulatordisplay;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button Button1;
    }
}
