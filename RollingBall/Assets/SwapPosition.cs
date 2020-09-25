using UnityEngine;

public class SwapPosition : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Transform _destroyPosition;

    void Update()
    {
        if (transform.position.x < _destroyPosition.position.x)
            transform.position = _spawnPosition.position;
    }
}
