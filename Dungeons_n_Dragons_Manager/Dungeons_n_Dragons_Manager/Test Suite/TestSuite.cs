﻿using Dungeons_n_Dragons_Manager.Test_Suite.Tests;
using System;
using System.Collections.Generic;

namespace Dungeons_n_Dragons_Manager.Test_Suite
{
    internal class TestSuite
    {
        public TestSuite() { }

        private List<String> m_testingOutput = new List<string>();

        public List<string> RunAllTests()
        {
            m_testingOutput.AddRange(new EncountersTabViewmodel_Tests().RunAllTests()); //Add EncountersTabViewmodel tests.
            m_testingOutput.AddRange(new Monster_Tests().RunAllTests()); //Add Monster tests.

            return m_testingOutput;
        }
    }
}