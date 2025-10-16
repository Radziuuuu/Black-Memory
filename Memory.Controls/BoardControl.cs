
using System.Reflection;

namespace Memory.Controls
{
    public partial class BoardControl : UserControl
    {
        private List<Image> emojis;
        private TileControl[,] tiles;
        private List<Image> ShuffledEmojis;
        private Random random = new Random();
        Dictionary<string, Image> images =  new Dictionary<string, Image>();

        public BoardControl()
        {
            InitializeComponent();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            InitializeEmojis();
            InitializeTiles();
        }
        private void InitializeEmojis()
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // Zwraca Listę nazw obrazków - Pl.wyk.

            emojis = new List<Image>();
            foreach (string name in assembly.GetManifestResourceNames())
            {
                if (!name.Contains("Emojis"))
                {
                    continue;
                }

                Image emoji = Bitmap.FromStream(assembly.GetManifestResourceStream(name)); // Otwiera "strumień" / dostęp do pliku obrazka
                emojis.Add(emoji);
                images.Add(name, emoji);
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("sex");
            TileControl tile = sender as TileControl;
            int tag = int.Parse((string)tile.Tag);
            Console.WriteLine(Tag);
            
            tile.Image = ShuffledEmojis[tag];
        }
        private void InitializeTiles(){
            tiles = new TileControl[tableLayoutPanel.ColumnCount, tableLayoutPanel.RowCount];

            for (int column = 0; column < tiles.GetLength(0); column++)
            {
                for (int row = 0; row < tiles.GetLength(1); row++)
                {
                    TileControl tile = (TileControl)tableLayoutPanel.GetControlFromPosition(column, row); // wypełnianie tablicy kontrolkami;
                    tile.Click += OnClick;
                    tiles[row, column] = tile;
                }
            }
            
            emojis.Shuffle();
            var shuffled = emojis.Take(8).ToArray(); //bierzemy 8 pierwszych elementów, 
            var doubled = shuffled.Concat(shuffled.ToArray()).ToArray(); // bierzemy shuflled i dodajemy go jeszcze raz
            ShuffledEmojis = doubled.OrderBy(x => random.Next()).ToList(); // losujemy kolejność (wyświetlenie emotek w grze)

            for (int i = 0; i < TileCount; i++)
            {
                (int column, int row) = Convert1DIndexTo2DIndex(i);
                tiles[column, row].Image = Properties.Resources.questionMark;
            }
        }

        private int TileCount => tableLayoutPanel.ColumnCount * tableLayoutPanel.RowCount;

        private (int column, int row) Convert1DIndexTo2DIndex(int index)
        {
            int column = index % tableLayoutPanel.ColumnCount;
            int row = index / tableLayoutPanel.ColumnCount;

            return (column, row);
        }
    }
}