using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.Interface
{

    /// <summary>
    /// CheckCalculate State
    /// </summary>
    public interface ICheckCalCulated
    {

        /// <summary>
        /// For Checking a Calculation
        /// </summary>
        /// <param name="scoreP1"></param>
        /// <param name="scoreP2"></param>
        void CheckCalculate(int scoreP1, int scoreP2);
    }
}


