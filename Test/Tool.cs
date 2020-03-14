﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace Altseed.Test
{
    [TestFixture]
    class Tool
    {
        [Test, Apartment(ApartmentState.STA)]
        public void BeginEnd()
        {
            var tc = new TestCore();
            tc.Init();
            
            tc.LoopBody(c =>
            {
                if (Engine.Tool.Begin("Test", ToolWindow.None))
                {
                    Engine.Tool.End();
                }
            }
            , null);

            tc.End();
        }
    }
}
