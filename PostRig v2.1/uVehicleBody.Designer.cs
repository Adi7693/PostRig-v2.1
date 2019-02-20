namespace PostRig_v2._1
{
    partial class uVehicleBody
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
            this.BodyUCTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // BodyUCTableLayout
            // 
            this.BodyUCTableLayout.ColumnCount = 1;
            this.BodyUCTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BodyUCTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyUCTableLayout.Location = new System.Drawing.Point(0, 0);
            this.BodyUCTableLayout.Name = "BodyUCTableLayout";
            this.BodyUCTableLayout.RowCount = 2;
            this.BodyUCTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21495F));
            this.BodyUCTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.78505F));
            this.BodyUCTableLayout.Size = new System.Drawing.Size(555, 428);
            this.BodyUCTableLayout.TabIndex = 0;
            // 
            // uVehicleBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BodyUCTableLayout);
            this.Name = "uVehicleBody";
            this.Size = new System.Drawing.Size(555, 428);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BodyUCTableLayout;
    }
}
