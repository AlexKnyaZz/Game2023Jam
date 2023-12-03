using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsSettings : MonoBehaviour
{
    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
}
