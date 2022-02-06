using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="FretButton")]

public class FretButton : ScriptableObject
{
    public Color fretColor;
    public int width = 2;
    public int fretID;
    public Material fretMat;
}
