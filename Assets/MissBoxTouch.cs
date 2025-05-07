using UnityEngine;

public class MissBoxTouch : MonoBehaviour
{
    public LogicManager logic;
    public bool Touch = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==6)
        {
            Debug.Log("Mz");
            Touch = true;
        }
        else
        {
            Touch = false;
        }
    }
}
