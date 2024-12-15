using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Notation
    {

        static Dictionary<char, Pieces> charToPiece = new Dictionary<char, Pieces>();
        static Dictionary<Pieces, char> pieceToChar = new Dictionary<Pieces, char>();

        public Notation() {

            charToPiece['P'] = Pieces.Pawn | Pieces.White;
            charToPiece['N'] = Pieces.Knight | Pieces.White;
            charToPiece['B'] = Pieces.Bishop | Pieces.White;
            charToPiece['R'] = Pieces.Rook | Pieces.White;
            charToPiece['Q'] = Pieces.Queen | Pieces.White;
            charToPiece['K'] = Pieces.King | Pieces.White;

            charToPiece['p'] = Pieces.Pawn | Pieces.Black;
            charToPiece['n'] = Pieces.Knight | Pieces.Black;
            charToPiece['b'] = Pieces.Bishop | Pieces.Black;
            charToPiece['r'] = Pieces.Rook | Pieces.Black;
            charToPiece['q'] = Pieces.Queen | Pieces.Black;
            charToPiece['k'] = Pieces.King | Pieces.Black;


            pieceToChar[(Pieces)8] = ' ';
            pieceToChar[(Pieces)9] = 'P'; 
            pieceToChar[(Pieces)10] = 'B'; 
            pieceToChar[(Pieces)11] = 'N'; 
            pieceToChar[(Pieces)12] = 'R'; 
            pieceToChar[(Pieces)13] = 'Q'; 
            pieceToChar[(Pieces)14] = 'K'; 

            pieceToChar[(Pieces)16] = ' ';
            pieceToChar[(Pieces)17] = 'p';
            pieceToChar[(Pieces)18] = 'b';
            pieceToChar[(Pieces)19] = 'n';
            pieceToChar[(Pieces)20] = 'r';
            pieceToChar[(Pieces)21] = 'q';
            pieceToChar[(Pieces)22] = 'k';
        }

        public static Pieces getPiece(char c) => charToPiece[c];
        public static char getChar(Pieces p) => pieceToChar[p];
        
    }
}
