using MiniBinaryParser;
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
            #endregion
            
            #region Method call
            //menu.Start();
            #endregion

            BinaryParser parser = new BinaryParser();
            byte[] sequence = new byte[] { 0x00, 0x01, 0x02, 0x03  };
            Console.WriteLine(parser.BinaryParserCalcMatch(sequence, '+'));
            
        }
    }
}
