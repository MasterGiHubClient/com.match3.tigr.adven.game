using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using System;
using Coffee.UIExtensions;
using UnityEngine.Events;

public class VisualControl_States_TLGRadventure : MonoBehaviour
{
    [SerializeField] private VisualStatesUI_TLGRadventure[] uiSatatesToControl_TLGRadventure;
    [SerializeField] private UnityEvent onChangeState_TLGRadventure, onOn_TLGRadventure, onOff_TLGRadventure;

    [SerializeField] private bool _isActive_TLGRadventure = false;

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



    public bool isActive_TLGRadventure
    {
        set
        {
            _isActive_TLGRadventure = value;
            UpdateStateUI_TLGRadventure();
            onChangeState_TLGRadventure?.Invoke();
            if (value)
            {
                onOn_TLGRadventure?.Invoke();
            }
            else
            {
                onOff_TLGRadventure?.Invoke();
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
        get { return _isActive_TLGRadventure; }
    }


    private Tween animColor_Text_TLGRadventure;
    private Tween animColor_Image_TLGRadventure;

    private void UpdateStateUI_TLGRadventure()
    {

        if (animColor_Text_TLGRadventure != null)
            animColor_Text_TLGRadventure.Kill();

        if (animColor_Image_TLGRadventure != null)
            animColor_Image_TLGRadventure.Kill();


        foreach (var uiAccess in uiSatatesToControl_TLGRadventure)
        {
            if (_isActive_TLGRadventure)
            {
                if (uiAccess._text_TLGRadventure != null)
                    animColor_Text_TLGRadventure = DOTween.To(() => uiAccess._text_TLGRadventure.color, x => uiAccess._text_TLGRadventure.color = x, uiAccess.color_Enable_TLGRadventure, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_ChangeColor_TLGRadventure != null)
                    animColor_Image_TLGRadventure = DOTween.To(() => uiAccess._image_ChangeColor_TLGRadventure.effectColor, x => uiAccess._image_ChangeColor_TLGRadventure.effectColor = x, uiAccess.color_Enable_TLGRadventure, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_TLGRadventure != null)
                    uiAccess._image_TLGRadventure.sprite = uiAccess.sprite_Enable_TLGRadventure;

            }
            else
            {
                if (uiAccess._text_TLGRadventure != null)
                    animColor_Text_TLGRadventure = DOTween.To(() => uiAccess._text_TLGRadventure.color, x => uiAccess._text_TLGRadventure.color = x, uiAccess.color_Disable_TLGRadventure, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_ChangeColor_TLGRadventure != null)
                    animColor_Image_TLGRadventure = DOTween.To(() => uiAccess._image_ChangeColor_TLGRadventure.effectColor, x => uiAccess._image_ChangeColor_TLGRadventure.effectColor = x, uiAccess.color_Disable_TLGRadventure, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_TLGRadventure != null)
                    uiAccess._image_TLGRadventure.sprite = uiAccess.sprite_Disable_TLGRadventure;
            }
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

    public void SetState_TLGRadventure(bool state)
    {
        _isActive_TLGRadventure = state;
        UpdateStateUI_TLGRadventure();
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

    [ContextMenu("Toggle")]
    private void ToggleState_TLGRadventure()
    {
        isActive_TLGRadventure = !isActive_TLGRadventure;

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

[Serializable]
public class VisualStatesUI_TLGRadventure
{
    public TMP_Text _text_TLGRadventure;
    public Color color_Enable_TLGRadventure, color_Disable_TLGRadventure;
    public UIEffect _image_ChangeColor_TLGRadventure;
    public Image _image_TLGRadventure;
    public Sprite sprite_Enable_TLGRadventure, sprite_Disable_TLGRadventure;
}
