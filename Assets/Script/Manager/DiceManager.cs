using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] 
    private List<DiceInfo> deckList = new List<DiceInfo>();
    private List<Dice> currentDiceList = new List<Dice>();
    DiceBoardGenerator diceBoardGenerator;

    private static DiceManager instance = null;
    public static DiceManager Instance
    {
        get
        {
            if(null == instance)
            {
                instance = new DiceManager();
            }
            return instance;
        }
    }

    private void Awake() {
        diceBoardGenerator = GetComponent<DiceBoardGenerator>();
    }

    public void CreateDice()
    {
        if(currentDiceList.Count >= diceBoardGenerator.slotSize.x * diceBoardGenerator.slotSize.y) return;

        int randomIdx = Random.Range(0,deckList.Count-1);
        DiceInfo selectedDiceInfo = deckList[randomIdx];

        List<GameObject> emptySlotList = diceBoardGenerator.diceSlotList.FindAll(x => x.GetComponent<Dice>().diceType == DiceType.None);

        randomIdx = Random.Range(0, emptySlotList.Count-1);
        GameObject selectedSlot = emptySlotList[randomIdx];

        print("Create Dice");

        // Set dice info
        try
        {
            Dice slotDice = selectedSlot.GetComponent<Dice>();
            slotDice.UpdateInfo(selectedDiceInfo);
            slotDice.GetComponent<SpriteRenderer>().sprite = selectedDiceInfo.image;

            currentDiceList.Add(slotDice);
        }catch{

        }
    }


    // merge b to a
    public void MergeDice(Dice a, Dice b)
    {

    }

    public void RemoveDice(Dice Dice)
    {

    }
}
