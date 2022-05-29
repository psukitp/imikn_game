using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardGameEnd : MonoBehaviour
{
    public Transform player;
    public GameObject cardGameUI;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = new Vector3(player.position.x, player.position.y + 3, player.position.z);
        Debug.Log(collision.name);
        cardGameUI.SetActive(false);
    }
}
