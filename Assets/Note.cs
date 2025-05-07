using UnityEngine;

public class Note : MonoBehaviour
{
    public float MoveSpeed;
    public NoteSpawn noteSpawn;
    public bool PTouch;
    public bool MTouch;
    public LogicManager logic;
    public string CurrentNoteState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        noteSpawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<NoteSpawn>();
        //Debug.Log(noteSpawn.noteCollumn);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * MoveSpeed * 10)*Time.deltaTime;
        
        
        //if (perfectBox.Touch==false &&missBox.Touch == true)
        //{
        //    Debug.Log("Miss");
        //}
        //else if(perfectBox.Touch==true &&missBox.Touch == true)
        //{
        //    Debug.Log("Good");
        //}
        //else if(perfectBox.Touch==true &&missBox.Touch == false)
        //{
        //    Debug.Log("Perfect");
        //}

        if (transform.position.y<-7)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Debug.Log("p");
            PTouch = true;        
        }
        if (collision.gameObject.layer==8)
        {
           Debug.Log("m");
           MTouch = true;
        }
    }
}
