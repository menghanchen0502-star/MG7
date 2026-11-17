using UnityEngine;

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;
    [SerializeField] private Transform _player;
    [SerializeField] private float _interactionDistance = 5.0f;

    private void Update()
    {
        for (int i = 0; i < _birds.Length; i++)
        {
            float distance = Vector3.Distance(_player.position, _birds[i].transform.position);

            if (distance <= _interactionDistance)
            {
                _birds[i].SetActive(true);
            }
        }
    }
}