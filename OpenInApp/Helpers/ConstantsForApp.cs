using OpenInApp.Common.Helpers;
using System.Collections.Generic;

namespace OpenInApp.Helpers
{
    public static class ConstantsForApp 
    {
        public const string AppFolderName = "Markdown Monster";//"Altova", "Paint.NET"
        public const string AppSubFolderName = null;//null in most cases, "XMLSpy"
        public const string ExecutableFileToBrowseFor = "MarkdownMonster.exe";//"XmlSpy.exe", "PaintDotNet.exe"
        public static IEnumerable<string> GetDefaultTypicalFileExtensions()
        {
            return new List<string>
            {
                #region Extensions
                "md",
	            #endregion
            };
        }



        internal const string CommonActualPathToExeOptionLabel = CommonConstants.ActualPathToExeOptionLabelPrefix + ExecutableFileToBrowseFor;
    }
}
