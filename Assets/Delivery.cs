using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;
    SpriteRenderer spriteRenderer;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destoyDelay = 0.5f;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You hit an Obstacle!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destoyDelay);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
