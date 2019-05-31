using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ledii/Variables/String Asset")]
public class StringAsset : ScriptableObject
{
    [SerializeField]
    [TextArea(3, int.MaxValue)]
    private string value;

    public string Value
    {
        get { return value; }
    }
}