using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorPorta : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            anim.SetBool("aberto", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            anim.SetBool("aberto", false);
        }
    }
}
