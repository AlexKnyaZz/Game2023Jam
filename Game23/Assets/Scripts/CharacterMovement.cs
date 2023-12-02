using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Animator CharacterAnimator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(0);
            CharacterAnimator.SetTrigger("Walk");
            CharacterAnimator.ResetTrigger("Idle");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log(1);
            CharacterAnimator.ResetTrigger("Walk");
            CharacterAnimator.SetTrigger("Idle");
        }
    }
}
