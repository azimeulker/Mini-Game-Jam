using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public float maxSize;
    public float growFactor;
    public float waitTime;

    public void MouseEnter()
    {
        StartCoroutine(Jitter());
    }

    public void MouseExit()
    {
        StopCoroutine(Jitter());
    }

    IEnumerator Jitter()
    {
        float timer = 0;

        while(maxSize > transform.localScale.x)
        {
            timer += Time.deltaTime;
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
            yield return null;
        }

        yield return new WaitForSeconds(waitTime);

        timer = 0;
        while(1 < transform.localScale.x)
        {
            timer += Time.deltaTime;
            transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
            yield return null;
        }

        timer = 0;
        yield return new WaitForSeconds(waitTime);
    }

    public void DisableItem()
    {
        this.gameObject.SetActive(false);
    }
}
