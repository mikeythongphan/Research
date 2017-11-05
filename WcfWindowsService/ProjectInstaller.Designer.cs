namespace WcfWindowsService
{
    partial class ProjectInstaller
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
            this.wcfServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.wcfServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // wcfServiceProcessInstaller
            // 
            this.wcfServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.wcfServiceProcessInstaller.Password = null;
            this.wcfServiceProcessInstaller.Username = null;
            // 
            // wcfServiceInstaller
            // 
            this.wcfServiceInstaller.Description = "Wcf Simpay Service";
            this.wcfServiceInstaller.DisplayName = "Wcf Simpay Service";
            this.wcfServiceInstaller.ServiceName = "WcfService";
            this.wcfServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.wcfServiceProcessInstaller,
            this.wcfServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller wcfServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller wcfServiceInstaller;
    }
}