using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    #region REFERENCES

    private Rigidbody _rigidbody;
    private Animator _animator;

    #endregion

    #region VARIABLES

    [SerializeField] private float MovementForce;
    [SerializeField] private float MovementSpeed;
    [SerializeField] private float TurningSpeed;

    private Vector2 _input;  // 0,1

    private bool _canGetInput;

    #endregion

    #region MONOBEHAVIOUR

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        _canGetInput = true;
    }

    private void Update()
    {
        GetInput();
        ProcessMovement();
        ProcessAnimation();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death") && _canGetInput)
        {
            Die();
        }
    }

    #endregion

    #region METHODS

    private void GetInput()
    {
        if (!_canGetInput) return;

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        _input = new Vector2(horizontalInput, verticalInput);
    }

    private void ProcessMovement()
    {
        if (!_canGetInput) return;

        transform.rotation *= Quaternion.Euler(0f, TurningSpeed * _input.x * Time.deltaTime, 0f);

        _rigidbody.velocity = transform.forward * MovementSpeed * _input.y;
    }

    private void ProcessAnimation()
    {
        if (!_canGetInput) return;

        _animator.SetBool("walking", _input.y != 0);
        _animator.SetFloat("walkDirection", _input.y > 0 ? 1f : -1f);
    }

    private void Die()
    {
        _animator.SetTrigger("die");
        _canGetInput = false;
        _input = Vector2.zero;
    }

    #endregion

}
