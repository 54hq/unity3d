using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFSM 
{
    public Transform transform;
    public PlayerFSM fsm; //管理类

    //进入状态
    public virtual void Enter() {
        AddListener();
    }

    //状态更新中
    public virtual void Update() { 
    
    }

    //退出状态
    public virtual void Exit() {
        RemoveListener();
    }

    //监听一些游戏事件
    public virtual void AddListener() { 
    
    }

    //移除掉监听的事件
    public virtual void RemoveListener()
    {

    }

    public virtual void HandleCMD()
    {
        if (C2S.Instance.Key == KeyCode.Mouse1.GetHashCode())
        {
            HandleMove();
        }
    }
    public virtual void HandleMove()
    {
        
    }
}
