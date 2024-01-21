using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proffesional
{
    public partial class Form1 : Form
    {
        private PictureBox clickedPictureBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox178_MouseMove(object sender, MouseEventArgs e)
        {
            coordinate.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            coordinate.Text = $"0";
        }

        private void pictureBox178_Click(object sender, EventArgs e)
        {
            clickedPictureBox = (PictureBox)sender;
            clickedPictureBox.BackColor = Color.Red; // изменяем цвет блока при нажатии
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickedPictureBox != null) // проверяем, что была выбрана PictureBox
            {
                PictureBox trafficLight = new PictureBox();
                trafficLight.Size = new Size(33, 33); // устанавливаем размеры светофора
                trafficLight.Location = new Point(clickedPictureBox.Location.X, clickedPictureBox.Location.Y);
                trafficLight.Image = Image.FromFile("C:\\Users\\mrwiz\\OneDrive\\Изображения\\4.png");
                trafficLight.SizeMode = PictureBoxSizeMode.Zoom;
                trafficLight.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                Controls.Remove(clickedPictureBox);
                this.Controls.Add(trafficLight); // добавляем светофор на форму
            }
            
            else
            {
                MessageBox.Show("Сначала выберите блок для установки светофора.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickedPictureBox != null) 
            {
                PictureBox peshehod = new PictureBox();
                peshehod.Size = new Size(33, 33); 
                peshehod.Location = new Point(clickedPictureBox.Location.X, clickedPictureBox.Location.Y);
                peshehod.Image = Image.FromFile("C:\\Users\\mrwiz\\OneDrive\\Изображения\\6.png");
                peshehod.SizeMode = PictureBoxSizeMode.Zoom;
                peshehod.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                Controls.Remove(clickedPictureBox);
                this.Controls.Add(peshehod); 
            }

            else
            {
                MessageBox.Show("Сначала выберите блок для установки пешехода.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clickedPictureBox != null) 
            {
                PictureBox znak = new PictureBox();
                znak.Size = new Size(33, 33); // устанавливаем размеры светофора
                znak.Location = new Point(clickedPictureBox.Location.X, clickedPictureBox.Location.Y);
                znak.Image = Image.FromFile("C:\\Users\\mrwiz\\OneDrive\\Изображения\\1.png");
                znak.SizeMode = PictureBoxSizeMode.Zoom;
                znak.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                Controls.Remove(clickedPictureBox);
                this.Controls.Add(znak);
            }

            else
            {
                MessageBox.Show("Сначала выберите блок для установки знака.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clickedPictureBox != null) 
            {
                PictureBox perehod = new PictureBox();
                perehod.Size = new Size(33, 33);
                perehod.Location = new Point(clickedPictureBox.Location.X, clickedPictureBox.Location.Y);
                perehod.Image = Image.FromFile("C:\\Users\\mrwiz\\OneDrive\\Изображения\\5.png");
                perehod.SizeMode = PictureBoxSizeMode.Zoom;
                perehod.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                Controls.Remove(clickedPictureBox);
                this.Controls.Add(perehod); 
            }

            else
            {
                MessageBox.Show("Сначала выберите блок для установки перехода.");
            }
        }
    }
}
