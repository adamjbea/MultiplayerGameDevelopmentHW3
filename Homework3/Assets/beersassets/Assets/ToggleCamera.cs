using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCamera : MonoBehaviour {
    public GameObject backCam;
    public GameObject skyCam;
    bool skyViewOn = false;
    
    void Start() {
        skyCam.SetActive(false);
        backCam.SetActive(true);
    }

    // Update is called once per frame
    void Update() {
        //if skyCam is on, switch to backCam
        if (Input.GetKeyDown(KeyCode.C)) {
            if (skyViewOn) {
                backCam.SetActive(true);
                skyCam.SetActive(false);
                skyViewOn = false;
            //otherwise the backCam is on, switch to skyCam
            } else {
                backCam.SetActive(false);
                skyCam.SetActive(true);
                skyViewOn = true;
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
   