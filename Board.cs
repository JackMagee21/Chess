using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Board : Form
    {
        private const int TileSize = 80;
        private const int BoardSize = TileSize * 8;

        private static readonly Color LightTile = Color.FromArgb(240, 217, 181);
        private static readonly Color DarkTile = Color.FromArgb(181, 136, 99);
        public Board()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    bool isLight = (rank + file) % 2 == 0;
                    var color = isLight ? LightTile : DarkTile;

                    g.FillRectangle(
                        new SolidBrush(color),
                        file * TileSize,
                        rank * TileSize,
                        TileSize,
                        TileSize);
                }
            }
        }
    }
}
