using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArtClass : BaseClass
{

    public BaseArtClass()
    {
        CharClassName = "Art";
        Creativity = 8;
        Stamina = 6;
        Skill = 4;
        Speed = 9;

        CreativityEXP = 0;
        StaminaEXP = 0;
        SkillEXP = 0;
        SpeedEXP = 0;
    }
}
