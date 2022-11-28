using DG.Tweening;
using UnityEngine;

public class TweenRotate : MonoBehaviour
{
    // Start is called before the first frame update

    private void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 15 * Time.deltaTime) ;
    }
    
}
