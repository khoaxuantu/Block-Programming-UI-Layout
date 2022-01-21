using UnityEngine;

public class InstantiatingPrehabs : MonoBehaviour
{
    public GameObject obj;

    private RectTransform rect;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject copyblock = Instantiate(obj, rect);
        Debug.Log("Initiate");
    }
}
