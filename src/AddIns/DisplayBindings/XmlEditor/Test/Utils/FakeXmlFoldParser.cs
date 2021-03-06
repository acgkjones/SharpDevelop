﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.NRefactory.Editor;
using ICSharpCode.SharpDevelop;
using ICSharpCode.SharpDevelop.Editor;
using ICSharpCode.XmlEditor;

namespace XmlEditor.Tests.Utils
{
	public class FakeXmlFoldParser : IXmlFoldParser
	{
		public List<FoldingRegion> Folds = new List<FoldingRegion>();
		public ITextSource TextBufferPassedToGetFolds;
		
		public IList<FoldingRegion> GetFolds(ITextSource textBuffer)
		{
			TextBufferPassedToGetFolds = textBuffer;
			return Folds;
		}
	}
}
