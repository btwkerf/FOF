using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private float _vertical;
    private float _horizontal;

    private PlayerStats _playerStats;


    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _playerStats = GetComponent<PlayerStats>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
        _rigidBody2D.velocity = new Vector2(_horizontal * _playerStats.Speed * Time.deltaTime, _vertical * _playerStats.Speed * Time.deltaTime);
    }

}