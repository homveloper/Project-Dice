using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Monster", order = 0)]
public class MonsterInfo : ScriptableObject
{
    public MonsterType monsterType = MonsterType.Normal;
    public string monsterName = "";
    public int hp = 100;
    public float hpFactorPerWave = 1;
    public float moveSpeed = 1f;
    public float moveSpeedFactorPerWave = 1f;
    public int Sp = 10;
    public float SPFactorPerWave = 1f;
}
