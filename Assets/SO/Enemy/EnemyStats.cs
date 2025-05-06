using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyType", menuName = "AI/EnemyType")]
public class EnemyStats : ScriptableObject
{
    [Header("Health")]
    public float maxHealth;
    public float currentHealth;

    [Header("Speed")]
    public float speed;

    [Header("Personality")]
    public EnemyPersonality enemyPersonality;
}
