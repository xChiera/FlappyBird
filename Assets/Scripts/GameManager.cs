using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text text;

    void Start()
    {
    }
    void Update()
    {
    }

    public void UpdateScore(){
        score++;
        text.text=score.ToString();
    }
    public void RestartSceen(){
        SceneManager.LoadScene(0);  
    }
}
