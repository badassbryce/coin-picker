using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab for the coin object
    public GameObject[] coins;  // Array to hold all the coin objects
    private int totalCoins;      // Total number of coins in the game

    // Start is called before the first frame update
    void Start()
    {
        // Find all the coin objects in the scene and store them
        coins = GameObject.FindGameObjectsWithTag("coin");
        totalCoins = coins.Length;
        
    }

    void Update()
    {
        // Check if active coin count is below threshold
        if (coins.Length < totalCoins)
        {
            StartCoroutine(RespawnCoinWithDelay());
        }


    }

    // Coroutine to respawn a coin after a delay
private IEnumerator RespawnCoinWithDelay()
{
    yield return new WaitForSeconds(2f); // Delay before respawning
    SpawnCoin();
    // Spawn a new coin instead of looking for inactive ones
    coins = GameObject.FindGameObjectsWithTag("coin");// Increment active coin count
}

private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(coinPrefab, GetRandomPosition(), Quaternion.identity);
     
        
    }
    // Method to get a random position for spawning coins
    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-10f, 10f), 1f, Random.Range(-10f, 10f));
    }
}
