using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class TypeEntry
{
	private string _typeName;

	private string _assemblyName;

	private RemoteAppEntry _cachedRemoteAppEntry;

	public string TypeName
	{
		get
		{
			return _typeName;
		}
		set
		{
			_typeName = value;
		}
	}

	public string AssemblyName
	{
		get
		{
			return _assemblyName;
		}
		set
		{
			_assemblyName = value;
		}
	}

	protected TypeEntry()
	{
	}

	internal void CacheRemoteAppEntry(RemoteAppEntry entry)
	{
		_cachedRemoteAppEntry = entry;
	}

	internal RemoteAppEntry GetRemoteAppEntry()
	{
		return _cachedRemoteAppEntry;
	}
}
