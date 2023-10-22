using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject ChickenPrefab;
    public GameObject CatPrefab;
    public GameObject LionPrefab;
    public GameObject DogPrefab;
    public GameObject PenguinPrefab;
    public GameObject cannon;
    public GameObject spawn;
    public int i;
    Rigidbody rb;
    Vector3 rotatearound;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        ChickenPrefab.AddComponent<Rigidbody>();//0
        CatPrefab.AddComponent<Rigidbody>();//1
        LionPrefab.AddComponent<Rigidbody>();//2
        DogPrefab.AddComponent<Rigidbody>();//3
        PenguinPrefab.AddComponent<Rigidbody>();//4
        rotatearound = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i == 0)
            {
                ChickenPrefab = Instantiate(ChickenPrefab, spawn.transform.position, transform.rotation);
                rb = ChickenPrefab.GetComponent<Rigidbody>();
                //rb.AddRelativeForce(Vector3.forward * 5000);
            }else if(i == 1){
                CatPrefab = Instantiate(CatPrefab, spawn.transform.position, transform.rotation);
                rb = CatPrefab.GetComponent<Rigidbody>();
               // rb.AddRelativeForce(Vector3.forward * 5000);
            }else if (i == 2) {
                LionPrefab = Instantiate(LionPrefab, spawn.transform.position, transform.rotation);
                rb = LionPrefab.GetComponent<Rigidbody>();
                //rb.AddRelativeForce(Vector3.forward * 5000);
            }
            else if (i == 3)
            {
                DogPrefab = Instantiate(DogPrefab, spawn.transform.position, transform.rotation);
                rb = DogPrefab.GetComponent<Rigidbody>();
               // rb.AddRelativeForce(Vector3.forward * 5000);
            }
            else if (i == 4)
            {
                PenguinPrefab = Instantiate(PenguinPrefab, spawn.transform.position, transform.rotation);
                rb = PenguinPrefab.GetComponent<Rigidbody>();
                //rb.AddRelativeForce(Vector3.forward * 5000);
            }
            rb.AddRelativeForce(Vector3.forward * 4000);

        }
        /*if (Input.GetKeyDown(KeyCode.R)) {
            if (i == 4)
                i = 0;
            else
                i++;
        }*/
        i = Random.Range(0, 4);
            
    }
}
