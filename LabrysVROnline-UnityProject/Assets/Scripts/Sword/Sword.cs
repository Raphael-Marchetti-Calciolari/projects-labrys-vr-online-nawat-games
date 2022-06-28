using System;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public static string swordClassTag = "Sword";
    public static event Action<GameObject> NotifyPlayerCollision;
    [SerializeField] private float damage;

    private void Start()
    {
        if (!gameObject.tag.Equals(swordClassTag)) Debug.Log($"Sword instance \"{gameObject.name}\" has no tag or wrong tag attributed!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(Player.playerClassTag))
        {
            NotifySwordCollision?.Invoke(damage, collision.gameObject);
        }
    }

}
