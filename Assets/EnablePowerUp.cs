using UnityEngine;

public class EnablePowerUp : MonoBehaviour
{
    public LevelManager lm;

    void OnTriggerEnter ()
    {
        Debug.Log("hit sphere");
        Destroy(gameObject);
        lm.activatePowerUp();
    }

}
