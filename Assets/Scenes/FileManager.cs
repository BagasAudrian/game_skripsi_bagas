using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileManager : MonoBehaviour
{
    string[] SoalArray;
    string myFilePath, fileSoal;
    void Start()
    {
        fileSoal = "soal.txt";
        myFilePath = Application.dataPath + "/" + fileSoal;
    }

    public void ReadFromTheFile()
    {
        SoalArray = File.ReadAllLines(myFilePath);

        System.Array.Sort(SoalArray);
        foreach(string line in SoalArray)
        {
            print(line);
        }
    }
}
