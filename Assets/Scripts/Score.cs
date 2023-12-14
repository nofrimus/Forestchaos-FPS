using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Score : MonoBehaviour
{
    new public string name; // Add 'new' keyword here
    public float score;

    // Default constructor required for serialization
    public Score()
    {
    }

    // Parameterized constructor
    public Score(string name, float score)
    {
        this.name = name;
        this.score = score;
    }

    // You can use Awake or Start methods for initialization instead of a traditional constructor
    private void Awake()
    {
        // Initialization code if needed
    }
}
