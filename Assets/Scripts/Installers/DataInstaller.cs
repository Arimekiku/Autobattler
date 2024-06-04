using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "Data Installer", menuName = "SO/Data Installer", order = 0)]
public class DataInstaller : ScriptableObjectInstaller<DataInstaller>
{
    [SerializeField] private PlayerData _playerData;

    public override void InstallBindings()
    {
        Container.Bind<PlayerData>().FromInstance(_playerData).AsSingle();
    }
}