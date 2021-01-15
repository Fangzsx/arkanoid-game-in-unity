using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // for debugging

    //cache references
    Level level;

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    private void Start()
    {
        level = FindObjectOfType<Level>();
    }
}
