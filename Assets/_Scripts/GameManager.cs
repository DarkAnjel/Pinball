using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    LevelObj currentLevel;
    public float currentHealth { get; private set; }
    public float score { get;  set; }

    // Start is called before the first frame update
    void Start()
    {
        Initialized();
    }
    private void Initialized()
    {
        currentLevel = Resources.Load("Level1/Level1", typeof(LevelObj)) as LevelObj;
        currentHealth = currentLevel.Health;
        UiManager.Instance.SetHealth();
        PlayerControll.Instance.CreateBall();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lose()
    {
        if(currentHealth!=0)
        {
            currentHealth--;
            print(currentHealth);
            if(currentHealth==0)
            {
                print("Player Lose all health");
                UiManager.Instance.losePage.SetActive(true);
            }
            else
            {
                PlayerControll.Instance.CreateBall();
            }
        }
        UiManager.Instance.SetHealth();
    }
}
