using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public List<GameObject> cubeGod = new List<GameObject>();


    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            foreach(GameObject cube in cubeGod)
            {
                cube.GetComponent<Animator>().Play("Start");
            }
            
        }
    }
}
