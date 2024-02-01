using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private NPCStateMachine _stateMachine;
    private NPCConfig _config;

    public float Speed => _config.Speed;

    private void Awake()
    {
        TestInputManager test = GetComponent<TestInputManager>();

        _config = new NPCConfig();
        _stateMachine = new NPCStateMachine(this, test);
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
