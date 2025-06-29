using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class ActivatedClientTypeEntry : TypeEntry
{
	private string _appUrl;

	private IContextAttribute[] _contextAttributes;

	public string ApplicationUrl => _appUrl;

	public Type ObjectType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
			return RuntimeTypeHandle.GetTypeByName(base.TypeName + ", " + base.AssemblyName, ref stackMark);
		}
	}

	public IContextAttribute[] ContextAttributes
	{
		get
		{
			return _contextAttributes;
		}
		set
		{
			_contextAttributes = value;
		}
	}

	public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		if (appUrl == null)
		{
			throw new ArgumentNullException("appUrl");
		}
		base.TypeName = typeName;
		base.AssemblyName = assemblyName;
		_appUrl = appUrl;
	}

	public ActivatedClientTypeEntry(Type type, string appUrl)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (appUrl == null)
		{
			throw new ArgumentNullException("appUrl");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
		}
		base.TypeName = type.FullName;
		base.AssemblyName = runtimeType.GetRuntimeAssembly().GetSimpleName();
		_appUrl = appUrl;
	}

	public override string ToString()
	{
		return "type='" + base.TypeName + ", " + base.AssemblyName + "'; appUrl=" + _appUrl;
	}
}
