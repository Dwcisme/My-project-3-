using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LogicManager : MonoBehaviour
{
    public bool Pausing = true;
    public int Score = 0;
	
	//public List<float> aList = new List<float>();
	//public List<float> sList = new List<float>();
	//public List<float> kList = new List<float>();
	//public List<float> lList = new List<float>();
	public List<List<float>> NoteList = new List<List<float>>();
	public NoteSpawn Note;
	void Start()
	{
		for (int i = 1, i<5 ,i++)
		{
			NoteList.Add({0});
		}
		//NoteList.Add(sList);
		//NoteList.Add(kList);
		//NoteList.Add(lList);
		Note = GameObject.FindGameObjectWithTag("Spawner").GetComponent<NoteSpawn>();

	}
	void Update()
	{
		UpdateList();
	}
	public void AddScore()
	{
		Score += 1;
        Debug.Log(Score);
	}
	public void AddList(float noteSlot ,float noteCollumn)
	{
		switch(noteCollumn)
		{
			case 1 :
				aList.Add(noteSlot);
                break;
            case 2 :
				sList.Add(noteSlot);
                break;
            case 3 :
				kList.Add(noteSlot);
                break;
            case 4 :
				lList.Add(noteSlot);			
                break;
		}
	}
	public void RemoveList(float NoteSlot, float noteCollumn)
	{
		switch(noteCollumn)
		{
			case 1 :
				aList.Remove(NoteSlot);
                break;
            case 2 :
				sList.Remove(NoteSlot);
                break;
            case 3 :
				kList.Remove(NoteSlot);
                break;
            case 4 :
				lList.Remove(NoteSlot);
                break;
		}
	}
	private void UpdateList()
	{
		NoteList[0]=aList;
		NoteList[1]=sList;
		NoteList[2]=kList;
		NoteList[3]=lList;


	}
}
