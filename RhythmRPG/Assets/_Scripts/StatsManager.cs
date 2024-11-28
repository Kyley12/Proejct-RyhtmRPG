using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/StatsManager")]
public class StatsManager : ScriptableObject
{
    public void ModifyStats(Stats statsDatabase, string name, float newValue)
    {
        StatsInfo currStat = statsDatabase.GetStats(name);

        if(currStat != null)
        {
            currStat.value = newValue;
            Debug.Log($"Stat with name: {name}'s value has been modified into {newValue}");
        }
        else
        {
            Debug.LogError($"Stat with name: {name} not found!");
        }
    }
}

