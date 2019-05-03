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
    ///The Confirm_PassWord_Null recording.
    /// </summary>
    [TestModule("e5aceb6d-890d-4708-99fd-1b3015ff0d3f", ModuleType.Recording, 1)]
    public partial class Confirm_PassWord_Null : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ATP_TopCVRepository repository.
        /// </summary>
        public static ATP_TopCVRepository repo = ATP_TopCVRepository.Instance;

        static Confirm_PassWord_Null instance = new Confirm_PassWord_Null();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Confirm_PassWord_Null()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Confirm_PassWord_Null Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email' at 234;36.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(0));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.Click("234;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'trangdth1{LShiftKey down}@{LShiftKey up}gmail.com' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(1));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.PressKeys("trangdth1{LShiftKey down}@{LShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 172;14.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(2));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("172;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1' at 170;24.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1Info, new RecordItemIndex(3));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1.Click("170;24");
            Delay.Milliseconds(4980);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 49;11.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(4));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("49;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'trangtrang' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(5));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.PressKeys("trangtrang");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất' at 51;8.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTấtInfo, new RecordItemIndex(6));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất.Click("51;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRa'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo, new RecordItemIndex(7));
            Validate.Exists(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại' at 210;27.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLạiInfo, new RecordItemIndex(8));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại.Click("210;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation' at 105;12.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmationInfo, new RecordItemIndex(9));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation.Click("105;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '            ' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmationInfo, new RecordItemIndex(10));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation.PressKeys("            ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất' at 51;8.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTấtInfo, new RecordItemIndex(11));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất.Click("51;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRa'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo, new RecordItemIndex(12));
            Validate.Exists(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐaCoLỗiXảyRaInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại' at 210;27.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLạiInfo, new RecordItemIndex(13));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại.Click("210;27");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
