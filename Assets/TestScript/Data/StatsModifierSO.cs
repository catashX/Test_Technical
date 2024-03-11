using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsModifierSO : ScriptableObject
{
    public bool isPercent;
    public SerializedDictionary<mainStat, float> statsToModify;
}
