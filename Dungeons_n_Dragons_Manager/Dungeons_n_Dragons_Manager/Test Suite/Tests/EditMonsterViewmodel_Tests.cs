﻿using Dungeons_n_Dragons_Manager.Models;
using Dungeons_n_Dragons_Manager.Viewmodels;
using System.Collections.Generic;
using System.Linq;

namespace Dungeons_n_Dragons_Manager.Test_Suite.Tests
{
    /// <summary>
    /// Test class for the EncountersTabViewmodel class.
    /// </summary>
    internal class EditMonsterViewmodel_Tests
    {
        /// <summary>
        /// Defualt constructor.
        /// </summary>
        public EditMonsterViewmodel_Tests() { }

        /// <summary>
        /// Stores all testing results.
        /// </summary>
        private List<string> m_testingOutput = new List<string>();

        #region Functions

        /// <summary>
        /// Executes all tests.
        /// </summary>
        /// <returns>Returns m_testingOutput.</returns>
        public List<string> RunAllTests()
        {
            m_testingOutput.Add("\n\nEditMonsterTabViewmodel Tests"); //Add header.

            defaultConstructorTest();

            return m_testingOutput;
        }

        #region Tests

        /// <summary>
        /// Default constructor testing.
        /// </summary>
        private void defaultConstructorTest()
        {
            EditMonsterWindowViewmodel EditMonsterWindowViewmodel = new EditMonsterWindowViewmodel();

            m_testingOutput.Add("Default Constructor:");

            string test1 = "The custom monsters dropdown is filled with current custom monsters.--> ";
            if(EditMonsterWindowViewmodel.CustomMonsters == null) test1 += "PASSED";
            else test1 += "FAILED";
            m_testingOutput.Add(test1);
        }


        #endregion Tests

        #endregion Functions
    }
}