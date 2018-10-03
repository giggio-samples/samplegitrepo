for (int i = 101; i <= 200; i++)
{
    var contents = "";
    for (int j = i; j < i + 5; j++)
        contents += j.ToString("000") + Environment.NewLine;
    if (i == 144)
    {
        contents += "ERR";
    }
    File.WriteAllText(i.ToString("000") + ".txt", contents);
    Process.Start(new ProcessStartInfo("git", "add .") { UseShellExecute = false, CreateNoWindow = true }).WaitForExit();
    Process.Start(new ProcessStartInfo("git", $"commit -m \"Add {i.ToString("000")}\"") { UseShellExecute = false, CreateNoWindow = true }).WaitForExit();
}
WriteLine("Done!")