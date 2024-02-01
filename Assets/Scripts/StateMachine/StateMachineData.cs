using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineData
{
    public StateMachineData(TestInputManager test) 
    {
        test.Init(this);
    }

    public Vector3 Target { get; private set; }
    public bool TargetExists { get; private set; } = false;
    public bool IsBusy { get; private set; } = false;

    public void SetTarget(Vector3 target)
    {
        TargetExists = true;
        Target = target;
    }

    public void ReachTarget()
    {
        TargetExists = false;
        Target = new(0,0,0);
    }

    public void SetBusy(bool value)
    {
        IsBusy = value;
    }
}
