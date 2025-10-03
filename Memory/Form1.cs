using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
                
            }
        }
    }
}