using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker : MonoBehaviour
{

    [SerializeField]
    private GameObject go;

    private void Start()
    {
        go = transform.parent.gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            go.SendMessage("Grounded");
        }
    }
}
