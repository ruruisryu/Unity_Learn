using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSound : MonoBehaviour
{ 
    public void OnCollisionEnter(Collision other)
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.Play();
    }
}
