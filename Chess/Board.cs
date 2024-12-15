using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {



        Pieces[,] board = new Pieces[8, 8];

         bool whiteTurn = true;

        public  void initialize()
        {
            Notation n;
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    board[i, j] = Pieces.Queen | (Pieces)(8 +  8 * ((i+j)%2));
                }
            }
        }
        static void move(string m)
        {
            switch (m)
            {

            }
        }
        
        public override string ToString()
        {
            Notation notation = new Notation();
            StringBuilder str = new StringBuilder(8*9);
            int i, j;
            for (i = 0; i < 8; i ++)
            {
                for (j = 0; j < 8; j++)
                {
                    str.Append(Notation.getChar(board[i, j]));
                    str.Append(' ');
                }
                str.Append('\n');
            }
            return str.ToString();
        }

    }
}
