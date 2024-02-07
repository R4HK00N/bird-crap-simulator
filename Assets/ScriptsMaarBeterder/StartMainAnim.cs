using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMainAnim : MonoBehaviour
{
    public Animator animator;

    public void Start()
    {
        animator.SetTrigger("StartAnim");
    }
}
