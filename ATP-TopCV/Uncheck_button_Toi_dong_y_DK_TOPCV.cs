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
    ///The Uncheck_button_Toi_dong_y_DK_TOPCV recording.
    /// </summary>
    [TestModule("cc0bbfb4-1c1b-417b-b01f-a6b0a193ab38", ModuleType.Recording, 1)]
    public partial class Uncheck_button_Toi_dong_y_DK_TOPCV : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ATP_TopCVRepository repository.
        /// </summary>
        public static ATP_TopCVRepository repo = ATP_TopCVRepository.Instance;

        static Uncheck_button_Toi_dong_y_DK_TOPCV instance = new Uncheck_button_Toi_dong_y_DK_TOPCV();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Uncheck_button_Toi_dong_y_DK_TOPCV()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Uncheck_button_Toi_dong_y_DK_TOPCV Instance
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1234567890' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Phone'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.PhoneInfo, new RecordItemIndex(10));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Phone.PressKeys("1234567890");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ColMd9.Select2SelectionArrow' at 12;15.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ColMd9.Select2SelectionArrowInfo, new RecordItemIndex(11));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ColMd9.Select2SelectionArrow.Click("12;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.LiTagNam' at 200;30.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.LiTagNamInfo, new RecordItemIndex(12));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.LiTagNam.Click("200;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.TempCompanyName' at 109;12.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.TempCompanyNameInfo, new RecordItemIndex(13));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.TempCompanyName.Click("109;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Cong Ty TNHH Huyen Trang' with focus on 'ĐăngKyTaiKhoảnNhaTuyểnDụng.TempCompanyName'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.TempCompanyNameInfo, new RecordItemIndex(14));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.TempCompanyName.PressKeys("Cong Ty TNHH Huyen Trang");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.SomeBTag' at 2;4.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.SomeBTagInfo, new RecordItemIndex(15));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.SomeBTag.Click("2;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.NhanVien' at 154;6.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.NhanVienInfo, new RecordItemIndex(16));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.NhanVien.Click("154;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.DivTagRow.Select2SelectionArrow1' at 18;20.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.DivTagRow.Select2SelectionArrow1Info, new RecordItemIndex(17));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.DivTagRow.Select2SelectionArrow1.Click("18;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.LiTagHaNội' at 80;12.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.LiTagHaNộiInfo, new RecordItemIndex(18));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.Select2GenderResults.LiTagHaNội.Click("80;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.AgreeTerm' at 4;6.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.AgreeTermInfo, new RecordItemIndex(19));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.AgreeTerm.Click("4;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất' at 42;11.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTấtInfo, new RecordItemIndex(20));
            repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.HoanTất.Click("42;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Bạn chưa đồng ý với điều khoản dịch vụ của TopCV.') on item 'ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessage'.", repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, new RecordItemIndex(21));
            Validate.AttributeContains(repo.ĐăngKyTaiKhoảnNhaTuyểnDụng.ModalErrorMessageInfo, "InnerText", "Bạn chưa đồng ý với điều khoản dịch vụ của TopCV.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
