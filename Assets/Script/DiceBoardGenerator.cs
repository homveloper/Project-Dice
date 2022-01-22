using System.Collections.Generic;
using UnityEngine;

public class DiceBoardGenerator : MonoBehaviour
{
    public GameObject diceSlotPrefab;
    public GameObject axis;

    public List<GameObject> diceSlotList = new List<GameObject>();

    [SerializeField] 
    public Vector2 slotSize;
    [SerializeField] 
    private float spacing;

    private void GeneratorMap(){
        for (int y=0; y<slotSize.y; y++){
            for(int x = 0; x<slotSize.x; x++){

                GameObject newSlot = Instantiate(diceSlotPrefab);
                newSlot.transform.parent = axis.transform;
                newSlot.transform.localPosition = new Vector2(x * 0.75f, y * 0.75f);
                diceSlotList.Add(newSlot);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GeneratorMap();
    }
}
