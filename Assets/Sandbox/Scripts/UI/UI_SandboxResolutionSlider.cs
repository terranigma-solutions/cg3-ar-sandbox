﻿/*  
 *  This file is part of sensilab-ar-sandbox.
 *
 *  sensilab-ar-sandbox is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 * 
 *  sensilab-ar-sandbox is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 * 
 *  You should have received a copy of the GNU General Public License
 *  along with sensilab-ar-sandbox.  If not, see <https://www.gnu.org/licenses/>.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ARSandbox
{
    public class UI_SandboxResolutionSlider : MonoBehaviour
    {
        public Text SliderTextBox;

        public void UpdateText(float value)
        {
            if (value == 0)
            {
                SliderTextBox.text = "Value: Low";
            }
            else if (value == 1)
            {
                SliderTextBox.text = "Value: Medium";
            }
            else
            {
                SliderTextBox.text = "Value: High";
            }
        }
    }
}
