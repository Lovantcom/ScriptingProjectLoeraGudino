using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IF : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature... 
        if (coffeeTemperature < hotlimitTemperature)
        {
            // ... do this.
            print("Coffee is to hot.");

        }
        //If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature > coldlimitTemperature)
        {
            //...do this.
            print("Coffee is to cold");
        }
        // If it is neither of those then
        else
        {
            //...do this. 
            print("Coffee is just right");
        }
    }
}