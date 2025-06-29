using System;
using System.Globalization;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Reflection;

public class ILRuntimeConstructorInfo : ConstructorInfo
{
	private ILMethod method;

	private ILRuntimeParameterInfo[] parameters;

	internal ILMethod ILMethod => method;

	public override System.Reflection.MethodAttributes Attributes => System.Reflection.MethodAttributes.Public;

	public override Type DeclaringType => method.DeclearingType.ReflectionType;

	public override RuntimeMethodHandle MethodHandle
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override string Name => method.Name;

	public override Type ReflectedType => method.DeclearingType.ReflectionType;

	public ILRuntimeConstructorInfo(ILMethod m)
	{
		method = m;
		parameters = new ILRuntimeParameterInfo[m.ParameterCount];
		for (int i = 0; i < m.ParameterCount; i++)
		{
			ParameterDefinition definition = m.Definition.Parameters[i];
			parameters[i] = new ILRuntimeParameterInfo(definition, m.Parameters[i], this, m.AppDomain);
		}
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		throw new NotImplementedException();
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		throw new NotImplementedException();
	}

	public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
	{
		throw new NotImplementedException();
	}

	public override ParameterInfo[] GetParameters()
	{
		return parameters;
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		ILTypeInstance iLTypeInstance = ((ILType)method.DeclearingType).Instantiate(callDefaultConstructor: false);
		method.DeclearingType.AppDomain.Invoke(method, iLTypeInstance, parameters);
		return iLTypeInstance;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		throw new NotImplementedException();
	}

	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		ILTypeInstance iLTypeInstance = ((ILType)method.DeclearingType).Instantiate(callDefaultConstructor: false);
		method.DeclearingType.AppDomain.Invoke(method, iLTypeInstance, parameters);
		return iLTypeInstance;
	}
}
