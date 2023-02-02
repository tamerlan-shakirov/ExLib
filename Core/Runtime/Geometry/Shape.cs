/* ================================================================
   ----------------------------------------------------------------
   Project   :   Aurora FPS Engine
   Publisher :   Renowned Games
   Developer :   Zinnur Davleev
   ----------------------------------------------------------------
   Copyright 2022-2023 Renowned Games All rights reserved.
   ================================================================ */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenownedGames.ExLib
{
    [Serializable]
    public class Shape : IEnumerable
    {
        [SerializeField]
        private List<Vector2> points = new List<Vector2>();

        public void Insert(int index, Vector2 point)
        {
            points.Insert(index, point);
        }

        public void RemoveAt(int index)
        {
            points.RemoveAt(index);
        }

        public bool IsPointInside(Vector2 point)
        {
            return Math2D.PointInPolygon(point, points);
        }

        #region [Indexer Implementation]
        public Vector2 this[int index]
        {
            get
            {
                return points[index];
            }
            set
            {
                points[index] = value;
            }
        }
        #endregion

        #region [IEnumerable Implementation]
        public IEnumerator GetEnumerator()
        {
            foreach (Vector2 point in points)
            {
                yield return point;
            }
        }
        #endregion

        #region [Getter / Setter]
        public List<Vector2> GetPoints()
        {
            return points;
        }
        #endregion
    }
}