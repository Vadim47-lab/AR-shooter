using UnityEngine.Events;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _deathEffect;
    [SerializeField] private AudioClip _buttonDestroy;

    public event UnityAction<Enemy> Dying;

    public void Die()
    {
        Dying?.Invoke(this);
        Instantiate(_deathEffect, transform.position, Quaternion.identity);
        GetComponent<AudioSource>().PlayOneShot(_buttonDestroy);
        Destroy(gameObject);
    }
}