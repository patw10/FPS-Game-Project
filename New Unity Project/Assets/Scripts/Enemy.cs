using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            animator.SetBool("Die", true);
        }
    }
    void Update()
    {
        transform.LookAt(Camera.main.transform.position, Vector3.up);
    }
}
