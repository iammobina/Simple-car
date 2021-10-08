using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    public GameObject spotlight;
    public GameObject spotlight2;
    public AudioSource intunel;
    public AudioSource outtunel;
    // Start is called before the first frame update
    void Start()
    {
        spotlight.SetActive(false);
        spotlight2.SetActive(false);
        intunel.Stop();
        outtunel.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("malidam cylander ");
        if (other.tag == "car")
        {
            Debug.Log("tu if bara car cylander");
            spotlight.SetActive(true);
            spotlight2.SetActive(true);
            intunel.Play();
        }
    }



    private void OnTriggerExit(Collider other)
    {
        Debug.Log("kharej cylander");
        if (other.tag == "car")
        {
            Debug.Log("tu if bara car exit cylander");
            spotlight.SetActive(false);
            spotlight2.SetActive(false);
            outtunel.Play();
        }

    }

}
