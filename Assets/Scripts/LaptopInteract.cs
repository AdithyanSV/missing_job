using UnityEngine;
using EasyPeasyFirstPersonController; // Required for your controller reference

public class LaptopInteract : MonoBehaviour
{
    [Header("Interaction Settings")]
    public float interactDistance = 3f;
    public LayerMask interactLayer; // optional: assign Laptop layer

    [Header("References")]
    public GameObject laptopUI;
    public FirstPersonController playerController;

    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isOpen && Physics.Raycast(Camera.main.transform.position,
                                           Camera.main.transform.forward,
                                           out RaycastHit hit, interactDistance))
            {
                if (hit.collider.CompareTag("Laptop"))
                    OpenLaptop();
            }
        }

        if (isOpen && Input.GetKeyDown(KeyCode.Escape))
            CloseLaptop();
    }

    void OpenLaptop()
    {
        laptopUI.SetActive(true);
        playerController.SetControl(false);
        playerController.SetCursorVisibility(true);
        isOpen = true;

        AudioManager.Instance.PlaySFX(AudioManager.Instance.laptopOpen);

    }

    public void CloseLaptop()
    {
        laptopUI.SetActive(false);
        playerController.SetControl(true);
        playerController.SetCursorVisibility(false);
        isOpen = false;

        
    }
}
