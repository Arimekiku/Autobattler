using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Transform _playerSpawn;
    
    public override void InstallBindings()
    {
        InstallPlayer();
    }

    private void InstallPlayer()
    {
        const string playerPath = "Prefabs/Entities/Player.prefab";
        var playerPrefab = Resources.Load(playerPath);
        
        var playerInstance = Container.InstantiatePrefabForComponent<PlayerBehaviour>(playerPrefab);
        playerInstance.transform.position = _playerSpawn.position;
        Container.Bind<PlayerBehaviour>().FromInstance(playerInstance).AsSingle();
    }
}