using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerPoints[] _spawningPoint;
    [SerializeField, Min(0)] private float _countSecondsBeforeSpawn;

    private int _minRandom = 0;
    private int _maxRandom = 3;
    
    private IEnumerator Start()
    {
        var wait = new WaitForSeconds(_countSecondsBeforeSpawn);

        while (true)
        {
            ActivatePoint();
            yield return wait;
        }
    }

    private void ActivatePoint()
    {
        int currentSpawnPoint = Random.Range(_minRandom, _maxRandom);
        SpawnerPoints spawnerPoint = _spawningPoint[currentSpawnPoint];
        spawnerPoint.Spawn();
    }
}