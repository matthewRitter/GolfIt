using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletonGameManager : MonoBehaviour
{
    private static singletonGameManager instance = null;

    public bool isLoaded = false;

    public int numPowerupsLeft = 10;

    public static singletonGameManager Instance
    {
        get
        {
            instance = FindObjectOfType<singletonGameManager>();
            if(instance == null)
            {
                GameObject go = new GameObject();
                go.name = "SingletonController";
                instance = go.AddComponent<singletonGameManager>();
                singletonGameManager.instance.loadEverything();
                DontDestroyOnLoad(go);
            }
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    public void loadEverything()
    {
        if (!isLoaded)
        {
            /*
             * if (hasKey("keyName"))
             * {
             * keyName = PlayerPrefs.GetInt("keyName");
             * }
             */
        }
    }

    public void saveEverything()
    {
        //PlayerPrefs.SetInt("Name", varName);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
