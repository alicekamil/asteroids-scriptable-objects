using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

#if true // compiler instructions

public class AsteroidManagerEditor : EditorWindow
{
    public VisualTreeAsset uxml;
    public AsteroidManager asteroidManager;
    [MenuItem("Editor/Custom")]
    public static void ShowWindow()
    {
        AsteroidManagerEditor window = GetWindow<AsteroidManagerEditor>();
        window.titleContent = new GUIContent("Custom Window");
        window.minSize = new Vector2(400, 400);
        window.maxSize = new Vector2(400, 400);
    }
    private void CreateGUI()
    {
        uxml.CloneTree(rootVisualElement);
    }
    private void OnEnable() 
    {
        asteroidManager ??= Resources.Load("CurrentAsteroidsSettings")as AsteroidManager; //setting scriptable object//cast
        var asteroidSettings = new SerializedObject(asteroidManager);
        rootVisualElement.Bind(asteroidSettings);
    }


}

#endif
