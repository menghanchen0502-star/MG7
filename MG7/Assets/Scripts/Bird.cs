using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _popUpTime = 1.0f;
    [SerializeField] private float _popUpSpeed = 5.0f;
    [SerializeField] private Player _player;

    private bool _doPopUpAnimation;
    private float _popUpTimeRemaining;

    // STEP 2 -----------------------------------------------------------------
    private void OnEnable()
    {
        _doPopUpAnimation = true;
        _popUpTimeRemaining = _popUpTime;
    }
    // STEP 2 -----------------------------------------------------------------

    private void Update()
    {
        // STEP 3 -------------------------------------------------------------
        if (_doPopUpAnimation)
        {
            _popUpTimeRemaining -= Time.deltaTime;

            if (_popUpTimeRemaining <= 0)
            {
                _doPopUpAnimation = false;
            }
            else
            {
                transform.Translate(Vector3.up * _popUpSpeed * Time.deltaTime, Space.World);
            }
        }
        // STEP 3 -------------------------------------------------------------


        // STEP 6 -------------------------------------------------------------
        if (_player._isHoldingSeed)
        {
            transform.LookAt(_player.transform);
        }
        // STEP 6 -------------------------------------------------------------
    }
}