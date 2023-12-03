using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerTrack : MonoBehaviour
{
    public Transform CharacterTransform;

    public Transform CameraTransform;

    private void Update()
    {
        CameraTransform.position = Vector3.Lerp(CameraTransform.position, new Vector3(CharacterTransform.position.x + 1, CharacterTransform.position.y - 1, -10), 1);
    }
}
