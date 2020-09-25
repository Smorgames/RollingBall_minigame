using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPrefabs;

    [SerializeField] private float _spawnRate;
    private float _countdowner;

    private void Start()
    {
        _countdowner = _spawnRate;
    }

    private void Update()
    {
        _countdowner += Time.deltaTime;

        if (_countdowner > _spawnRate)
        {
            Instantiate(_spawnPrefabs[Random.Range(0, _spawnPrefabs.Length)], transform.position, Quaternion.identity);
            _countdowner = 0f;
        }
    }
}
