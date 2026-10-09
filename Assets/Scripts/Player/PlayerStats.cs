using UnityEngine;


[CreateAssetMenu(fileName = "PlayerStats", 
menuName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
    [Header("Config")]
    [SerializeField] private int Playerlevel = 1;

    [Header("Health")]
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 100;
}
