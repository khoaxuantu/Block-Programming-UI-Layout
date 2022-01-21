using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class File_Dropdown : MonoBehaviour
{

    [SerializeField] private GameObject[] filebnt;
    public GameObject Filebnt;

    void Start()
    {
        for (int i = 0; i < filebnt.Length; i++)
        {
            filebnt[i].SetActive(false);
        }
    }

    // Active the native drop down menu
    public void ClickonFilebnt()
    {
        for (int i = 0; i < filebnt.Length; i++)
        {
            filebnt[i].SetActive(true);
        }
    }

    // Clear the native drop down menu
    private void Dropdown_clr(GameObject fileButton)
    {
        if (Input.GetMouseButton(0) &&
           !RectTransformUtility.RectangleContainsScreenPoint(
               fileButton.GetComponent<RectTransform>(),
               Input.mousePosition,
               Camera.main))
        {
            for (int i = 0; i < filebnt.Length; i++)
            {
                filebnt[i].SetActive(false);
            }
            // Debug.Log("Outside the panel");
        }
    }

    void Update()
    {
        Dropdown_clr(Filebnt);
    }
}
