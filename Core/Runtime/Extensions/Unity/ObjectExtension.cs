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
        /// 유니지 객체가 삭제됐는지 검사한다.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsLive([NotNullWhen(true)] this Object? obj)
        {
            return obj != null && obj;
        }
    }
}