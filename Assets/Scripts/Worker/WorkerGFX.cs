using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class WorkerGFX : MonoBehaviour
{
    public AIPath aiPath;
    public Animator anim;

    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(6f, 6f, 1f);
            anim.SetBool("IsWalking", true);
        }
        else if(aiPath.desiredVelocity.x <= -0.01f)
        { 
            transform.localScale = new Vector3(-6f, 6f, 1f);
            anim.SetBool("IsWalking", true);
        }
        else if(aiPath.desiredVelocity == Vector3.zero)
        {
            anim.SetBool("IsWalking", false);
        }
    }
}
