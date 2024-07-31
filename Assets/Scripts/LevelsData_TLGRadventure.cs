using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "LevelsData", menuName = "ScriptableObjects/LevelsData")]
public class LevelsData_TLGRadventure : ScriptableObject
{
    //[FormerlySerializedAs("levels_")]
    public Level_TLGRadventure[] levels_TLGRadventure;
    public int index_to_randomize = 0;

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
public class Level_TLGRadventure
{
    //[FormerlySerializedAs("level")]
    public int level_TLGRadventure;
    //[FormerlySerializedAs("spritesLevel")]
    public Sprite[] spritesLevel_TLGRadventure;
    public CellToReach_TLGRadventure[] cellToReach_TLGRadventure;

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
public class CellToReach_TLGRadventure
{
    public Sprite sprite_TLGRadventure;
    public int count_TLGRadventure;

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









#if UNITY_EDITOR


[CustomEditor(typeof(LevelsData_TLGRadventure))]
public class LevelsData_TLGRadventureEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LevelsData_TLGRadventure levelsData = (LevelsData_TLGRadventure)target;

        // Draw the default inspector
        base.OnInspectorGUI();

        // Add a button to randomize the order of the levels_TLGRadventure array
        if (GUILayout.Button("Randomize Levels Order"))
        {
            RandomizeLevelsOrder(levelsData);
        }
    }

    private void RandomizeLevelsOrder(LevelsData_TLGRadventure levelsData)
    {
        // Shuffle the levels_TLGRadventure array
        System.Random random = new System.Random();
        Sprite[] shuffledLevels = levelsData.levels_TLGRadventure[levelsData.index_to_randomize].spritesLevel_TLGRadventure.Clone() as Sprite[];
        for (int i = shuffledLevels.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Sprite temp = shuffledLevels[i];
            shuffledLevels[i] = shuffledLevels[j];
            shuffledLevels[j] = temp;
        }

        // Assign the shuffled array back to the LevelsData_TLGRadventure object
        levelsData.levels_TLGRadventure[levelsData.index_to_randomize].spritesLevel_TLGRadventure = shuffledLevels;

        // Mark the asset as dirty to ensure the changes are saved
        EditorUtility.SetDirty(levelsData);
    }
}
#endif