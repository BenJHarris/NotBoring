using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public IntVariable gold;
    public IntVariable score;

    public int scoreAmount = 30;
    public int goldAmount = 10;

    public void Die()
    {
        gold.RuntimeValue += goldAmount;
        score.RuntimeValue += scoreAmount;
        Destroy(gameObject);
    }
}
