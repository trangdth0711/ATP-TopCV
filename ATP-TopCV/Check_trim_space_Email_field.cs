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
    ///The Check_trim_space_Email_field recording.
    /// </summary>
    [TestModule("9f3cdf5e-b733-4819-b366-adc76bd0b5f8", ModuleType.Recording, 1)]
    public partial class Check_trim_space_Email_field : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ATP_TopCVRepository repository.
        /// </summary>
        public static ATP_TopCVRepository repo = ATP_TopCVRepository.Instance;

        static Check_trim_space_Email_field instance = new Check_trim_space_Email_field();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_trim_space_Email_field()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Check_trim_space_Email_field Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email' at 179;21.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(0));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.Click("179;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '      trangdth0711{LShiftKey down}@{LShiftKey up}gmail.com' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(1));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.PressKeys("      trangdth0711{LShiftKey down}@{LShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 83;23.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(2));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("83;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRa'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại' at 271;19.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLạiInfo, new RecordItemIndex(4));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại.Click("271;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email' at 249;28.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(5));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.Click("249;28");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email' at 197;15.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(6));
            //repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.Click("197;15");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '       ' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(7));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.PressKeys("       ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 224;10.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(8));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("224;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRa'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo, new RecordItemIndex(9));
            Validate.Exists(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại' at 182;25.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLạiInfo, new RecordItemIndex(10));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại.Click("182;25");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
