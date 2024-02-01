using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : IState
{
    private IStateSwitcher _stateSwitcher;
    private StateMachineData _data;
    private NPC _npc;

    public Rest(IStateSwitcher stateMachine, StateMachineData data, NPC npc)
    {
        _stateSwitcher = stateMachine;
        _data = data;
        _npc = npc;
    }

    public void Enter()
    {
        Debug.Log("Начинаю отдыхать");
    }

    public void Exit()
    {
        Debug.Log("Закончил отдыхать");
    }

    public void Update()
    {
        if (_data.TargetExists == true)
            _stateSwitcher.Switch<MoveToTarget>();

        if (_data.IsBusy == true)
            _stateSwitcher.Switch<DoWork>();
    }
}
