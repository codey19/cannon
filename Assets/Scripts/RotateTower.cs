using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTower : MonoBehaviour
{
    Vector3 rotateAround;
    // Start is called before the first frame update
    void Start()
    {
        rotateAround = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKey(KeyCode.DownArrow)) // && transform.rotation.eulerAngles.x < 14
            transform.RotateAround(rotateAround, Vector3.left, 60 * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))// && transform.rotation.eulerAngles.x > -160
            transform.RotateAround(rotateAround, Vector3.right, 60 * Time.deltaTime);
        Debug.Log(transform.rotation.eulerAngles.x);

    }
}
