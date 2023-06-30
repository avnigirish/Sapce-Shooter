using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject missle;
    GameObject clone;
    float force = 20f;
    int count;
    float time;
    float pos;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        time = 0;
        Debug.Log("Time (start): " + time);
        pos = (transform.localScale.x / 2.0f)+ (transform.localScale.x / 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            transform.position = new Vector3(transform.position.x + (transform.localScale.x / 2.0f), transform.position.y, transform.position.z);
            count++;
        }
        else
        {
            transform.position = new Vector3(transform.position.x - (transform.localScale.x / 2.0f), transform.position.y, transform.position.z);
            count--;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clone = Instantiate(missle, transform.position, transform.rotation);
            //if (missle.transform.position.y <= -3.2)
            //{
                Debug.Log("If statement called");
                clone.GetComponent<Rigidbody>().AddForce(missle.transform.forward * force, ForceMode.Impulse);
            //}
            
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
