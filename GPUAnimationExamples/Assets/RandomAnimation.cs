using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
    public List<Animation> animations;
    
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponentsInChildren<Animation>().ToList();
        foreach (var animation1 in animations)
        {
            animation1["Walk"].speed = Random.Range(0.01f, 2f);
        }
    }

}
