using System.Collections.ObjectModel;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComVisible(false)]
public class DesignerNamespaceResolveEventArgs : EventArgs
{
	private string _NamespaceName;

	private Collection<string> _ResolvedAssemblyFiles;

	public string NamespaceName => _NamespaceName;

	public Collection<string> ResolvedAssemblyFiles => _ResolvedAssemblyFiles;

	public DesignerNamespaceResolveEventArgs(string namespaceName)
	{
		_NamespaceName = namespaceName;
		_ResolvedAssemblyFiles = new Collection<string>();
	}
}
