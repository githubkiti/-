﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSetup.Run();
            Wall wall = new Wall();
            wall.Draw();
            BlocksWorker BW = new BlocksWorker();
            BW.DrawBlocks();
        }
    }
}
