using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x>=-12)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-90, 45, 0.0f), 60.0f * Time.deltaTime);
            transform.Translate(Vector3.left * 7f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 12)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-90, -45, 0.0f), 60.0f * Time.deltaTime);
            transform.Translate(Vector3.right * 7f * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-90, 0, 0.0f), 30.0f * Time.deltaTime);
        }
        
    }

}
