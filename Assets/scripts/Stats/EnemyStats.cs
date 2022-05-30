using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats {
	public override void Die()
	{
		base.Die();
        Animator animator = GetComponent<Animator>();
        GetComponent<EnemyController>().lookRadius = 0;
        GetComponent<Enemy>().radius = 0;
        AnimationClip death = animator.runtimeAnimatorController.animationClips[3];
        animator.Play("die");
        StartCoroutine(DestroyTimer(death));
	}

    IEnumerator DestroyTimer(AnimationClip deathAnimation)
    {
        yield return new WaitForSeconds(deathAnimation.length + 10);
		Destroy(gameObject);
    }

}