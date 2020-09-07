using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_LookForPlayerState : LookForPlayerState
{
    private Enemy1 enemy;
    public E1_LookForPlayerState(Entity entity, string animBoolName, D_LookForPlayerState stateData) : base(entity, animBoolName, stateData)
    {
        this.enemy = entity as Enemy1;
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
