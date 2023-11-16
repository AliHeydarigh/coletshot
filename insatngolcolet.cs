using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class insatngolcolet : MonoBehaviour
{
    [SerializeField] GameObject shotpoinet;
    [SerializeField] GameObject kheshab;
    [SerializeField] GameObject tir;
    [SerializeField] GameObject poketir;
    [SerializeField] GameObject kheshab_position;
    [SerializeField] GameObject poketir_position;
    [SerializeField] Text khsab;
    [SerializeField] int khsab_limit;
    // Start is called before the first frame update
    void Start()
    {
        load();
    }

    // Update is called once per frame
    void Update()
    {
        khsab.text = khsab_limit.ToString();
        if(khsab_limit == 7)
        {
            khsab_limit = 0;
            keshb();

        }
        if (Input.GetMouseButtonDown(0))
        {
            tirandazi();
        }
    }
    void tirandazi()
    {
        if(shotpoinet.transform.rotation.eulerAngles.y == 180)
        {
            GameObject A = Instantiate(tir, shotpoinet.transform.position, Quaternion.identity);
            A.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000);
            GameObject C = Instantiate(poketir , poketir_position.transform.position, Quaternion.identity);
            Destroy(C , 3);
            khsab_limit += 1;

        }
        if (shotpoinet.transform.rotation.eulerAngles.y == 0)
        {
            GameObject A = Instantiate(tir, shotpoinet.transform.position, Quaternion.identity);
            A.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 1000);
            GameObject C = Instantiate(poketir, poketir_position.transform.position, Quaternion.identity);
            Destroy(C, 3);
        }

    }
    void keshb()
    {
        GameObject B = Instantiate(kheshab, kheshab_position.transform.position, Quaternion.identity);
        Destroy(B , 2);


    }
    void save()
    {
        PlayerPrefs.DeleteAll();
        khsab_limit = PlayerPrefs.GetInt("khsab");
        khsab.text = khsab.ToString();
    }
    void load()
    {
        khsab_limit = PlayerPrefs.GetInt("khsab");
        khsab.text = khsab.ToString();
    }
}
