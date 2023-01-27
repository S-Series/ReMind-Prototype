using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public static int playMs;

    public static double bpm;

    private void Awake()
    {
        GM = this;
    }
}
