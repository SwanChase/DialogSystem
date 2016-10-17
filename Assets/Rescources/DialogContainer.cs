using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("DialogCollection")]
public class DialogContainer
{
    [XmlArray("DialogItems")]
    [XmlArrayItem("DialogItem")]
    public List<DialogsClass> dialogs = new List<DialogsClass>();

    public static DialogContainer Load(string path)
    {
        /*
        XmlDocument doc = new XmlDocument();
        doc.Load(path);

        XmlNodeList nodeList;
        XmlNode root = doc.DocumentElement;
        */
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(DialogContainer));

        StreamReader reader = new StreamReader(path);

        DialogContainer dialogs = serializer.Deserialize(reader) as DialogContainer;

        reader.Close();


        return dialogs;
    }
}
