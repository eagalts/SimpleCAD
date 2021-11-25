
namespace simplecad
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CursorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolLineButton = new System.Windows.Forms.ToolStripButton();
            this.toolDotButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolthickness = new System.Windows.Forms.ToolStripTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolRectangularButton = new System.Windows.Forms.ToolStripButton();
            this.toolEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolArcButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CursorStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "status";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // CursorStatus
            // 
            this.CursorStatus.BackColor = System.Drawing.Color.Transparent;
            this.CursorStatus.Name = "CursorStatus";
            this.CursorStatus.Size = new System.Drawing.Size(120, 17);
            this.CursorStatus.Text = "Положение курсора";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLineButton,
            this.toolRectangularButton,
            this.toolEllipseButton,
            this.toolArcButton,
            this.toolDotButton,
            this.toolStripLabel1,
            this.toolthickness,
            this.ClearButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(808, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "tools";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolLineButton
            // 
            this.toolLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLineButton.Image = ((System.Drawing.Image)(resources.GetObject("toolLineButton.Image")));
            this.toolLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLineButton.Name = "toolLineButton";
            this.toolLineButton.Size = new System.Drawing.Size(23, 22);
            this.toolLineButton.Text = "Линия";
            this.toolLineButton.Click += new System.EventHandler(this.toolLineButton_Click);
            // 
            // toolDotButton
            // 
            this.toolDotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDotButton.Image = ((System.Drawing.Image)(resources.GetObject("toolDotButton.Image")));
            this.toolDotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDotButton.Name = "toolDotButton";
            this.toolDotButton.Size = new System.Drawing.Size(23, 22);
            this.toolDotButton.Text = "Точка";
            this.toolDotButton.ToolTipText = "Точка";
            this.toolDotButton.Click += new System.EventHandler(this.toolDotButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Толщина";
            // 
            // toolthickness
            // 
            this.toolthickness.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolthickness.MaxLength = 3;
            this.toolthickness.Name = "toolthickness";
            this.toolthickness.Size = new System.Drawing.Size(25, 25);
            this.toolthickness.Text = "3";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // toolRectangularButton
            // 
            this.toolRectangularButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRectangularButton.Image = ((System.Drawing.Image)(resources.GetObject("toolRectangularButton.Image")));
            this.toolRectangularButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRectangularButton.Name = "toolRectangularButton";
            this.toolRectangularButton.Size = new System.Drawing.Size(23, 22);
            this.toolRectangularButton.Text = "Прямоугольник";
            this.toolRectangularButton.Click += new System.EventHandler(this.toolRectangularButton_Click);
            // 
            // toolEllipseButton
            // 
            this.toolEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("toolEllipseButton.Image")));
            this.toolEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEllipseButton.Name = "toolEllipseButton";
            this.toolEllipseButton.Size = new System.Drawing.Size(23, 22);
            this.toolEllipseButton.Text = "Окружность";
            this.toolEllipseButton.Click += new System.EventHandler(this.toolEllipseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(23, 22);
            this.ClearButton.Text = "Очистить экран";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolArcButton
            // 
            this.toolArcButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolArcButton.Image = ((System.Drawing.Image)(resources.GetObject("toolArcButton.Image")));
            this.toolArcButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolArcButton.Name = "toolArcButton";
            this.toolArcButton.Size = new System.Drawing.Size(23, 22);
            this.toolArcButton.Text = "Дуга";
            this.toolArcButton.Click += new System.EventHandler(this.toolArcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "SimpleCAD";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolLineButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripTextBox toolthickness;
        private System.Windows.Forms.ToolStripStatusLabel CursorStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolDotButton;
        private System.Windows.Forms.ToolStripButton toolRectangularButton;
        private System.Windows.Forms.ToolStripButton toolEllipseButton;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStripButton toolArcButton;
    }
}

