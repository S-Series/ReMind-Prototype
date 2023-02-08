using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static int lastMusicId;
    public static int lastMusicIndex;
    public static int lastMusicSorting;
    public static int SelectDifficultyIndex;
}

public static class SettingValue
{
    public static double[] volume = new double[3]{0.7, 0.7, 0.7};
}

public static class GameValues
{

}
