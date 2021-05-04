using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _playerSpawnPlace;
    private void Start()
    {
        Instantiate(_player, _playerSpawnPlace.position, _playerSpawnPlace.rotation);
    }
}
