using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpinner : MonoBehaviour {

    public float speed = 10f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        transform.Rotate(Vector3.right, speed * Time.deltaTime);

    }
}
