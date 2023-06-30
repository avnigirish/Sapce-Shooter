using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMissile : MonoBehaviour
{
    public GameObject explosion;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 10)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        GameObject clone = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        time = 0;
        time = Time.deltaTime;
        Destroy(this.gameObject);
        if (time == 2)
        {
            Destroy(collision.collider.gameObject);
            Destroy(clone.gameObject);
        }


    }
}
