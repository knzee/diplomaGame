using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_DeadState : DeadState
{
    private Enemy2 enemy;
    public E2_DeadState(Entity entity, string animBoolName, D_DeadState stateData) : base(entity, animBoolName, stateData)
    {
        this.enemy = entity as Enemy2;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
