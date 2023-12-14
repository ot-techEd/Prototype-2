using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int foodMeter = 0;
    public int foodMeterMax = 50;
    public float speed = 10.0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodItem"))
        {
            FeedAnimal(other.GetComponent<FoodItem>().feedAmount);

        }
    }


    public void FeedAnimal(int feedAmount)
    {
        if (foodMeter < foodMeterMax)
        {
            foodMeter += feedAmount;
        }

        if (foodMeter >= foodMeterMax)
        {
            AnimalFed();

        }

        float foodMeterValue = ((float)foodMeter / (float)foodMeterMax) * 100;
        Debug.Log("Animal Fed, food meter is curently at " + foodMeterValue + "%");
    }

    public void AnimalFed()
    {
        Debug.Log("Animal has been fed");
        //Destroy(gameObject);
        TurnAround();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void TurnAround()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
