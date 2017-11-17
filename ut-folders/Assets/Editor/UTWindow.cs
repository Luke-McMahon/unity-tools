using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UTWindow : EditorWindow
{
    private bool _multipleFolders = false;
    private int _folderCount = 0;

    [MenuItem("UnityTools/Folder Set Up")]
    private static void Init()
    {
        UTWindow window = (UTWindow)GetWindow(typeof(UTWindow));
        window.titleContent.text = "<b>Unity Tools</b>";
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Folder Set Up");

        GUILayout.Space(10.0f);

        _multipleFolders = EditorGUILayout.BeginToggleGroup("Multiple Folders", _multipleFolders);
        _folderCount = EditorGUILayout.IntField("How many folders?", _folderCount);
        EditorGUILayout.EndToggleGroup();
    }
}

public struct Folder
{
    public bool _hasSubfolders;
    public File[] _files;
}

public struct File
{
    public string Name;
}