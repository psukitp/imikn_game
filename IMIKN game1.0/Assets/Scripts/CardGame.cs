using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float timeSpend;

    private bool isDragging;
    private Vector3 oldPosotion;
    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            timeSpend += Time.deltaTime;
            Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            gameObject.transform.position = new Vector3(transform.position.x + point.x, transform.position.y, transform.position.z);
        }
        else
        {
            if (transform.position.x > 3.5f)
            {
                print(transform.position.x);
                gameObject.transform.position += new Vector3(-6f * Time.deltaTime, 0, 0);
            }
        }
    }
    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x - oldPosotion.x, transform.position.y, transform.position.z);
    }

    private void OnMouseDown()
    {
        timeSpend = 0;
        Vector3 delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        isDragging = true;
    }

    private void OnMouseUp()
    {
        timeSpend = 0;
        isDragging = false;
    }
}
