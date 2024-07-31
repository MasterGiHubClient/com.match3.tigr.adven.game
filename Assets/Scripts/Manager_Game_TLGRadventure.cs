using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEngine.Serialization;
using System.Runtime.CompilerServices;

public class Manager_Game_TLGRadventure : MonoBehaviour
{
    //[FormerlySerializedAs("onGameStart_UrbanEnigma")]
    public UnityEvent onGameStart_TLGRadventure;
    //[FormerlySerializedAs("onGameFinish_UrbanEnigma")]
    public UnityEvent onGameFinish_TLGRadventure;
    //[FormerlySerializedAs("onNextClick_UrbanEnigma")]
    public UnityEvent onNextClick_TLGRadventure;
    //[FormerlySerializedAs("levels_data_UrbanEnigma")]
    public LevelsData_TLGRadventure levels_data_TLGRadventure;
    public ReferenceIconsReach[] references_icons_reach;
    public Timer timmer_TLGRadventure;




    private Level_TLGRadventure current_level_data_TLGRadventure;
    private int current_level_TLGRadventure;
    private AllLevelsData_TLGRadventure all_levels_data_TLGRadventure = new AllLevelsData_TLGRadventure();
    private bool game_running_TLGRadventure = false;
    private int card_clicked_TLGRadventure = 0;
    private CellGame_TLGRadventure cell_selected_TLGRadventure;
    private int amount_unlocked_sprite_01;

    private int amountScore;


    public static Manager_Game_TLGRadventure instance;

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


