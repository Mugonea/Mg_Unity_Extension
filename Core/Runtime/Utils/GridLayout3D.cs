using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MUE
{
    [ExecuteInEditMode]
    public class GridLayout3D : MonoBehaviour
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        //
        //                    VARIABLES
        //
        ///////////////////////////////////////////////////////////////////////////////////////

        [SerializeField]
        private Vector3 m_Gap = Vector3.one;

        [SerializeField]
        private Vector3Int m_Counts = new Vector3Int(10, 10, 10);

        public Vector3 Gap { get => m_Gap; set => m_Gap = value; }

        public Vector3Int Counts { get => m_Counts; set => m_Counts = value; }


        ///////////////////////////////////////////////////////////////////////////////////////
        //
        //                    UNITY
        //
        ///////////////////////////////////////////////////////////////////////////////////////

        private void LateUpdate()
        {
            int childCount = transform.childCount;

            int childIndex = 0;

            for (int y = 0; y < Counts.y; y++)
            {
                for (int z = 0; z < Counts.z; z++)
                {
                    for (int x = 0; x < Counts.x; x++)
                    {
                        var child = transform.GetChild(childIndex++);

                        child.transform.localPosition = new Vector3(m_Gap.x * x, m_Gap.y * y, m_Gap.z * z);

                        if (childIndex == childCount)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}