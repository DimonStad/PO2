﻿using MiniBinaryParser;
using System;

namespace _1_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Field
            /// <summary>
            /// Menu class object.
            /// </summary>
            /// <returns></returns>
            Menu menu = new Menu();
            /// <summary>
            /// BinaryParser object.
            /// </summary>
            /// <returns></returns>
            BinaryParser parser = new BinaryParser();
            #endregion
            
            #region Method call Menu
            menu.Start();
            #endregion

            #region Method call BinaryParser 
            byte[] sequence = new byte[] { 0x00, 0x01, 0x02, 0x03  };
            parser.BinaryParserCalcMatch(sequence, '+');
            #endregion
            
        }
    }
}
