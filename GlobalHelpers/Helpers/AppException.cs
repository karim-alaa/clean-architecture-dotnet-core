using SharedConfig.Messages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GlobalHelpers.Helpers
{
    public class AppException : Exception
    {
        public dynamic args;
        public string field;
        public AppException() : base() { }

        public AppException(string message, string field = "")
            : base(message) { this.field = field; }

        public AppException(string message, dynamic args, string field = "")
            : base(message) { this.args = args; this.field = field; }

        public AppException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
    }
}
