namespace Opti_Algo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
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
            */
            BinaryTree bt = new BinaryTree();
            bt.Add("coucou");
            bt.Add("blabla");
            bt.Add("bonjour");
            bt.Add("jpp");
            bt.Add("test");
            
            Console.WriteLine(bt.Search("caca"));
            Console.WriteLine(bt.Search("test"));
            Console.WriteLine(bt.Search("bonjour"));
            Console.WriteLine(bt.Search("blabla"));
            
        }
    }
}