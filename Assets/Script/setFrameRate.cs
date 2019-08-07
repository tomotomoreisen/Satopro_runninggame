using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFrameRate : MonoBehaviour {
    public int targerFrameRate = 60;
    void Awake()
    {
        if (targerFrameRate > 0)
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = targerFrameRate;
        }
    }
}
