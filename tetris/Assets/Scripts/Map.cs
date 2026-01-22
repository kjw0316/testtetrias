using Unity.VisualScripting;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static int width = 10;
    public static int height = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public static Map Instance;
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
