using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    //$ UnChange Data
    [Header("##Unchange Data")]
    public int musicId;
    public Sprite jacket;
    public AudioSource[] musicAudio = new AudioSource[2];
    public int specialIndex = 0;
    public int[] noteCount = new int[5];
    public int[] difficulty = new int[5];
    public string musicName, musicArtist;
    public double lowestBpm, highestBpm;
    
    //$ Changable Data
    [Header("##Changable Data")]
    public bool isShown;
    public bool[] isOwned = new bool[5];
    public bool[] isSecret = new bool[5];

    //$ LoadFrom SaveFile
    [Space(10f)]
    [Header("##Imported By PlayedData")]
    public int[] bestScore = new int[5];
    public int[] played_maxCombo = new int[5];
    public int[] played_pure = new int[5];
    public int[] played_perf = new int[5];
    public int[] played_near = new int[5];
    public int[] played_lost = new int[5];

    public void ApplyData(MusicJsonData data)
    {
        if (musicId != data.musicId) { throw new System.Exception(""); }
        musicName = data.musicName;
        musicArtist = data.musicArtist;
        lowestBpm = data.lowestBpm;
        highestBpm = data.highestBpm;
        difficulty = data.difficulty;
        specialIndex = data.specialIndex;
    }

    public void ApplyPlayedData(MusicPlayedData data)
    {

    }
}
