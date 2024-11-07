using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Ghost : MonoBehaviour
{
     // Speed at which the ghost moves
    public Transform Player; // Reference to the player's Transform
    private NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component
    [SerializeField] private Transform movePositionTransform;

    private void Start()
    {
        // Get the NavMeshAgent component on the ghost object
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        if (Player != null)
        {
            // Set the target position for the NavMeshAgent to move towards the player
            navMeshAgent.destination = movePositionTransform.position;
        }
    }

    // Detect collision with player
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // Trigger game over condition
            GameOver();
        }
    }

    // Game over logic
    private void GameOver()
    {
        Debug.Log("Game Over!");
        // Reload the current scene to reset the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}