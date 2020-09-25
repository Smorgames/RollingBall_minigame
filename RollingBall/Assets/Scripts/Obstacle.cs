using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private bool _onTheTop;
    [SerializeField] private bool _onTheBot;

    [SerializeField] private int _damageAmount;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _onTheTop)
            _animator.SetTrigger("Down");
        if (Input.GetMouseButtonDown(0) && _onTheBot)
            _animator.SetTrigger("Up");
    }

    public void Set_onTheTopEqualFalse()
    {
        _onTheTop = false;
    }

    public void Set_onTheBotEqualFalse()
    {
        _onTheBot = false;
    }

    public void Set_onTheTopEqualTrue()
    {
        _onTheTop = true;
    }

    public void Set_onTheBotEqualTrue()
    {
        _onTheBot = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            collision.GetComponent<Player>().Damage(_damageAmount);
            Destroy(gameObject);
        }

        if (collision.tag == "Destroyer")
            Destroy(gameObject);
    }
}
