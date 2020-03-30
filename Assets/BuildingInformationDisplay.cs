using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingInformationDisplay : MonoBehaviour
{
    public BuildingVariable selectedBuilding;

    public Image buildingImage;
    public GameObject panel;

    public void UpdateDisplay()
    {
        buildingImage.sprite = selectedBuilding.RuntimeValue.sr.sprite;
        Display(true);
    }

    public void Display(bool display)
    {
        Debug.Log("Setting panel to" + display);
        panel.SetActive(display);
    }
}
