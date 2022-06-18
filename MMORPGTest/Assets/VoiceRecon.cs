using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecon : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, Action> commands = new Dictionary<string, Action>();

    void Start()
    {

        Debug.Log("were active!");
        commands.Add("fireball", fireball);
        commands.Add("fireball x ten", fireball2);
        commands.Add("healing aura", aura);
        commands.Add("warp portal", portal);

        keywordRecognizer = new KeywordRecognizer(commands.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += hasRecongnized;
        keywordRecognizer.Start();
    }

    void hasRecongnized(PhraseRecognizedEventArgs command)
    {
        Debug.Log(command.text);
        commands[command.text].Invoke();
    }

    void fireball()
    {
        Instantiate(Resources.Load("Fireball"));
    }
    void fireball2()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Resources.Load("Fireball"));

        }
    }
    void portal()
    {
        Instantiate(Resources.Load("Portal"));
    }
    void aura()
    {
        Instantiate(Resources.Load("Aura"));
    }
}