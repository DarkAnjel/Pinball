using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinHandles : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform leftHandle;
    [SerializeField]
    Transform rightHandle;
    float startTime;
    bool isLeft;
    public bool ballIsHere;
    Quaternion startRotLeft;
    Quaternion startRotRight;
    public Vector3 diraction;
    bool canUse;
    void Start()
    {
        startRotLeft = leftHandle.rotation;
        startRotRight = rightHandle.rotation;
        canUse = true;
    }

    // Update is called once per frame
    void Update()
    {
       if(canUse)
        {
            HandleInput();
        }
        HandleMove();
    }
    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            startTime = Time.time + 0.2f;

            isLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            startTime = Time.time + 0.2f;

            isLeft = false;

        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            if (ballIsHere)
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody>().AddForce(diraction * 20, ForceMode.Impulse);
            }
            canUse = false;
        }
        
        StartCoroutine(CoolDown());
    }
    void HandleMove()
    {
        if (Time.time < startTime)
        {
            if (isLeft)
            {
                leftHandle.transform.Rotate(Vector3.up * Time.deltaTime * -300);
            }
            else
            {
                rightHandle.transform.Rotate(Vector3.up * Time.deltaTime * -300);
            }

        }
        else
        {
            leftHandle.rotation = startRotLeft;
            rightHandle.rotation = startRotRight;
        }
    }
    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(0.8f);
        canUse = true;
        
    }

}
