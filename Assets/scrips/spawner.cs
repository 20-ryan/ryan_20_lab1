using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spawner : MonoBehaviour
{
    public GameObject opponent; 
    public Text opponentText;
public int count;

    void Start()
    {
        
        InvokeRepeating("SpawnOpponent", 1f, 2f);
    }

    void SpawnOpponent()
    {

        Vector3 position = new Vector3(Random.Range(-10f, 10f), 0.5f, 1f);


        Instantiate(opponent, position, Quaternion.identity);
        count++;
        opponentText.text = "number of opponents spawned: " + count;
    }
}
