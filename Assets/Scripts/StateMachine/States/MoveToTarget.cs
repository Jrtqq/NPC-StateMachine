using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : IState
{
    private IStateSwitcher _stateSwitcher;
    private StateMachineData _data;
    private NPC _npc;

    public MoveToTarget(IStateSwitcher stateMachine, StateMachineData data, NPC npc)
    {
        _stateSwitcher = stateMachine;
        _data = data;
        _npc = npc;
    }

    public void Enter()
    {
        Debug.Log("Начинаю идти куда-то");
    }

    public void Exit()
    {
        Debug.Log("Закончил идти куда-то");
    }

    public void Update()
    {
        Vector3 target = new(_data.Target.x, _npc.transform.position.y, _data.Target.z);
        _npc.transform.position = Vector3.MoveTowards(_npc.transform.position, target, _npc.Speed * Time.deltaTime);

        if (_npc.transform.position.x == _data.Target.x && _npc.transform.position.z == _data.Target.z)
        {
            _data.ReachTarget();
            _stateSwitcher.Switch<Rest>();
        }
    }
}
