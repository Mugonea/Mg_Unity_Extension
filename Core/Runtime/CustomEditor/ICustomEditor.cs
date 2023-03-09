using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MUE
{
    public interface ICustomEditor
    {
    }

    public interface ICustomEditorPreview : ICustomEditor
    {
        bool EditorHasPreview();
        GUIContent EditorPreviewTitle();
        void EditorPreviewGUI(Rect r, GUIStyle background);
    }

    public interface ICustomEditorInsepctor : ICustomEditor
    {
        bool EditorCallBaseInspectorGUI();
        void EditorInspectorGUI();
    }

    public interface ICustomEditorHeader : ICustomEditor
    {
        void EditorHeaderGUI();
    }

    public interface ICustomEditorScene : ICustomEditor
    {
        void EditorSceneGUI();
    }
}