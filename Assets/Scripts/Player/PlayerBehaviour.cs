using UnityEngine;
using Zenject;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _weaponSlot;
    
    private Rigidbody2D _body;
    private BaseWeaponBehaviour _weapon;

    private float _movementSpeed;
    private float _attackSpeedMultiplier;
    
    [Inject]
    private void Build(PlayerData data)
    {
        //TODO: maybe should change to DI spawning
        _weapon = Instantiate(data.BaseWeapon, _weaponSlot);
        
        _movementSpeed = data.BaseMovementSpeed;
        _attackSpeedMultiplier = data.BaseAttackSpeedMultiplier;
    }
    
    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 movementVector)
    {
        var nextPosition = _body.position + movementVector.normalized * _movementSpeed * Time.deltaTime;
        _body.MovePosition(nextPosition);
    }

    public void Attack()
    {
        _weapon.Attack();
    }
}