using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleShine : MonoBehaviour {
    private bool toggleShine = true;
    Renderer rend;

    // Start is called before the first frame update
    void Start() {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Y)) {
            if (toggleShine) {
                rend.material.SetFloat("_Glossiness", 0.5f);
                toggleShine = !toggleShine;
            } else {
                rend.material.SetFloat("_Glossiness", 0.0f);
                toggleShine = !toggleShine;
            }
        }
    }
}
