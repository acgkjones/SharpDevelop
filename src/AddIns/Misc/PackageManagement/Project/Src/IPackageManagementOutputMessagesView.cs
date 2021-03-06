﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using ICSharpCode.SharpDevelop.Workbench;
using NuGet;

namespace ICSharpCode.PackageManagement
{
	public interface IPackageManagementOutputMessagesView
	{
		void Clear();
		void AppendLine(string message);
		IOutputCategory OutputCategory { get; }
	}
}
