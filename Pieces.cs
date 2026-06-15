using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum PieceTypes { King, Queen, Bishop, Horse, Rook, Pawn }
    public enum PieceColour { White, Black }

    public class Pieces
    {
        public PieceTypes Type { get; }
        public PieceColour Colour { get; }

        public Pieces(PieceTypes type, PieceColour colour)
        {
            this.Type = type;
            this.Colour = colour;
        }
        
    }
}
