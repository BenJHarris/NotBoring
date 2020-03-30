using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100f;
    public float currentHealth;

    private Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            enemy.Die();
        }
    }

    public void Damage(float val)
    {
        currentHealth -= val;
    }
}
