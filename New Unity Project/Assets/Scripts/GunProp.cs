using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunProp : MonoBehaviour
{
    public GameObject gun;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            gun.SetActive(true);
        }
    }
}
