using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class WellKnownServiceTypeEntry : TypeEntry
{
	private string _objectUri;

	private WellKnownObjectMode _mode;

	private IContextAttribute[] _contextAttributes;

	public string ObjectUri => _objectUri;

	public WellKnownObjectMode Mode => _mode;

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

	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		if (objectUri == null)
		{
			throw new ArgumentNullException("objectUri");
		}
		base.TypeName = typeName;
		base.AssemblyName = assemblyName;
		_objectUri = objectUri;
		_mode = mode;
	}

	public WellKnownServiceTypeEntry(Type type, string objectUri, WellKnownObjectMode mode)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (objectUri == null)
		{
			throw new ArgumentNullException("objectUri");
		}
		if (!(type is RuntimeType))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		base.TypeName = type.FullName;
		base.AssemblyName = type.Module.Assembly.FullName;
		_objectUri = objectUri;
		_mode = mode;
	}

	public override string ToString()
	{
		return "type='" + base.TypeName + ", " + base.AssemblyName + "'; objectUri=" + _objectUri + "; mode=" + _mode;
	}
}
