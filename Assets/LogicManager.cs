using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public bool Pausing = true;
    public int Score = 0;


	public void AddScore()
	{
		Score += 1;
        Debug.Log(Score);
	}

}
