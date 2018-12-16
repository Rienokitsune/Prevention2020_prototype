using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class appStartIcon : MonoBehaviour, IPointerClickHandler
{

   [SerializeField] windowManager windowManager;
    bool isSelected = false;
    [SerializeField]GameObject appPrefab;
    Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked");
        if (!isSelected)
        {
            isSelected = true;
            image.color = Color.blue;

        } else
        {
            GameObject AppWindow;
            AppWindow = Instantiate(appPrefab,gameObject.transform.parent);
            

            isSelected = false;
            image.color = Color.white;
        }
    }
}
