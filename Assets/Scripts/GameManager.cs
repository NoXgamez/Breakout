using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int blocksRemaining;
    public int timeRemaining;
    public int livesRemaining;

    public TMPro.TMP_Text txtTime;
    public TMPro.TMP_Text txtLives;

    private void Start()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
        blocksRemaining = blocks.Length;
    }

    private void CheckIfGameOver()
    {
        if(blocksRemaining <= 0)
        {
            //DEBUG - DO NOT REMOVE
            UnityEditor.EditorApplication.isPlaying = false;

            Application.Quit();
        }
        else if(livesRemaining <= 0 || timeRemaining <= 0)
        {

        }
    }

    public void OnBlockDestroyed()
    {
        blocksRemaining--;
        CheckIfGameOver();
    }

    public void OnLivesLost()
    {
        livesRemaining--;
        CheckIfGameOver();
    }
}
