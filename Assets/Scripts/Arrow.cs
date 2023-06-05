using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(-transform.localPosition);
    }
}
