using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : Singleton<UiManager>
{

    public GameObject[] healths;
    public Text score;
    public GameObject losePage;
    public Button restartBtt;
    void Start()
    {
        restartBtt.onClick.AddListener(Restart);
    }

    // Update is called once per frame
    void Update()
    {
        if(score)
        score.text = GameManager.Instance.score.ToString();
    }
   public void SetHealth()
    {
        for (int i = 0; i <healths.Length; i++)
        {
            if(i<=GameManager.Instance.currentHealth-1)
            {
                healths[i].SetActive(true);
            }
            else
            {
                healths[i].SetActive(false);
            }
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
