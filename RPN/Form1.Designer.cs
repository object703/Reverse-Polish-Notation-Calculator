namespace RPN
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Eval = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reverse Polish Notation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txt_Input
            //
            this.txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Input.Location = new System.Drawing.Point(40, 102);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(238, 22);
            this.txt_Input.TabIndex = 1;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter expression to evaluate";
            //
            // btn_Eval
            //
            this.btn_Eval.Location = new System.Drawing.Point(203, 130);
            this.btn_Eval.Name = "btn_Eval";
            this.btn_Eval.Size = new System.Drawing.Size(75, 23);
            this.btn_Eval.TabIndex = 3;
            this.btn_Eval.Text = "Evaluate";
            this.btn_Eval.UseVisualStyleBackColor = true;
            this.btn_Eval.Click += new System.EventHandler(this.btn_Eval_Click);
            //
            // lbl_Output
            //
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(12, 180);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(297, 30);
            this.lbl_Output.TabIndex = 4;
            this.lbl_Output.Text = "...";
            this.lbl_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 231);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Eval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Eval;
        private System.Windows.Forms.Label lbl_Output;
    }
}
