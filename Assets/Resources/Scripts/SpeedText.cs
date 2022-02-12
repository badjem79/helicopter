using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
	private Text text;
	private int coins;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Speed: " + SkyscraperSpawner.speed;
    }
}
