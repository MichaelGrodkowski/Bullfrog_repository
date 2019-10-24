using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Disable_effect : MonoBehaviour
{
    public GameObject toDisable;
    void Start()
    {
        toDisable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            toDisable.SetActive(true);
            print("you pressed the A key");
        }
    }

}
 
