using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_hide : MonoBehaviour
{

    public float delayStart = 0.0f;
    public GameObject dragInEffect;
   // public Animator animator;
    public float waitForThisAmount = 0.0f;
    void Start()
    {
        dragInEffect.SetActive(false);

      //  animator = dragInEffect.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))

        {
          //  dragInEffect.SetActive(true);
            //animator.enabled = (true);
            StartCoroutine(routine: Delay());
        }

        IEnumerator Delay()
        {
            yield return new WaitForSeconds(delayStart);
            dragInEffect.SetActive(true);
            StartCoroutine(routine: Duration());
        }

    IEnumerator Duration()
        {
    
            yield return new WaitForSeconds(waitForThisAmount);
                dragInEffect.SetActive(false);
        }
    }
}

