using UnityEngine;



public class DoorController : MonoBehaviour

{

    public Animator animator; // Assign parent Door Animator here



    private void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))

            animator.SetBool("isOpen", true);

    }



    private void OnTriggerExit(Collider other)

    {

        if (other.CompareTag("Player"))

            animator.SetBool("isOpen", false);

    }

}