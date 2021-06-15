using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//单例接收集

public class C2S
{
    private static C2S instance;

    public static C2S Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new C2S();
            }
            return instance;
        }
    }
    public void Init()
    {
        instance = new C2S();
    }
    public int Key;
    public Vector3 MousePosition;
    public int ID;
}

//public class C2S : MonoBehaviour
//{
//    public static C2S Instance;

//    void Awake()
//    {
//        instance == this;
//    }






