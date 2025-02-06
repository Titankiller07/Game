using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject BasketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -10f;
    public float basketSpacingY = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(BasketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
