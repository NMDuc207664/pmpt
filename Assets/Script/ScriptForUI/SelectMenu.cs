using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
=======
using System;
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af

public class SelectMenu : MonoBehaviour
{
    [SerializeField] private Button[] levelButton;

    // Start is called before the first frame update
    void Start()
    {
        // Kiem soat level da choi toi
        int levelReached = PlayerPrefs.GetInt("levelReached",1);
        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 1 > levelReached)
                levelButton[i].interactable = false;
        }
    }

    // Nut bam de chuyen toi level do
<<<<<<< HEAD
    public void LevelSelect(string level)
    {
        SceneManager.LoadScene(level);
=======
    public void LevelSelect(int level)
    {   try{
            SceneManager.LoadScene("Level " + level.ToString());
        }catch(Exception e)
        {
            Console.Write(e.Message);
            SceneManager.LoadScene("Level 1_Network");
        }
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
        AudioManager.Instance.PlayMusic("Theme");
    }
}
