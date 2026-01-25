using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Score : Tetristry
{
    public TMPro.TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
