using System;

class Program
{
    static void Main()
    {
        string nome = "Julia Cardoso";
        
        string reverse = ReverseString(nome);
        Console.WriteLine(reverse);
    }
    
static string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    int l = 0;
    int right = charArray.Length - 1;
    while (l < right)
    {
        (charArray[l], charArray[right]) = (charArray[right], charArray[l]);
        l++;
        right--;
    }
    return new string(charArray);
}

}