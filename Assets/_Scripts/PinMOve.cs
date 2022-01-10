using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinMOve : MonoBehaviour
{
    Vector3 intPos;
    Vector3 releasePos;
    [SerializeField]
    Vector3 nextPos;
    float startTime;
    [SerializeField]
     float speed;
    bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        Initialized();

    }
    private void Initialized()
    {
        intPos = transform.position;

    }
   
    void Update()
    {
        PinString();
      }
    void PinString()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            float tempTime = (Time.time - startTime) * speed;
            Vector3 pos = Vector3.Lerp(intPos, nextPos, tempTime);
            transform.position = pos;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            releasePos = transform.position;
            Vector3 pos = Vector3.Lerp(nextPos, intPos, 1);
            transform.position = pos;

            canShoot = true;

        }
        if (transform.position == intPos)
        {
            if (canShoot)
            {
                print("BackTosamePos");
                float temp = (releasePos.z - intPos.z) * 100;
                print(temp);
                PlayerControll.Instance.ShootTheBall(temp);
            }
            canShoot = false;
        }
    }
}
