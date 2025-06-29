using System.Reflection;
using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
public class ResolveEventArgs : EventArgs
{
	private string _Name;

	private Assembly _RequestingAssembly;

	public string Name => _Name;

	public Assembly RequestingAssembly => _RequestingAssembly;

	public ResolveEventArgs(string name)
	{
		_Name = name;
	}

	public ResolveEventArgs(string name, Assembly requestingAssembly)
	{
		_Name = name;
		_RequestingAssembly = requestingAssembly;
	}
}
