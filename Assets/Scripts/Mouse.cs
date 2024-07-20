using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Mouse : MonoBehaviour
{
    private Score score;
    private bool gameOver = false;

    void Start()
    {
        score = FindObjectOfType<Score>(); // Find the first Score script in the scene
    }

    private void OnMouseDown()
    {
        if (!gameOver) // Update score only if game is not over
        {
            score.AddPoints(10);
            Destroy(gameObject);
            Debug.Log("Destroy the gameobject");
            // Set gameOver flag to true here (if appropriate based on game logic)
        }
    }
}
