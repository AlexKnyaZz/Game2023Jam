using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //Animator
    public Animator CharacterAnimator;
    //Animator

    //BackGround
    public GameObject BackGroundObject;

    public GameObject BackGroundSprite;

    public int BackGroundSize;

    public Vector3 BackGroundStartPosition;

    public float BackGroundOffset;

    public float Speed;

    public AudioSource WalkSound;
    //BackGround

    private void Awake()
    {
        for (int i = 0; i < BackGroundSize; i++)
        {
            GameObject NewBackGround = Instantiate(BackGroundSprite, BackGroundStartPosition, Quaternion.Euler(0, 0, -45), BackGroundObject.transform);

            BackGroundStartPosition.x += BackGroundOffset;
            BackGroundStartPosition.y += BackGroundOffset;
        }
    }

    private void Update()
    {
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
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 BackGroundPosition = BackGroundObject.transform.position;

            BackGroundObject.transform.position = new Vector3(BackGroundPosition.x - Speed, BackGroundPosition.y - Speed, BackGroundPosition.z);

            WalkSound.enabled = true;
        }
        else
        {
            WalkSound.enabled = false;
        }
    }
}
