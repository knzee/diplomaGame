using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_DodgeState : DodgeState
{
    private Enemy2 enemy;
    public E2_DodgeState(Entity entity, string animBoolName, D_DodgeState stateData) : base(entity, animBoolName, stateData)
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

        if (isDodgeOver)
        {
            if (isPlayerInMaxAgroRange && performCloseRangeAction)
            {
                enemy.stateMachine.ChangeState(enemy.meleeAttackState);
            }
            else if (isPlayerInMaxAgroRange && !performCloseRangeAction)
            {
                enemy.stateMachine.ChangeState(enemy.rangedAttackState);
            }
            else if (!isPlayerInMaxAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }

        
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
