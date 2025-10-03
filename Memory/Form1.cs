namespace Memory;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    List<Image> images = new List<Image>();


    private void LoadImages()
    {
        string path = Path.Combine(Application.StartupPath, "rsc");
        foreach (var file in Directory.GetFiles(path, "*.png"))
        {
            images.Add(Image.FromFile(file));
        }
    }
}