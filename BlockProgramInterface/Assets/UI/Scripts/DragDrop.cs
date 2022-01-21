using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private RectTransform initLocation;
    public GameObject block;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        initLocation = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        
    }

    // Dragging the block
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        // Debug.Log(rectTransform);
        rectTransform.anchoredPosition += eventData.delta;
    }

    // Dropping the block
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        // Creating a new same type of block
        // I was still in fixing this part but the deadline had come
        GameObject BlockClone = Instantiate(block, initLocation);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}
