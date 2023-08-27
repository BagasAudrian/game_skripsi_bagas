using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level ", menuName = "ScriptableObjects/Level")]
public class LevelSoalPlayerPrefs : ScriptableObject
{
    [Header("Soal 1")]
    public string Soal1;
    public string[] Soal1Jawaban;

    [Header("Soal 2")]
    public string Soal2;
    public string[] Soal2Jawaban;

    [Header("Soal 3")]
    public string Soal3;
    public string[] Soal3Jawaban;

    [Header("Soal 4")]
    public string Soal4;
    public string[] Soal4Jawaban;

    [Header("Soal 5")]
    public string Soal5;
    public string[] Soal5Jawaban;

    [Header("Soal 6")]
    public string Soal6;
    public string[] Soal6Jawaban;

    [Header("Soal 7")]
    public string Soal7;
    public string[] Soal7Jawaban;

    [Header("Soal 8")]
    public string Soal8;
    public string[] Soal8Jawaban;

    [Header("Soal 9")]
    public string Soal9;
    public string[] Soal9Jawaban;

    [Header("Soal 10")]
    public string Soal10;
    public string[] Soal10Jawaban;

    public string IsAllSoalFilled;
}
