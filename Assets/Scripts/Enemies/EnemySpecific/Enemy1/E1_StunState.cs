using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_StunState : StunState
{
    private Enemy1 enemy;
    public E1_StunState(Entity entity, string animBoolName, D_StunState stateData) : base(entity, animBoolName, stateData)
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

        if (isStunTimeOver)
        {
            if (performCloseRangeAction)
            {
                enemy.stateMachine.ChangeState(enemy.meleeAttackState);
            }
            else if (isPlayerInMinAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.chargeState);
            }
            else
            {
                enemy.lookForPlayerState.setTurnImmideately(true);
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }
        }
        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
