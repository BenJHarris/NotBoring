using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableBuilding : Selectable
{
    public Sprite selectedSprite;
    public SpriteRenderer sr;
    public GameEvent selectEvent;
    public GameEvent deselectEvent;

    public BuildingVariable selectedBuildingRef;

    public GameEventListener deselectListener;

    private Sprite originalSprite;
    private Building building;

    private void Start()
    {
        building = GetComponent<Building>();
        originalSprite = sr.sprite;
    }

    override public void Select()
    {

        // deselect other buildings
        deselectEvent.Raise();
        deselectListener.enabled = true;

        // raise event to update UI
        selectedBuildingRef.RuntimeValue = building;
        selectEvent.Raise();
        sr.sprite = selectedSprite;
    }

    override public void Unselect()
    {
        sr.sprite = originalSprite;
        deselectListener.enabled = false;
    }
}
