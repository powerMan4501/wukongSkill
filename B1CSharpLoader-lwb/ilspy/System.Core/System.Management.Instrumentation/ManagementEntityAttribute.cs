using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementEntityAttribute : Attribute
{
	private string _nounName;

	private bool _isExternalClass;

	private bool _isSingleton;

	public string Name
	{
		get
		{
			return _nounName;
		}
		set
		{
			_nounName = value;
		}
	}

	public bool External
	{
		get
		{
			return _isExternalClass;
		}
		set
		{
			_isExternalClass = value;
		}
	}

	public bool Singleton
	{
		get
		{
			return _isSingleton;
		}
		set
		{
			_isSingleton = value;
		}
	}
}
