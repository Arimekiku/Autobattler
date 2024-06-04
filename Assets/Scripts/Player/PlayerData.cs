using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "SO/Player Data", order = 0)]
public class PlayerData : ScriptableObject
{
    [field: Header("Base Parameters"), Space]
    [field: SerializeField] public float BaseMovementSpeed { get; private set; }
    [field: SerializeField] public float BaseAttackSpeedMultiplier { get; private set; }
    
    [field: Header("Weapon Parameters"), Space]
    [field: SerializeField] public BaseWeaponBehaviour BaseWeapon { get; private set; }
}