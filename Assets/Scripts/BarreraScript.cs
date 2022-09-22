using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreraScript : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        Debug.Log("Ingreso detectado");
        anim.SetBool("estaAdentro", true);
    }

    private void OnTriggerExit()
    {
        Debug.Log("Salida detectada");
        anim.SetBool("estaAdentro", false);
    }
}
