using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeButton : MonoBehaviour
{
    public static  int volVal = 1;
    public Sprite OnImage;
    public Sprite OffImage;
    // Start is called before the first frame update

    // Update is called once per frame
    public void PressingVolume()
    {
       volVal = 1 - volVal;
       if(volVal == 0)
        {
            gameObject.GetComponent<Image>().sprite = OffImage;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = OnImage;
        }
    } 
}
