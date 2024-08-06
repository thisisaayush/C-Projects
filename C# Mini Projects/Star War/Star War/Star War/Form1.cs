using Microsoft.VisualBasic.ApplicationServices;
using WMPLib;

namespace Star_War
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] stars;
        int playerSpeed;

        PictureBox[] ammunition;
        int ammunitionSpeed;

        PictureBox[] enemies;
        int enemiesSpeed;

        PictureBox[] enemiesAmmunition;
        int enemiesAmmunitionSpeed;

        int backgroundSpeed;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            MoveBackgroundSpeedTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundSpeed = 4;
            playerSpeed = 4;
            ammunitionSpeed = 20;
            enemiesSpeed = 4;
            enemiesAmmunitionSpeed = 4;

            ammunition = new PictureBox[3];

            Image ammunitionImg = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\munition.png");
            Image enemy1Img = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\E1.png");
            Image enemy2Img = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\E2.png");
            Image enemy3Img = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\E3.png");
            Image boss1Img = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\Boss1.png");
            Image boss2Img = Image.FromFile(@"C:\Users\thaku\Desktop\Software Engineering Projects\C# Advance Level\C-Sharp-Projects\C# Mini Projects\Star War\Star War\Star War Images\asserts\Boss2.png");

            enemies = new PictureBox[10];

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1Img;
            enemies[1].Image = enemy1Img;
            enemies[2].Image = enemy2Img;
            enemies[3].Image = enemy3Img;
            enemies[4].Image = enemy1Img;
            enemies[5].Image = enemy3Img;
            enemies[6].Image = enemy2Img;
            enemies[7].Image = enemy1Img;
            enemies[8].Image = enemy2Img;
            enemies[9].Image = boss2Img;

            for (int i = 0; i < ammunition.Length; i++)
            {
                ammunition[i] = new PictureBox();
                ammunition[i].Size = new Size(8, 8);
                ammunition[i].Image = ammunitionImg;
                ammunition[i].SizeMode = PictureBoxSizeMode.Zoom;
                ammunition[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(ammunition[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            gameMedia.URL = "C:\\Users\\thaku\\Desktop\\Software Engineering Projects\\C# Advance Level\\C-Sharp-Projects\\C# Mini Projects\\Star War\\Star War\\Star War Musics\\songs\\GameSong.mp3";
            shootMedia.URL = "C:\\Users\\thaku\\Desktop\\Software Engineering Projects\\C# Advance Level\\C-Sharp-Projects\\C# Mini Projects\\Star War\\Star War\\Star War Musics\\songs\\shoot.mp3";
            explosion.URL = "C:\\Users\\thaku\\Desktop\\Software Engineering Projects\\C# Advance Level\\C-Sharp-Projects\\C# Mini Projects\\Star War\\Star War\\Star War Musics\\songs\\boom.mp3";

            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootMedia.settings.volume = 2;
            shootMedia.settings.volume = 7;


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

            enemiesAmmunition = new PictureBox[10];

            for (int i = 0; i < enemiesAmmunition.Length; i++)
            {
                enemiesAmmunition[i] = new PictureBox();
                enemiesAmmunition[i].Size = new Size(2, 25);
                enemiesAmmunition[i].Visible = false;
                enemiesAmmunition[i].BackColor = Color.Yellow;

                int x = rnd.Next(0, 10);

                enemiesAmmunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesAmmunition[i]);
            }

            gameMedia.controls.play();
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
            shootMedia.controls.play();
            for (int i = 0; i < ammunition.Length; i++)
            {
                if (ammunition[i].Top > 0)
                {
                    ammunition[i].Visible = true;
                    ammunition[i].Top -= ammunitionSpeed;
                    Collision();
                }

                else
                {
                    ammunition[i].Visible = false;
                    ammunition[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - 1 * 30);
                }
            }
        }

        private void EnemiesMoveTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (ammunition[0].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    ammunition[1].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    ammunition[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 18;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over!");
                }
            }
        }

        private void GameOver(String str)
        {
            gameMedia.controls.stop();
            StopTimers();
        }

        private void StopTimers()
        {
            MoveBackgroundSpeedTimer.Stop();
            EnemiesMoveTimer.Stop();
            AmmunitionSpeedTimer.Stop();
            EnemiesAmmunitionTimer.Stop();
        }

        private void StartTimers()
        {
            MoveBackgroundSpeedTimer.Start();
            EnemiesMoveTimer.Start();
            AmmunitionSpeedTimer.Start();
            EnemiesAmmunitionTimer.Start();
        }

        private void EnemiesAmmunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesAmmunition.Length; i++)
            {
                if (enemiesAmmunition[i].Top < this.Height)
                {
                    enemiesAmmunition[i].Visible = true;
                    enemiesAmmunition[i].Top += enemiesAmmunitionSpeed;
                }

                else
                {
                    enemiesAmmunition[i].Visible = false;

                    int x = rnd.Next(0, 10);

                    enemiesAmmunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void CollisionWithEnemiesAmmunition()
        {
            for (int i = 0; i < enemiesAmmunition.Length; i++)
            {
                if (enemiesAmmunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesAmmunition[i].Visible = false;
                    explosion.settings.volume = 27;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over!");
                }
            }
        }
    }
}
