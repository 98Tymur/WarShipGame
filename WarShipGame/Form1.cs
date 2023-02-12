using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WarShipGame
{
    public partial class SpaceWar : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] stars;
        int backgroundSpeed;
        int playerSpeed;

        PictureBox[] munitions;
        int munitionSpeed;

        PictureBox[] enemies;
        int enemiesSpeed;

        PictureBox[] enemiesMunition;
        int enemiesMunitionSpeed;

        int score;
        int level;
        int deficulty;
        bool pause;
        bool gameIsOver;

        Random random;

        public SpaceWar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            level = 1;
            deficulty = 9;
            pause = false;
            gameIsOver = false;

            munitions = new PictureBox[3];
            munitionSpeed = 20;

            random = new Random();

            //Load image
            Image munition = Image.FromFile(@"icon\munition.png");

            for(int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            stars = new PictureBox[15];
            backgroundSpeed = 4;
            playerSpeed = 4;
                
            for (int i = 0; i < stars.Length; i++) 
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(random.Next(20, 580), random.Next(-10,400)); 

                if(i % 2 == 0)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);
            }

            enemiesSpeed = 4;
            enemies = new PictureBox[10];

            #region Enemies 

            Image enemy1 = Image.FromFile(@"icon\enemy-1.png");
            Image enemy2 = Image.FromFile(@"icon\enemy-2.png");
            Image enemy3 = Image.FromFile(@"icon\enemy-3.png");
            Image boss1 = Image.FromFile(@"icon\boss-1.png");
            Image boss2 = Image.FromFile(@"icon\boss-2.png");

            for(int i = 0; i < enemies.Length;i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                enemies[i].Location = new Point((i + 1) * 50, -50);
                this.Controls.Add(enemies[i]);
            }
            //Initialiase ememies PictureBox
            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy3;
            enemies[3].Image = enemy1;
            enemies[4].Image = enemy3;
            enemies[5].Image = enemy2;
            enemies[6].Image = boss2;
            #endregion

            #region Create media WMP

            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            //Load songs
            gameMedia.URL = "songs\\GameMusic.mp3";
            shootMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";

            //Songs settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootMedia.settings.volume = 1;
            explosion.settings.volume = 6;

            gameMedia.controls.play();

            #endregion

            //Enemy minition
            enemiesMunition = new PictureBox[10];
            enemiesMunitionSpeed = 4;
            
            for(int i = 0; i < enemiesMunition.Length; i++)
            {
                enemiesMunition[i] = new PictureBox();
                enemiesMunition[i].Size = new Size(2, 25);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Yellow;
                int x = random.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesMunition[i]);
            }
        }

        private void MoveBackgraundTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < stars.Length / 2;i++)
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

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if(player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if(player.Right < 580)
            {
                player.Left += playerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if(player.Top < 400)
            {
                player.Top += playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if(player.Top > 10)
            {
                player.Top -= playerSpeed;
            }
        }

        private void SpaceWar_KeyDown(object sender, KeyEventArgs e)
        {
            if(!pause)
            {
                if (e.KeyCode == Keys.Right) { RightMoveTimer.Start(); }
                if (e.KeyCode == Keys.Left) { LeftMoveTimer.Start(); }
                if (e.KeyCode == Keys.Down) { DownMoveTimer.Start(); }
                if (e.KeyCode == Keys.Up) { UpMoveTimer.Start(); }
            }
            
        }

        private void SpaceWar_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

            if(e.KeyCode == Keys.Space)
            {
                if(!gameIsOver)
                {
                    if(pause)
                    {
                        StartTimers();
                        label1.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void MoveMinitionsTimer_Tick(object sender, EventArgs e)
        {

            shootMedia.controls.play();

            for(int i = 0; i < munitions.Length; i++) 
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionSpeed;

                    Collision();

                    CollisionWithEnemiesMinition();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(player.Location.X + 20, player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for(int i = 0; i < array.Length; i++)
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
            for(int i = 0; i < enemies.Length; i++) 
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    munitions[2].Bounds.IntersectsWith(enemies[i].Bounds)) 
                {
                    explosion.controls.play();

                    score += 1;
                    scoreLbl.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score % 30 == 0)
                    {
                        level += 1;
                        levelLbl.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                        if(enemiesSpeed <= 10 && enemiesMunitionSpeed <= 10 && deficulty >= 0)
                        {
                            deficulty--;
                            enemiesSpeed++;
                            enemiesMunitionSpeed++;
                        }
                        
                        if(level == 10)
                        {
                            GameOver("NICE GAME");
                        }

                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }

                if (player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();
                    explosion.settings.volume = 30;
                    player.Visible = false;
                    GameOver("");
                }
            }
        }

        private void GameOver(String str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            Replay.Visible = true;
            Exit.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }
        // Stop all timers
        private void StopTimers()
        {
            MoveBackgraundTimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMinitionsTimer.Stop();
            EnemiesMutionTimer.Stop();
        }
        // Start all timers
        private void StartTimers()
        {
            MoveBackgraundTimer.Start();
            MoveEnemiesTimer.Start();
            MoveMinitionsTimer.Start();
            EnemiesMutionTimer.Start();
        }

        private void EnemiesMutionTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < (enemiesMunition.Length - deficulty); i++)
            {
                if (enemiesMunition[i].Top < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemiesMunitionSpeed;

                    CollisionWithEnemiesMinition();
                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = random.Next(0, 10);
                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void CollisionWithEnemiesMinition()
        {
            for(int i = 0; i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(player.Bounds))
                {
                    enemiesMunition[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    player.Visible = false;
                    GameOver("Game over!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Replay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
