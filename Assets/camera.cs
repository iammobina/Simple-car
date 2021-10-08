using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;
    void FixedUpdate()
    {
        Vector3 dpos = target.position + dist;
        Vector3 spos = Vector3.Lerp(transform.position, dpos, smoothSpeed * Time.deltaTime);
        transform.position = spos;
        transform.LookAt(lookTarget.position);
    }

}
