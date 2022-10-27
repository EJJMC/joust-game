using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsMenu : MonoBehaviour
{
    [SerializeField] GameObject[] UIElements;
    [SerializeField] GameObject[] IntructionElements;

    public void InstructionsTapped()
    {
        foreach(GameObject UIElement in UIElements)
        {
            UIElement.gameObject.SetActive(false);
        }
        foreach (GameObject InstructionElement in IntructionElements)
        {
            InstructionElement.gameObject.SetActive(true);
        }
    }

    public void InstructionsBackToMenu()
    {
        foreach (GameObject InstructionElement in IntructionElements)
        {
            InstructionElement.gameObject.SetActive(false);
        }
        foreach (GameObject UIElement in UIElements)
        {
            UIElement.gameObject.SetActive(true);
        }
    }
}
