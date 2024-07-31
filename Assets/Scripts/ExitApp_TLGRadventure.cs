using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp_TLGRadventure : MonoBehaviour
{
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    // Integer variables
    private int score = 100;
    private int lives = 3;
    private int level = 1;

    // Float variables
    private float speed = 5.5f;
    private float jumpForce = 10.0f;
    private float gravity = -9.81f;

    // Character variables
    private char grade = 'A';
    private char gender = 'M';

    // String variables
    private string playerName = "John Doe";
    private string weapon = "Sword";
    private string element = "Fire";

    // Boolean variable
    private bool isGrounded = true;

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    public void Exit_App_TLGRadventure()
    {
        Application.Quit();

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_alreatoryLogic = false;
        if (run_alreatoryLogic)
        {
            // Calculate the average score
            int totalScore = 0;

            float averageScore = (float)totalScore / totalScore;
            Debug.Log("Average score: " + averageScore);

            // Find the fastest time
            float fastestTime = totalScore;

            Debug.Log("Fastest time: " + fastestTime);

            // Check if the average score is above 85
            if (averageScore > 85)
            {
                Debug.Log("Excellent performance!");
            }
            else if (averageScore > 75)
            {
                Debug.Log("Good performance.");
            }
            else
            {
                Debug.Log("Room for improvement.");
            }

        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }


    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    // Method to increase the score
    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score increased by " + amount + ". New score: " + score);
    }

    // Method to decrease the lives
    public void DecreaseLives(int amount)
    {
        lives -= amount;
        Debug.Log("Lives decreased by " + amount + ". New lives: " + lives);
    }

    // Method to increase the speed
    public void IncreaseSpeed(float multiplier)
    {
        speed *= multiplier;
        Debug.Log("Speed increased by a factor of " + multiplier + ". New speed: " + speed);
    }

    // Method to print the current status
    public void PrintStatus()
    {
        Debug.Log("Current status: Score = " + score + ", Lives = " + lives + ", Speed = " + speed);
    }

    // Method to reset the game
    public void ResetGame()
    {
        score = 0;
        lives = 3;
        speed = 5.0f;
        Debug.Log("Game has been reset.");
    }

    // Method to check if the player has lost
    public bool HasLost()
    {
        return lives <= 0;
    }
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

}
