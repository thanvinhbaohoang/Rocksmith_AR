using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="NoteSquare")]
public class NoteSquare : ScriptableObject
{
   public Color noteSquareColor;
   public int noteSquareWidth;
   public int noteID;
   public Material noteMat;
   public Vector3 spawnPoint;
}
