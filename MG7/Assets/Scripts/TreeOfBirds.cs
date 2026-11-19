using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{
    public GameObject[] sparrows;
    public Transform player;
    public float interactionDistance = 5f;

    void Update()
    {
        if (player == null || sparrows == null)
        {
            return;
        }

        foreach (GameObject sparrow in sparrows)
        {
            if (sparrow == null)
            {
                continue;
            }

            float distance = Vector3.Distance(
                player.position,
                sparrow.transform.position
            );

            if (distance <= interactionDistance)
            {
                sparrow.SetActive(true);
            }
        }
    }
}