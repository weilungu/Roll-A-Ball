using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Awake
    PlayerMovement move;
    PlayerPickup pickup;
    
    GameManager GM;
    
    
    // === Life Cycle === //
    void Awake()
    {
        GM = GameObject.FindWithTag("GameManager")
            .GetComponent<GameManager>();
        
        move = GetComponent<PlayerMovement>();
        pickup = GetComponent<PlayerPickup>();
    }
    void Update()
    {
        GM.OutcomeActions();
        
        if (GM.IsLose())
            gameObject.SetActive(false);

        if (GM.IsGameOver())
        {
            GM.GameResult();
        }
    }
    void FixedUpdate()
    {
        move.Movement();
    }
    
    
    // Events
    void OnTriggerEnter(Collider other)
    {
        bool layerDetected = pickup.DetextedLayer(other);

        if (!layerDetected) return;
        pickup.Count++;
        GM.AddScore(1);
        
        other.gameObject.SetActive(false);
    }
}
