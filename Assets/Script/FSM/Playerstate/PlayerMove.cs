using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : EntityFSM
{
    public PlayerMove(Transform transform, PlayerFSM fsm)
    {
        this.transform = transform;
        this.fsm = fsm;

    }
    public override void AddListener()
    {
        base.AddListener();
    }

    Vector3 destination;
    bool isMove;
    public override void Enter()
    {
        base.Enter();

        fsm.animatorManager.play(PAClip.Run);
        fsm.agent.enabled = true;
        Debug.Log(C2S.Instance.MousePosition.ToString());
        destination = C2S.Instance.MousePosition;
        fsm.agent.SetDestination(destination);
        isMove = true;
    }

    public override void Exit()
    {
        base.Exit();
        isMove = false;

    }

    public override void RemoveListener()
    {
        base.RemoveListener();
    }

    public override void Update()
    {
        base.Update();
        if(isMove)
        {
            if (fsm.agent.pathStatus!=NavMeshPathStatus.PathComplete)
            {
                fsm.ToNext(FSMState.Idle);
                
            }
            float dev = Vector3.Distance(this.transform.position, destination);
            if(dev<=0.15f)
            {
                fsm.agent.SetDestination(transform.position);
                fsm.ToNext(FSMState.Idle);

            }

        }
    }

    public override void HandleMove()
    {
        base.HandleMove();
        destination = C2S.Instance.MousePosition;
        Debug.Log("new" + destination.ToString());
        fsm.agent.SetDestination(destination);
    }
}
