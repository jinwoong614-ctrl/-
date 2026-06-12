using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    bool open = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!open)
                transform.Rotate(0, 90, 0);
            else
                transform.Rotate(0, -90, 0);

            open = !open;
        }
    }
}