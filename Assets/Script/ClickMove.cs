using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool isPressed = false;
    public GameObject Player;
    public GameObject TurnPoint;
    public Color ButtonUi;
    public float rotationSpeed = 200f;


    void Update()
    {
        if (isPressed)
        {
            Player.transform.RotateAround(TurnPoint.transform.position, new Vector3(0,0,1), rotationSpeed * Time.deltaTime);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        Debug.Log("Coucou");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
    
}
