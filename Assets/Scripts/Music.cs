using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public int musicId;
    public string musicName, musicArtist;
    public double lowestBpm, highestBpm;
    public Sprite jacket;
    public AudioSource[] musicAudio = new AudioSource[2];
    public int[] difficulty = new int[5];
    public int specialIndex = 0;


    public int[] noteCount = new int[5];

    //$ LoadFrom SaveFile
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
