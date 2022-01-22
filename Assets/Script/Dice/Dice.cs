using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DiceType {
    None,
    Physical,
    Magical,
    Debuff,
    Transmogrification
}

public enum TargetSelection {
    Disable,
    First,
    Strongger,
    Random
}

public class Dice : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public DiceType diceType= DiceType.None;
    [SerializeField] public string diceName = "";
    [SerializeField] public int baseDamage  = 1;
    [SerializeField] public float baseAPS = 1.0f; 
    [SerializeField] public TargetSelection targetSelection = TargetSelection.Disable;
    [SerializeField] public List<Buff> currentBuffList;
    [SerializeField] public int classLevel = 1;
    [SerializeField] public int powerLevel = 1;

    [SerializeField] public int damageFactorPerClass = 0;
    [SerializeField] public int damageFactorPerPower = 0;
    [SerializeField] public float APSFactorPerClass = 0;
    [SerializeField] public float APSFactorPerPower = 0;

    [SerializeField] public GameObject projectile = null;

    [SerializeField] Monster target = null;


    private void SearchTarget(){

        switch (targetSelection)
        {
            case TargetSelection.First:

            case TargetSelection.Strongger:
            case TargetSelection.Random:
                break;
        }
    }

    private void SearchFirstTarget()
    {
        
    }

    private void SearchStronggerTarget()
    {

    }

    private void SearchRandomTarget()
    {

    }

    private void AttackTarget(){

    }

    private void SpawnProjectile(){

    }


    public void UpdateInfo(DiceInfo diceInfo)
    {   
        diceType = diceInfo.diceType;
        diceName = diceInfo.diceName;
        baseDamage = diceInfo.baseDamage;
        baseAPS = diceInfo.baseAPS;
        targetSelection = diceInfo.targetSelection;
        currentBuffList = new List<Buff>(diceInfo.initBuffList);

        damageFactorPerClass = diceInfo.damageFactorPerClass;
        damageFactorPerPower = diceInfo.damageFactorPerPower;
        APSFactorPerClass = diceInfo.APSFactorPerClass;
        APSFactorPerPower = diceInfo.APSFactorPerClass;

        projectile = diceInfo.projectile;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
