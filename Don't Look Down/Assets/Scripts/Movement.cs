using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody _playerBody;
    float dashSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Dash();
    }

    private void FixedUpdate()
    {
        Move();

    }

    // Movement
    void Move()
    {
        if (Input.GetKey(KeyCode.S))
        {
            _playerBody.AddForce(transform.forward * -5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            _playerBody.AddForce(transform.forward * 5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerBody.AddForce(transform.right * 5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerBody.AddForce(transform.right * -5f, ForceMode.Impulse);
        }

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerBody.AddForce(transform.up * 75f, ForceMode.Impulse);
            print("Jump");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            _playerBody.AddForce(transform.up * 75f, ForceMode.Impulse);
            print("Jump");
        }
    }

    void Dash()
    {
        if (Input.GetKey(KeyCode.R))
        {
            _playerBody.AddForce(transform.forward * dashSpeed, ForceMode.Impulse);
        }
    }

    void ExitGame()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //SceneManager.LoadScene(0);
        }
    }
}
