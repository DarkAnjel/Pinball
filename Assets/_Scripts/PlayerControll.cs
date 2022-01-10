using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : Singleton<PlayerControll>
{
    [SerializeField]
    float pinIntForce;
    [SerializeField]
    Transform respawnPoint;
   
    [SerializeReference]
    float minRot, maxRot;
    GameObject ballPrefab;
    GameObject ball;
   
    
    // Start is called before the first frame update
    void Awake()
    {
        Initialized();
    }
    private void Initialized()
    {
        ballPrefab = Resources.Load("Ball/ball",typeof(GameObject))as GameObject;

      

    }
    // Update is called once per frame
    void Update()
    {
        
    }
   public void ShootTheBall(float percent)
    {
        float tempForce = (pinIntForce * percent) /100 ;
        print(tempForce);
        ball.GetComponent<Rigidbody>().AddForce(-Vector3.forward* tempForce, ForceMode.Impulse);
        print("We pushing the Ball");
    }
   public void CreateBall()
    {
        if (GameManager.Instance.currentHealth > 0)
        {
            ball = Instantiate(ballPrefab, respawnPoint.position, Quaternion.identity);
        }

       
    }
}
