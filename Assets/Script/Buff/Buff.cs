using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum BuffType {
    Physical,
    Magical,
    Debuff,
    Transmogrification
}

public class Buff : MonoBehaviour
{
    BuffType buffType;

    int damage;
    int APS;    // attack per second
}
