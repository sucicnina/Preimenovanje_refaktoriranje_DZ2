//Refaktoriranje

//Zadatak 2:
using System.Runtime.CompilerServices;

class Average
{
    List<double> CreateListOfAverages(List<double[]> arrays)
    {
        List<double> averages = new List<double>(); 
        
        foreach (double[] array in arrays)
        {
            averages.Add(CalculateAverage(array));
        }
        return averages;
    }

    public double CalculateAverage(double[] array)
    {
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];

        }
        return average/array.Length;
        
    }
}

//Zadatak 4:
class CetvrtiZadatak
{
    public static List<char> CountUniqueChars(string text)
    {
        List<char> chars = new List<char>();
        for (int i = 0; i < text.Length; i++)
        {
            if(CountCharOccurrence(text, text[i]) == 1)
            {
                chars.Add(text[i]);
            }
            
        }
        return chars;
    }

    public static int CountCharOccurrence(string text, char character)
    {
        int occurrenceCount = 0;
        for (int j = 0; j < text.Length; j++)
        {
            if (character == text[j])
            {
                occurrenceCount++;
            }
        }
        return occurrenceCount;
    }
}

//Zadatak 5:
class PetiZadatak
{
    public List<string> FindPalindromes(List<string> strings)
    {
        List<string> palindromes = new List<string>();
        if (strings == null) return palindromes;

        foreach (string str in strings)
        {
            if (IsPalindrome(str))
            {
                palindromes.Add(str);
            }
        }
        return palindromes;
    }

    public bool IsPalindrome(string str)
    {
        string trimmedString = str.Replace(" ", "").ToLower();
        string reversedString = new string(trimmedString.Reverse().ToArray());

        return trimmedString.Equals(reversedString);
    }
}
