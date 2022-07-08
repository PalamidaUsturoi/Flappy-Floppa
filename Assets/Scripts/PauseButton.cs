using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PauseButton : MonoBehaviour
{
    public Action OnClick;
    // Start is called before the first frame update
    public void Pause(){
        if (OnClick != null)
        {
            OnClick.Invoke();
        }
    }
}
