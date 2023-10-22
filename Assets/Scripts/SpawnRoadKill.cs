using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoadKill : MonoBehaviour
{
    //public GameObject Prefab;
    Rigidbody rb;
    bool turn;
    // Start is called before the first frame update
    void Start()
    {
        //Prefab.AddComponent<Rigidbody>();
        //Prefab = Instantiate(Prefab, new Vector3(0, 1, 0), transform.rotation);
        rb = GetComponent<Rigidbody>();
        transform.Rotate(0, 180, 0);
        turn = false;

    }

    // Update is called once per frame
    void Update()
    {/*
        if (!turn)
        {
            transform.Translate(new Vector3(0, 0, -1) * 40 * Time.deltaTime);
        }
        if (turn)
        {
            transform.Translate(new Vector3(0, 0, 1) * 40 * Time.deltaTime);

        }*/

        if (transform.position.x <= -15 && turn) {
            transform.Rotate(0, 180, 0);
            turn = false;
        }
        if (transform.position.x >= 35 && !turn) {
            turn = true;
            transform.Rotate(0, 180, 0);

        }
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        
           
    }
}
