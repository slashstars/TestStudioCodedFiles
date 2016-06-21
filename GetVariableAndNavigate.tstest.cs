using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace CodedFilesTest
{

    public class GetVariableAndNavigate : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
          
        [CodedStep(@"Enter text from variable in 'SearchInputSearch'")]
        public void GetVariableAndNavigate_CodedStep1()
        {
            // Enter text from variable in 'SearchInputSearch'
            var title = VariableContext.GetVariable<string>("RandomArticle");
            Actions.SetText(Pages.WikipediaTheFree.SearchInputSearch, title);
            
        }
    
        [CodedStep(@"Verify 'TextContent' 'Contains' 'William O'Connell Bradley' on 'FirstHeadingH1Tag'")]
        public void GetVariableAndNavigate_CodedStep2()
        {
            var title = VariableContext.GetVariable<string>("RandomArticle");
            // Verify 'TextContent' 'Contains' 'William O'Connell Bradley' on 'FirstHeadingH1Tag'
            Pages.WilliamOConnellBradley.FirstHeadingH1Tag.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, title);
            
        }
    }
}
