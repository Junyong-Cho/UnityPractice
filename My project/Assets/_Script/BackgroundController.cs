using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    public float scrollSpeed = 0.5f;
    Material me;

    void Start()
    {
        me = GetComponent<Renderer>().material;
    }

    void Update()
    {
        Vector2 newOffset = me.mainTextureOffset;
        newOffset.Set(0, newOffset.y + scrollSpeed * Time.deltaTime);

        me.mainTextureOffset = newOffset;
    }
}
