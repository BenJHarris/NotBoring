using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnitSpeech : MonoBehaviour
{
    public TextMeshPro speechPrefab;
    public Vector3 speechOffset = new Vector3(0, 1, 0);
    private TextMeshPro currentText;
    private IEnumerator coroutine;

    public void Say(string sentence, float timeToShow = 3f)
    {

        if (coroutine != null)
        {
            StopCoroutine(coroutine);
            coroutine = null;
        }

        if (currentText == null)
        {
            currentText = Instantiate(speechPrefab, Vector3.zero, Quaternion.identity);
        }

        currentText.text = sentence;
        currentText.transform.SetParent(transform);

        coroutine = RemoveTextAfterSeconds(timeToShow);
        StartCoroutine(coroutine);
    }

    public void Update()
    {
        if (currentText != null)
        {
            currentText.transform.position = transform.position + speechOffset;
        }
    }

    public IEnumerator RemoveTextAfterSeconds(float timeToShow)
    {
        yield return new WaitForSeconds(timeToShow);
        Destroy(currentText.gameObject);
        currentText = null;
    }
}
