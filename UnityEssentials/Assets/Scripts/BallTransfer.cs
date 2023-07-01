using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransfer : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotationChange;

    void Update()
    {
        rotationChange += rotationChange * Time.deltaTime;
        transform.localScale += scaleChange * Time.deltaTime;
        transform.position += positionChange * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotationChange);
    }
}
