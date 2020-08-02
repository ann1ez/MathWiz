using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int LevelNo;
    public int NoQuestons;
    
    public static int NoUnmatchedStatic = 0;
    public GameObject nextButton;
    public static GameObject nextButtonStatic;

    private void Start()
    {
        NoUnmatchedStatic = NoQuestons;
        nextButton.SetActive(false);
        nextButtonStatic = nextButton;
    }

    public void GoToNext()
    {
        SceneManager.LoadScene(LevelNo + 1);
    }

}
