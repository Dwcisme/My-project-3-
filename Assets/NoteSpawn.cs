using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject Note;
    public float SpawnRate = 1;
    private float timer;
    private string[] randomPositions = new string[3];
    public float noteCollumn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if( timer< SpawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                SpawnNote();
                timer = 0;
            }
    }
    public void SpawnNote()
    {
        noteCollumn = UnityEngine.Random.Range(1,5);
        Instantiate(Note, new Vector3((noteCollumn-1)*1.5f-2.25f,transform.position.y,0), transform.rotation);
    }
}
