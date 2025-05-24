using UnityEngine;

public class Lane : MonoBehaviour
{
    [SerializeField]
    private Transform _noteOrigin;
    public Transform NotesOrigin
    {
        get { return _noteOrigin; }
    }
    [SerializeField]
    private GameObject _notePrefab;
    public GameObject NotePrefab
    {
        get { return _notePrefab; }
    }
}
