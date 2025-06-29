using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComVisible(false)]
public class NamespaceResolveEventArgs : EventArgs
{
	private string _NamespaceName;

	private Assembly _RequestingAssembly;

	private Collection<Assembly> _ResolvedAssemblies;

	public string NamespaceName => _NamespaceName;

	public Assembly RequestingAssembly => _RequestingAssembly;

	public Collection<Assembly> ResolvedAssemblies => _ResolvedAssemblies;

	public NamespaceResolveEventArgs(string namespaceName, Assembly requestingAssembly)
	{
		_NamespaceName = namespaceName;
		_RequestingAssembly = requestingAssembly;
		_ResolvedAssemblies = new Collection<Assembly>();
	}
}
