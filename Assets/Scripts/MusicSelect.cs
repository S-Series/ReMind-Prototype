using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour
{
    public enum SortingOption { None, Name, Difficulty, LowestBpm, HighestBpm, BestScore }

    PlayerInputSystem[] inputSystem = new PlayerInputSystem[3];

    [Header("##Generate Field")]
    [SerializeField] GameObject MusicField;

    [Header("##Prefab Object")]
    [SerializeField] GameObject MusicSelectFramePrefab;

    //$ Static Field
    public static MusicSelect musicSelect;
    public static int s_nowDifficulty;
    public static bool isMusicSelectable = false, isSortingReversed = false;

    public static List<MusicInfo> SelectableMusicList = new List<MusicInfo>();
    public static SortingOption sortingOption = SortingOption.None;

    private int nowMusicIndex = 0;

    //$ Unity Actions
    private void Awake()
    {
        musicSelect = this;

        inputSystem[0] = new PlayerInputSystem();
        inputSystem[1] = new PlayerInputSystem();
        inputSystem[2] = new PlayerInputSystem();

        inputSystem[0].FindAction("OnMenu");

        inputSystem[0].Disable();
        inputSystem[1].Disable();
        inputSystem[2].Disable();
    }

    public static void GenerateMusicField()
    {
        MusicSelect ms = musicSelect;

        //$ Reset Music Field
        for (int i = 0; i < ms.MusicField.transform.childCount - 1; i++)
        {
            Destroy(ms.MusicField.transform.GetChild(i).gameObject);
        }

        //$ Generate Music Field
        int count = 0;
        for (int i = 0; i < SelectableMusicList.Count - 1; i++)
        {
            if (SelectableMusicList[i].isShown)
            {
                GameObject copyObject;
                copyObject = Instantiate(ms.MusicSelectFramePrefab, ms.MusicField.transform);
                copyObject.name = SelectableMusicList[i].musicName;
                copyObject.transform.localPosition = new Vector3(0, 0, 0);
                count++;
            }
        }

        int index;
        MusicInfo lastInfo;
        lastInfo = SelectableMusicList.Find(item => item.musicId == PlayerManager.lastMusicId);
        index = lastInfo == null? SelectableMusicList.IndexOf(lastInfo):PlayerManager.lastMusicIndex;
        index = index >= SelectableMusicList.Count - 1 ?
            index = SelectableMusicList.Count - 1 : index;

        ms.nowMusicIndex = index;
        SelectMusicBox.UpdateBoxFrameInfo(SelectableMusicList[index]);
    }

    public static void PickOutMusicList()
    {

    }

    public static void SortingMusicList()
    {
        switch (sortingOption)
        {
            //$ Date, MusicId
            case SortingOption.None:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.musicId).ToList();
                PlayerManager.lastMusicSorting = 0;
                break;

            //$ MusicName => MusicId
            case SortingOption.Name:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.musicName)
                    .ThenBy(item => item.musicId).ToList();
                PlayerManager.lastMusicSorting = 1;
                break;

            //$ Difficulty => MusicId
            case SortingOption.Difficulty:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.difficulty[s_nowDifficulty])
                    .ThenBy(item => item.musicId).ToList();
                PlayerManager.lastMusicSorting = 2;
                break;

            //$ LowestBpm => MusicId
            case SortingOption.LowestBpm:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.lowestBpm)
                    .ThenBy(item => item.musicId).ToList();
                PlayerManager.lastMusicSorting = 3;
                break;

            //$ HighestBpm => MusicId
            case SortingOption.HighestBpm:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.highestBpm)
                    .ThenBy(item => item.musicId).ToList();
                PlayerManager.lastMusicSorting = 4;
                break;

            //$ BestScore => MusicId
            case SortingOption.BestScore:
                SelectableMusicList = SelectableMusicList
                    .OrderBy(item => item.bestScore[s_nowDifficulty])
                    .ThenBy(item => item.musicId).ToList();
                PlayerManager.lastMusicSorting = 5;
                break;
        }

        if (isSortingReversed) { SelectableMusicList.Reverse(); }
    }

    #region //$ Input Actions
    //$ inputSystem[0]
    //$ inputSystem[1]
    //$ inputSystem[2]
    #endregion
}
