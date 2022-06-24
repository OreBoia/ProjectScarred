using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Emotion { Idle, Sad, Angry, Happy }
public enum BubblePosition { Right, Left}

public class DialogScriptableObject : ScriptableObject
{
    [System.Serializable]
    public class DialogString
    {
        public string sentence;
        public int id;
        public Emotion emotion;
        public Color colorFrame;
        public Color colorText;
        public BubblePosition bubblePosition;
    }

    public List<DialogString> strings = new List<DialogString>();

}
