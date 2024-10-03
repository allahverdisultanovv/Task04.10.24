//Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin
string[] words = { "SALam", "Ako", "Taceddin", "Gel" };
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 4)
    {
        Console.WriteLine(words[i]);
    }
}