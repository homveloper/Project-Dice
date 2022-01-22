using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MonsterType
{
    Normal,
    Boss
}

public class Monster : MonoBehaviour
{
    public MonsterType monsterType = MonsterType.Normal;
    public string monsterName = "";
    public int hp = 100;
    public float hpFactorPerWave = 1;
    public float moveSpeed = 1f;
    public float moveSpeedFactorPerWave = 1f;
    public int Sp = 10;
    public float SPFactorPerWave = 1f;

    private List<Transform> wayPoints;
    private int currentIdx = 0;
    private Movement2D movement2D;

    public int HP
    {
        get { return hp; }
        set {
            hp = value;
        }
    }

    public void TakeDamage(int factor)
    {
        HP -= factor;

        if (HP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {

    }
}
