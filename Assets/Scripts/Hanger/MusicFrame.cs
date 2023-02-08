using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicFrame : MonoBehaviour
{
    [Header("## Info Renderer")]
    [SerializeField] SpriteRenderer[] InfoRenderer;

    [Header("## Info Tmp")]
    [SerializeField] TextMeshPro[] InfoTmp; 

    [Header("## Difficulty Game Objects")]
    [SerializeField] GameObject[] DifficultyBox;

    [Header("## Block Object")]
    [SerializeField] GameObject[] BlockObject;

    public void SetFrameInfo(MusicInfo info)
    {
        if (info.isSecret)
        {
            BlockObject[0].SetActive(true);
            BlockObject[1].SetActive(false);
            InfoTmp[0].text = "? ? ? ?";
            InfoTmp[1].text = "? ? ? ?";
            InfoTmp[2].text = "??? - ???";
            InfoTmp[3].text = "UnPlayed";
            return;
        }
        else { BlockObject[0].SetActive(false); }

        if (info.isOwned[PlayerManager.SelectDifficultyIndex]) { BlockObject[1].SetActive(true); }
        else { BlockObject[1].SetActive(false); }

        InfoRenderer[0].sprite = info.jacket;
        InfoRenderer[1].sprite = null; //todo : Rank Renderer

        InfoTmp[0].text = info.musicName;
        InfoTmp[1].text = info.musicArtist;

        if (info.highestBpm == info.lowestBpm) { InfoTmp[2].text = info.highestBpm.ToString(); }
        else { InfoTmp[2].text = info.lowestBpm.ToString() + " - " + info.highestBpm.ToString(); }

        if (info.bestScore[PlayerManager.SelectDifficultyIndex] == 0) { InfoTmp[3].text = "UnPlayed"; }
        else { InfoTmp[3].text = string.Format("{0:D8}", info.bestScore[PlayerManager.SelectDifficultyIndex].ToString()); }

        //InfoTmp[4].text = 
    }
}
