﻿using System;
using FactoryMethod.Reporters;

namespace FactoryMethod
{
    public static class ReportFactory
    {
        public static IReporter Create() => new PdfReporter();

        public static IReporter Create(ReportFormat format) => format switch
        {
            ReportFormat.Json => new JsonReporter(),
            ReportFormat.Xml => new XmlReporter(),
            ReportFormat.Pdf => new PdfReporter(),
            _ => throw new NotSupportedException()
        };
    }
}