using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingSc : MonoBehaviour
{
    //Sets the start score to 0
    public int score = 0;

    //Does to I could edit the font size
    GUIStyle guiStyle = new GUIStyle();


    // Sets the font size and makes the Score UI
    void OnGUI()
    {
        guiStyle.fontSize = 100;

        GUI.Label(new Rect(10, 10, 200, 40), "Score : " + score, guiStyle);
    }

    //Makes the player win when the score is high enough
    void Update()
    {
        if (score == 30)
        {
            FindObjectOfType<GameManager>().GameWon();
        }
    }

}