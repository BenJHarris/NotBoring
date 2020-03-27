using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacer : MonoBehaviour
{
    [SerializeField]
    private GameObject ghostBuildingPrefab;

    private BuildingData currentBuildingData;
    private BuildingGhost currentBuildingGhost;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    public void CreatePlacementGhostBuilding(BuildingData data)
    {
        // Check for existing building ghost
        if (currentBuildingGhost != null)
        {
            RemoveCurrentBuildingGhost();
        }

        currentBuildingData = data;
        GameObject ghostBuilding = Instantiate(ghostBuildingPrefab);
        currentBuildingGhost = ghostBuilding.GetComponent<BuildingGhost>();
        currentBuildingGhost.Initialize(currentBuildingData);
    }

    private void Update()
    {
        if (currentBuildingGhost == null) return;

        Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        currentBuildingGhost.transform.position = position;

        if (Input.GetMouseButtonDown(0) && currentBuildingGhost.checkPlaceable())
        {
            Instantiate(currentBuildingData.BuildingPrefab, position, Quaternion.identity);
            RemoveCurrentBuildingGhost();
        } else if (Input.GetMouseButtonDown(1))
        {
            RemoveCurrentBuildingGhost();
        }

    }

    private void RemoveCurrentBuildingGhost()
    {
        Destroy(currentBuildingGhost.gameObject);
        currentBuildingGhost = null;
    }
}
