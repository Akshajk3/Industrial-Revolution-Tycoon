using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private Items item;
    public float money;
    public TextMeshProUGUI moneyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        item = collision.gameObject.GetComponent<Items>();
        money += item.value;
    }
}
