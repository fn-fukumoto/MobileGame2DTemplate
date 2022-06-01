using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUI : MonoBehaviour
{
    private bool counting = false;
    private TextMeshProUGUI counter;
    private float cnt = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = transform.GetChild(1).GetComponent<Button>();
        TextMeshProUGUI txt = btn.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        counter = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        btn.onClick.AddListener(() => {
            if (counting)
            {
                counting = !counting;
                txt.text = "START";
                cnt = 0.0f;
            }
            else
            {
                counting = !counting;
                txt.text = "STOP";
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (counting)
        {
            cnt += 0.01f;
            float tmp = Mathf.Floor(cnt * 100) / 100;
            counter.text = tmp.ToString("F2");
        }
    }
}
