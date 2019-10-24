using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_pulse : MonoBehaviour
{

    public float waitTime = 0.4f;
    public Renderer testRenderer;
    public float amount = 0.6f;
    
    
    void Start()
    {
      // if(set.Active(true)??
        
        testRenderer = GetComponent<MeshRenderer>();
        StartCoroutine(Flashing());


    }

    

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(amount);
            testRenderer.enabled = !testRenderer.enabled;

        }
    }
}
