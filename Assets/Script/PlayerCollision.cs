using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    bool isInvicible = false;
  

    void start()
    {
        RenderSettings.fogColor = Color.magenta;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "ennemy" && !isInvicible)
        {
            isInvicible = true;
            PlayerHealth.pi.SetHealth(-1);
            RenderSettings.fogColor = Color.red;
            StartCoroutine("ResetInvicible");
        }

        if (other.gameObject.tag == "vie")
        {
            print("Life");
            PlayerHealth.pi.SetHealth(+1);
            RenderSettings.fogColor = Color.green;
        }

        StartCoroutine(ResetColor());
    }

    IEnumerator ResetInvicible() 
    {
        print("invinsible");
        yield return new WaitForSeconds(1);
        isInvicible = false;
    }

    IEnumerator ResetColor()
    {
        print("color");
        yield return new WaitForSeconds(2);
        RenderSettings.fogColor = Color.magenta;
    }

}
