using UnityEngine;
public class SpawnerPoints : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Mover _moverPrefab;
    [SerializeField] private Target _target;

    public void Spawn()
    {
        Mover mover = Instantiate(_moverPrefab, _position, Quaternion.identity);
        mover.SetTarget(_target);
    }
}