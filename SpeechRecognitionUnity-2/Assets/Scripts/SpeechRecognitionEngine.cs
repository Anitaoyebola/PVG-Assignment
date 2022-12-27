using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class SpeechRecognitionEngine : MonoBehaviour
{
    public string[] keywords = { "right", "left", "down", "up" };
    public ConfidenceLevel confidence = ConfidenceLevel.Low;
    public float speed = .1f;

    public Text results;
    public Image target;

    protected KeywordRecognizer keywordRecognizer;
    protected string word = "right";

    private void Start()
    {
        keywordRecognizer = new KeywordRecognizer(keywords, confidence);
        keywordRecognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Recognizer_OnPhraseRecognized");

        word = args.text;
        results.text = "You said: <b>" + word + "</b>";
    }

    private void Update()
    {
        var x = target.transform.position.x;
        var y = target.transform.position.y;

        switch (word)
        {
            case "up":
                y += speed;
                break;
            case "down":
                y -= speed;
                break;
            case "left":
                x -= speed;
                break;
            case "right":
                x += speed;
                break;
        }

        target.transform.position = new Vector3(x, y, 0);
    }

    private void OnApplicationQuit()
    {
        if (keywordRecognizer != null && keywordRecognizer.IsRunning)
        {
            keywordRecognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            keywordRecognizer.Stop();
        }
    }
}
