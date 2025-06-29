using System.Globalization;

namespace System.Reflection.Emit;

internal sealed class MethodBuilderInstantiation : MethodInfo
{
	internal MethodInfo m_method;

	private Type[] m_inst;

	public override MemberTypes MemberType => m_method.MemberType;

	public override string Name => m_method.Name;

	public override Type DeclaringType => m_method.DeclaringType;

	public override Type ReflectedType => m_method.ReflectedType;

	public override Module Module => m_method.Module;

	public override RuntimeMethodHandle MethodHandle
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
		}
	}

	public override MethodAttributes Attributes => m_method.Attributes;

	public override CallingConventions CallingConvention => m_method.CallingConvention;

	public override bool IsGenericMethodDefinition => false;

	public override bool ContainsGenericParameters
	{
		get
		{
			for (int i = 0; i < m_inst.Length; i++)
			{
				if (m_inst[i].ContainsGenericParameters)
				{
					return true;
				}
			}
			if (DeclaringType != null && DeclaringType.ContainsGenericParameters)
			{
				return true;
			}
			return false;
		}
	}

	public override bool IsGenericMethod => true;

	public override Type ReturnType => m_method.ReturnType;

	public override ParameterInfo ReturnParameter
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	internal static MethodInfo MakeGenericMethod(MethodInfo method, Type[] inst)
	{
		if (!method.IsGenericMethodDefinition)
		{
			throw new InvalidOperationException();
		}
		return new MethodBuilderInstantiation(method, inst);
	}

	internal MethodBuilderInstantiation(MethodInfo method, Type[] inst)
	{
		m_method = method;
		m_inst = inst;
	}

	internal override Type[] GetParameterTypes()
	{
		return m_method.GetParameterTypes();
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return m_method.GetCustomAttributes(inherit);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return m_method.GetCustomAttributes(attributeType, inherit);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return m_method.IsDefined(attributeType, inherit);
	}

	public new Type GetType()
	{
		return base.GetType();
	}

	public override ParameterInfo[] GetParameters()
	{
		throw new NotSupportedException();
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return m_method.GetMethodImplementationFlags();
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	public override Type[] GetGenericArguments()
	{
		return m_inst;
	}

	public override MethodInfo GetGenericMethodDefinition()
	{
		return m_method;
	}

	public override MethodInfo MakeGenericMethod(params Type[] arguments)
	{
		throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericMethodDefinition"));
	}

	public override MethodInfo GetBaseDefinition()
	{
		throw new NotSupportedException();
	}
}
