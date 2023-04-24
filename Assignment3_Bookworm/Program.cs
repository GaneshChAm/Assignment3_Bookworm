//The bookworm is the latest craze in the word puzzle game world. The players connect the letter to form words; the words formed gain the player points.
//The initial step in building up the game programmatically is to explore Strings and their functionality. To enable us to get familiar with Strings, the various searching and sorting techniques on them, we will write a C# program.
//The words that will be fed to the bookworm are taken from the user as input one after another.

// (a)Write a C# program to get the strings as input from the user and push them to an array.
//Find the shortest word in the list of Strings and output the same on screen.
Console.WriteLine("(a)  Enter the Number of Words");
int m = Convert.ToInt32(Console.ReadLine());
string[] words = new string[m];
Console.WriteLine("Enter the words:");
for (int i = 0; i < m; i++)
{
    words[i] = Console.ReadLine();
}
string shortestWord = words[0];
for (int i = 1; i < words.Length; i++)
{
    if (words[i].Length < shortestWord.Length)
    {
        shortestWord = words[i];
    }
}
Console.WriteLine("The shortest word is: " + shortestWord);
Console.WriteLine();


//(b)Write a C# program that gets a word from the user and checks if the word is present in the list of words already stored in the array or not.
Console.Write("(b)  Enter a word to search: ");
string searchWord = Console.ReadLine();
bool found = false;
foreach (string item in words)
{
    if (item == searchWord)
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine("The word is present in the list");
}
else
{
    Console.WriteLine("The word is not present in the list");
}
Console.WriteLine();


//(c) Write a C# program to sort all of the words in the list in alphabetical order and display >
Array.Sort(words);
Console.WriteLine("(c) The sorted array is:");
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine((i + 1) + "\t" + words[i]);
}
Console.WriteLine();


//(d) Find if any of the words in the list is a palindrome or not, print their count and the words.
bool IsPalindrome(string word)
{
    int length = word.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (word[i] != word[length - 1 - i])
        {
            return false;
        }
    }
    return true;
}
Console.Write("(d) Enter the number of words for checking Palindromes in the list: ");
int n =Convert.ToInt32(Console.ReadLine());
string[] words1 = new string[n];
Console.WriteLine("Enter the words in the list:");
for (int i = 0; i < n; i++)
{
    words[i] = Console.ReadLine();
}

int palindromeCount = 0;
Console.WriteLine("Palindromes in the given list are below:");
foreach (string word in words)
{
    if (IsPalindrome(word))
    {
        Console.WriteLine(word);
        palindromeCount++;
    }
}
Console.WriteLine("The total number of palindromes in the list: " + palindromeCount);
