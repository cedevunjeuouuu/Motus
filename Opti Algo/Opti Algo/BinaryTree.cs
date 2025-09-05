using System.Diagnostics.Tracing;

namespace Opti_Algo;

public class BinaryTree
{
    private Node root = new Node(null);
    private Node currentNode;

    public void Add(string newWord) // ajoute un string a l'arbre
    {
        if (root.word == null)
        {
            root.word = newWord;
            currentNode = root;
        }
        else
        {
            if (string.Compare(currentNode.word, newWord) > 0) //Left
            {
                if (currentNode.leftChild == null)
                {
                    currentNode.leftChild = new Node(newWord);
                    currentNode = root;
                    return;
                }
                currentNode = currentNode.leftChild; 
                Add(newWord);
                
            }
            else //Right
            {
                if (currentNode.rightChild == null)
                {
                    currentNode.rightChild = new Node(newWord);
                    currentNode = root;
                    return;
                }
                currentNode = currentNode.rightChild;
                Add(newWord);
                
            }
        }
    }
    
    public void Display() // affiche l'arbre
    {
        if (currentNode == null)
        {
            currentNode = root;
            Display();
        }
        if (currentNode.leftChild == null && currentNode.rightChild == null)
        {
            Console.WriteLine("le node courant est " + currentNode.word + " et n'a pas d'enfant");
        }
        
        if (currentNode.leftChild != null)
        {
            Console.WriteLine("le node courant est " + currentNode.word + " le node a gauche est " + currentNode.leftChild.word);
            currentNode = currentNode.leftChild;
            Display();
        }

        if (currentNode.rightChild != null)
        {
            Console.WriteLine("le node courant est " + currentNode.word + " le node a droite est " + currentNode.rightChild.word);
            currentNode = currentNode.rightChild;
            Display();
        }

        currentNode = root;
    }

    public bool Search(string wordToSearch)
    {
        if (root.word == null)
        {
            Console.WriteLine("Empty tree");
        }
        else
        {
            if (currentNode.word == wordToSearch) // Trouvé
            {
                return true;
            }

            if (string.Compare(currentNode.word, wordToSearch) > 0) //Left
            {
                if (currentNode.leftChild == null)
                {
                    currentNode = root;
                    return false;
                }
                currentNode = currentNode.leftChild;
                Search(wordToSearch);
                
            }
            else //Right
            {
                if (currentNode.rightChild == null)
                {
                    return false;
                }
                currentNode = currentNode.rightChild;
                Search(wordToSearch);
                
            }
            
        }
        return false;
    }
}

public class Node
{
    public String word;
    public Node leftChild;
    public Node rightChild;

    public Node(string word)
    {
        this.word = word;
    }
}