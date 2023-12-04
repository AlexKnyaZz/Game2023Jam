using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    //Animator
    public Animator CharacterAnimator;
    //Animator

    public GameObject BackGroundObject;

    public float Speed;

    public Event EventScript;

    public Transform CharacterTransform;

    public Transform ParentTransform;

    public Vector3 NativeCord;

    public float BalanceModifier;

    public float number;

    public float Modifier;

    private void Update()
    {
        if (!(Input.GetKey(KeyCode.Q)) && !(Input.GetKey(KeyCode.E)))
        {
            if (BalanceModifier < 0)
            {
                BalanceModifier -= number;
            }
            else
            {
                BalanceModifier += number;
            }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            BalanceModifier -= number * Modifier;
        }

        if (Input.GetKey(KeyCode.E))
        {
            BalanceModifier += number * Modifier;
        }

        CharacterTransform.rotation = Quaternion.Euler(0f, 0f, -BalanceModifier);

        ParentTransform.position = new Vector3(NativeCord.x + BalanceModifier * 0.04F, NativeCord.y, NativeCord.z);

        if (Mathf.Abs(BalanceModifier) > 20)
        {
            CharacterAnimator.SetTrigger("Off");
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {
            CharacterAnimator.ResetTrigger("Idle");
            CharacterAnimator.SetTrigger("Walk");
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.anyKey == false)
        {
            CharacterAnimator.SetTrigger("Idle");
            CharacterAnimator.ResetTrigger("Walk");
        }
    }

    private void FixedUpdate()
    {
        Vector3 BackGroundPosition = BackGroundObject.transform.position;

        BackGroundObject.transform.position = new Vector3(BackGroundPosition.x - Speed, BackGroundPosition.y - Speed, BackGroundPosition.z);
    }
}
