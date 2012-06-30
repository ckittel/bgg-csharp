using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameGeek.Api.ServerModels
{
    /// <summary>
    /// Most of the api is in the form of &gt;element value="something" /&lt;.  This helps account for that.
    /// </summary>
    public class ValueAttribute
    {
        public string value { get; set; }
    }
}
