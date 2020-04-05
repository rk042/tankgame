using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Camera fpscam;
    public float demage = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }
    }
    void shoot()
    {
        RaycastHit hit;

     //   if (Input.GetKey(KeyCode.Mouse0))
     //   {


            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit))
            {
                // Debug.Log(hit.transform.name);
               destroyEnime des= hit.transform.GetComponent<destroyEnime>();
                if(des!=null)
                {
                    des.teckdamge(demage);
                }
            }
     //   }

    }

}
