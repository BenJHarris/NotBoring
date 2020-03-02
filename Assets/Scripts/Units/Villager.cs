using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour
{
    public string currentTask;

    public UnitSpeech unitSpeech;

    private void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            unitSpeech.Say("hello");
        }

        if (Input.GetKeyDown("c"))
        {
            unitSpeech.Say("THERE");
        }
    }

}
