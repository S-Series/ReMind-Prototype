using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour
{
    public enum SortingOption { None, Name, Difficulty, LowestBpm, HighestBpm, BestScore } 

    //$ Static Field
    public static MusicSelect musicSelect;
    public static int s_nowDifficulty;
    public static bool isMusicSelectable = false, isSortingReversed = false;

    public static List<Music> SelectableMusicList = new List<Music>();
    public static SortingOption sortingOption = SortingOption.None;

    //$ Unity Actions
    private void Awake()
    {
        musicSelect = this;
    }

    public static void PickOutMusicList()
    {

    }

    public static void SortingMusicList()
    {
        switch(sortingOption)
        {
            //$ Date, MusicId
            case SortingOption.None:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.musicId).ToList();
                break;

            //$ MusicName => MusicId
            case SortingOption.Name:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.musicName)
                    .ThenBy(item => item.musicId).ToList();
                break;

            //$ Difficulty => MusicId
            case SortingOption.Difficulty:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.difficulty[s_nowDifficulty])
                    .ThenBy(item => item.musicId).ToList();
                break;

            //$ LowestBpm => MusicId
            case SortingOption.LowestBpm:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.lowestBpm)
                    .ThenBy(item => item.musicId).ToList();
                break;

            //$ HighestBpm => MusicId
            case SortingOption.HighestBpm:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.highestBpm)
                    .ThenBy(item => item.musicId).ToList();
                break;

            //$ BestScore => MusicId
            case SortingOption.BestScore:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.bestScore[s_nowDifficulty])
                    .ThenBy(item => item.musicId).ToList();
                break;
        }

        if (isSortingReversed) { SelectableMusicList.Reverse(); }
    }
}
