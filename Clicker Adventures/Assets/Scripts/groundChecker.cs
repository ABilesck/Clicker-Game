using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker : MonoBehaviour
{

    [SerializeField]
    private GameObject go;

    public float attackTime = 3f;

    private void Start()
    {
        go = transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            int random = Random.Range(0, 4);

            if(random == 0 || random == 1 || random == 4)
                StartCoroutine(WaitFor(attackTime));
            else
                go.SendMessage("Grounded");
        }
    }

    IEnumerator WaitFor(float s)
    {
        yield return new WaitForSeconds(s);
        go.SendMessage("Grounded");
    }
}
