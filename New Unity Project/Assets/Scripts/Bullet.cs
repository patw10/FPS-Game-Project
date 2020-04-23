using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject BulletHole;
    private Vector3 Location;

    void OnCollisionEnter(Collision collision)
    {
        Location = collision.contacts[0].point;
        GameObject.Instantiate(BulletHole,Location,collision.transform.rotation);
    }

    void FixedUpdate()
    {
        Destroy(BulletHole.gameObject, 1);
    }
}
