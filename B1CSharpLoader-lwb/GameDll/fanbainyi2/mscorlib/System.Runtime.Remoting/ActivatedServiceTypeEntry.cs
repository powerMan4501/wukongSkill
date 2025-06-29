using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class ActivatedServiceTypeEntry : TypeEntry
{
	private IContextAttribute[] _contextAttributes;

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

	public ActivatedServiceTypeEntry(string typeName, string assemblyName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		base.TypeName = typeName;
		base.AssemblyName = assemblyName;
	}

	public ActivatedServiceTypeEntry(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
		}
		base.TypeName = type.FullName;
		base.AssemblyName = runtimeType.GetRuntimeAssembly().GetSimpleName();
	}

	public override string ToString()
	{
		return "type='" + base.TypeName + ", " + base.AssemblyName + "'";
	}
}
