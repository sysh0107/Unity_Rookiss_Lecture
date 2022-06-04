using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManger
{
    public Action KeyAction = null;

    public void OnUpdate()
    {
        if (Input.anyKey == false) return;

        if(KeyAction != null)
        {
            KeyAction.Invoke();
        }
    }
}
