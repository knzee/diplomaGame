using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_PlayerDetectedState : PlayerDetectedState
{
    private Enemy2 enemy;
    public E2_PlayerDetectedState(Entity entity, string animBoolName, D_PlayerDetected stateData) : base(entity, animBoolName, stateData)
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

        if (performCloseRangeAction)
        {
            if (Time.time >= enemy.dodgeState.startTime + enemy.dodgeStateData.dodgeCoolDown)
            {
                enemy.stateMachine.ChangeState(enemy.dodgeState);
            }
            else
            {
                enemy.stateMachine.ChangeState(enemy.meleeAttackState);
            }
            
        }
        else if (performLongRangeAction)
        {
            enemy.stateMachine.ChangeState(enemy.rangedAttackState);
        }
        else if (!isPlayerInMaxAgroRange)
        {
            enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
