using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.currentPlant == null)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load("Scenes/Sprites/General/Shovel", typeof(Sprite)) as Sprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = GameManager.currentPlant.GetComponent<SpriteRenderer>().sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var MouseP = Input.mousePosition;
        MouseP.z = transform.position.z - Camera.main.transform.position.z;
        transform.position = Camera.main.ScreenToWorldPoint(MouseP);

        if (GameManager.currentPlant == null && !GameManager.ShovelEnabled)
        {
            Destroy(gameObject);
        }


    }
}
