using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public TMP_Text bestScore;
    public void Start()
    {
        bestScore.SetText("Your best score: " + HighScore.score);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("_Scene_Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
