using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardGameEnd : MonoBehaviour
{
    public GameObject cardGameUI;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        cardGameUI.SetActive(false);
    }
}
