using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    private Rigidbody rb;
    private breakable bk;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * bulletSpeed;
        bk = FindObjectOfType<breakable>();

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f);
    }
    private void OnTriggerEnter(Collider colide) {
        if (colide.gameObject.CompareTag("quebravel")) {

            bk.objectLife -= 1;
            Destroy(gameObject);
        }
    }
}
