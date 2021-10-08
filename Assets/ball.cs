using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("malidam");
        Debug.Log(collision.collider.name);
        if (collision.collider.tag == "ball")
        {
            Debug.Log("tu if");
            transform.Translate(-Input.GetAxis("Vertical") * Time.deltaTime, 0f, Input.GetAxis("Horizontal") * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
