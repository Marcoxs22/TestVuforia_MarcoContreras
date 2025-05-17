using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onSelecteDance;

    [SerializeField]
    private UnityEvent _onDanceSelected;

    public void ActivateSelectDance()
    {
        _onSelecteDance?.Invoke();
    }

    public void OnSelectedDance()
    {
        _onDanceSelected?.Invoke();
    }
}
