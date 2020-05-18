using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Terrain : MonoBehaviour
{
    public LandMap landMap;

    public List<GameObject> landPrefabs;
    public GameObject seaPrefab;

    public int tileSize = 8;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {

        float offset = tileSize * landMap.Size / 2 - tileSize / 2;
        transform.localPosition -= new Vector3(offset, offset);

        float y = landMap.Size * tileSize;
        float x = 0;

        for (int i = 0; i < landMap.Map.Length; i++)
        {    
            if (i % landMap.Size == 0)
            {
                x = 0;
                y -= tileSize;
            } else
            {
                x += tileSize;
            }

            GameObject currentPrefab;

            switch (landMap.Map[i])
            {
                case 0:
                    currentPrefab = seaPrefab;
                    break;
                case 1:
                    currentPrefab = landPrefabs[0];
                    break;
                default:
                    currentPrefab = seaPrefab;
                    break;
            }

            GameObject currentInstance = Instantiate(currentPrefab, transform);
            currentInstance.transform.localPosition = new Vector2(x, y);

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Purchase()
    {
    }
}
