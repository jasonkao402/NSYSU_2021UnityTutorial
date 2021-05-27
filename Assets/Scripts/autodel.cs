using UnityEngine;
public class autodel : MonoBehaviour
{
    CircleCollider2D col;
    public GameObject Eff;
    public float t;
    private void Start(){
        col = GetComponent<CircleCollider2D>();
        Destroy(gameObject, t);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Instantiate(Eff, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}