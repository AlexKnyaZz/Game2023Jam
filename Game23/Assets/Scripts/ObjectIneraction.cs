using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIneraction : MonoBehaviour
{
    public Camera Camera;

    public BoxCollider CatCollider;

    private Ray ray;
    private RaycastHit hit;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000f))
            {
                if (hit.collider != null)
                {
                    Debug.Log(2);
                }
            }
        }
    }
}
