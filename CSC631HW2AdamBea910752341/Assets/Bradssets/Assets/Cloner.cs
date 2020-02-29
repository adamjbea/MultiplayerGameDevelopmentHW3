using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloner : MonoBehaviour
{
    //Creates a GameObject, what will be cloned
    public GameObject subject;

    //clone fucntion takes the new 3d object created in update and instantiates it 
    public void Clone(Vector3 position)
    {
        Instantiate(subject).transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        //If right mouse is clicked then ...
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //... a new variable is made that holds a position and perspective of the main camera
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            
            //Creates a new 3d object with the x,y, and z  and send it to the clone()
            Clone(new Vector3(worldPoint.x, worldPoint.y, worldPoint.z));
        }
    }
}
