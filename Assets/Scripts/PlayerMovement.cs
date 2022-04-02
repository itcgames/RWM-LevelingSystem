using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _jumpForce;
    [SerializeField] float _movementForce;
    Rigidbody2D _rb;

    bool _isOnGround;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            _rb.AddForce(Vector3.left * _movementForce, ForceMode2D.Force);
        else if (Input.GetKey(KeyCode.D))
            _rb.AddForce(Vector3.right * _movementForce, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            if (_isOnGround)
            {
                _rb.AddForce(Vector3.up * _jumpForce, ForceMode2D.Impulse);
                _isOnGround = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
            _isOnGround = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            GetComponent<CharacterLeveling>().addExperience(50);
            Destroy(collision.gameObject);
        }
    }

    public void setMovementSpeed(float t_newSpeed)
    {
        _movementForce = t_newSpeed;
    }

    public void setJumpForce(float t_newJump)
    {
        _jumpForce = t_newJump;
    }
}
