using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, Vector3.zero, 2f).setLoopPingPong().setEaseSpring();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
