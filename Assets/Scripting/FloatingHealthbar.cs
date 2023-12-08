using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthbar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }
   // public void SetMaxHealth(int health)
    /// {
    ///     Debug.Log(health);
    ///     slider.value = health;
    ///     slider.maxValue = health;
}
    // Update is called once per frame
 ///   public void SetHealth(int health)
   // {
    //    slider.value = health;
//}//
