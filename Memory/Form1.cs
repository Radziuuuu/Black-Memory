using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace Memory;

public partial class Form1 : Form
{
    Stopwatch Elapsed = new Stopwatch();
 
    public Form1()
    {
        InitializeComponent();
        
    }

    List<Image> images = new List<Image>();
    List<Image> gameImages = new List<Image>();
    Image backImage;

    PictureBox firstClicked = null;
    PictureBox secondClicked = null;
  
    private void LoadImages()
    {
        string path = Path.Combine(Application.StartupPath, "rsc");
        foreach (var file in Directory.GetFiles(path, "pic*.png"))
        {
            images.Add(Image.FromFile(file));
        }

        string backPath = Path.Combine(path, "back.png");
        if (File.Exists(backPath)) 
        {
            backImage = Image.FromFile(backPath);
        }
        else
        {
            MessageBox.Show("Brak pliku back.png w folderze rsc!");
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        timer1 = new();
        timer1.Interval = 1000;
        timer1.Tick += Tick;
        timer1.Start();
        Elapsed.Start();
    }

    private void Tick(object sender, EventArgs e)
    {
        var elapsed = Elapsed.Elapsed;
        this.Text = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
    }

    private void PrepareGameImages()
    {
        for (int i = 0; i < 8; i++) 
        {
            gameImages.Add(images[i]);
            gameImages.Add(images[i]);
        }

        Random random = new Random();
        gameImages = gameImages.OrderBy(x => random.Next()).ToList();
    }

    private void AssignImages()
    {
        int index = 0;
        foreach (Control c in tableLayoutPanel1.Controls) 
        {
            if(c is PictureBox pb)
            {
                pb.Tag = gameImages[index];
                pb.Image = backImage;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Click += Pb_Click;
                index++;
            }
        }
    }

    private void Pb_Click(object sender, EventArgs e)
    {
        if (timer1.Enabled) 
        {
            return;
        }

        PictureBox? clicked = sender as PictureBox;

       if(firstClicked == null)
        {
            firstClicked = clicked;
            return;
        }
        secondClicked = clicked;

        if (firstClicked.Tag == secondClicked.Tag)
        {
            firstClicked = null;
            secondClicked = null;
            CheckWin();
        }
        else
        {
            timer1.Start();
        }
    }
    private void CheckWin()
    {
        bool allOpen = tableLayoutPanel1.Controls.OfType<PictureBox>()
            .All(pb => pb.Image != backImage);

        if (allOpen)
        {
            timer1.Stop();
            Elapsed.Stop();
            MessageBox.Show($"Wygra³eœ w czasie: {Elapsed.Elapsed.Minutes:D2}:{Elapsed.Elapsed.Seconds:D2}");
        }
    }
}