using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class DialogsClass
{

    [XmlAttribute("SentenceNumber")]
    public int sentenceNumber;

    [XmlElement("name")]
    public string name;

    [XmlElement("Mood")]
    public string mood;

    [XmlElement("Dialog")]
    public string dialog;

}
