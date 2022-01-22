using UnityEngine;

public class GameManager : MonoBehaviour {
    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if(null == instance)
            {
                return null;
            }

            return instance;
        }
    }

    private void Awake() {
        if (null == instance)
        {
            instance = this;
        }
    }
}