namespace WizardStored
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fastColoredTextBox
            // 
            this.fastColoredTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(1210, 2142);
            this.fastColoredTextBox.BackBrush = null;
            this.fastColoredTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox.CharHeight = 21;
            this.fastColoredTextBox.CharWidth = 11;
            this.fastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.fastColoredTextBox.IsReplaceMode = false;
            this.fastColoredTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox.LeftBracket = '(';
            this.fastColoredTextBox.LeftBracket2 = '{';
            this.fastColoredTextBox.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox.Name = "fastColoredTextBox";
            this.fastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox.RightBracket = ')';
            this.fastColoredTextBox.RightBracket2 = '}';
            this.fastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox.ServiceColors")));
            this.fastColoredTextBox.Size = new System.Drawing.Size(738, 525);
            this.fastColoredTextBox.TabIndex = 0;
            this.fastColoredTextBox.Text = resources.GetString("fastColoredTextBox.Text");
            this.fastColoredTextBox.Zoom = 100;
            this.fastColoredTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 525);
            this.Controls.Add(this.fastColoredTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox;
    }
}

