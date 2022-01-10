using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    BouncerObject bouncerPoint;
    

  
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 dir = collision.contacts[0].point - transform.position;
        dir =- dir.normalized;
        collision.collider.GetComponent<Rigidbody>().AddForce(dir * bouncerPoint.bounceForce, ForceMode.Impulse);
        GameManager.Instance.score += bouncerPoint.score;
    }
}
