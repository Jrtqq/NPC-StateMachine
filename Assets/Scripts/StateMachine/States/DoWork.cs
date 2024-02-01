using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWork : IState
{
    private IStateSwitcher _stateSwitcher;
    private StateMachineData _data;
    private NPC _npc;

    public DoWork(IStateSwitcher stateMachine, StateMachineData data, NPC npc)
    {
        _stateSwitcher = stateMachine;
        _data = data;
        _npc = npc;
    }

    public void Enter()
    {
        Debug.Log("������� ���-�� ������");
    }

    public void Exit()
    {
        Debug.Log("�������� ���-�� ������");
    }

    public void Update()
    {
        if (_data.IsBusy == false)
            _stateSwitcher.Switch<Rest>();

        Debug.Log("����");
    }
}
