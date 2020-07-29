using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    private Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        r.enabled = false;
        //StartCoroutine("FadeIn");
        //StartCoroutine("FadeOut");
        //r.enabled = false;
    }

    public void FadeOutAnima(Vector3 pos)
    {
        transform.position = pos;
        r.enabled = true;
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {
        

        for (float ft = 1f; ft >= 0; ft -= 0.05f)
        {
            Color c = r.material.color;
            c.a = ft;
            r.material.color = c;

            if (ft <= 0.05f)
            {
                r.enabled = false;
            }

            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator FadeIn()
    {
        for (float ft = 0f; ft <= 1; ft += 0.05f)
        {
            r.enabled = true;
            Color c = r.material.color;
            c.a = ft;
            r.material.color = c;

            yield return null;
        }
    }

}
