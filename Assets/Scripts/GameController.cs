using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Saindo já, mano");
        Application.Quit();
    }

    public void BackToHome()
    {
        SceneManager.LoadScene(0);
    }
}
