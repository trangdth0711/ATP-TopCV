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
    ///The Test_trim_space_SDT recording.
    /// </summary>
    [TestModule("8c1ede25-0745-4cc5-a0f6-063f623d1c6c", ModuleType.Recording, 1)]
    public partial class Test_trim_space_SDT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ATP_TopCVRepository repository.
        /// </summary>
        public static ATP_TopCVRepository repo = ATP_TopCVRepository.Instance;

        static Test_trim_space_SDT instance = new Test_trim_space_SDT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Test_trim_space_SDT()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Test_trim_space_SDT Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 87;16.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(2));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("87;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1' at 177;22.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1Info, new RecordItemIndex(3));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1.Click("177;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 87;16.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(4));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("87;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Trang{LShiftKey down}{@ down}{LShiftKey up}123' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(5));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.PressKeys("Trang{LShiftKey down}{@ down}{LShiftKey up}123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation' at 97;15.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmationInfo, new RecordItemIndex(6));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation.Click("97;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Trang{LShiftKey down}{@ down}{LShiftKey up}123' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmationInfo, new RecordItemIndex(7));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation.PressKeys("Trang{LShiftKey down}{@ down}{LShiftKey up}123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Huyen Trang' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Fullname'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.FullnameInfo, new RecordItemIndex(8));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Fullname.PressKeys("Huyen Trang");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Phone' at 276;28.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PhoneInfo, new RecordItemIndex(9));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Phone.Click("276;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' 1234567 ' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Phone'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PhoneInfo, new RecordItemIndex(10));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Phone.PressKeys(" 1234567 ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất' at 42;11.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTấtInfo, new RecordItemIndex(11));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất.Click("42;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Điện thoại cá nhân từ 9-12 ký tự.') on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessage'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, new RecordItemIndex(12));
            Validate.AttributeContains(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, "InnerText", "Điện thoại cá nhân từ 9-12 ký tự.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
