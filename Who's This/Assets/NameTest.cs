using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class NameTest : MonoBehaviour {
    public Text Textfield;
    public Text FrameCounter;
    public Text FPS;
    public Text Incorrect;
    public InputField InputTextfield;
    public string test;
    private int WRONG;

    public AudioSource h31p;

    public bool GotIt;

    private int frameid;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("blocked", 0) == 1)
        {
            Application.Quit();
        }
        if (File.Exists("C:/Users/Public/Documents/ProjectGameThingy/activation.txt")){
            Debug.Log("File Found");
            readTextFile("C:/Users/Public/Documents/ProjectGameThingy/activation.txt");
        }
        else {
            Debug.Log("Activation not found, preparing to quit");
            Application.Quit();
        }
        Textfield.text = "Hi there, What's your name.";
        InputTextfield.text = "";
        Debug.Log(Environment.UserName);
    }

    void readTextFile(string file_path)
    {
        StreamReader inp_stm = new StreamReader(file_path);

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            if(inp_ln != "sAppiesZIJNl3kkr")
            {
                 Debug.Log("INVALID ACTIAVTION");
                Application.Quit();
            }
            else
            {
                Debug.Log("Valid code!");
            }
        }

        inp_stm.Close();
    }

    // Update is called once per frame
    void Update () {
        Incorrect.text = "Attempts: " + -(WRONG - 6);
        frameid++;
        FrameCounter.text = "FRAME: " + frameid;
        float current = (int)(1f / Time.unscaledDeltaTime);
        FPS.text = "FPS: " + current;
        if (!GotIt)
        {
            if (Input.GetKeyDown("return"))
            {
                if (InputTextfield.text.ToLower() == Environment.UserName)
                {
                    GotIt = true;
                    h31p.Play();
                    WRONG = 0;
                    Textfield.fontSize = 14;
                    Textfield.text = "Good boy.";
                    Screen.fullScreen = true;
                    File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/good boy.txt", "you are a good boy.. į̴̽̀͒͑̽̑̇ͮͫ͞҉̸͓̟̠͚̲̟͕̺̞̦̘̮̘͇ ̡̨̲̥̳̣̯͈̘͕̮͇͎̯̮̞̭̮́̊̃ͣ̋̉ͮ͐̄͋͋́͛̐ͤ̽̌ͮ̒h́̉͒̋̆ͦ͜҉͓͙͚͙̙ơ̸̢̻̟̙̭̮͈͈̖͋̋ͭ͌̽̇̓̌͞p̿̀̅̔ͬ̄̓̈̀̔͑̊̀ͩͫ̚҉̬̲̮̜͍̺̱̙͈̣̰̟͔̲͉͘ͅę̶̞͈̦̭̳̙͚̦̤̌̐͊̊ͮ̕͡ ̋ͧͨ͋ͯͦͫ̇̃̂̾͂̃͐̀ͦ͗̚҉̶̡͇̹͙̝̠͇̳̥͙̣̲͚̀ͅͅͅyͨ̀ͥ̿ͫ̒ͩͮ͏̵̪̻̟̟͎͍̟̻̗̗͚̯͉̖͙͔̥̯̀ͅo̵̶͇͙̹͈͎͇͍̪͎͇̥͇̜͍̟̱ͧ̊͐ͤ̓̌ͪ̆̍̒̅ͩͪ̈́̊̆͘͡͝u̶̧̡̲̼̻̭̠̼̬̹͛͗̈̄́̐̇̑ͩͥ͛ͦ̿̉ͫ̑ ̡̛̋͗̓́̿͐͌ͩ̑҉̵̰̱͉͓̠̣͍̤̜̮̥̪͙̝͞ͅͅd̷̸͈͈̹̺͓̎ͯ͊̅̋͒̌̈́̊i̵̛̜͖̠̙̰͖͔̠͚̝̠̝̟̝̝͚͍ͭ̾ͧ̉̾̏̾̅̏͐́̊e̸̓̃̉̃̍̒́ͬ͂ͫ̿̽͋͐ͯ͐ͫ͏͖͎͕̝͉͉̗͇͖̞̯̖̥͇");
                    
                }

                if (InputTextfield.text == "")
                {
                    Textfield.fontSize++;
                    Textfield.text = "WRITE SOMETHING!";
                }
                else if(InputTextfield.text.ToLower() != Environment.UserName && InputTextfield.text.ToLower() != "")
                {
                    WRONG++;
                    Textfield.fontSize++;
                    Textfield.text = "No it's not.";
                    if (WRONG >= 3)
                    {
                        Textfield.text = "COME ON, YOU KNOW IT.";
                    }
                    if (WRONG >= 5)
                    {
                        Textfield.text = "i am very dissapointed in you " + Environment.UserName + "..";
                    }
                    if(WRONG >= 6)
                    {
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuckyou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck y ou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck y o u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuc k y o u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f uc k y o u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f u c k y o u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fu ck yo u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f uc ky ou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f u c ky o u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f uck you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fu ck you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuc k you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck y ou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck yo u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f u c k you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f u ck you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck.you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck_you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck_y_ou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuck_y_o_u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fuc_k_y_o_u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/fu_c_k_y_o_u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f_u_c_k_y_o_u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f_u_c_k_y_ou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f_u_c_k_you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f_u_ckyou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f_uckyou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f.u.c.k.y.o.u.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f.u.c.k.y.ou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f.u.c.k.you.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f.u.c.kyou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f.u.ckyou.txt", "Fuck you");
                        File.WriteAllText("C:/Users/Public/Documents/ProjectGameThingy/f.uckyou.txt", "Fuck you");
                        Textfield.text = "Fuck you, you are not worthy!";
                        File.Delete("C:/Users/Public/Documents/ProjectGameThingy/activation.txt");
                        PlayerPrefs.SetInt("blocked", 1);
                        Application.Quit();
                    }
                }
                InputTextfield.text = "";

                if (Textfield.fontSize > 60)
                {
                    Textfield.fontSize = 60;
                }
            }
        }
	}
}
