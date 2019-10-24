using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experimental : MonoBehaviour
{

    public GameObject dragInEffect;
    public Animator animator;
    public float waitForThisAmount = 0.0f;
    void Start()
    {
        dragInEffect.SetActive(false);

        animator = dragInEffect.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))

        {
            dragInEffect.SetActive(true);
            animator.enabled = (true);
            StartCoroutine(routine: Duration());
        }

        IEnumerator Duration()
        {
            
                yield return new WaitForSeconds(waitForThisAmount);
                dragInEffect.SetActive(false);
        }
    }
}