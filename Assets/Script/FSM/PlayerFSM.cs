using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 角色有限状态机的管理类
/// </summary>
public class PlayerFSM : MonoBehaviour
{
    public NavMeshAgent agent;
    public AnimatorManager animatorManager;
    Dictionary<FSMState, EntityFSM> playerState = new Dictionary<FSMState, EntityFSM>();
    FSMState currentState = FSMState.None;


    void Start()
    {
        animatorManager = transform.GetComponent<AnimatorManager>();
        agent = transform.GetComponent<NavMeshAgent>();
        playerState[FSMState.Idle] = new PlayerIdle(transform, this);
        playerState[FSMState.Move] = new PlayerMove(transform, this);
        ToNext(FSMState.Idle);
    }

    private void Update()
    {
        HandleCMD();
        if (currentState != FSMState.None)
        {
            playerState[currentState].Update();
        }
    }

    public void ToNext(FSMState nextState)
    {
        if (currentState != FSMState.None)
        {
            playerState[currentState].Exit();
        }
        playerState[nextState].Enter();
        currentState = nextState;
    }

    public void HandleCMD()
    {
        playerState[currentState].HandleCMD();
    }
}
