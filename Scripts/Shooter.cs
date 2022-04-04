using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private AudioClip _buttonShoot;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Menu.ButtonClick == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(_buttonShoot);
                    Instantiate(_bulletTemplate, _shootPoint);
                }
            }
        }
    }
}