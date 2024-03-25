
namespace NEW_Programming
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TXCM = new System.Windows.Forms.TextBox();
            this.TXM = new System.Windows.Forms.TextBox();
            this.TXKM = new System.Windows.Forms.TextBox();
            this.TXinch = new System.Windows.Forms.TextBox();
            this.TXFT = new System.Windows.Forms.TextBox();
            this.TXyard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 36F);
            this.label2.Location = new System.Drawing.Point(324, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "公尺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 36F);
            this.label3.Location = new System.Drawing.Point(595, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 36F);
            this.label4.Location = new System.Drawing.Point(54, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "英吋";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 36F);
            this.label5.Location = new System.Drawing.Point(324, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "英尺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 36F);
            this.label6.Location = new System.Drawing.Point(619, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "碼";
            // 
            // TXCM
            // 
            this.TXCM.Font = new System.Drawing.Font("新細明體", 18F);
            this.TXCM.Location = new System.Drawing.Point(62, 124);
            this.TXCM.Name = "TXCM";
            this.TXCM.Size = new System.Drawing.Size(100, 36);
            this.TXCM.TabIndex = 6;
            this.TXCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXCM_KeyUp);
            // 
            // TXM
            // 
            this.TXM.Font = new System.Drawing.Font("新細明體", 18F);
            this.TXM.Location = new System.Drawing.Point(332, 124);
            this.TXM.Name = "TXM";
            this.TXM.Size = new System.Drawing.Size(100, 36);
            this.TXM.TabIndex = 7;
            this.TXM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXM_KeyUp);
            // 
            // TXKM
            // 
            this.TXKM.Font = new System.Drawing.Font("新細明體", 18F);
            this.TXKM.Location = new System.Drawing.Point(603, 124);
            this.TXKM.Name = "TXKM";
            this.TXKM.Size = new System.Drawing.Size(100, 36);
            this.TXKM.TabIndex = 8;
            this.TXKM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXKM_KeyUp);
            // 
            // TXinch
            // 
            this.TXinch.Font = new System.Drawing.Font("新細明體", 18F);
            this.TXinch.Location = new System.Drawing.Point(62, 244);
            this.TXinch.Name = "TXinch";
            this.TXinch.Size = new System.Drawing.Size(100, 36);
            this.TXinch.TabIndex = 9;
            this.TXinch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXinch_KeyUp);
            // 
            // TXFT
            // 
            this.TXFT.Font = new System.Drawing.Font("新細明體", 18F);
            this.TXFT.Location = new System.Drawing.Point(332, 244);
            this.TXFT.Name = "TXFT";
            this.TXFT.Size = new System.Drawing.Size(100, 36);
            this.TXFT.TabIndex = 10;
            this.TXFT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXFT_KeyUp);
            // 
            // TXyard
            // 
            this.TXyard.Font = new System.Drawing.Font("新細明體", 18F);
            this.TXyard.Location = new System.Drawing.Point(603, 244);
            this.TXyard.Name = "TXyard";
            this.TXyard.Size = new System.Drawing.Size(100, 36);
            this.TXyard.TabIndex = 11;
            this.TXyard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXyard_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 36F);
            this.label7.Location = new System.Drawing.Point(226, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "單位轉換工具";
            // 
            // changebutton
            // 
            this.changebutton.Font = new System.Drawing.Font("新細明體", 15F);
            this.changebutton.Location = new System.Drawing.Point(332, 312);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(100, 46);
            this.changebutton.TabIndex = 13;
            this.changebutton.Text = "清除數據";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.changebutton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXyard);
            this.Controls.Add(this.TXFT);
            this.Controls.Add(this.TXinch);
            this.Controls.Add(this.TXKM);
            this.Controls.Add(this.TXM);
            this.Controls.Add(this.TXCM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TXCM;
        private System.Windows.Forms.TextBox TXM;
        private System.Windows.Forms.TextBox TXKM;
        private System.Windows.Forms.TextBox TXinch;
        private System.Windows.Forms.TextBox TXFT;
        private System.Windows.Forms.TextBox TXyard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changebutton;
    }
}

