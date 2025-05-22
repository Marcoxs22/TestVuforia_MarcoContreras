using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private Animator _characterAnimator;
    [SerializeField]
    private UnityEvent _onSelecteDance;

    [SerializeField]
    private UnityEvent _onDanceSelected;
    private SoundData _currentSoundData;

    public void ActivateSelectDance()
    {
        _onSelecteDance?.Invoke();
    }

    public void OnSelectedDance(SoundData soundData)
    {
        _currentSoundData = soundData;
        _onDanceSelected?.Invoke();
    }

    public void StartDance()
    {
        _characterAnimator.Play(_currentSoundData.animationName);
        SoundManager.instance.PlayMusic(_currentSoundData.musicName);
    }
}
