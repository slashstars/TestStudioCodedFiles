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
            //Angular needs change event to update the bindings, so trigger it
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
