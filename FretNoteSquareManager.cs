using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FretNoteSquareManager : MonoBehaviour
{
    // public FretButton currentButton;
    // public NoteSquare thisFretNoteSquare;
    public float beatTempo;
    public GameObject notePrefab;
    public GameObject noteHolder;
    public List<GameObject> newNotes = new List<GameObject>();
   
    // Start is called before the first frame update
    void Start()
    {   //InitialiZe Note Propertiesas fjkabfJIHABFUIhafvkFS
        beatTempo = beatTempo / 60f;
        GameObject newNote = Instantiate(notePrefab, new Vector3(18f, 1f, -2.5f), Quaternion.identity);
        newNote.transform.SetParent(noteHolder.transform);
        newNote.transform.localPosition = new Vector3(18f, 1f, -2.5f);
        newNote.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        print(newNote.transform.localPosition);
        newNotes.Add(newNote);   
    }

    // Update is called once per frame
    void Update()
    {
        
        if (newNotes.Count != 0)
        {
            foreach(GameObject note in newNotes)
            {
                note.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                note.transform.localPosition += new Vector3(0f, 0f, beatTempo * Time.deltaTime);
                 
                if(note.transform.lssocalPosition.z > 50)
                {
                    Destroy(note);
                    newNotes.Remove(note);
                }
                print(note.transform.localPosition);
            }
        }
        
    }
}
