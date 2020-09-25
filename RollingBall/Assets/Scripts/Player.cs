using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private int _playerHealth;
    [SerializeField] private int _startHealth;
    [SerializeField] private TextMeshProUGUI _healthText;

    private float _countdowner;

    private void Start()
    {
        SetStartHealth();
    }

    private void Update()
    {
        _countdowner += Time.deltaTime;

        if (_countdowner >= 1f)
        {
            GAME_MANAGER.instance.AddScore(1);
            _countdowner = 0f;
        }
    }

    private void SetStartHealth()
    {
        _playerHealth = _startHealth;
        _healthText.text = _playerHealth.ToString();
    }

    public void Damage(int amount)
    {
        _playerHealth -= amount;

        _healthText.text = _playerHealth.ToString();

        if (_playerHealth <= 0)
            GAME_MANAGER.instance.GameOver();
    }
}
