using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerDownHandler, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("Pointer Click");
        transform.LeanMoveY(180, 0.2f);
    }

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("Pointer Down");
        transform.LeanMoveY(180, 0.2f);
    }
    public void Flip() {
        Debug.Log("Pointer Down");
        transform.LeanRotateY(180, 0.2f); 
    }
    public void Update() {
        if (Input.GetMouseButton(0)) {
            Flip();
        }
    }
}
