using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchangingobject : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer cubeRenderer;
    public GameObject cube;
    [SerializeField] private Color[] colors;
    private int colorValue;

    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial()
    {
        colorValue++;
        if(colorValue > 2)
        {
            colorValue = 0;
        }

        cubeRenderer.material.color = colors[colorValue];

        //cubeRenderer.material.color =colors[Random,Range(0,3)];
    }
}
