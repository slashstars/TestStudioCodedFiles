using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;

namespace CodedFilesTest
{
    public static class Extensions
    {
        public static void SetInputText(this HtmlControl element, string text)
        {
            // IE will respond to a 'change' event; see https://github.com/angular/angular.js/blob/master/src/ng/directive/input.js for detailed Angular code
            string script =
                "angular.element(" + element.ClientSideLocator + ").val('" + text + "').triggerHandler('change')";
            Manager.Current.ActiveBrowser.Actions.InvokeScript(script);
        }
        
        public static void ClickWithChangeEvent(this HtmlControl element)
        {
            string script =
               "angular.element(" + element.ClientSideLocator + ").triggerHandler('click')";

            Manager.Current.ActiveBrowser.Actions.InvokeScript(script);
        }
    }
}
