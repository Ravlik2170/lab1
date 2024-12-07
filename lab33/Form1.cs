﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        Color Defaultcolor
        {
            get { return Color.White; }
        }
        
        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j<height; j++)
                {
                    bmp.SetPixel(i, j, Defaultcolor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        int _x;
        int _y;
        bool _mouseClicked = false;

        Color SelectedColor
        {
            get { return Color.Red; }
        }

        int SelectedSize
        {
            get { return trackBar1.Value; }
        }

        Brush _selectedBrush;


     
        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }
            _selectedBrush.Draw((Bitmap)pictureBox1.Image, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

