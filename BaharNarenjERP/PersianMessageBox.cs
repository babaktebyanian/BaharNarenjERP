using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaharNarenjERP
{
    public static class PersianMessageBox
    {
        private static Form _dialog;
        private static Label _lblmessage;
        private static Button _btnOk;
        private static Button _btnCancel;
        private static Button _btnYes;
        private static Button _btnNo;
        private static Button _btnIgnore;
        private static Button _btnAbort;
        private static Button _btnRetry;
        private static DialogResult _dr = DialogResult.Cancel;
        public static DialogResult Show(string message, string title)
        {
            var dlgFont = new Font("B Yekan", 9.5f);
            _dialog = new Form
            {
                Name = "FrmMessage",
                Height = 120,
                Width = 75,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ControlBox = false,
                Font = dlgFont,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterParent,
                Text = title,
                MinimumSize = new Size(180,100)
            };

            _lblmessage = new Label
            {
                Name="LblMessage",
                AutoSize = true,
                BorderStyle = BorderStyle.None,
                RightToLeft = RightToLeft.Yes,
                Left = _dialog.Left + 15,
                Top = _dialog.Top + 15,
                Font= dlgFont,
                Text = message + Environment.NewLine + Environment.NewLine
            };
            _dialog.Controls.Add(_lblmessage);

            _btnOk = new Button
            {
                Name = "BtnOk",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.OK,
                Font = dlgFont,
                TabIndex = 0,
                Text = @"باشه",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 90
            };
            _btnOk.Click += Action;

            _btnCancel = new Button
            {
                Name = "BtnCancel",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.Cancel,
                Font = dlgFont,
                TabIndex = 1,
                Text = @"لغو",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 175
            };
            _btnCancel.Click += Action;

            _btnYes = new Button
            {
                Name = "BtnYes",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.Yes,
                Font = dlgFont,
                TabIndex = 2,
                Text = @"بله",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 90
            };
            _btnYes.Click += Action;

            _btnNo = new Button
            {
                Name = "BtnNo",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.No,
                Font = dlgFont,
                TabIndex = 3,
                Text = @"خیر",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 175
            };
            _btnNo.Click += Action;

            _btnAbort = new Button
            {
                Name = "BtnAbort",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.Abort,
                Font = dlgFont,
                TabIndex = 4,
                Text = @"ترک عملیات",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 430
            };
            _btnAbort.Click += Action;

            _btnIgnore = new Button
            {
                Name = "BtnIgnore",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.Ignore,
                Font = dlgFont,
                TabIndex = 5,
                Text = @"نادیده گرفتن",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 515
            };
            _btnIgnore.Click += Action;

            _btnRetry = new Button
            {
                Name = "BtnRetry",
                Height = 26,
                Width = 80,
                DialogResult = DialogResult.Retry,
                Font = dlgFont,
                TabIndex = 6,
                Text = @"تلاش دوباره",
                Top = _dialog.Bottom - 36,
                Left = _dialog.Right - 600
            };
            _btnRetry.Click += Action;

            //_dialog.Controls.Add(_btnOk);
            //.Controls.Add(_btnCancel);
            _dialog.Controls.Add(_btnYes);
            _dialog.Controls.Add(_btnNo);
            //_dialog.Controls.Add(_btnIgnore);
            //_dialog.Controls.Add(_btnAbort);
            //_dialog.Controls.Add(_btnRetry);
            _dialog.AcceptButton = _btnYes;
            _dialog.CancelButton = _btnNo;

            _dialog.ShowDialog();
            return _dr;
        }

        private static void Action(object sender, EventArgs e)
        {
            var f = sender as Form;
            var b = sender as Button;
            if (b != null) _dr = b.DialogResult;
            //if (b != null && b.Name == "BtnOk")
            //    dr = DialogResult.OK;
            //if (b != null && b.Name == "BtnCancel")
            //    dr = DialogResult.Cancel;
            if (f != null) f.Close();
        }
    }
}
