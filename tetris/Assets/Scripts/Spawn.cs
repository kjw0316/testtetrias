using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] tetriminos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnTetrimino();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTetrimino()
    {
        int randomIndex = Random.Range(0, tetriminos.Length);
        Instantiate(tetriminos[randomIndex], transform.position, Quaternion.identity);
    }
}
