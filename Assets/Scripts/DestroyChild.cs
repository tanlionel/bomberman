using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChild : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 objectPosition;
    private OnDestroyItemBrick parentScript;

    void Start()
    {
        objectPosition = transform.position;
    }

    void OnDestroy()
    {
        parentScript = GetComponentInParent<OnDestroyItemBrick>();

        if (parentScript != null)
            parentScript.SpawnRandomItem(objectPosition);

    }
}
