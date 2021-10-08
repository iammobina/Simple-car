using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polic : MonoBehaviour
{
    public AudioSource speed_camera;
    // Start is called before the first frame update
    void Start()
    {
        speed_camera.Stop();
}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("speed camera");
        if (other.tag == "car")
        {
            speed_camera.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
