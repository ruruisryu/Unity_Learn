using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class rotationTest : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float yAngle = 0f;

    void Update()
    {
        yAngle += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0f, yAngle, 0f));
    }
}
