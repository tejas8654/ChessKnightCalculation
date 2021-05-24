using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessKnightCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPut;
            Console.WriteLine("Please enter your input");
            inPut = Console.ReadLine();
            bool IsError = false;
            // Character lenght validation
            if (inPut.Length > 2)
            {
                Console.WriteLine("Please enter valid input");
                IsError = true;
            }
            // Validation for Capital letters
            if ((int)inPut[0] >= 97 && (int)inPut[0] <= 122)
            {
                Console.WriteLine("Please enter character in Capital");
                IsError = true;
            }
            // Validation for digits 1-8
            if ((int)inPut[1] <= 48 || (int)inPut[1] >= 57)
            {
                Console.WriteLine("Please enter digit in between 1-8");
                IsError = true;
            }

            if (!IsError)
            {
                string FirstsPosistion = string.Empty;
                string SecondPosistion = string.Empty;
                string ThirdPosition = string.Empty;
                string FourthPosition = string.Empty;
                string FifthPosition = string.Empty;
                string SixthPosition = string.Empty;
                string SevenPosition = string.Empty;
                string EightiPosition = string.Empty;

                bool IsValidCharacter(char[] Input)
                {
                    bool isValidString = true;
                    for (int i = 0; i < Input.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(Input[i]))
                        {
                            isValidString = false;
                            break;
                        }
                    }
                    return isValidString;
                }

                var splitarray = inPut.ToCharArray();

                //----------Uppper positions
                splitarray[1] = (char)((int)splitarray[1] + 2);
                splitarray[0] = (char)((int)splitarray[0] - 1);
                if (IsValidCharacter(splitarray))
                {
                    FirstsPosistion = new string(splitarray);
                }


                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] + 2);
                splitarray[0] = (char)((int)splitarray[0] + 1);
                if (IsValidCharacter(splitarray))
                {
                    SecondPosistion = new string(splitarray);
                }
                //------------------------------

                // Down positions
                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] - 2);
                splitarray[0] = (char)((int)splitarray[0] + 1);
                if (IsValidCharacter(splitarray))
                {
                    ThirdPosition = new string(splitarray);
                }

                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] - 2);
                splitarray[0] = (char)((int)splitarray[0] - 1);
                if (IsValidCharacter(splitarray))
                {
                    FourthPosition = new string(splitarray);
                }
                //--------------------------------

                //Right Positions
                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] - 1);
                splitarray[0] = (char)((int)splitarray[0] + 2);
                if (IsValidCharacter(splitarray))
                {
                    FifthPosition = new string(splitarray);
                }

                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] + 1);
                splitarray[0] = (char)((int)splitarray[0] + 2);
                if (IsValidCharacter(splitarray))
                {
                    SixthPosition = new string(splitarray);
                }
                //-------------------

                // Left positions
                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] - 1);
                splitarray[0] = (char)((int)splitarray[0] - 2);
                if (IsValidCharacter(splitarray))
                {
                    SevenPosition = new string(splitarray);
                }

                splitarray = inPut.ToCharArray();
                splitarray[1] = (char)((int)splitarray[1] + 1);
                splitarray[0] = (char)((int)splitarray[0] - 2);
                if (IsValidCharacter(splitarray))
                {
                    EightiPosition = new string(splitarray);
                }
                //-------------------

                Console.WriteLine("First position is {0}", FirstsPosistion);
                Console.WriteLine("Second position is {0}", SecondPosistion);
                Console.WriteLine("Third position is {0}", ThirdPosition);
                Console.WriteLine("Fouth position is {0}", FourthPosition);
                Console.WriteLine("Fifth position is {0}", FifthPosition);
                Console.WriteLine("Sixth position is {0}", SixthPosition);
                Console.WriteLine("Seventh position is {0}", SevenPosition);
                Console.WriteLine("Eightth position is {0}", EightiPosition);
                Console.ReadLine();
            }
        }


    }
}
