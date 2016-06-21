using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodedFilesTest
{
    public static class VariableContext
    {
        private static Dictionary<string,object> context;
        
        static VariableContext()
        {
            context = new Dictionary<string,object>();
        }
        
        public static void SetVariable(string key, object value)
        {
            context[key] = value;
        }
        
        public static T GetVariable<T>(string key)
        {
            if(context.ContainsKey(key))
            {
                return (T)context[key];   
            }
            else
            {
                return default(T);   
            }
        }
        
        public static void ClearContext(){
            context = new Dictionary<string,object>();
        }
    }
}
