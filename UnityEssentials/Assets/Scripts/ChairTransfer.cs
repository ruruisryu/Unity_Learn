using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTransfer : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] private Vector3 destDir;
    [SerializeField] private float speed = 5.0f;
    void Start()
    {
        destDir = destination.transform.localPosition - transform.position;
    }

    void Update()
    {
        transform.position += destDir.normalized * Time.deltaTime * speed;
    }
}
