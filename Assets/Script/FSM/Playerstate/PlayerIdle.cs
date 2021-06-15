using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : EntityFSM
{
    public PlayerIdle(Transform transform,PlayerFSM fsm)
    {
        this.transform = transform;
        this.fsm = fsm;

    }

    public override void AddListener()
    {
        base.AddListener();
    }

    public override void Enter()
    {
        base.Enter();
        this.fsm.agent.enabled = false;
        fsm.animatorManager.play(PAClip.Idle);

    }
    public override void Exit()
    {
        base.Exit();
    }

    public override void HandleMove()
    {
        base.HandleMove();
        fsm.ToNext(FSMState.Move);
    }
    public override void RemoveListener()
    {
        base.RemoveListener();
    }

    public override void Update()
    {
        base.Update();

    }
}
