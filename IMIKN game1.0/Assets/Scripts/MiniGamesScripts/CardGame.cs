using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardGame : MonoBehaviour
{
    public Transform card;
    private Vector3 dragOffset;
    private Vector3 startPos;
    private float speedDrag = 5f;

    private void OnMouseDown()
    {
        startPos = card.transform.position;
        dragOffset = card.transform.position - GetMousePosition();
    }

    private void OnMouseDrag()
    {
        var newPos = GetMousePosition() + dragOffset;
        card.transform.position = Vector3.MoveTowards(card.transform.position, newPos, speedDrag * Time.deltaTime);
    }
    private Vector3 GetMousePosition()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -1;
        mousePos.y = card.transform.position.y;
        return mousePos;
    }

    private void OnMouseUp()
    {
        card.transform.position = startPos;
    }
}
