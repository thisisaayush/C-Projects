namespace Star_War
{
    public partial class Form1 : Form
    {
        PictureBox[] stars;
        int backgroundSpeed;
        int playerSpeed;
        int ammunitionSpeed;
        PictureBox[] ammunition;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            MoveBackgroundSpeed.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundSpeed = 4;
            playerSpeed = 4;
            ammunitionSpeed = 20;

            ammunition = new PictureBox[3];

            Image ammunitionImg = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\munition.png");

            for (int i = 0; i < ammunition.Length; i++)
            {
                ammunition[i] = new PictureBox();
                ammunition[i].Size = new Size(8, 8);
                ammunition[i].Image = ammunitionImg;
                ammunition[i].SizeMode = PictureBoxSizeMode.Zoom;
                ammunition[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(ammunition[i]);
            }

            stars = new PictureBox[10];
            rnd = new Random();

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));

                if (i % 3 == 1)
                {
                    stars[i].Size = new Size(2, 1);
                    stars[i].BackColor = Color.White;
                }

                else if (i % 2 == 0)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.DarkGray;
                }

                else if (i % 2 == 1)
                {
                    stars[i].Size = new Size(4, 2);
                    stars[i].BackColor = Color.Red;
                }

                else if (i % 5 == 2)
                {
                    stars[i].Size = new Size(1, 2);
                    stars[i].BackColor = Color.DarkViolet;
                }

                this.Controls.Add(stars[i]);
            }
        }

        private void MoveBackgroundSpeed_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundSpeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed - 2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerSpeed;
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RightMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Left)
            {
                LeftMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                DownMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                UpMoveTimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();
        }

        private void ammunitionSpeedTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ammunition.Length; i++)
            {
                if (ammunition[i].Top > 0)
                {
                    ammunition[i].Visible = true;
                    ammunition[i].Top -= ammunitionSpeed;
                }

                else
                {
                    ammunition[i].Visible = false;
                    ammunition[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - 1 * 30);
                }
            }
        }
    }
}
