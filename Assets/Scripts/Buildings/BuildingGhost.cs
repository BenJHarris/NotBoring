using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGhost : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer buildingRenderer;
    [SerializeField]
    private SpriteRenderer backgroundRenderer;
    [SerializeField]
    private Material validLocationBuilding;
    [SerializeField]
    private Material invalidLocationBuilding;
    [SerializeField]
    private Material validLocationBackground;
    [SerializeField]
    private Material invalidLocationBackground;

    private BuildingData buildingData;
    private bool placeable = false;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    public void Initialize(BuildingData data)
    {
        buildingData = data;
        buildingRenderer.sprite = buildingData.Sprite;
        buildingRenderer.transform.localPosition = buildingData.SpriteOffset;
        backgroundRenderer.size = buildingData.FloorSize;
    }

    private void Update()
    {
        if (placeable)
        {
            buildingRenderer.material = validLocationBuilding;
            backgroundRenderer.material = validLocationBackground;
        } else
        {
            buildingRenderer.material = invalidLocationBuilding;
            backgroundRenderer.material = invalidLocationBackground;
        }
    }

    private void FixedUpdate()
    {
        placeable = checkPlaceable();
    }

    public bool checkPlaceable()
    {
        int layerMask = (1 << 8) | (1 << 10);

        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, buildingData.FloorSize, 0, layerMask);
        return hits.Length == 0;
    }

}
