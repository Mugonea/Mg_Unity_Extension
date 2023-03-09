#nullable enable

using System.Diagnostics;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace MUE
{
    public static class __EditorExtension
    {
        [Conditional("UNITY_EDITOR")]
        public static void EditorRecord(this Object? obj, string? msg = null)
        {
#if UNITY_EDITOR
            if (obj.IsLive())
            {
                Undo.RecordObject(obj, msg ?? ("Record " + obj.name));
            }
#endif
        }

        [Conditional("UNITY_EDITOR")]
        public static void EditorSetDirty(this Object? obj)
        {
#if UNITY_EDITOR
            if (obj.IsLive())
            {
                EditorUtility.SetDirty(obj);
            }
#endif
        }
    }
}