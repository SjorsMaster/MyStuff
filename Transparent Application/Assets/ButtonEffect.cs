using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEffect : MonoBehaviour
{

    [DllImport("user32.dll")]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);


    [SerializeField]
    Camera cam;


    public void EpicButtonClick(int opt)
    {
        if (opt == 1)
        {
            cam.clearFlags = CameraClearFlags.Nothing;
        }
        else
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
        }
    }

    public void EpicDisplayText(string text)
    {
        MessageBox(new IntPtr(0), text, "Hi, " + Environment.UserName + "!", 0);

    }
}
