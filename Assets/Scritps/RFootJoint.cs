using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFootJoint : MonoBehaviour
{

    public Rigidbody2D LkneeJoint;
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

        if (Input.GetKey(KeyCode.K))
        {
            Mainbody.velocity = new Vector3(power, power, 0);
        }
        
    }
}
