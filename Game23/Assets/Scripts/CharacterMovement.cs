using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Animator CharacterAnimator;

    public GameObject BackGround;

    public List<GameObject> Planes = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CharacterAnimator.SetTrigger("Walk");
            CharacterAnimator.ResetTrigger("Idle");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            CharacterAnimator.ResetTrigger("Walk");
            CharacterAnimator.SetTrigger("Idle");
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 BackGroundPosition = BackGround.transform.position;

            BackGround.transform.position = new Vector3(BackGroundPosition.x - 0.1F, BackGroundPosition.y - 0.1F, BackGroundPosition.z);

            for (int i = 0; i < Planes.Count; i++)
            {
                Vector3 BackGroundPosition1 = Planes[i].transform.position;

                Planes[i].transform.position = new Vector3(BackGroundPosition1.x - 0.1F, BackGroundPosition1.y - 0.1F, BackGroundPosition1.z);
            }
        }
    }
}
