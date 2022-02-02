using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    [SerializeField]
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Welcome, " + Environment.UserName + "!\n- OS: " + Environment.OSVersion + "\n- Is64Bit: " + Environment.Is64BitOperatingSystem + "\n- Graphics Card: " + SystemInfo.graphicsDeviceName + "\n- Supports raytracing: " + SystemInfo.supportsRayTracing + "\n- Memory size: " + SystemInfo.systemMemorySize;
    }
}
