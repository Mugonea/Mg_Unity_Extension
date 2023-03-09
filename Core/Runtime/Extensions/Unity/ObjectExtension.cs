#nullable enable

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace MUE
{
    public static class __ObjectExtension
    {
        /// <summary>
        /// ������ ��ü�� �����ƴ��� �˻��Ѵ�.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsLive([NotNullWhen(true)] this Object? obj)
        {
            return obj != null && obj;
        }
    }
}