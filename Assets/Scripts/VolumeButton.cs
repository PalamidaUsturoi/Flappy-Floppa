using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeButton : MonoBehaviour
{
    public static  int volVal;
    public Sprite OnImage;
    public Sprite OffImage;
    // Start is called before the first frame update

    // Update is called once per frame
    void PressingVolume()
    {
       volVal = 1 - volVal;
       if(volVal == 0)
        {
            
        }
        else
        {
            
        }
    } 
}
