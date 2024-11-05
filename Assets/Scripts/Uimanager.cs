using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Newscript : MonoBehaviour
{


    public void StartMainScene()
    {
        SceneManager.LoadScene(1);
    }


    public void ExitGame()
    {
        EditorApplication.ExitPlaymode();


        Application.Quit();

    }
}
