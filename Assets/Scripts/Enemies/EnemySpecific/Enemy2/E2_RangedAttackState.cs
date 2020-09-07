﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_RangedAttackState : RangedAttackState
{
    private Enemy2 enemy;
    public E2_RangedAttackState(Entity entity, string animBoolName, Transform attackPosition, D_RangedAttackState stateData) : base(entity, animBoolName, attackPosition, stateData)
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

    public override void FinishAttack()
    {
        base.FinishAttack();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (isAnimationFinished)
        {
            if (isPlayerInMinAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.playerDetectedState);
            }
            else
            {
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void TriggerAttack()
    {
        base.TriggerAttack();
    }
}
