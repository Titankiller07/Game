using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject BasketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -10f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(BasketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }
        public void AppleMissed()
        {
            GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
            foreach(GameObject tempGO in appleArray)
            {
                Destroy(tempGO);
            }
            int basketIndex = basketList.Count - 1;
            GameObject tBasketGO = basketList[basketIndex];
            basketList.RemoveAt(basketIndex);
            Destroy(tBasketGO);
            if(basketList.Count == 0)
            {
                SceneManager.LoadScene(2);
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
