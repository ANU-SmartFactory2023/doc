namespace WindowsFormsApp4
{
    partial class main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
		{
			this.panel_title = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.panel_menu = new System.Windows.Forms.Panel();
			this.btn_logout = new System.Windows.Forms.Button();
			this.PnlNav = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel_main = new System.Windows.Forms.Panel();
			this.btn_stop = new System.Windows.Forms.Button();
			this.btn_detail = new System.Windows.Forms.Button();
			this.btn_summary = new System.Windows.Forms.Button();
			this.btn_running = new System.Windows.Forms.Button();
			this.btn_monitoring = new System.Windows.Forms.Button();
			this.btn_home = new System.Windows.Forms.Button();
			this.panel_title.SuspendLayout();
			this.panel_menu.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_title
			// 
			this.panel_title.Controls.Add(this.button6);
			this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_title.Location = new System.Drawing.Point(0, 0);
			this.panel_title.Name = "panel_title";
			this.panel_title.Size = new System.Drawing.Size(1162, 26);
			this.panel_title.TabIndex = 0;
			this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
			this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
			this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
			this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
			// 
			// button6
			// 
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(1134, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(25, 25);
			this.button6.TabIndex = 6;
			this.button6.Text = "X";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// panel_menu
			// 
			this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel_menu.Controls.Add(this.btn_logout);
			this.panel_menu.Controls.Add(this.PnlNav);
			this.panel_menu.Controls.Add(this.btn_stop);
			this.panel_menu.Controls.Add(this.btn_detail);
			this.panel_menu.Controls.Add(this.btn_summary);
			this.panel_menu.Controls.Add(this.btn_running);
			this.panel_menu.Controls.Add(this.btn_monitoring);
			this.panel_menu.Controls.Add(this.panel2);
			this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_menu.Location = new System.Drawing.Point(0, 26);
			this.panel_menu.Name = "panel_menu";
			this.panel_menu.Size = new System.Drawing.Size(186, 551);
			this.panel_menu.TabIndex = 0;
			// 
			// btn_logout
			// 
			this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_logout.FlatAppearance.BorderSize = 0;
			this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_logout.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_logout.Location = new System.Drawing.Point(0, 501);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(186, 50);
			this.btn_logout.TabIndex = 6;
			this.btn_logout.Text = "로그아웃";
			this.btn_logout.UseVisualStyleBackColor = true;
			this.btn_logout.Click += new System.EventHandler(this.button_click);
			// 
			// PnlNav
			// 
			this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.PnlNav.Location = new System.Drawing.Point(3, 194);
			this.PnlNav.Name = "PnlNav";
			this.PnlNav.Size = new System.Drawing.Size(3, 100);
			this.PnlNav.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.btn_home);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(186, 144);
			this.panel2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label2.Location = new System.Drawing.Point(122, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "label3";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// panel_main
			// 
			this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_main.Location = new System.Drawing.Point(186, 26);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(976, 551);
			this.panel_main.TabIndex = 2;
			this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
			// 
			// btn_stop
			// 
			this.btn_stop.FlatAppearance.BorderSize = 0;
			this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_stop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_stop.Image = global::WindowsFormsApp4.Properties.Resources.free_icon_stop_bullying_2452756;
			this.btn_stop.Location = new System.Drawing.Point(0, 404);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(186, 50);
			this.btn_stop.TabIndex = 5;
			this.btn_stop.Text = "라인 긴급 중지";
			this.btn_stop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			this.btn_stop.Leave += new System.EventHandler(this.button5_Click);
			// 
			// btn_detail
			// 
			this.btn_detail.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_detail.FlatAppearance.BorderSize = 0;
			this.btn_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_detail.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_detail.Image = global::WindowsFormsApp4.Properties.Resources.free_icon_404_error_5975189;
			this.btn_detail.Location = new System.Drawing.Point(0, 294);
			this.btn_detail.Name = "btn_detail";
			this.btn_detail.Size = new System.Drawing.Size(186, 50);
			this.btn_detail.TabIndex = 4;
			this.btn_detail.Text = "상세정보";
			this.btn_detail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_detail.UseVisualStyleBackColor = true;
			this.btn_detail.Click += new System.EventHandler(this.button_click);
			// 
			// btn_summary
			// 
			this.btn_summary.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_summary.FlatAppearance.BorderSize = 0;
			this.btn_summary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_summary.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_summary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_summary.Image = global::WindowsFormsApp4.Properties.Resources.free_icon_statistics_8367611;
			this.btn_summary.Location = new System.Drawing.Point(0, 244);
			this.btn_summary.Name = "btn_summary";
			this.btn_summary.Size = new System.Drawing.Size(186, 50);
			this.btn_summary.TabIndex = 3;
			this.btn_summary.Text = "제품통계";
			this.btn_summary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_summary.UseVisualStyleBackColor = true;
			this.btn_summary.Click += new System.EventHandler(this.button_click);
			// 
			// btn_running
			// 
			this.btn_running.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_running.FlatAppearance.BorderSize = 0;
			this.btn_running.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_running.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_running.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_running.Image = global::WindowsFormsApp4.Properties.Resources.free_icon_robotic_arm_8019037;
			this.btn_running.Location = new System.Drawing.Point(0, 194);
			this.btn_running.Name = "btn_running";
			this.btn_running.Size = new System.Drawing.Size(186, 50);
			this.btn_running.TabIndex = 2;
			this.btn_running.Text = "공정가동";
			this.btn_running.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_running.UseVisualStyleBackColor = true;
			this.btn_running.Click += new System.EventHandler(this.button_click);
			// 
			// btn_monitoring
			// 
			this.btn_monitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_monitoring.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_monitoring.FlatAppearance.BorderSize = 0;
			this.btn_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_monitoring.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_monitoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_monitoring.Image = global::WindowsFormsApp4.Properties.Resources.free_icon_computer_8281294;
			this.btn_monitoring.Location = new System.Drawing.Point(0, 144);
			this.btn_monitoring.Name = "btn_monitoring";
			this.btn_monitoring.Size = new System.Drawing.Size(186, 50);
			this.btn_monitoring.TabIndex = 1;
			this.btn_monitoring.Text = "모니터링";
			this.btn_monitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_monitoring.UseVisualStyleBackColor = true;
			this.btn_monitoring.Click += new System.EventHandler(this.button_click);
			// 
			// btn_home
			// 
			this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_home.FlatAppearance.BorderSize = 0;
			this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_home.Font = new System.Drawing.Font("굴림", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btn_home.Image = global::WindowsFormsApp4.Properties.Resources.홈버튼_이미지;
			this.btn_home.Location = new System.Drawing.Point(0, 0);
			this.btn_home.Name = "btn_home";
			this.btn_home.Size = new System.Drawing.Size(186, 144);
			this.btn_home.TabIndex = 0;
			this.btn_home.Text = "Flawless";
			this.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_home.UseVisualStyleBackColor = false;
			this.btn_home.Click += new System.EventHandler(this.button_click);
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(1162, 577);
			this.Controls.Add(this.panel_main);
			this.Controls.Add(this.panel_menu);
			this.Controls.Add(this.panel_title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel_title.ResumeLayout(false);
			this.panel_menu.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_summary;
        private System.Windows.Forms.Button btn_running;
        private System.Windows.Forms.Button btn_monitoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btn_home;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_logout;
	}
}

