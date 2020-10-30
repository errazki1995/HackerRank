using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace MyLab.Training
{
    class Train
    {
        public Train()
        {

        }
        //using System.IO
        /*
         * @param filename, the file to find
         * @param startDirectory, the directory where to look
         */
        public void findTheFile(string filename,string startDirectory)
        {
            try
            {
                foreach (string filepath in Directory.GetFiles(startDirectory))
                {
                    string fileFromPath = Path.GetFileName(filepath).ToString();
                    if (fileFromPath.ToString().Equals(filename)) { Console.WriteLine("File found at directory" + startDirectory + "\\+" + filename); break; }
                    else continue;
                }
                foreach (string directory in Directory.GetDirectories(startDirectory))
                {
                    findTheFile(filename, directory);
                }
            }
            catch(Exception e) { Console.Write(e.Message); }
        }

        public string palindrome(string input)
        {
            bool ispalindrom = true;
            if (input == null || input.Length <= 2) return "incorrect input";
            else
            {
                //test every side front and rear
                int rearpos = input.Length-1;
               for(int i = 0; i < input.Length; i++)
                {
                    if (input[rearpos] != input[i]) ispalindrom = false;  //Console.WriteLine("front :"+input[i]+" rear :"+input[rearpos]);
                    rearpos--;
                }
            }
            return ispalindrom ? "Is palindrom" : "Not palindrom";

        }

        //reverse a sentence input "Welcome to Csharp corner" output : "corner Csharp to Welcome"
        public string CallReverse(string sentence)
        {
            string[] words = sentence.Split(" ");
           string sentenceReversed= reverseSentence(words, false);
           
            return sentenceReversed;
        }

        public string  reverseSentence(string[] words,bool reversewords)
        {
            string concat = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if(reversewords) concat += reverseWord(words[i]) + " ";
                else concat += words[i] + " ";
                concat.TrimEnd(' ');
            }
            return concat;
        }

        public string reverseWord(string x)
        {
            string rev = "";
            for(int i = x.Length - 1; i >= 0; i--)
            {
                rev += x[i];
            }
            return rev;
        }
        

        public void Debug(Object message)
        {
            Console.WriteLine(message.ToString());
        }


        public List<char> toListArray(char [] arrchar)
        {
            List<char> resArray = null;
            if (arrchar.Length > 0)
            {

            resArray = new List<char>();

            for(int i = 0; i < arrchar.Length; i++)
            {
                resArray.Add(arrchar[i]);
            }
            }
            return resArray;
        }
        public bool isTwin(string a,string b)
        {
            if (/*a.Length != b.Length ||*/ a==null || b==null) return false;
            else
            {
                List<char> sortedAlpha1 = new List<char>();
                List<char> sortedAlpha2 = new List<char>();
                if (a.Length > b.Length)
                {
                    sortedAlpha1 = toListArray(b.ToCharArray());
                    sortedAlpha2 = toListArray(a.ToCharArray());
                }
               else 
                {
                    sortedAlpha2 = toListArray(b.ToCharArray());
                    sortedAlpha1 = toListArray(a.ToCharArray());
                }

           // Array.Sort(sortedAlpha1);
            //Array.Sort(sortedAlpha2);

                for (int i = 0; i < sortedAlpha1.Count; i++)
                {
                    int twin = 0;

                    Debug("boucle 1: "+sortedAlpha1[i]);
                    for (int j = 0; j < sortedAlpha2.Count; j++)
                    {
                        Debug("boucle 2: " + sortedAlpha2[j]);

                        if (sortedAlpha1[i].Equals(sortedAlpha2[j])) twin++;

                    }
                    if (twin == 0) return false;
                   
                                   }
               // Debug("isTwin? => " + twin);
                return  true; 
            }



        }



    }

  
}
