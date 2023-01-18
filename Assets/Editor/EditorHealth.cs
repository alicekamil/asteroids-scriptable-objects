using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EditorHealth : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/EditorHealth")]
    public static void ShowExample()
    {
        EditorHealth wnd = GetWindow<EditorHealth>();
        wnd.titleContent = new GUIContent("EditorHealth");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);
    }
}
