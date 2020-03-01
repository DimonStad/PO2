using MiniBinaryParser;
using System;
using System.IO;

namespace _1_Lab{
    class BinaryParser
    {
        private Calculate calculate = new Calculate();

        public byte BinaryParserCalcMatch(byte[] sequence, char oper){
            Match match = sequence.Parse(Endian.Big, (byte)0x01, (byte)0x02);
            byte[] matchedSequence = match.MatchedBytes;
            if (oper == '+'){
                calculate.RES1 = matchedSequence[0];
                return calculate.Sum(matchedSequence[1]);
            }

            if (oper == '-'){
                calculate.RES1 = matchedSequence[0];
                return calculate.Diff(matchedSequence[1]);;
            }

            if (oper == '*'){
                calculate.RES1 = matchedSequence[0];
                return calculate.Multiplication(matchedSequence[1]);
            }

            if (oper == '/'){
                calculate.RES1 = matchedSequence[0];
                return calculate.Division(matchedSequence[1]);
            }
            
            return 0;
        }
    }
}