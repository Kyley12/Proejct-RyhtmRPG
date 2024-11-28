using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats Data", menuName = "Scriptable Object/Stats Data", order = 0)]

public class StatsData : ScriptableObject
{
    public float hp;
    public float mp;
    public float st;
    public float damge;
}
