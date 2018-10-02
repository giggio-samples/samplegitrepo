for (int i = 1; i <= 100; i++)
{
    var contents = "";
    for (int j = i; j < i + 5; j++)
        contents += j.ToString("000") + Environment.NewLine;
    File.WriteAllText(i.ToString("000") + ".txt", contents);
}
WriteLine("Done!")