    private void Awake()
    {
        instance = this;


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

    private void Start()
    {
        LoadLevelsSaved_TLGRadventure();


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

    public void StartLevel_TLGRadventure(int level)
    {

        onGameStart_TLGRadventure?.Invoke();

        current_level_data_TLGRadventure = GetLevel_TLGRadventure(level);
        current_level_TLGRadventure = level;

        card_clicked_TLGRadventure = 0;


        if (current_level_data_TLGRadventure == null)
            return;

        for (int i = 0; i < current_level_data_TLGRadventure.spritesLevel_TLGRadventure.Length; i++)
        {
            CellGame_TLGRadventure.on_set_icon_TLGRadventure?.Invoke(current_level_data_TLGRadventure.spritesLevel_TLGRadventure[i], i + 1);
        }

        for (int i = 0; i < references_icons_reach.Length; i++)
        {
            references_icons_reach[i].image.sprite = current_level_data_TLGRadventure.cellToReach_TLGRadventure[i].sprite_TLGRadventure;
            references_icons_reach[i].text.text = $"00/{current_level_data_TLGRadventure.cellToReach_TLGRadventure[i].count_TLGRadventure}";
        }

        cell_to_reach_OrientMind = current_level_data_TLGRadventure.cellToReach_TLGRadventure;
        amount_unlocked_sprite_01 = 0;
        CellGame_TLGRadventure.show_icon_TLGRadventure?.Invoke(true);

        game_running_TLGRadventure = true;



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

    private Level_TLGRadventure GetLevel_TLGRadventure(int level)
    {
        foreach (var item in levels_data_TLGRadventure.levels_TLGRadventure)
        {
            if (item.level_TLGRadventure == level)
                return item;
        }

        return null;


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

















    private CellToReach_TLGRadventure[] cell_to_reach_OrientMind;




    public void OnCellSelected(CellGame_TLGRadventure cell)
    {
        cell_selected_TLGRadventure = cell;



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

    public async void CheckIfMatchs_OrientMind(List<CellGame_TLGRadventure> cell_group, CellGame_TLGRadventure center_cell)
    {
        List<CellGame_TLGRadventure> matchs_local = new List<CellGame_TLGRadventure>();
        matchs_local.Add(center_cell);

        Loop_Check_TLGRadventure(cell_group, center_cell, ref matchs_local);

        await Task.Delay(TimeSpan.FromSeconds(0.5));
        if (matchs_local.Count >= 3)
        {
            CheckIfIsGoalSprites_TLGRadventure(matchs_local);

            foreach (var cell_match in matchs_local)
            {
                cell_match.InvokeNewIcon();
                amountScore += 100;
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

    private void Loop_Check_TLGRadventure(List<CellGame_TLGRadventure> cell_group, CellGame_TLGRadventure center_cell, ref List<CellGame_TLGRadventure> matchs_local)
    {

        foreach (var cell in cell_group)
        {
            if (cell.image_of_cell_TLGRadventure.sprite.name == center_cell.image_of_cell_TLGRadventure.sprite.name)
            {
                if (!matchs_local.Contains(cell))
                {


                    matchs_local.Add(cell);
                    Loop_Check_TLGRadventure(cell.GetCells_OrientMind(), cell, ref matchs_local);
                }
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

    private void CheckIfIsGoalSprites_TLGRadventure(List<CellGame_TLGRadventure> sprites_ref)
    {

        for (int i = 0; i < sprites_ref.Count; i++)
        {
            for (int k = 0; k < cell_to_reach_OrientMind.Length; k++)
            {
                if (sprites_ref[i].image_of_cell_TLGRadventure.sprite.name == cell_to_reach_OrientMind[k].sprite_TLGRadventure.name)
                {
                    if (k == 0)
                    {
                        if (amount_unlocked_sprite_01 < cell_to_reach_OrientMind[k].count_TLGRadventure)
                        {
                            amount_unlocked_sprite_01 += 100;
                            references_icons_reach[k].text.text = $"{amount_unlocked_sprite_01}/{cell_to_reach_OrientMind[k].count_TLGRadventure}";
                        }
                    }

                }
            }
        }

        CheckIfReached_TLGRadventure();



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

    private void CheckIfReached_TLGRadventure()
    {

        if (amount_unlocked_sprite_01 == cell_to_reach_OrientMind[0].count_TLGRadventure)
        {
            onGameFinish_TLGRadventure?.Invoke();
            LevelFinish_TLGRadventure();
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
    public void OnDirectionTrigger_TLGRadventure(int direction)
    {
        if (cell_selected_TLGRadventure == null) return;

        switch (direction)
        {
            case 0:
                cell_selected_TLGRadventure.OnCellDirectionDrag_TLGRadventure(Directions_TLGRadventure.up);
                break;
            case 1:
                cell_selected_TLGRadventure.OnCellDirectionDrag_TLGRadventure(Directions_TLGRadventure.right);
                break;
            case 2:
                cell_selected_TLGRadventure.OnCellDirectionDrag_TLGRadventure(Directions_TLGRadventure.down);
                break;
            case 3:
                cell_selected_TLGRadventure.OnCellDirectionDrag_TLGRadventure(Directions_TLGRadventure.left);
                break;
        }

        cell_selected_TLGRadventure = null;



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


    private void LevelFinish_TLGRadventure()
    {
        CheckStars();
        FetchDataLevels_TLGRadventure();



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
    private void CheckStars()
    {

        bool level_exist_at_list = false;
        foreach (var item in all_levels_data_TLGRadventure.levels_TLGRadventure)
        {
            if (item.level_TLGRadventure == current_level_TLGRadventure) level_exist_at_list = true;
        }


        if (timmer_TLGRadventure.timeRemaining < 120)
        {
            //3 stars
            if (level_exist_at_list)
            {
                foreach (var item in all_levels_data_TLGRadventure.levels_TLGRadventure)
                {
                    if (item.level_TLGRadventure == current_level_TLGRadventure)
                    {
                        item.stars_TLGRadventure = 3;
                    }
                }

            }
            else
            {
                LevelData_TLGRadventure level_data = new LevelData_TLGRadventure();
                level_data.level_TLGRadventure = current_level_TLGRadventure;
                level_data.stars_TLGRadventure = 3;
                all_levels_data_TLGRadventure.levels_TLGRadventure.Add(level_data);
            }

        }
        else if (timmer_TLGRadventure.timeRemaining > 120 && timmer_TLGRadventure.timeRemaining < 180)
        {
            //2 stars
            if (level_exist_at_list)
            {
                foreach (var item in all_levels_data_TLGRadventure.levels_TLGRadventure)
                {
                    if (item.level_TLGRadventure == current_level_TLGRadventure)
                    {
                        item.stars_TLGRadventure = 2;
                    }
                }

            }
            else
            {
                LevelData_TLGRadventure level_data = new LevelData_TLGRadventure();
                level_data.level_TLGRadventure = current_level_TLGRadventure;
                level_data.stars_TLGRadventure = 2;
                all_levels_data_TLGRadventure.levels_TLGRadventure.Add(level_data);

            }

        }
        else if (timmer_TLGRadventure.timeRemaining > 180)
        {
            //1 stars
            if (level_exist_at_list)
            {
                foreach (var item in all_levels_data_TLGRadventure.levels_TLGRadventure)
                {
                    if (item.level_TLGRadventure == current_level_TLGRadventure)
                    {
                        item.stars_TLGRadventure = 1;
                    }
                }

            }
            else
            {
                LevelData_TLGRadventure level_data = new LevelData_TLGRadventure();
                level_data.level_TLGRadventure = current_level_TLGRadventure;
                level_data.stars_TLGRadventure = 1;
                all_levels_data_TLGRadventure.levels_TLGRadventure.Add(level_data);

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


    public void NextClick_TLGRadventure()
    {
        if (current_level_TLGRadventure < 7)
        {
            current_level_TLGRadventure++;
        }
        else
        {
            current_level_TLGRadventure = 1;

        }
        StartLevel_TLGRadventure(current_level_TLGRadventure);

        onNextClick_TLGRadventure?.Invoke();


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

    private void OnDestroy()
    {
        SaveDataLevels_TLGRadventure();


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

    private void SaveDataLevels_TLGRadventure()
    {
        var allData = new JSONObject("[]");



        var JsonObj_Data = new JSONObject(JsonUtility.ToJson(all_levels_data_TLGRadventure));
        allData.AddField("Levels", JsonObj_Data);

        PlayerPrefs.SetString("LevelsData", allData.ToString());



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

    private void LoadLevelsSaved_TLGRadventure()
    {
        if (PlayerPrefs.HasKey("LevelsData"))
        {
            var data_loaded = PlayerPrefs.GetString("LevelsData");
            var allData = new JSONObject(data_loaded);


            if (allData.HasField("Levels"))
            {
                all_levels_data_TLGRadventure = JsonUtility.FromJson<AllLevelsData_TLGRadventure>(allData["Levels"].ToString());
            }

            FetchDataLevels_TLGRadventure();
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



    private void FetchDataLevels_TLGRadventure()
    {
        foreach (var item in all_levels_data_TLGRadventure.levels_TLGRadventure)
        {
            Cell_TLGRadventure.set_data_level_TLGRadventure?.Invoke(item);
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

    public void PlayTheHighestLevel_TLGRadventure()
    {
        StartLevel_TLGRadventure(all_levels_data_TLGRadventure.levels_TLGRadventure[all_levels_data_TLGRadventure.levels_TLGRadventure.Count - 1].level_TLGRadventure);



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

    public Sprite GetRandomSprite()
    {
        return levels_data_TLGRadventure.levels_TLGRadventure[0].spritesLevel_TLGRadventure[UnityEngine.Random.Range(0, levels_data_TLGRadventure.levels_TLGRadventure[0].spritesLevel_TLGRadventure.Length)];



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
public class AllLevelsData_TLGRadventure
{
    public List<LevelData_TLGRadventure> levels_TLGRadventure = new List<LevelData_TLGRadventure>();

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
}

[Serializable]
public class ReferenceIconsReach
{
    public Image image;
    public TMP_Text text;


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

}


