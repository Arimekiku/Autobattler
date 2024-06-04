using UnityEngine;
using Zenject;

public class PlayerInputListener : ITickable
{
    private readonly PlayerBehaviour _player;
    
    [Inject]
    public PlayerInputListener(PlayerBehaviour player)
    {
        _player = player;
    }
    
    public void Tick()
    {
        PlayerMove();
        PlayerAttack();
    }

    private void PlayerMove()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");
        var movementVector = new Vector2(xAxis, yAxis);
        _player.Move(movementVector);
    }

    private void PlayerAttack()
    {
        if (Input.GetMouseButtonDown(0))
            _player.Attack();
    }
}