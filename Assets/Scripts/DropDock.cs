using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropDock : MonoBehaviour, IDropHandler, IPointerClickHandler, IPointerEnterHandler
{
    public Fade CheckFadeScript;
    public Fade CrossFadeScript;
    public int Number;
    public GameObject NextButton;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Enter");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop " + Number);
        if (eventData.pointerDrag != null)
        {
            int matchNumber = Convert.ToInt32(eventData.pointerDrag.GetComponentInChildren<Text>().text);
            if (matchNumber == Number)
            {
                eventData.pointerDrag.GetComponent<Transform>().parent = transform;
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                //eventData.pointerDrag.GetComponentInChildren<Text>().text = "0";
                CheckFadeScript.FadeOutAnima(transform.position);
                LevelControl.NoUnmatchedStatic = LevelControl.NoUnmatchedStatic - 1;
                Debug.Log("Updated" + LevelControl.NoUnmatchedStatic);
                if (LevelControl.NoUnmatchedStatic == 0)
                {
                    Debug.Log("Updated :" + "Enable Button");
                    LevelControl.nextButtonStatic.SetActive(true);
                }
                //NextQPanel.SetActive(true);
            }
            else
            {
                CrossFadeScript.FadeOutAnima(transform.position);
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
}
