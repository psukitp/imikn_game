using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject card;
    // Update is called once per frame
    void Update()
    {
        if (card.transform.position.x == -500)
        {
            Debug.Log(SceneManager.GetActiveScene());
            SceneManager.LoadScene("Game");
        }
    }
}
