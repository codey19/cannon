using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool turn;
    // Start is called before the first frame update
    void Start()
    {
        turn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.y < -0.07)
            turn = false;
        if (transform.rotation.y >= 0.07)
            turn = true;
        //if(Input.GetKey(KeyCode.RightArrow))
        if(!turn)
            transform.Rotate(new Vector3(0, 1, 0), 10 * Time.deltaTime);
        if (turn)
        //else if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, -1, 0), 10 * Time.deltaTime);
        /*    transform.RotateAround(rotateAround, Vector3.left, 60 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.RotateAround(rotateAround, Vector3.right, 60 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            if (Input.GetKey(KeyCode.A))*/
        Debug.Log(transform.rotation.y);
    }
}
