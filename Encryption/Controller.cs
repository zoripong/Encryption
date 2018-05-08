using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Controller
    {
        Boolean isDebugging = true;

        public Controller()
        {
            Console.WriteLine("Create Controller");

        }

        // 키워드를 적절히 셋팅
        public char[] MakeKeyword(String str)
        {


            char[] letter = (new HashSet<char>(str.ToCharArray())).ToArray<char>();

            for(int i = 0; i<letter.Length; i++)
            {
                letter[i] = Char.ToLower(letter[i]);
            }

            if (isDebugging)
            {
                Console.WriteLine("size : {0}", letter.Length);
                for (int i = 0; i < letter.Length; i++)
                {
                    Console.WriteLine(letter[i]);
                }
            }
            return letter;
        }

        // 평문을 두글자씩 잘라 반환
        public ArrayList MakePlainText(string plainText)
        {
            plainText = plainText.Replace(" ", "");
            char[] plainChar = plainText.ToCharArray();

            ArrayList convertPlain = new ArrayList();

            int index = 0;

            while (true)
            {
                if (index >= plainChar.Length)
                    break;

                char fLetter = plainChar[index++];
                char sLetter;
                if (index >= plainChar.Length)
                {
                    sLetter = 'x';
                }
                else
                {
                    sLetter = plainChar[index++];
                }

                if (fLetter == sLetter)
                {
                    index--;
                    sLetter = 'x';
                }

                convertPlain.Add(Char.ToLower(fLetter).ToString() + Char.ToLower(sLetter).ToString());
            }


            if (isDebugging)
            {
                for (int i = 0; i < convertPlain.Count; i++)
                {
                    Console.WriteLine(convertPlain[i]);
                }
            }
            return convertPlain;

        }

        //암호판 생성
        public char[,] ToConvertBoard(char[] keyLetter)
        {
            char[,] board = new char[5, 5];
            int[] alphabet = new int[26];

            Boolean isContainZ = false;
            int index = 0, i = 0, j = 0;

            // 암호판에 중복제거한 키워드를 차례대로 삽입

            while (index < keyLetter.Length)
            {
                board[i, j] = keyLetter[index++];
                alphabet[(int)(board[i, j] - 'a')] = 1;

                if (board[i, j] == 'z')
                {
                    isContainZ = true;
                    board[i, j] = 'q';
                }

                j++;
                if (j >= 5)
                {
                    j = 0;
                    i++;
                }
            }

            index = 0;

            // 나머지 알파벳을 순서대로 삽입

            while (index < alphabet.Length)
            {
                if (((char)('a' + index) == 'z') || (isContainZ == true && (char)('a' + index) == 'q'))
                {
                    index++;
                    continue;
                }

                if (alphabet[index] == 0)
                {
                    board[i, j] = (char)('a' + index);
                    j++;
                    if (j >= 5)
                    {
                        j = 0;
                        i++;
                    }
                }
                index++;
            }


            // 디버깅
            if (isDebugging)
            {

                for (int ii = 0; ii < alphabet.Length; ii++)
                {
                    char check = (char)(ii + 'a');
                    Console.WriteLine(check + ":" + alphabet[ii]);
                }

                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        Console.Write("{0}", board[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            return board;
        }


        // 암호판에 위치한 인덱스를 반환
        public int[] GetIndex(char c, char[,] board)
        {
            int[] index = new int[2] { -1, -1 };

            if (c == 'z')
                c = 'q';

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i, j] == c)
                    {
                        index[0] = i;
                        index[1] = j;
                        return index;
                    }
                }
            }

            return index;
        }

        // 평문의 인덱스를 교체
        public string ChangeIndex(string text, char[,] pwKeyBoard)
        {
            /*
             * fChar : 2글자 중 앞
             * sChar : 2글자 중 뒤
             * fIndex : fChar가 암호판에 위치한 인덱스
             * sIndex : sChar가 암호판에 위치한 인덱스
             */
            char fChar, sChar;

            int[] fIndex = GetIndex(text.ToCharArray()[0], pwKeyBoard);
            int[] sIndex = GetIndex(text.ToCharArray()[1], pwKeyBoard);

            // 열이 같을 때
            if (sIndex[1] == fIndex[1])
            {
                fChar = pwKeyBoard[((fIndex[0] + 1) % 5), fIndex[1]];
                sChar = pwKeyBoard[((sIndex[0] + 1) % 5), sIndex[1]];
            }
            // 행이 같을 때
            else if (sIndex[0] == fIndex[0])
            {
                fChar = pwKeyBoard[fIndex[0], ((fIndex[1] + 1) % 5)];
                sChar = pwKeyBoard[sIndex[0], ((sIndex[1] + 1) % 5)];
            }
            // 둘 다 다를 때
            else
            {
                fChar = pwKeyBoard[sIndex[0], fIndex[1]];
                sChar = pwKeyBoard[fIndex[0], sIndex[1]];
            }


            if (isDebugging)
            {
                Console.WriteLine(text + "->" + fChar.ToString() + sChar.ToString());
            }

            return fChar.ToString() + sChar.ToString();

        }

        // 암호화
        public string DoEncrypt(ArrayList plainText, char[,] pwKeyBoard)
        {
            string text = "";

            for (int i = 0; i < plainText.Count; i++)
            {
                plainText[i] = ChangeIndex((string)plainText[i], pwKeyBoard);
                text += plainText[i];
            }



            if (isDebugging)
            {
                for (int i = 0; i < plainText.Count; i++)
                {
                    Console.Write(plainText[i]);
                }
            }

            return text;
        }


        public string Encryption(String keyword, string plainText)
        {

            /*
             * KeyBox : 암호키 textBox
             * pwKey : 암호키
             * pwKeyBoard : 암호키판 (2차원 배열)
             * convertPlain : 변환한 평문
             */

            char[] pwKey = MakeKeyword(keyword);
            if (isDebugging)
            {
                foreach(char c in pwKey)
                {
                    Console.WriteLine(c);
                }
            }
            char[,] pwKeyBoard = ToConvertBoard(pwKey);
            ArrayList convertPlain = MakePlainText(plainText.ToLower()); // textBox에서 소문자로 변환한 후 매개변수로 넘김

            return DoEncrypt(convertPlain, pwKeyBoard);
        }




    }
}