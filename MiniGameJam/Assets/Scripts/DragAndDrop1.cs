using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public delegate void DragEndedDelagate(DragAndDrop draggableObject);

    public DragEndedDelagate dragEndedCallback;

    private bool isDragged = false;
    private bool isSelected;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;

    //rotation
    private Quaternion initialRotation;
    private float rotationSpeed = 10f;

    private void Update()
    {
        //Rotate the selected object using the scroll wheel
        if (isSelected)
        {
            float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
            if(scrollWheel != 0)
            {
                transform.Rotate(Vector3.forward, scrollWheel * rotationSpeed);
            }
        }
    }

    private void OnMouseDown()
    {
        isDragged = true;
        isSelected = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
        isSelected = false;
        dragEndedCallback(this);
    }
}