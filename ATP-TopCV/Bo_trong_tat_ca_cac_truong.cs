﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ATP_TopCV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bo_trong_tat_ca_cac_truong recording.
    /// </summary>
    [TestModule("e58dd50e-8cae-4580-97fe-86d405ee9b27", ModuleType.Recording, 1)]
    public partial class Bo_trong_tat_ca_cac_truong : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ATP_TopCVRepository repository.
        /// </summary>
        public static ATP_TopCVRepository repo = ATP_TopCVRepository.Instance;

        static Bo_trong_tat_ca_cac_truong instance = new Bo_trong_tat_ca_cac_truong();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bo_trong_tat_ca_cac_truong()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bo_trong_tat_ca_cac_truong Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất' at 20;14.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTấtInfo, new RecordItemIndex(0));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất.Click("20;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRa'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo, new RecordItemIndex(1));
            Validate.Exists(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại' at 223;26.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLạiInfo, new RecordItemIndex(2));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại.Click("223;26");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}