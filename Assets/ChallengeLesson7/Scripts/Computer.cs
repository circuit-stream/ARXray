using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Computer : MonoBehaviour
{
    public GameObject turnedOffMesh;
    public GameObject turnedOnMesh;

    public UnityEvent OnComputerTurnedOn;

    // This function is called by the "OnStartTracking" unity event, from the "Default Trackable Event Handler" component
    public void OnStartTracking()
    {
        // Toggles which meshes are active
        turnedOffMesh.SetActive(true);
        turnedOnMesh.SetActive(false);

        StartCoroutine(TurnOnPC());
    }

    private IEnumerator TurnOnPC()
    {
        // Waits 1 seconds before continuing the execution of the method
        yield return new WaitForSeconds(1);

        turnedOffMesh.SetActive(false);
        turnedOnMesh.SetActive(true);

        // Invokes the event if there is any registered callbacks
        OnComputerTurnedOn?.Invoke();
    }
}
