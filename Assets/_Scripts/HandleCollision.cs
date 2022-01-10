using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollision : MonoBehaviour
{
    PinHandles pinHanle;
    // Start is called before the first frame update
    void Start()
    {
        pinHanle = FindObjectOfType<PinHandles>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("we hit handle");
        if (collision.collider.gameObject.CompareTag("ball"))
        {
          pinHanle. ballIsHere = true;
        }
        else
        {
            pinHanle.  ballIsHere = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        pinHanle.  ballIsHere = false;
    }
    private void OnCollisionStay(Collision collision)
    {
        Vector3 dir = collision.contacts[0].point - transform.position;
        dir = dir.normalized;
        pinHanle.diraction = dir;
    }
}
