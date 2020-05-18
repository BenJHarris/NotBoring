using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageUpdate : MonoBehaviour
{
    public Sprite s;

    private Image i;

    private void Start()
    {
        i = GetComponent<Image>();
    }

    public void Run()
    {
        i.sprite = s;
    }
}
