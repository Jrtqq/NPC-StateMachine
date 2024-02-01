using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputManager : MonoBehaviour
{
    [SerializeField] private Transform _target;

    StateMachineData _data;

    public void Init(StateMachineData data)
    {
        _data = data;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _data.SetTarget(_target.position);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _data.SetBusy(true);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _data.SetBusy(false);
        }
    }
}
