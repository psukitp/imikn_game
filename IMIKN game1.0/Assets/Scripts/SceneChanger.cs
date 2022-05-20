using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        Debug.Log(SceneManager.GetActiveScene());
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
