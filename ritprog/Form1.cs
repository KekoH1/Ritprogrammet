using System.Drawing;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;

namespace ritprog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 850;
            this.Height = 600;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 3);
        Pen erase = new Pen(Color.White, 10);

        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;
        private static StringBuilder cache;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            px = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }

            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }

            if (index == 5)
            {
                Point[] points = new Point[3];
                points[0] = new Point(cX, cY + sY);
                points[1] = new Point(cX + sX, cY + sY);
                points[2] = new Point(cX + (sX / 2), cY);
                g.DrawPolygon(p, points);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_tri_Click(object sender, EventArgs e)
        {
            index = 5;
        }



        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    Point[] points = new Point[3];
                    points[0] = new Point(cX, cY + sY);
                    points[1] = new Point(cX + sX, cY + sY);
                    points[2] = new Point(cX + (sX / 2), cY);
                    g.DrawPolygon(p, points);
                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            picked_color.BackColor = new_color;
            p.Color = cd.Color;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image (*.jpg)|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image saved successfully");
            }


        }


        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();

        private void btn_undo_Click(object sender, EventArgs e)
        {
            SwitchElements(undoStack, redoStack);
        }
        private void btn_redo_Click(object sender, EventArgs e)
        {
            SwitchElements(redoStack, undoStack);
        }


        private void SwitchElements(Stack<Bitmap> undoStack, Stack<Bitmap> redoStack)
        {
            if (undoStack.Any())
            {
                redoStack.Push(new Bitmap(bm));
                bm = undoStack.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }





        private void btn_size_Click(object sender, EventArgs e)
        {

            p.Width = +10;
        }

        private void btn_sizep_Click(object sender, EventArgs e)
        {
            p.Width = -10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.Width = 3;
        }

       
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bm = new Bitmap(ofd.FileName);
                    g = Graphics.FromImage(bm);
                    pic.Image = bm;
                    g.Clear(Color.White);
                    index = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }
    }
}
            







        
    

