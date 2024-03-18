
namespace ritprog
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
            panel1 = new Panel();
            panel3 = new Panel();
            picked_color = new Button();
            btn_save = new Button();
            btn_clear = new Button();
            panel4 = new Panel();
            btn_tri = new Button();
            btn_rect = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            btn_color = new Button();
            pic_color = new Button();
            btn_undo = new Button();
            pic = new PictureBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_ellipse);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(btn_color);
            panel1.Controls.Add(pic_color);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 109);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(picked_color);
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 97);
            panel3.TabIndex = 6;
            // 
            // picked_color
            // 
            picked_color.BackColor = Color.White;
            picked_color.Location = new Point(9, 31);
            picked_color.Name = "picked_color";
            picked_color.Size = new Size(45, 44);
            picked_color.TabIndex = 0;
            picked_color.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            btn_save.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_save.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_save.Location = new Point(713, 12);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(83, 33);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_clear.Location = new Point(713, 51);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(83, 32);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(btn_tri);
            panel4.Controls.Add(btn_rect);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(63, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(644, 82);
            panel4.TabIndex = 8;
            // 
            // btn_tri
            // 
            btn_tri.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_tri.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_tri.Location = new Point(546, 19);
            btn_tri.Name = "btn_tri";
            btn_tri.Size = new Size(69, 44);
            btn_tri.TabIndex = 7;
            btn_tri.Text = "Line";
            btn_tri.UseVisualStyleBackColor = true;
            btn_tri.Click += btn_tri_Click;
            // 
            // btn_rect
            // 
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_rect.Location = new Point(416, 19);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(90, 44);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rectangle";
            btn_rect.UseVisualStyleBackColor = true;
            btn_rect.Click += btn_rect_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseDownBackColor = Color.Silver;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.Location = new Point(18, 19);
            button5.Name = "button5";
            button5.Size = new Size(72, 45);
            button5.TabIndex = 1;
            button5.Text = "Color";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.Location = new Point(117, 20);
            button3.Name = "button3";
            button3.Size = new Size(70, 44);
            button3.TabIndex = 3;
            button3.Text = "Pencil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.Location = new Point(208, 19);
            button2.Name = "button2";
            button2.Size = new Size(72, 44);
            button2.TabIndex = 4;
            button2.Text = "Eraser";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.Location = new Point(310, 19);
            button1.Name = "button1";
            button1.Size = new Size(73, 44);
            button1.TabIndex = 5;
            button1.Text = "Circle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_3;
            // 
            // btn_ellipse
            // 
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_ellipse.Location = new Point(575, 12);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(70, 63);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Circle";
            btn_ellipse.UseVisualStyleBackColor = true;
            // 
            // btn_eraser
            // 
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_eraser.Location = new Point(499, 12);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(70, 63);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.UseVisualStyleBackColor = true;
            // 
            // btn_pencil
            // 
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_pencil.Location = new Point(423, 12);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(70, 63);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += button1_Click_2;
            // 
            // btn_fill
            // 
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_fill.Location = new Point(347, 12);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(70, 63);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            btn_color.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_color.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_color.Location = new Point(271, 12);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(70, 63);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += button1_Click_1;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(220, 31);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(45, 40);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            pic_color.Click += button1_Click;
            // 
            // btn_undo
            // 
            btn_undo.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_undo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_undo.Location = new Point(9, 19);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new Size(45, 32);
            btn_undo.TabIndex = 10;
            btn_undo.Text = "Undo";
            btn_undo.UseVisualStyleBackColor = true;
            btn_undo.Click += btn_undo_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 109);
            pic.Name = "pic";
            pic.Size = new Size(800, 341);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Click += pictureBox1_Click;
            pic.Paint += pic_Paint;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(btn_undo);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(66, 341);
            panel5.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(pic);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btn_tri_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_color;
        private Button btn_pencil;
        private Button btn_fill;
        private Button btn_eraser;
        private Panel panel3;
        private Button btn_tri;
        private Button btn_rect;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button picked_color;
        private Button btn_ellipse;
        private Panel panel4;
        private Button btn_save;
        private Button btn_clear;
        private Button btn_undo;
        private Panel panel5;
    }
}
