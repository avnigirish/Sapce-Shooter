using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    int count;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 1)
        {
            Debug.Log("z-axis: " + transform.position.z);
            Vector3 totalMovement1 = Vector3.zero;
            if (count < 4)
            {
                totalMovement1 += transform.right * -0.5f;
            }
            else if (count < 8 && count >= 4)
            {
                totalMovement1 += transform.right * 0.5f;
            }
            else if (count >= 8)
            {
                count = 0;
            }
            transform.SetPositionAndRotation(transform.position + totalMovement1 * 20f * Time.deltaTime, transform.rotation);
            if (transform.position.y < -20)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
