using System;


namespace StemWordCounter
{
    public class Stem
    {

        public string WordStem(string sWord)

        {

            //set sWordstem to sWord in case of no stemming required.
            string sWordStem = sWord;

            //Simple Stem processing for the known terms only - avoiding libraries and time constraint of implementing porter/snowball algorithms.
                        
            if (sWord.EndsWith("ing") )
            {
                sWordStem = sWord.Replace("ing", "");
            }
                       
            //remove single "s"
            if (sWord.EndsWith("s") && !sWord.EndsWith("ss") && !sWord.EndsWith("es"))
            {
                sWordStem = sWord.Remove(sWord.Length - 1, 1); ;
            }

            if (sWord.EndsWith("ification"))
            {
                sWordStem = sWord.Replace("ification", "");
            }

            if (sWord.EndsWith("lier"))
            {
                sWordStem = sWord.Replace("lier", "");
            }

            if (sWord.EndsWith("es") && !sWord.EndsWith("lies"))
            {
                sWordStem = sWord.Remove(sWord.Length - 2, 2);
            }


            if (sWord.EndsWith("lies"))
            {
                sWordStem = sWord.Replace("lies", "");
            }

            if (sWord.EndsWith("y") && !sWord.EndsWith("ly") && !sWord.EndsWith("ify"))
            {
                sWordStem = sWord.Remove(sWord.Length - 1, 1); ;
            }

            if (sWord.EndsWith("ly"))
            {
                sWordStem = sWord.Remove(sWord.Length - 2, 2); ;
            }

            if (sWord.EndsWith("ify"))
            {
                sWordStem = sWord.Remove(sWord.Length - 3, 3); ;
            }

            return sWordStem;

        }


        public string[] ParseWords(string inputText)

        {

            string[] Words;

            //removal of punctuation and shift all to lowercase
            string Text = inputText.Replace(".", "").ToLower();
            //split words on space
            Words = Text.Split(new string[] { " " }, StringSplitOptions.None);
                                                               
            return Words;
        }


        public int CountStems(string InputText, string GivenWord)
        {

            Stem ostem = new Stem();

            int i=0;
            //get stem of the given word
            string StemGW = ostem.WordStem(GivenWord);
            //get array of words in the Input text
            var words = ostem.ParseWords(InputText);

            foreach (string word in words)
            {
                //compare the stem of each word in the input text with the stem of the given word
                if (ostem.WordStem(word) == StemGW)
                { 
                    i++; 
                }
            }

            return i;
        }

    }
}
