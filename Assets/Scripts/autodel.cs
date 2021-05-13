using UnityEngine;
public class autodel : MonoBehaviour
{
    public float t;
    private void Start(){
        Destroy(gameObject, t);
    }
}