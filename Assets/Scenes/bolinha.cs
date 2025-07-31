using UnityEngine;
using System.Collections;

public class bolinha : MonoBehaviour
{
    public GameObject bola;
    private Vector3 posInicial;
    bool canBack = false;

    void Start()
    {
        posInicial = bola.transform.position;
    }

    void Update()
    {
        if (!canBack) {
            bola.transform.position = Input.mousePosition / 2f;
            StartCoroutine(BackBall());
            return;
        }
        StartCoroutine(BackBall());
    }

    IEnumerator BackBall(){
        while (!canBack) {
            yield return new WaitForSeconds(5f);
            break;
        }
        if (Input.GetMouseButton(0) && !canBack){
            canBack = true;
            bola.transform.position = posInicial;
        }
    }
}
