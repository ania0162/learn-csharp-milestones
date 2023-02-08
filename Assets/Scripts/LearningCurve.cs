using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // This is a int variable
    public int CurrentAge = 21;
    public int AddedAge = 1;

    // This is a float variable
    public float Movement = 0.001F;

    // This is a string variable
    public string Bob = "Hello, My name is Bob.";

    // This is a boolean variable
    public bool Method = true;

    // This is a Single Line Comment

    /* This is a
        Multi Line Comment */

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(21 + 1);
        Debug.Log(CurrentAge + 1);
        ComputeAge();
    }
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
