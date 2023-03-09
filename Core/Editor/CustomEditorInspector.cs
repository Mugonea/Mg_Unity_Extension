using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MUE
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(GMonoBehaviour), true, isFallback = true)]
    public class CustomEditorInsepctor : Editor
    {
        public override void OnInspectorGUI()
        {
            if (target is ICustomEditorInsepctor t)
            {
                if (t.EditorCallBaseInspectorGUI())
                {
                    base.OnInspectorGUI();
                }
                t.EditorInspectorGUI();
            }
            else
            {
                base.OnInspectorGUI();
            }
        }

        protected override void OnHeaderGUI()
        {
            if (target is ICustomEditorHeader t)
            {
                t.EditorHeaderGUI();
            }
            else
            {
                base.OnHeaderGUI();
            }
        }

        public override GUIContent GetPreviewTitle()
        {
            if (target is ICustomEditorPreview t)
            {
                return t.EditorPreviewTitle();
            }
            else
            {
                return base.GetPreviewTitle();
            }
        }

        public override bool HasPreviewGUI()
        {
            if (target is ICustomEditorPreview t)
            {
                return t.EditorHasPreview();
            }
            else
            {
                return base.HasPreviewGUI();
            }
        }

        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
            if (target is ICustomEditorPreview t)
            {
                t.EditorPreviewGUI(r, background);
            }
            else
            {
                base.OnPreviewGUI(r, background);
            }
        }

        protected virtual void OnSceneGUI()
        {
            if (target is ICustomEditorScene t)
            {
                t.EditorSceneGUI();
            }
        }
    }
}