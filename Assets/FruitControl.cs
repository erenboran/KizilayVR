using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitControl : MonoBehaviour
{

    Rigidbody rigid;
    

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();

    }


    private void OnCollisionEnter(Collision collision)
    {
        rigid.useGravity = true;
    }
}
