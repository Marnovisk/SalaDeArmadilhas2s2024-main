using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaArmadilhaTrigger : MonoBehaviour
{
    [SerializeField]
    private string nomeTriggerParaAtivar;

    [SerializeField]
    private string tagParaAtivar;
    
    [SerializeField]
    private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals(tagParaAtivar))
        {
            anim.SetTrigger(nomeTriggerParaAtivar);
        }
    }
}
