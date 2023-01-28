using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static List<Music> musics = new List<Music>();

    void Start()
    {
        for (int i = 0; i < transform.childCount - 1; i++)
        {
            Music music;
            music = transform.GetChild(i).GetComponent<Music>();
            if (music.musicId != i + 1) { throw new System.Exception("Music Id Error!"); }
            musics.Add(music);
        }
    }

    public static Music GetMusic(int musicIndex)
    {
        if (musicIndex >= musics.Count) { throw new System.Exception("Music Data Request Error!"); }
        return musics[musicIndex];
    }

    static IEnumerator LoadMusicData()
    {
        for (int i = 0; i < musics.Count - 1; i++)
        {
            MusicJsonData data = new MusicJsonData();
            TextAsset text = Resources.Load(musics[i].musicId.ToString()) as TextAsset;
            data = JsonUtility.FromJson<MusicJsonData>(text.ToString());
            musics[i].ApplyData(data);
            yield return null;
        }
    }

}

public class MusicJsonData
{
    //$ UnChange Data
    public int musicId;
    public Sprite jacket;
    public AudioSource[] musicAudio = new AudioSource[2];
    public int specialIndex = 0;
    public int[] noteCount = new int[5];
    public int[] difficulty = new int[5];
    public string musicName, musicArtist;
    public double lowestBpm, highestBpm;
    
    //$ Changable Data
    public bool isShown;
    public bool[] isOwned = new bool[5];
    public bool[] isSecret = new bool[5];

}

public class MusicPlayedData
{
    public int[] bestScore = new int[5];
    public int[] played_maxCombo = new int[5];
    public int[] played_pure = new int[5];
    public int[] played_perf = new int[5];
    public int[] played_near = new int[5];
    public int[] played_lost = new int[5];
}
