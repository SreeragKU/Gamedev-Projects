using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectileOne;
    [SerializeField] GameObject projectileTwo;
    [SerializeField] GameObject projectileThree;
    [SerializeField] GameObject projectileFour;
    [SerializeField] GameObject projectileFive;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectileOne.SetActive(true);
            projectileTwo.SetActive(true);
            projectileThree.SetActive(true);
            projectileFour.SetActive(true);
            projectileFive.SetActive(true);
        }
    }
}
