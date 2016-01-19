namespace Framework.Base.App.@object
{
    partial class AppFunctionsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppFunctionsView));
            this.windowsUIButtonPanel2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel2
            // 
            this.windowsUIButtonPanel2.BackColor = System.Drawing.Color.Transparent;
            this.windowsUIButtonPanel2.ButtonBackgroundImages = this.imageList1;
            this.windowsUIButtonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsUIButtonPanel2.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel2.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel2.Name = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.windowsUIButtonPanel2.Size = new System.Drawing.Size(150, 150);
            this.windowsUIButtonPanel2.TabIndex = 8;
            this.windowsUIButtonPanel2.Text = "windowsUIButtonPanel2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "transparent1.png");
            this.imageList1.Images.SetKeyName(1, "transparent2.png");
            this.imageList1.Images.SetKeyName(2, "transparent3.png");
            // 
            // AppFunctionsView
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.windowsUIButtonPanel2);
            this.Name = "AppFunctionsView";
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel2;
        private System.Windows.Forms.ImageList imageList1;
    }
}
