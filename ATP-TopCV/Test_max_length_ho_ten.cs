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
    ///The Test_max_length_ho_ten recording.
    /// </summary>
    [TestModule("0d65e250-6edd-4e74-9d62-558e05390fd1", ModuleType.Recording, 1)]
    public partial class Test_max_length_ho_ten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ATP_TopCVRepository repository.
        /// </summary>
        public static ATP_TopCVRepository repo = ATP_TopCVRepository.Instance;

        static Test_max_length_ho_ten instance = new Test_max_length_ho_ten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Test_max_length_ho_ten()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Test_max_length_ho_ten Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email' at 234;36.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(0));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.Click("234;36");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'trangdth1{LShiftKey down}@{LShiftKey up}gmail.com' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Email'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.EmailInfo, new RecordItemIndex(1));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Email.PressKeys("trangdth1{LShiftKey down}@{LShiftKey up}gmail.com");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 87;16.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(2));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("87;16");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1' at 177;22.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1Info, new RecordItemIndex(3));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại1.Click("177;22");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password' at 87;16.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(4));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.Click("87;16");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Trang{LShiftKey down}{@ down}{LShiftKey up}123' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Password'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordInfo, new RecordItemIndex(5));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Password.PressKeys("Trang{LShiftKey down}{@ down}{LShiftKey up}123");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation' at 97;15.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmationInfo, new RecordItemIndex(6));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation.Click("97;15");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Trang{LShiftKey down}{@ down}{LShiftKey up}123' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmationInfo, new RecordItemIndex(7));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PasswordConfirmation.PressKeys("Trang{LShiftKey down}{@ down}{LShiftKey up}123");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Fullname' at 121;32.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.FullnameInfo, new RecordItemIndex(8));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Fullname.Click("121;32");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'trangtrangtrangtrangtrangtrangtrang' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Fullname'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.FullnameInfo, new RecordItemIndex(9));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Fullname.PressKeys("trangtrangtrangtrangtrangtrangtrang");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất' at 42;11.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTấtInfo, new RecordItemIndex(10));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất.Click("42;11");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessage'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, new RecordItemIndex(11));
            Validate.Exists(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Loi_ho_ten1' with region {X=1,Y=2,Width=363,Height=18}) on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessage'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, new RecordItemIndex(12));
            //Validate.CompareImage(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, ModalErrorMessage_Loi_ho_ten1, ModalErrorMessage_Loi_ho_ten1_Options);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại' at 181;14.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLạiInfo, new RecordItemIndex(13));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ĐongLại.Click("181;14");
            
        }

#region Image Feature Data
        CompressedImage ModalErrorMessage_Loi_ho_ten1
        { get { return repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo.GetLoi_ho_ten1(new Rectangle(1, 2, 363, 18)); } }

        Imaging.FindOptions ModalErrorMessage_Loi_ho_ten1_Options
        { get { return Imaging.FindOptions.Parse("1;None;1,2,363,18;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
