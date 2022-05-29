using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardGame : MonoBehaviour
{
    private Vector3 dragOffset;
    private float speedDrag = 20f;
    private void OnMouseDown()
    {
        dragOffset = this.transform.position - GetMousePosition();
    }

    private void OnMouseDrag()
    {
        var newPos = GetMousePosition() + dragOffset;
        this.transform.position = Vector3.MoveTowards(this.transform.position, newPos, speedDrag * Time.deltaTime);  
    }
    private Vector3 GetMousePosition()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -1;
        mousePos.y = this.transform.position.y;
        return mousePos;
    }

    private void OnMouseUp()
    {
        this.transform.position = new Vector3(-21, this.transform.position.y, -1);
    }
}
