using UnityEngine;
using UnityEngine.UI;

public class SpawnTest : MonoBehaviour
{
    public GameObject prefab;

    public Vector3 offset;
    
    public Vector3 origin;

    private int count = 0;
    public Text text;
    
    public void SpawnOne()
    {
        origin += offset;
        var go = Instantiate(prefab,origin, Quaternion.identity);
        text.text = (++count).ToString();
    }
}
