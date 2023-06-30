using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ship;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        InvokeRepeating("SpawnEnemy", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        if (count < 4)
        {
            transform.position = new Vector3(7f, transform.position.y, transform.position.z);
            count++;
        }
        else if (count < 8 && count >= 4)
        {
            transform.position = new Vector3(-7f, transform.position.y, transform.position.z);
            count++;
        }
        else if (count >= 8)
        {
            count = 0;
        }
        GameObject clone = Instantiate(ship, transform.position, transform.rotation);
        clone.GetComponent<Rigidbody>().AddForce(Vector3.forward * 0.5f * Time.deltaTime, ForceMode.Force);

    }
}
