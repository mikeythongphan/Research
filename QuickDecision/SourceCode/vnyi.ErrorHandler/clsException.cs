using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vnyi.Utility
{
    public class WebException : Exception
    {
        private Exception _innerException;

        private string _displayMessage;
        private string _displayType;

        public WebException(string displayMessage, string displayType, Exception ex)
        {
            _displayMessage = displayMessage;
            _displayType = displayType;
            if (ex != null)
            {
                _innerException = ex;
            }
        }

        public Exception inException
        {
            get { return _innerException; }
        }

        public string Message
        {
            get{ return _displayMessage; }
        }

        public string Type
        {
            get { return _displayType; }
        }
    }
}
