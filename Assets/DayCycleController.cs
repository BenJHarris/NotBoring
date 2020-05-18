using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DayCycleController : MonoBehaviour
{
    public float timeOfDayMax = 60;
    public GameEvent newDayEvent;

    public IntVariable day;
    public FloatVariable time;

    public Light2D global;

    private void Update()
    {
        time.RuntimeValue += Time.deltaTime;

        if (time.RuntimeValue >= timeOfDayMax)
        {
            day.RuntimeValue++;
            time.RuntimeValue = 0;
        }

        if (time.RuntimeValue < 2)
        {
            global.intensity = Mathf.Lerp(0.5f, 1, time.RuntimeValue);
        }
        else if (time.RuntimeValue > 50)
        {
            global.intensity = Mathf.Lerp(1.0f, 0.5f, (time.RuntimeValue - 50) / 10);
        }
    }

}
