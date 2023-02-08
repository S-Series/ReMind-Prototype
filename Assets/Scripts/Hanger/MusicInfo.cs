using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInfo : MonoBehaviour
{
    #region //$ UnChange Data
    [Header("##Unchange Data")]
    public int musicId;
    public Sprite jacket;
    public AudioSource[] musicAudio = new AudioSource[2];
    public int specialIndex = 0;
    public int[] noteCount = new int[5];
    public int[] difficulty = new int[5];
    public string musicName, musicArtist;
    public double lowestBpm, highestBpm;
    #endregion
    
    #region  //$ Changable Data
    [Header("##Changable Data")]
    public bool isShown, isSecret;
    public bool[] isOwned = new bool[5];
    #endregion

    #region //$ LoadFrom SaveFile
    [Space(10f)]
    [Header("##Imported By PlayedData")]
    public int[] bestScore = new int[5];
    public int[] played_maxCombo = new int[5];
    public int[] played_pure = new int[5];
    public int[] played_perf = new int[5];
    public int[] played_near = new int[5];
    public int[] played_lost = new int[5];
    #endregion

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

    [ContextMenu("Save Default Data")]
    public void SaveDefaultData()
    {
        string path;
        path = Application.dataPath + "/NoteBox/Default/" + String.Format("{0:d4}", musicId) + ".json";

        MusicJsonData newData;
        newData = new MusicJsonData();
        newData.musicId = musicId;
        newData.specialIndex = specialIndex;
        newData.noteCount = noteCount;
        newData.difficulty = difficulty;
        newData.musicName = musicName;
        newData.musicArtist = musicArtist;
        newData.lowestBpm = lowestBpm;
        newData.highestBpm = highestBpm;
        newData.isShown = isShown;
        newData.isOwned = isOwned;
        newData.isSecret = isSecret;

        string jsonData;
        jsonData = JsonUtility.ToJson(newData, true);
        File.WriteAllText(path, jsonData);
    }
}
