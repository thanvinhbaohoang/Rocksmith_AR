using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject button;

    public void startScript()
    {
        FretNoteSquareManager script = button.GetComponent<FretNoteSquareManager>();
        script.enabled = true;
    }

    public void pauseGame()
    {
        button.GetComponent<FretNoteSquareManager>().pause = true;
    }

    public void resumeGame()
    {
        button.GetComponent<FretNoteSquareManager>().pause = false;
    }

}
