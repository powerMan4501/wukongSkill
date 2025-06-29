using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
internal sealed class ManagedActivationFactory : IActivationFactory, IManagedActivationFactory
{
	private Type m_type;

	[SecurityCritical]
	internal ManagedActivationFactory(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!(type is RuntimeType) || !type.IsExportedToWindowsRuntime)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeNotActivatableViaWindowsRuntime", type), "type");
		}
		m_type = type;
	}

	public object ActivateInstance()
	{
		try
		{
			return Activator.CreateInstance(m_type);
		}
		catch (MissingMethodException)
		{
			throw new NotImplementedException();
		}
		catch (TargetInvocationException ex2)
		{
			throw ex2.InnerException;
		}
	}

	void IManagedActivationFactory.RunClassConstructor()
	{
		RuntimeHelpers.RunClassConstructor(m_type.TypeHandle);
	}
}
