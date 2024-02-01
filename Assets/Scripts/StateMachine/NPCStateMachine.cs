using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NPCStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public NPCStateMachine(NPC npc, TestInputManager test)
    {
        StateMachineData data = new StateMachineData(test);

        _states = new List<IState>()
        {
            new Rest(this, data, npc), 
            new DoWork(this, data, npc), 
            new MoveToTarget(this, data, npc)
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void Update() => _currentState.Update();

    public void Switch<State>() where State : IState
    {
        IState state = _states.FirstOrDefault(x => x is State) ?? throw new ArgumentException();

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }
}
