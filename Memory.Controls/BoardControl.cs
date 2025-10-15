
using System.Reflection;

namespace Memory.Controls
{
    public partial class BoardControl : UserControl
    {
        private List<Image> emojis;
        private TileControl[,] tiles;

        public BoardControl()
        {
            InitializeComponent();
            InitializeEmojis();
            InitializeTiles();
        }

        private void InitializeEmojis()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            emojis = new List<Image>();
            foreach (string name in assembly.GetManifestResourceNames())
            {
                if (!name.Contains("Emojis"))
                {
                    continue;
                }

                Image emoji = Bitmap.FromStream(assembly.GetManifestResourceStream(name));
                emojis.Add(emoji);
            }
        }

        private void InitializeTiles()
        {
            tiles = new TileControl[tableLayoutPanel.ColumnCount, tableLayoutPanel.RowCount];

            for (int column = 0; column < tiles.GetLength(0); column++)
            {
                for (int row = 0; row < tiles.GetLength(1); row++)
                {
                    tiles[row, column] = 
                        (TileControl)tableLayoutPanel.GetControlFromPosition(column, row);
                }
            }

            emojis.Shuffle();

            for (int i = 0; i < TileCount; i += 2)
            {
                Image currentEmojiImage = emojis[i];
                (int column, int row) = Convert1DIndexTo2DIndex(i);
                tiles[column, row].Image = currentEmojiImage;
                tiles[column + 1, row].Image = currentEmojiImage;
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