using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackColor : MonoBehaviour
{
    //Creates a Camera object 
    public Camera cam;
    
    //Function that will be used when the button is clicked on 
    public void buttonPressed()
    {
        //Camera object allows us to use background component
        cam.backgroundColor = UnityEngine.Random.ColorHSV();
    }
}
