using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_off_wave : MonoBehaviour
{
    public GameObject dragInEffect;
    public Animator animator;

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

        }
        /*else
        {
            dragInEffect.SetActive(false);
            animator.enabled = (false);

        }
    */}
}
