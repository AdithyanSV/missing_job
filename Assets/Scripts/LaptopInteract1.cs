using UnityEngine;
using EasyPeasyFirstPersonController; // Required for your controller reference

public class LaptopInteract1 : MonoBehaviour
{
    [Header("Interaction Settings")]
    public float interactDistance = 6f;
    public LayerMask interactLayer; // optional: assign Laptop layer

    [Header("References")]
    public GameObject laptopUI;
    public FirstPersonController playerController;

    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Pressed Q — checking for laptop...");
            if (!isOpen && Physics.Raycast(Camera.main.transform.position,
                                           Camera.main.transform.forward,
                                           out RaycastHit hit, interactDistance))
            {
                Debug.Log($"Hit object: {hit.collider.name}");
                if (hit.collider.CompareTag("Laptop"))
                {
                    Debug.Log("Laptop found — opening UI.");
                    OpenLaptop();
                }
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
