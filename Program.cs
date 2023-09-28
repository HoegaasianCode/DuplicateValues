List<string> strList = new();
foreach (string line in File.ReadAllLines(
@"C:\Users\Joakim.Hogas\Desktop\tekstMappe\parcelList1.txt"))
{
     strList.Add(line);
}
 IsDuplicateValue(strList);
void IsDuplicateValue(List<string> strList)
{
    List<string> duplicateList = new();
    foreach (string str in strList)
    {
        int i = 0;
        foreach (string str1 in strList)
        {
            if (str1 == str || str1 == '0' + str || str1 == str.Remove(0, 1))
            {
                i++;
            }
        }
        if (i > 1)
        {
            duplicateList.Add(str);
            continue;
        }
    }
    PrintDuplicateValues(duplicateList);
}
void PrintDuplicateValues(List<string> strList)
{
    foreach (string str in strList.Distinct())
    {
        Console.WriteLine(str);
    }
}