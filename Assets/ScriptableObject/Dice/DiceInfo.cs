using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dice", order = 0)]
public class DiceInfo : ScriptableObject
{
    public DiceType diceType = DiceType.None;
    public string diceName = "";
    public Sprite image;
    public int baseDamage = 1;
    public float baseAPS = 1.0f;
    public TargetSelection targetSelection = TargetSelection.Disable;
    public List<Buff> initBuffList = new List<Buff>();
    public int damageFactorPerClass = 0;
    public int damageFactorPerPower = 0;

    public float APSFactorPerClass = 0;
    public float APSFactorPerPower = 0;

    public GameObject projectile;
}
