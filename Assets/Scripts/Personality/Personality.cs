using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPersonality", menuName = "AI/Personality")]
public class Personality : ScriptableObject
{
    public string personalityName;
    public float personalityValue;
}
