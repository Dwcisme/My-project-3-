using UnityEngine;

public class Note : MonoBehaviour
{
    public float MoveSpeed;
    private NoteSpawn noteSpawn;
    private LogicManager logic;
    public string CurrentNoteState = "N";
    private float NoteCollumn;
    public float CurrentNoteSlot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        noteSpawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<NoteSpawn>();
        CurrentNoteSlot = noteSpawn.noteSlot;
        NoteCollumn = noteSpawn.noteCollumn;
        logic.AddList(CurrentNoteSlot, NoteCollumn);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * MoveSpeed * 10)*Time.deltaTime;
        if (transform.position.y<-7)
        {
            NextNote();
        }
        if(CurrentNoteSlot == logic.NoteList[(int)(NoteCollumn-1)][0] && CurrentNoteState != "N")
        {

            Click();
        }


        Debug.Log((NoteCollumn-1) + CurrentNoteState + CurrentNoteSlot);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        switch(collision.gameObject.layer)
        {
            case 7:
                CurrentNoteState = "P";
                break;
            case 8:
                CurrentNoteState = "G";
                break;
            case 9:
                CurrentNoteState = "M";
                break;
        }
    }
    private void Click()
    {
        if (true)
        {
            switch (NoteCollumn)
            {
                case 1:
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Debug.Log("a");
                        NextNote();
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.S))
                    {
                        Debug.Log("s");
                        NextNote();
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        Debug.Log("k");
                        NextNote();
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.L))
                    {
                        Debug.Log("l");
                        NextNote();
                    }
                    break;
            }
        }
    }
    private void NextNote()
    {
        logic.RemoveList(CurrentNoteSlot,NoteCollumn);
        Destroy(gameObject);
    }
}
