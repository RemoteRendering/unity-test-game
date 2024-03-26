using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //range: -7 to -1
        gameObject.transform.position = new Vector3(-12, 17, Random.Range(-7.0f, -1.0f));
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
