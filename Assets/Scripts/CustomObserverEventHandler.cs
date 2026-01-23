using UnityEngine;
using Vuforia;

public class CustomObserverEventHandler : DefaultObserverEventHandler
{
    [SerializeField] private RotateManager2 rotateManager;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        string targetName = gameObject.name;

        if (rotateManager != null)
        {
            rotateManager.OnTargetFound(targetName);
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();

        if (rotateManager != null)
        {
            rotateManager.OnTargetLost();
        }
    }
}
