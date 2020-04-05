using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    private Rigidbody rd;

    public float speed;
    public float rospeed;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
       
        //v3 = transform.position();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHori = Input.GetAxis("Horizontal");
        float MoveVert = Input.GetAxis("Vertical");
        Vector3 MoveMent = new Vector3(MoveHori, 0.0f, MoveVert);
        rd.AddForce(MoveMent * speed);
        transform.Rotate(Vector3.left * rospeed * Time.deltaTime);
    }
}
