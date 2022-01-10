using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.CompareTag("ball"))
        {
            Destroy(collision.collider.gameObject);
            GameManager.Instance.Lose();

        }
    }
}
