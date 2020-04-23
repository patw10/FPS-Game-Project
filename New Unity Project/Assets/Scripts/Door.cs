using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Open", true);
        }
        if(other.gameObject.tag == "Bullet")
        {
            animator.SetBool("OpenG", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Open", false);
        }
    }
}
