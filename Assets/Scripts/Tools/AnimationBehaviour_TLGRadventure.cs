using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class AnimationBehaviour_TLGRadventure : MonoBehaviour
{

    //[FormerlySerializedAs("gameObjectToMove_UrbanEnigma")]
    public GameObject gameObjectToMove_TLGRadventure;
    //[FormerlySerializedAs("targetPosition_UrbanEnigma")]
    public Transform targetPosition_TLGRadventure;
    //[FormerlySerializedAs("moveSpeed_UrbanEnigma")]
    public float moveSpeed_TLGRadventure = 1f;
    //[FormerlySerializedAs("easeType_UrbanEnigma")]
    public Ease easeType_TLGRadventure = Ease.Linear;
    //[FormerlySerializedAs("moveOnXAxis_UrbanEnigma")]
    public bool moveOnXAxis_TLGRadventure = true;
    //[FormerlySerializedAs("moveOnYAxis_UrbanEnigma")]
    public bool moveOnYAxis_TLGRadventure = true;
    //[FormerlySerializedAs("gameObjectToMove2_UrbanEnigma")]
    public GameObject gameObjectToMove2_TLGRadventure;
    //[FormerlySerializedAs("targetPosition2_UrbanEnigma")]
    public Transform targetPosition2_TLGRadventure;
    //[FormerlySerializedAs("on_first_object_start_UrbanEnigma")]
    public UnityEvent on_first_object_start_TLGRadventure;
    //[FormerlySerializedAs("on_first_object_finish_UrbanEnigma")]
    public UnityEvent on_first_object_finish_TLGRadventure;
    //[FormerlySerializedAs("on_second_object_start_UrbanEnigma")]
    public UnityEvent on_second_object_start_TLGRadventure;
    //[FormerlySerializedAs("on_second_object_finish_UrbanEnigma")]
    public UnityEvent on_second_object_finish_TLGRadventure;

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

    public void MoveObjectToTarget()
    {
        if (gameObjectToMove_TLGRadventure != null && targetPosition_TLGRadventure != null)
        {
            on_first_object_start_TLGRadventure?.Invoke();

            Vector3 targetPos = new Vector3(moveOnXAxis_TLGRadventure ? targetPosition_TLGRadventure.position.x : gameObjectToMove_TLGRadventure.transform.position.x,
                moveOnYAxis_TLGRadventure ? targetPosition_TLGRadventure.position.y : gameObjectToMove_TLGRadventure.transform.position.y,
                gameObjectToMove_TLGRadventure.transform.position.z);

            gameObjectToMove_TLGRadventure.transform.DOMove(targetPos, moveSpeed_TLGRadventure).SetEase(easeType_TLGRadventure).OnComplete(() =>
            {
                on_first_object_finish_TLGRadventure?.Invoke();
            });
        }

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

    public void MoveObjectToTarget2()
    {
        if (gameObjectToMove2_TLGRadventure != null && targetPosition2_TLGRadventure != null)
        {
            on_second_object_start_TLGRadventure?.Invoke();

            Vector3 targetPos2 = new Vector3(moveOnXAxis_TLGRadventure ? targetPosition2_TLGRadventure.position.x : gameObjectToMove2_TLGRadventure.transform.position.x,
                moveOnYAxis_TLGRadventure ? targetPosition2_TLGRadventure.position.y : gameObjectToMove2_TLGRadventure.transform.position.y,
                gameObjectToMove2_TLGRadventure.transform.position.z);

            gameObjectToMove2_TLGRadventure.transform.DOMove(targetPos2, moveSpeed_TLGRadventure).SetEase(easeType_TLGRadventure).OnComplete(() =>
            {
                on_second_object_finish_TLGRadventure?.Invoke();
            });
        }


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
