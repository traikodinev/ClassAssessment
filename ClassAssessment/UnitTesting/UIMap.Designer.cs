﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UnitTesting
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// LoginTest - Use 'LoginTestParams' to pass parameters into this method.
        /// </summary>
        public void LoginTest()
        {
            #region Variable Declarations
            WinControl uIItemDocument = this.UILoginGoogleChromeWindow.UIItemWindow.UIItemDocument;
            #endregion

            // Click document
            Mouse.Click(uIItemDocument, new Point(612, 85));

            // Type 'asdf' in document
            Keyboard.SendKeys(uIItemDocument, this.LoginTestParams.UIItemDocumentSendKeys, ModifierKeys.None);

            // Click document
            Mouse.Click(uIItemDocument, new Point(810, 151));

            // Click document
            Mouse.Click(uIItemDocument, new Point(748, 132));

            // Type 'asdf' in document
            Keyboard.SendKeys(uIItemDocument, this.LoginTestParams.UIItemDocumentSendKeys1, ModifierKeys.None);

            // Click document
            Mouse.Click(uIItemDocument, new Point(600, 198));
        }
        
        #region Properties
        public virtual LoginTestParams LoginTestParams
        {
            get
            {
                if ((this.mLoginTestParams == null))
                {
                    this.mLoginTestParams = new LoginTestParams();
                }
                return this.mLoginTestParams;
            }
        }
        
        public UILoginGoogleChromeWindow UILoginGoogleChromeWindow
        {
            get
            {
                if ((this.mUILoginGoogleChromeWindow == null))
                {
                    this.mUILoginGoogleChromeWindow = new UILoginGoogleChromeWindow();
                }
                return this.mUILoginGoogleChromeWindow;
            }
        }
        #endregion
        
        #region Fields
        private LoginTestParams mLoginTestParams;
        
        private UILoginGoogleChromeWindow mUILoginGoogleChromeWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'LoginTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class LoginTestParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'asdf' in document
        /// </summary>
        public string UIItemDocumentSendKeys = "asdf";
        
        /// <summary>
        /// Type 'asdf' in document
        /// </summary>
        public string UIItemDocumentSendKeys1 = "asdf";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UILoginGoogleChromeWindow : WinWindow
    {
        
        public UILoginGoogleChromeWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Login - Google Chrome";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("Login - Google Chrome");
            this.WindowTitles.Add("Index - Google Chrome");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "295634432";
            this.WindowTitles.Add("Login - Google Chrome");
            this.WindowTitles.Add("Index - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinControl UIItemDocument
        {
            get
            {
                if ((this.mUIItemDocument == null))
                {
                    this.mUIItemDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUIItemDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUIItemDocument.WindowTitles.Add("Login - Google Chrome");
                    this.mUIItemDocument.WindowTitles.Add("Index - Google Chrome");
                    #endregion
                }
                return this.mUIItemDocument;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIItemDocument;
        #endregion
    }
}