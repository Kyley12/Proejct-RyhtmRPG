using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Stats")]
public class Stats : ScriptableObject
{
    public List<StatsInfo> stats;

    public StatsInfo GetStats(string name)
    {
        return stats.Find(stat => stat.name == name);
    }

    public void AddStats(string name, float value)
    {
        StatsInfo currStat = GetStats(name);
        if (currStat != null)
        {
            Debug.LogWarning($"Stat with name: {name} already exists");
            return;
        }

        stats.Add(currStat);
        Debug.Log($"Stat with name: {name} has been successfully added");
    }

    public void RemoveStats(string name)
    {
        StatsInfo currStat = GetStats(name);

        if(currStat != null)
        {
            stats.Remove(currStat);
            Debug.Log($"Stat with name: {name} has been successfully removed!");
        }
        else
        {
            Debug.LogError($"Stat with name: {name} not found!");
        }
    }

    
}

[System.Serializable]
public class StatsInfo
{
    public string name;
    public float value;

    public StatsInfo(string name, float value)
    {
        this.name = name;
        this.value = value;
    }
}