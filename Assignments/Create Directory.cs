using System;
using System.IO;

public class FileIO
{
    public void Assignment2()
    {
        string rootFolderName = "Nepal";
        Directory.CreateDirectory(rootFolderName);
        string[] subFoldersName = {"Bagmati", "Sagarmatha","Mechi","Mahakali","Karnali","Gandaki","Lumbini", "Bheri","Seti","Rapti"};
        foreach(string sub in subFoldersName)
        {
            string subFolderNamePath = rootFolderName + "/" + sub;
            Directory.CreateDirectory(subFolderNamePath);
            string filePath = subFolderNamePath + "/" + "Test.txt";
            File.WriteAllText(filePath,sub);
        }
    }
}