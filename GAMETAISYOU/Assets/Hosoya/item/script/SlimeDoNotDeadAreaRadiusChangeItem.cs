using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDoNotDeadAreaRadiusChangeItem : MonoBehaviour
{
    [SerializeField] float chengeSize;  //大きさの変化量

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //スライムだったら
        if (collision.gameObject.tag == "Slime")
        {
            collision.gameObject.GetComponent<SlimeController>()._slimeBuf._doNotDeadAreaRadius += chengeSize;
            Destroy(this.gameObject);
        }
    }
}
