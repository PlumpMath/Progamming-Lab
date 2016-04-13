namespace Progamming.PropertyUserControl
{
    partial class ScriptProperty
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcProperty = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tcProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProperty
            // 
            this.tcProperty.AllowDrop = true;
            this.tcProperty.Controls.Add(this.tpGeneral);
            this.tcProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProperty.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tcProperty.Location = new System.Drawing.Point(0, 0);
            this.tcProperty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcProperty.Name = "tcProperty";
            this.tcProperty.SelectedIndex = 0;
            this.tcProperty.Size = new System.Drawing.Size(178, 444);
            this.tcProperty.TabIndex = 1;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Location = new System.Drawing.Point(4, 24);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(170, 416);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // ScriptProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcProperty);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScriptProperty";
            this.Size = new System.Drawing.Size(178, 444);
            this.tcProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProperty;
        private System.Windows.Forms.TabPage tpGeneral;
    }
}
