using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
   [SerializeField] private Sprite[] idle;

    private void Start()
    {
        Debug.Log("Anzahl Elemente:" + idle.Length);
    }
}
