using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed;
    public GameObject spotlight;
    public GameObject spotlight2;
    public AudioSource audioSource;
    public AudioSource lightson; 
    public AudioSource lightsoff;
    [SerializeField] 
    public Text speedtxt;
    [SerializeField]
    public Text acctxt;
    public float speed = 0;
    public System.DateTime startTime;
    Vector3 lastPosition = Vector3.zero;
    public float dt;

    // Start is called before the first frame update
    void Start()
    {
        spotlight.SetActive(false);
        spotlight2.SetActive(false);
        audioSource.Stop();
        lightson.Stop();
        lightsoff.Stop();
        startTime = System.DateTime.UtcNow;
        dt = Time.time;


    }
    

    // Update is called once per frame

        /*Debug.Log(collision.collider.name);
        if (collision.collider.tag == "ball")
        {
            Debug.Log("tu if");
            Vector3 x_add = new Vector3(-1,0,0);
            transform.position+=(x_add);
        }
        */
    
    /*
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "Sphere")
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
        }
    }
    */

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            spotlight.SetActive(true);
            spotlight2.SetActive(true);
            audioSource.Play();
            lightson.Play();
        }
        else if (Input.GetKeyUp(KeyCode.P))
        {
            spotlight.SetActive(false);
            spotlight2.SetActive(false);
            audioSource.Stop();
            lightsoff.Play();
        }
       transform.Translate(-Input.GetAxis("Vertical") * Time.deltaTime, 0f, Input.GetAxis("Horizontal")*Time.deltaTime);






    }
    void FixedUpdate()
    {
        var vel = GetComponent<Rigidbody>().velocity;
        var speedy = vel.sqrMagnitude;
        Debug.Log("speed" + speedy/100);


        System.TimeSpan ts = System.DateTime.UtcNow - startTime;
        Debug.Log(ts.Seconds.ToString());
        var acc = ((speedy)/ ts.Seconds) ;
        Debug.Log("Acceleration" + acc);

        speedtxt.text = ("Speed : " + speedy).ToString();
        acctxt.text = (" Acceleration : " + acc ).ToString();
    }
}


