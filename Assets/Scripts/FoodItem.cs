using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public float speed = 10.0f;
    public int feedAmount = 5;
    private void Awake()
    {
        Destroy(gameObject, 5.0f);
    }
    private void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
