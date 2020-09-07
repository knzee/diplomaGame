using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_LookForPlayerState : LookForPlayerState
{
    private Enemy2 enemy;
    public E2_LookForPlayerState(Entity entity, string animBoolName, D_LookForPlayerState stateData) : base(entity, animBoolName, stateData)
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

        if (isPlayerInMinAgroRange)
        {
            enemy.stateMachine.ChangeState(enemy.playerDetectedState);
        }
        else if (isAllTurnTimeDone)
        {
            enemy.stateMachine.ChangeState(enemy.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
