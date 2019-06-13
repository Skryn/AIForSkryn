using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGround : MonoBehaviour
{
    public Unit[] radiantUnits;
    public Unit[] direUnits;

    public GameObject unitDisplay;
    public Text textPrefab;

    void Start()
    {
        for (int i = 0; i < radiantUnits.Length; ++i)
        {
            GameObject ud = Instantiate(unitDisplay, new Vector2(-3f, i * 3 - 3), Quaternion.identity);
            unitDisplay.GetComponent<SpriteRenderer>().sprite = radiantUnits[i].DisplayIcon;
            Text txt = Instantiate(textPrefab, GameObject.Find("Canvas").transform);
            txt.text = radiantUnits[i].Name + "\nHealth: " + radiantUnits[i].Health.ToString() + "\nAttack: " + radiantUnits[i].Attack.ToString();
            Vector3 pos = Camera.main.WorldToScreenPoint(ud.transform.position);
            txt.transform.position = new Vector2(pos.x - 120f, pos.y);
        }

        for (int i = 0; i < direUnits.Length; ++i)
        {
            GameObject ud = Instantiate(unitDisplay, new Vector2(3f, i * 3 - 3), Quaternion.identity);
            unitDisplay.GetComponent<SpriteRenderer>().sprite = direUnits[i].DisplayIcon;
            Text txt = Instantiate(textPrefab, GameObject.Find("Canvas").transform);
            txt.text = direUnits[i].Name + "\nHealth: " + direUnits[i].Health.ToString() + "\nAttack: " + direUnits[i].Attack.ToString();
            Vector3 pos = Camera.main.WorldToScreenPoint(ud.transform.position);
            txt.transform.position = new Vector2(pos.x + 120f, pos.y);
        }
    }

}
