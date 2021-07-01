using System.Collections.Generic;
using UnityEngine;

public class ComputerConnectionController : MonoBehaviour
{
    public LineRenderer lineRenderer;

    private List<Transform> computerLinkTransforms;

    // This function is called by the "OnComputerTurnedOn" unity event, from the "Computer" component
    public void RegisterComputer(Transform computerLinkPoint)
    {
        computerLinkTransforms.Add(computerLinkPoint);
        lineRenderer.positionCount = computerLinkTransforms.Count;

        if (computerLinkTransforms.Count == 2)
        {
            lineRenderer.enabled = true;
        }
    }

    private void Update()
    {
        // Constantly update the linerenderer points so it matches the current position of the computers
        for (var index = 0; index < computerLinkTransforms.Count; index++)
        {
            var computerLinkTransform = computerLinkTransforms[index];
            lineRenderer.SetPosition(index, computerLinkTransform.position);
        }
    }

    private void Awake()
    {
        computerLinkTransforms = new List<Transform>();
        lineRenderer.enabled = false;
    }
}
