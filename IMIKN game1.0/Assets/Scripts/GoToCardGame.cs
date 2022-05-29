using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GoToCardGame : MonoBehaviour
{
    public Transform player;
    public Transform cardGamePoint;
    public GameObject cardGameUI;

    private Vector3 normalDistance = new Vector3(2, 3, 10);
    public void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            var currentDistance = player.position - cardGamePoint.position;
            if (Mathf.Abs(currentDistance.x) < normalDistance.x &&
                Mathf.Abs(currentDistance.y) < normalDistance.y)
            {
                //Debug.Log(SceneManager.GetActiveScene());
                //SceneManager.LoadScene("CardGame");
                Debug.Log(currentDistance.x + " " + currentDistance.y);
                cardGameUI.transform.position = new Vector3(cardGameUI.transform.position.x,
                    cardGameUI.transform.position.y, -5);
                cardGameUI.SetActive(true);
            }
        }
    }
}
