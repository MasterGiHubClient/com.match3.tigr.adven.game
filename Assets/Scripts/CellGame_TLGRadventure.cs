using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CellGame_TLGRadventure : MonoBehaviour
{
    [SerializeField] private GameObject icon_p_TLGRadventure;
    [SerializeField] public Image image_of_cell_TLGRadventure;
    [SerializeField] private CellGame_TLGRadventure cell_up_TLGRadventure;
    [SerializeField] private CellGame_TLGRadventure cell_right_TLGRadventure;
    [SerializeField] private CellGame_TLGRadventure cell_down_TLGRadventure;
    [SerializeField] private CellGame_TLGRadventure cell_left_TLGRadventure;


    [HideInInspector] public Sprite icon_for_cell_TLGRadventure;



    public static Action<Sprite, int> on_set_icon_TLGRadventure = delegate { };
    public static Action<bool> show_icon_TLGRadventure = delegate { };
    private static CellGame_TLGRadventure currentCell_TLGRadventure = null;
    public static Action<Action> isNotFound_TLGRadventure = delegate { };



    [HideInInspector] public bool is_showing_icon_TLGRadventure = false;
    private LevelData_TLGRadventure levelData_TLGRadventure = new LevelData_TLGRadventure();





    private GridLayoutGroup gridLayout_TLGRadventure;
    private int gridWidth_TLGRadventure = 6;


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



    private void Start()
    {
        // Get the Grid Layout component
        gridLayout_TLGRadventure = GetComponentInParent<GridLayoutGroup>();

        // Find the adjacent buttons
        FindAdjacentButtons_TLGRadventure();
    }


    private void OnEnable()
    {
        on_set_icon_TLGRadventure += SetUpIconForGame_TLGRadventure;
        show_icon_TLGRadventure += Show_Icon_TLGRadventure;
        isNotFound_TLGRadventure += IsNotFound_TLGRadventure;

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
    private void OnDisable()
    {
        on_set_icon_TLGRadventure -= SetUpIconForGame_TLGRadventure;
        show_icon_TLGRadventure -= Show_Icon_TLGRadventure;
        isNotFound_TLGRadventure -= IsNotFound_TLGRadventure;


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


    private void SetUpIconForGame_TLGRadventure(Sprite icon, int index)
    {
        if ((this.gameObject.transform.GetSiblingIndex() + 1) == index)
        {
            icon_for_cell_TLGRadventure = icon;
            image_of_cell_TLGRadventure.sprite = icon_for_cell_TLGRadventure;
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
    private void IsNotFound_TLGRadventure(Action callback)
    {
        if (!is_showing_icon_TLGRadventure)
        {
            callback?.Invoke();
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

    public void Show_Icon_TLGRadventure(bool state)
    {
        icon_p_TLGRadventure.SetActive(state);
        is_showing_icon_TLGRadventure = state;
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
    public void onCellDown_TLGRadventure()
    {
        Manager_Game_TLGRadventure.instance?.OnCellSelected(this);
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

    public void OnCellDirectionDrag_TLGRadventure(Directions_TLGRadventure direction)
    {
        Image image_c = null;
        switch (direction)
        {
            case Directions_TLGRadventure.up:
                if (cell_up_TLGRadventure != null)
                {
                    image_c = cell_up_TLGRadventure.image_of_cell_TLGRadventure;
                    cell_up_TLGRadventure.AssignNewCard_OrientMind(image_of_cell_TLGRadventure);
                    AssignNewCard_OrientMind(image_c);
                    cell_up_TLGRadventure.CheckIfMatch_OrientMind();
                }
                break;
            case Directions_TLGRadventure.right:
                if (cell_right_TLGRadventure != null)
                {

                    image_c = cell_right_TLGRadventure.image_of_cell_TLGRadventure;
                    cell_right_TLGRadventure.AssignNewCard_OrientMind(image_of_cell_TLGRadventure);
                    AssignNewCard_OrientMind(image_c);
                    cell_right_TLGRadventure.CheckIfMatch_OrientMind();

                }
                break;
            case Directions_TLGRadventure.left:
                if (cell_left_TLGRadventure != null)
                {

                    image_c = cell_left_TLGRadventure.image_of_cell_TLGRadventure;
                    cell_left_TLGRadventure.AssignNewCard_OrientMind(image_of_cell_TLGRadventure);
                    AssignNewCard_OrientMind(image_c);
                    cell_left_TLGRadventure.CheckIfMatch_OrientMind();

                }
                break;
            case Directions_TLGRadventure.down:
                if (cell_down_TLGRadventure != null)
                {

                    image_c = cell_down_TLGRadventure.image_of_cell_TLGRadventure;
                    cell_down_TLGRadventure.AssignNewCard_OrientMind(image_of_cell_TLGRadventure);
                    AssignNewCard_OrientMind(image_c);
                    cell_down_TLGRadventure.CheckIfMatch_OrientMind();

                }
                break;
        }

        CheckIfMatch_OrientMind();
        //Manager_Game_OrientMind.instance.FinalCheck();
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

    public void AssignNewCard_OrientMind(Image card)
    {
        card.transform.parent = this.transform;
        card.transform.DOLocalMove(Vector3.zero, 0.5f);
        image_of_cell_TLGRadventure = card;
        icon_for_cell_TLGRadventure = card.sprite;
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

    public void CheckIfMatch_OrientMind()
    {
        List<CellGame_TLGRadventure> list_cells = new List<CellGame_TLGRadventure>();
        if (cell_up_TLGRadventure != null)
            list_cells.Add(cell_up_TLGRadventure);
        if (cell_right_TLGRadventure != null)
            list_cells.Add(cell_right_TLGRadventure);
        if (cell_left_TLGRadventure != null)
            list_cells.Add(cell_left_TLGRadventure);
        if (cell_down_TLGRadventure != null)
            list_cells.Add(cell_down_TLGRadventure);

        Manager_Game_TLGRadventure.instance.CheckIfMatchs_OrientMind(list_cells, this);

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
    Tween anim_image_OrientMind;
    public void InvokeNewIcon()
    {
        if (anim_image_OrientMind != null)
            anim_image_OrientMind.Kill();

        anim_image_OrientMind = image_of_cell_TLGRadventure.transform.DOScale(0, 0.05f).OnComplete(() =>
        {
            image_of_cell_TLGRadventure.sprite = Manager_Game_TLGRadventure.instance.GetRandomSprite();
            image_of_cell_TLGRadventure.transform.DOScale(1, 0.3f).SetEase(Ease.InOutElastic);
        });

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

    public List<CellGame_TLGRadventure> GetCells_OrientMind()
    {
        List<CellGame_TLGRadventure> list_cells = new List<CellGame_TLGRadventure>();
        if (cell_up_TLGRadventure != null)
            list_cells.Add(cell_up_TLGRadventure);
        if (cell_right_TLGRadventure != null)
            list_cells.Add(cell_right_TLGRadventure);
        if (cell_left_TLGRadventure != null)
            list_cells.Add(cell_left_TLGRadventure);
        if (cell_down_TLGRadventure != null)
            list_cells.Add(cell_down_TLGRadventure);

        return list_cells;

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

    private void FindAdjacentButtons_TLGRadventure()
    {
        // Calculate the current button's index in the Grid Layout
        int currentIndex = transform.transform.GetSiblingIndex();

        // Calculate the indices of the adjacent buttons
        int upIndex = currentIndex - gridWidth_TLGRadventure;
        int rightIndex = currentIndex + 1;
        int downIndex = currentIndex + gridWidth_TLGRadventure;
        int leftIndex = currentIndex - 1;

        // Find the adjacent buttons and assign them to the variables
        if (upIndex >= 0)
            cell_up_TLGRadventure = gridLayout_TLGRadventure.transform.GetChild(upIndex).GetComponent<CellGame_TLGRadventure>();
        if (rightIndex < gridLayout_TLGRadventure.transform.childCount && (rightIndex % gridWidth_TLGRadventure) != 0)
            cell_right_TLGRadventure = gridLayout_TLGRadventure.transform.GetChild(rightIndex).GetComponent<CellGame_TLGRadventure>();
        if (downIndex < gridLayout_TLGRadventure.transform.childCount)
            cell_down_TLGRadventure = gridLayout_TLGRadventure.transform.GetChild(downIndex).GetComponent<CellGame_TLGRadventure>();
        if (leftIndex >= 0 && (leftIndex % gridWidth_TLGRadventure) != (gridWidth_TLGRadventure - 1))
            cell_left_TLGRadventure = gridLayout_TLGRadventure.transform.GetChild(leftIndex).GetComponent<CellGame_TLGRadventure>();


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

public enum Directions_TLGRadventure
{
    up,
    right,
    left,
    down
}
