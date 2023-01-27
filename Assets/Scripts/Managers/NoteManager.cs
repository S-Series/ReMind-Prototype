using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameNotes;

public class NoteManager : MonoBehaviour
{
    public static NoteManager noteManager;
    public static List<NormalNote> normalNotes;
    public static List<SpeedNote> speedNotes;
    public static List<EffectNote> effectNotes;

    private void Awake()
    {
        noteManager = this;
    }
    private void Start()
    {
        ResetNoteData();
    }
    public static void ResetNoteData()
    {
        foreach (NormalNote normal in normalNotes) { Destroy(normal.noteObject); }
        normalNotes = new List<NormalNote>();
        speedNotes = new List<SpeedNote>();
        effectNotes = new List<EffectNote>();
    }
}
