using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewListPersonality", menuName = "AI/ListPersonality")]
public class EnemyPersonality : ScriptableObject
{
    [Header("Personalities")]
    public List<Personality> personalities;
}
