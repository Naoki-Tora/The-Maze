using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    //Sets the game to have been neither won nor lost YET
    bool gameOver = false;
    bool gameWon = false;

    //Makes us able to call the fitting UI when the game is
    public GameObject gameOverUI;
    public GameObject gameWonUI;

    //Makes the player loose the game, activates the UI, and unlocks the mouse
    public void GameOver()
    {
        if (!gameOver && !gameWon)
        {
           gameOver = true;
           gameOverUI.SetActive(true);
           Cursor.lockState = CursorLockMode.None;
        }

    }

    //Makes the player win the game, activates the UI, and unlocks the mouse
    public void GameWon()
    {
        if (!gameOver && !gameWon)
        {
            gameWon = true;
            gameWonUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        
    }

    //Makes the retry buttons work
    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //Makes the quit buttons work
    public void Quit()
    {
        Application.Quit();
    }

}
