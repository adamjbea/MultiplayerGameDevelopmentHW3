using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChange : MonoBehaviour {
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    private int matChoice = 1;
    Renderer rend;
   
    void Start() {
        rend = GetComponent<Renderer>();
        rend.material = mat3;
    }

    void Update() {
        //get random texture on keypress
        if (Input.GetKeyDown(KeyCode.T)) {
            if (matChoice == 1) {
                rend.material = mat1;
                matChoice++;
            } 
            else if (matChoice == 2) {
                rend.material = mat2;
                matChoice++;
            }
            else if (matChoice == 3) {
                rend.material = mat3;
                matChoice++;
            } else {
                rend.material = mat4;
                matChoice = 1;
            } 
        }
    }
}
