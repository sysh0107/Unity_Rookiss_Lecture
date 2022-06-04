using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers Instance;
    public static Managers GetInstance() { Init(); return Instance; }

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    static void Init()
    {
        if(Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            Instance = go.AddComponent<Managers>();
        }
        
    }
}
