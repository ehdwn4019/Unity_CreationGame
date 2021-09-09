﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    [SerializeField]
    float speed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed, ForceMode.Impulse);
            
        }
    }
}
