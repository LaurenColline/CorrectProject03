using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EventSystem : MonoBehaviour
{

    public static event Action ExampleEvent;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ExampleEvent?.Invoke();
        }
    }
}
