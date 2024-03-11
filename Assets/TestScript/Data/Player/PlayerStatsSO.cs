using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/PlayerStats")]
public class PlayerStatsSO : ScriptableObject
{
    [SerializeField] PlayerStats statData;
    [SerializeField] List<StatsModifierSO> modifiers;
    public float GetDefaultValue(mainStat key)
    {
        if(statData.defaultValue.TryGetValue(key,out float value))
        {
            foreach(var modifier in modifiers)
            {
                if (!modifier.statsToModify.ContainsKey(key)) continue;
                else if (modifier.isPercent) value *= modifier.statsToModify[key];
                else value += modifier.statsToModify[key];
            }
            return value;
        }
        else
        {
            return 0;
        }
    }

    public float GetInstanceValue(mainStat key)
    {
        if (statData.instanceValue.TryGetValue(key, out float value))
        {
            return value;
        }
        else
        {
            return 0;
        }
    }
}

[System.Serializable]
public class PlayerStats
{
    public SerializedDictionary<mainStat, float> defaultValue;
    public SerializedDictionary<mainStat, float> instanceValue;
    public int playerExp;
}

public enum mainStat
{
    Health,
    Stamina,
    AttackValue,
    MovementSpeed,
    Defense,
}
