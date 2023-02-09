using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    /* This is Learing Curve:
        Chapter 3 */
    // This is a int variable
    private int CurrentAge = 21;
    public int AddedAge = 1;

    // This is a float variable
    public float Pi = 3.14F;

    // This is a string variable
    public string FirstName = "Aina";
    public string LastName = "Solis";

    // This is a boolean variable
    public bool IsHuman = true;

    // This is a Single Line Comment

    /* This is a
        Multi Line Comment */

    // Start is called before the first frame update

    void Start()
    {
        /* This is Learing Curve:
         Chapter 2 */
            Debug.Log(21 + 1);
            Debug.Log(CurrentAge + 1);
            ComputeAge();

        /* This is Learing Curve:
         Chapter 3 */
            //This is a conconate string (using $)
            Debug.Log($"A string can have variables like {FirstName} inserted directly!");
            //This is a conconate string (using +)
            Debug.Log(FirstName + " " + LastName);

            //Pg.63 Take Action
            int CharacterLevel = 32;
            GenerateCharacter("Spike", CharacterLevel);

            //Pg.68 Take Action
            int CharacterNextLevel = GenerateCharacter("Spike", CharacterLevel);

            Debug.Log(CharacterNextLevel);
            Debug.Log(GenerateCharacter("Spike", CharacterLevel));
        
    }

    /* This is Learing Curve:
         Chapter 2 */
        void ComputeAge()
        {
            Debug.Log(CurrentAge + AddedAge);
        }

    /* This is Learing Curve:
         Chapter 3 */
        public int GenerateCharacter(string name, int level)
        {
            //Debug.LogFormat("Character: {0} - Level: {1}",name,level);
            return level += 5;
        }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
