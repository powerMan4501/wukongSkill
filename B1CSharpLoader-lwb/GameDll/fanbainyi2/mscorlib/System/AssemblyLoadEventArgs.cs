using System.Reflection;
using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
public class AssemblyLoadEventArgs : EventArgs
{
	private Assembly _LoadedAssembly;

	public Assembly LoadedAssembly => _LoadedAssembly;

	public AssemblyLoadEventArgs(Assembly loadedAssembly)
	{
		_LoadedAssembly = loadedAssembly;
	}
}
