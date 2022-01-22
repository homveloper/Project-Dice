using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boss", order = 0)]
public class BossInfo : MonsterInfo
{
    public List<Buff> initBuffList = new List<Buff>();
    float stopMoving;
    int castTime = 10;
}
