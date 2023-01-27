using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClasses : MonoBehaviour
{
    public static NoteClasses noteClasses;

    private void Awake()
    {
        noteClasses = this;
    }
}

namespace GameNotes
{
    public class Note
    {
        public int ms, pos;
    }

    public class NormalNote : Note
    {
        public int soundIndex;
        public GameObject noteObject;
    }

    public class SpeedNote : Note
    {
        public double bpm, multiple;
    }

    public class EffectNote : Note
    {
        public int effectIndex;

    }
}
