﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.PieceFactory
{
    public class Queen : RayPiece
    {
        public override Piece CreatePiece()
        {
            return new Queen();
        }
    }
}
