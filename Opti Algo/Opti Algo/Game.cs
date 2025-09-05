using System.Text; // A REGARDER PAR LUCAS ET PAS OIUBLIER DE SUPPR :
                   // check d'abord les rouges et mettre tout le reste en blanc et après check les jaunes en remplacant ceux qui on besoin

namespace Opti_Algo;

public class Game
{
    public bool CompareWords(string word1, string word2) // cette fonction compare le mot du joueur et celui selectionné
    {
        if (word1.Length != word2.Length)
        {
            Console.WriteLine("The word don't have the right lenght");
            return false;
        }
        else
        {
            string word2Copy = word2;
            bool isGoodWord = true;
            var baseColor = Console.ForegroundColor;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == word2[i]) // premier test pour voir si elle est bien placée
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(word1[i]);
                    Console.ForegroundColor = baseColor;
                }
                else if (word2Copy.Contains(word1[i])) // celui ci pour tester si c'est dans le mot mais mal placé
                {
                    for (int j = 0; j < word2Copy.Length; j++)
                    {
                        if (word1[i] == word2Copy[j])
                        {
                            word2Copy = word2Copy.Remove(j);
                            word2Copy = word2Copy.Insert(j, ".");
                            break;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(word1[i]);
                    Console.ForegroundColor = baseColor; 
                    isGoodWord = false;
                    
                }
                else // si il n'est pas dans le mot 
                {
                    Console.Write(word1[i]);
                    isGoodWord = false;
                }
            }
            Console.WriteLine("");
            if (isGoodWord) // victoire
            {
                Console.WriteLine("You win");
                return true;
            }
            return false;
        }
    }
/*
    public void ReadFile()
    {
        string filePath = "";
        string[] originalWords = File.ReadAllLines(filePath);
        string[] words = new string[originalWords.Length];
        string cleanWord = "";
        for (int i = 0; i < originalWords.Length; i++)
        {
            cleanWord = originalWords[i].Normalize(NormalizationForm.FormD);
            
            foreach (char letter in cleanWord)
            {
                if (letter >= 'a' && letter <= 'z')
                {
                    words[i] = cle
                }
            }
        }

    }
    */
}