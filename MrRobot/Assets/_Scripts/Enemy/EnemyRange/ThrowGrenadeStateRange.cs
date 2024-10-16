using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ThrowGrenadeStateRange : EnemyState
{

    private EnemyRange _enemyRange;
    public ThrowGrenadeStateRange(Enemy enemyBase, EnemyStateMachine stateMachine, string animBoolName) : base(enemyBase, stateMachine, animBoolName)
    {
        _enemyRange = enemyBase as EnemyRange;
    }

    public override void AbilityTrigger()
    {
        base.AbilityTrigger();

        _enemyRange.ThrowGrenade();

        
    }

    public override void Enter()
    {
        base.Enter();

        _enemyRange.EnemyVisuals.EnableWeaponModel(false);
        _enemyRange.EnemyVisuals.EnableIK(false, false);
        _enemyRange.EnemyVisuals.EnableSecondaryWeaponModel(true);
    }

    public override void Exit()
    {
        base.Exit();

        //_enemyRange.EnemyVisuals.EnableWeaponModel(true);
        //_enemyRange.EnemyVisuals.EnableSecondaryWeaponModel(false);
    }

    public override void Update()
    {
        base.Update();

        Vector3 playerPos = _enemyRange.Player.position + Vector3.up;

        _enemyRange.FaceTarget(playerPos);
        _enemyRange.Aim.position = playerPos;

        if(triggerCalled)
        {
            stateMachine.ChangeState(_enemyRange.BattleStateRange);
        }
     }
}