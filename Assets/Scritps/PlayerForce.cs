using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{

    public Rigidbody2D Kneebody;
    Rigidbody2D Mainbody;

    public float power;

    public AudioSource mySource;
    public AudioClip jumpClip;
  

    // Start is called before the first frame update
    void Start()
    {
        Mainbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //Mainbody.velocity = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            mySource.PlayOneShot(jumpClip);
            Kneebody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Mainbody.velocity = new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Mainbody.velocity = new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Mainbody.velocity = new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Mainbody.velocity = new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            Mainbody.velocity = new Vector3(power, 0, 0);
        }
    }
}
