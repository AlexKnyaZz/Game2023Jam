using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DevTool : MonoBehaviour
{
    public TMP_InputField TeleportInputField;

    public GameObject BackGroundObject;

    public void Teleport()
    {
        int Cord = int.Parse(TeleportInputField.text);

       BackGroundObject.transform.position = new Vector3(Cord, Cord, BackGroundObject.transform.position.z);
    }
}
