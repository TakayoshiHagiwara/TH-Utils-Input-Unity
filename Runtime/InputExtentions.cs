// -----------------------------------------------------------------------
// Author:  Takayoshi Hagiwara (Toyohashi University of Technology)
// Created: 2023/6/12
// Summary: Utility class for input. Enables processing that is not available in UnityEngine's Input class.
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using UnityEngine;

namespace TH.Utils
{
    public static class InputExtentions
    {
        static bool isInput;
        static KeyCode keyCode;

        /// <summary>
        /// Decision when any KeyCode other than a specific KeyCode is received.
        /// </summary>
        /// <param name="keycode">KeyCode to except from decision.</param>
        /// <returns>Returns true if a KeyCode other than a specific KeyCode is received.</returns>
        public static bool AnyKeyDownExceptSpecificKeyCode(KeyCode keycode)
        {
            if (Input.anyKeyDown)
            {
                foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
                {
                    if (Input.GetKeyDown(code))
                    {
                        if (code == keycode)
                            return false;
                        else
                            return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Decision when any KeyCode other than a specific KeyCode in the list is received.
        /// </summary>
        /// <param name="keycodes">KeyCode list to except from decision.</param>
        /// <returns>Returns true if a KeyCode other than a specific KeyCode in the list is received.</returns>
        public static bool AnyKeyDownExceptSpecificKeyCode(List<KeyCode> keycodes)
        {
            isInput = false;

            foreach (KeyCode keycode in keycodes)
            {
                if (!AnyKeyDownExceptSpecificKeyCode(keycode))
                    return false;
                else
                    isInput = true;
            }
            return isInput;
        }

        /// <summary>
        /// Returns the input KeyCode.
        /// </summary>
        /// <returns>Input KeyCode.</returns>
        public static KeyCode GetInputKeyCode()
        {
            keyCode = KeyCode.None;

            if (Input.anyKeyDown)
            {
                foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
                {
                    if (Input.GetKeyDown(code))
                        return code;
                }
            }
            return keyCode;
        }
    }
}

