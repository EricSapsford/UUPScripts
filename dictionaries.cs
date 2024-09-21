using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneController: MonoBehaviour {
    public Dictionary<string, Shape> shapeDictionary;

    void Start()
    {
        shapeDictionary = new Dictionary<string, Shape>();
        var shapeName = "Circle";
        var circle = new Shape { Name = shapeName };

        shapeDictionary.Add(shapeName, circle);
    }

    private void SetColorByName(string shapeName, Color color)
    {
        shapeDictionary[shapeName].SetColor(color);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SetColorByName("Circle", Color.red);
        }
    }
}
