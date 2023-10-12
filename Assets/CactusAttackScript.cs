using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusAttackScript : MonoBehaviour
{
    public Transform cactus1;
    public Transform cactus2;
    public Animator cactus1Animator;
    public Animator cactus2Animator;

    public float attackDistance = 0.25f;

    void Update()
    {
        float distance = Vector3.Distance(cactus1.position, cactus2.position);

        if (distance < attackDistance)
        {
            if (cactus1Animator.GetBool("isAttacking") == false)
            {
                cactus1Animator.SetBool("isAttacking", true);
                cactus2Animator.SetBool("isAttacking", true);
            }
        }
        else
        {
            if (cactus1Animator.GetBool("isAttacking") == true)
            {
                cactus1Animator.SetBool("isAttacking", false);
                cactus2Animator.SetBool("isAttacking", false);
            }
        }
    }
}

