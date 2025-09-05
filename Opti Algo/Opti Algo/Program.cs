namespace Opti_Algo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game gameRef = new Game();
            
            List<string> wordList = new List<string>() // liste totale des mots
            {
                "coco"
            };
            
            Random rnd = new Random();
            string actualWord = wordList[rnd.Next(wordList.Count)];
            
            Console.Write(actualWord[0]);
            for (int i = 1; i < actualWord.Length; i++) // écrit la première lettre du mot et met le reste en tirets pour en voir la taille
            {
                Console.Write("_");
            }
            Console.WriteLine();
            
            string? userWord = Console.ReadLine();
            
            while (!gameRef.CompareWords(userWord, actualWord)) // boucle de jeu
            {
                userWord = Console.ReadLine();
            }
        }
    }
}