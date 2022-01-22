using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static MonsterManager instance = null;

    public static MonsterManager Instance
    {
        get
        {
            if(null == instance)
            {
                instance = new MonsterManager();
            }

            return instance;
        }
    }
}
