using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectMusicBox : MonoBehaviour
{
    private static MusicFrame BoxFrame;
    [SerializeField] private GameObject BoxFrameObject;

    private void Start()
    {
        BoxFrame = BoxFrameObject.GetComponent<MusicFrame>();
    }

    public static void UpdateBoxFrameInfo(MusicInfo info)
    {
        BoxFrame.SetFrameInfo(info);
        
        //$ Send Web Manager to Update Ranking
    }
}
