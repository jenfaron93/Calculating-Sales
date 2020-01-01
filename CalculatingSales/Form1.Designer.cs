namespace CalculatingSales
{
   partial class frmSales
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
         this.txtProduct1 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtProduct2 = new System.Windows.Forms.TextBox();
         this.txtProduct3 = new System.Windows.Forms.TextBox();
         this.btnCalculate = new System.Windows.Forms.Button();
         this.lblSalesOutput = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label1.Location = new System.Drawing.Point(68, 62);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(162, 32);
         this.label1.TabIndex = 0;
         this.label1.Text = "Product 1: ";
         // 
         // txtProduct1
         // 
         this.txtProduct1.Location = new System.Drawing.Point(251, 68);
         this.txtProduct1.Name = "txtProduct1";
         this.txtProduct1.Size = new System.Drawing.Size(115, 26);
         this.txtProduct1.TabIndex = 1;
         this.txtProduct1.TextChanged += new System.EventHandler(this.txtProduct1_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label2.Location = new System.Drawing.Point(68, 146);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(162, 32);
         this.label2.TabIndex = 0;
         this.label2.Text = "Product 2: ";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label3.Location = new System.Drawing.Point(68, 231);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(162, 32);
         this.label3.TabIndex = 0;
         this.label3.Text = "Product 3: ";
         // 
         // txtProduct2
         // 
         this.txtProduct2.Location = new System.Drawing.Point(251, 153);
         this.txtProduct2.Name = "txtProduct2";
         this.txtProduct2.Size = new System.Drawing.Size(115, 26);
         this.txtProduct2.TabIndex = 1;
         this.txtProduct2.TextChanged += new System.EventHandler(this.txtProduct2_TextChanged);
         // 
         // txtProduct3
         // 
         this.txtProduct3.Location = new System.Drawing.Point(251, 238);
         this.txtProduct3.Name = "txtProduct3";
         this.txtProduct3.Size = new System.Drawing.Size(115, 26);
         this.txtProduct3.TabIndex = 1;
         this.txtProduct3.TextChanged += new System.EventHandler(this.txtProduct3_TextChanged);
         // 
         // btnCalculate
         // 
         this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCalculate.Location = new System.Drawing.Point(124, 334);
         this.btnCalculate.Name = "btnCalculate";
         this.btnCalculate.Size = new System.Drawing.Size(188, 43);
         this.btnCalculate.TabIndex = 2;
         this.btnCalculate.Text = "Calculate";
         this.btnCalculate.UseVisualStyleBackColor = true;
         this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
         // 
         // lblSalesOutput
         // 
         this.lblSalesOutput.AutoSize = true;
         this.lblSalesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSalesOutput.ForeColor = System.Drawing.Color.Tomato;
         this.lblSalesOutput.Location = new System.Drawing.Point(57, 438);
         this.lblSalesOutput.Name = "lblSalesOutput";
         this.lblSalesOutput.Size = new System.Drawing.Size(0, 29);
         this.lblSalesOutput.TabIndex = 3;
         // 
         // frmSales
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(698, 635);
         this.Controls.Add(this.lblSalesOutput);
         this.Controls.Add(this.btnCalculate);
         this.Controls.Add(this.txtProduct3);
         this.Controls.Add(this.txtProduct2);
         this.Controls.Add(this.txtProduct1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmSales";
         this.Text = "Sales Calculation";
         this.Load += new System.EventHandler(this.frmSales_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtProduct1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtProduct2;
      private System.Windows.Forms.TextBox txtProduct3;
      private System.Windows.Forms.Button btnCalculate;
      private System.Windows.Forms.Label lblSalesOutput;
   }
}

