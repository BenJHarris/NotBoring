using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingInformationDisplay : MonoBehaviour
{
    public BuildingVariable selectedBuilding;

    public Image buildingImage;
    public TMPro.TMP_Text costText;
    public TMPro.TMP_Text buttonText;
    public GameObject panel;

    public void UpdateDisplay()
    {

        Building b = selectedBuilding.RuntimeValue;
        buildingImage.sprite = selectedBuilding.RuntimeValue.sr.sprite;
        costText.SetText(b.spawnUnitCost.ToString() + " Gold");
        buttonText.SetText("Create " + b.spawnUnitName);
        Display(true);
    }

    public void Display(bool display)
    {
        Debug.Log("Setting panel to" + display);
        panel.SetActive(display);
    }
}
