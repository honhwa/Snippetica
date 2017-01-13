﻿using System;
using System.Xml.Linq;

namespace Pihrtsoft.Records
{
    public class DocumentException : Exception
    {
        public DocumentException()
        {
        }

        public DocumentException(string message)
            : base(message)
        {
        }

        public DocumentException(XObject @object)
        {
            XObject = @object;
        }


        public DocumentException(string message, XObject @object)
            : base(message)
        {
            XObject = @object;
        }

        public DocumentException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public DocumentException(string message, XObject @object, Exception inner)
            : base(message, inner)
        {
            XObject = @object;
        }

        public XObject XObject { get; }
    }
}
