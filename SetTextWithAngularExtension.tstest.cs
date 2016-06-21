
using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;

namespace CodedFilesTest
{

    public class SetTextWithAngularExtension : BaseWebAiiTest
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
    
        [CodedStep(@"Enter text '2 + 2' in 'QueryText'")]
        public void SetTextWithAngularExtension_CodedStep()
        {
            // Enter text '2 + 2' in 'QueryText'
            Pages.WolframAlphaComputational.QueryText.SetInputText("2 + 2");
        }
    
        [CodedStep(@"Verify element 'x4Image' 'is' visible.")]
        public void SetTextWithAngularExtension_CodedStep1()
        {
            // Verify element 'x4Image' 'is' visible.
            Pages.x22WolframAlpha.x4Image.Wait.ForVisible(30000);
            Assert.AreEqual(true, Pages.x22WolframAlpha.x4Image.IsVisible());
            
        }
    }
}
