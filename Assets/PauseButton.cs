using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public bool PauseButtonClicked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseButtonClicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PauseButtonClicked = true;
        }
    }
}
