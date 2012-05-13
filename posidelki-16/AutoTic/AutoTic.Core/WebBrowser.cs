using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

namespace AutoTic.Core
{
    public class WebBrowser
    {
        [ThreadStatic]
        private static IE m_Inst1;
        
        public static IE Instance
        {
            get
            {
                m_Inst1 = m_Inst1 ?? new IE();
                return m_Inst1;
            }
        }


    }
}
