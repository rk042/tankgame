
using UnityEngine;

public class destroyEnime : MonoBehaviour
{
    public float helth = 10f;
    public GameObject destroyeffetc;
    public void teckdamge(float amount)
    {
        helth -= amount;
        if(helth<=0f)
        {
            die();

            Debug.Log("destroy");
        }
    }
    void die()
    {
        Instantiate(destroyeffetc, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }

}
