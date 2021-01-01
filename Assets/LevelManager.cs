using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public move movement;

    public void activatePowerUp()
    {
        movement.longJump = true;
    }
}
