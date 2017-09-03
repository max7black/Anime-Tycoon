using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {

    private BaseCharacter newCharacter;
    private bool isArtClass;
    private bool isAnimationClass;
    private bool isSoundClass;
    private bool isProductionClass;
    private string playerName = "Enter Name";
    

	// Use this for initialization
	void Start () {
        newCharacter = new BaseCharacter();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName);

        isArtClass = GUILayout.Toggle(isArtClass, "Art Class");
        isAnimationClass = GUILayout.Toggle(isAnimationClass, "Animation Class");
        isSoundClass = GUILayout.Toggle(isSoundClass, "Sound Class");
        isProductionClass = GUILayout.Toggle(isProductionClass, "Production Class");

        if (GUILayout.Button("create"))
        {
            if (isArtClass)
            {
                newCharacter.CharClass = new BaseArtClass();
            }
            else if (isAnimationClass)
            {
                newCharacter.CharClass = new BaseAnimationClass();
            }
            else if(isSoundClass)
            {
                newCharacter.CharClass = new BaseSoundClass();
            }
            else if(isProductionClass)
            {
                newCharacter.CharClass = new BaseProductionClass();
            }

            newCharacter.CharName = playerName;

            newCharacter.Creativity = 1;
            newCharacter.Skill = 1;
            newCharacter.Speed = 1;
            newCharacter.Stamina = 1;
            newCharacter.CreativityEXP = 0;
            newCharacter.SkillEXP= 0;
            newCharacter.SpeedEXP = 0;
            newCharacter.StaminaEXP = 0;

            Debug.Log("Player Name: " + newCharacter.CharName);
            Debug.Log("Player Class: " + newCharacter.CharClass.CharClassName);
            Debug.Log("Player Creativity: " + newCharacter.Creativity);
            Debug.Log("Player Skill: " + newCharacter.Skill);
            Debug.Log("Player Speed: " + newCharacter.Speed);
            Debug.Log("Player Stamina: " + newCharacter.Stamina);
            Debug.Log("Player SkillEXP : " + newCharacter.SkillEXP);


        }


    }

}
