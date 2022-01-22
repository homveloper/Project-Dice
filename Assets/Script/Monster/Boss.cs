using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Monster
{
    public List<Buff> initBuffList = new List<Buff>();
    float stopMoving;
    int castTime = 10;
    int currentCastTime = 8;
}