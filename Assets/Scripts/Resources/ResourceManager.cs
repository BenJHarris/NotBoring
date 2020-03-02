using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class ResourceManager : MonoBehaviour
{

    private Dictionary<string, int> resources;

    public void Awake()
    {
        resources = new Dictionary<string, int>();
        resources.Add("wood", 0);
        resources.Add("gold", 0);
        resources.Add("stone", 0);
    }

    public void AddResource(int amount, string resourceType)
    {
        if (!resources.ContainsKey(resourceType))
        {
            throw new ArgumentException(string.Format("{0} is not a valid resource type", resourceType));
        }
        resources[resourceType] += amount;
    }
}
