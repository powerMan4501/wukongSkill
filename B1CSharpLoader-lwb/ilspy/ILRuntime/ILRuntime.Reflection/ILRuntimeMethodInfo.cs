using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Reflection;

public class ILRuntimeMethodInfo : MethodInfo
{
	private ILMethod method;

	private ILRuntimeParameterInfo[] parameters;

	private MethodDefinition definition;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private Attribute[] customAttributes;

	private Type[] attributeTypes;

	private IDelegateAdapter iDelegate;

	internal ILMethod ILMethod => method;

	public override System.Reflection.MethodAttributes Attributes
	{
		get
		{
			System.Reflection.MethodAttributes methodAttributes = System.Reflection.MethodAttributes.Public;
			if (definition.IsPrivate)
			{
				methodAttributes = System.Reflection.MethodAttributes.Private;
			}
			else if (definition.IsFamily)
			{
				methodAttributes = System.Reflection.MethodAttributes.Family;
			}
			if (method.IsStatic)
			{
				methodAttributes |= System.Reflection.MethodAttributes.Static;
			}
			if (method.IsVirtual)
			{
				methodAttributes |= System.Reflection.MethodAttributes.Virtual;
			}
			return methodAttributes;
		}
	}

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

	public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override bool IsGenericMethod
	{
		get
		{
			if (!method.IsGenericInstance)
			{
				return method.GenericParameterCount > 0;
			}
			return true;
		}
	}

	public override bool IsGenericMethodDefinition => method.GenericParameterCount > 0;

	public override Type ReturnType
	{
		get
		{
			if (method.ReturnType != null)
			{
				return method.ReturnType.ReflectionType;
			}
			return null;
		}
	}

	public ILRuntimeMethodInfo(ILMethod m)
	{
		method = m;
		definition = m.Definition;
		appdomain = m.DeclearingType.AppDomain;
		parameters = new ILRuntimeParameterInfo[m.ParameterCount];
		for (int i = 0; i < m.ParameterCount; i++)
		{
			ParameterDefinition parameterDefinition = m.Definition.Parameters[i];
			parameters[i] = new ILRuntimeParameterInfo(parameterDefinition, m.Parameters[i], this, appdomain);
		}
	}

	private void InitializeCustomAttribute()
	{
		customAttributes = new Attribute[definition.CustomAttributes.Count];
		attributeTypes = new Type[customAttributes.Length];
		for (int i = 0; i < definition.CustomAttributes.Count; i++)
		{
			CustomAttribute customAttribute = definition.CustomAttributes[i];
			IType type = appdomain.GetType(customAttribute.AttributeType, null, null);
			try
			{
				Attribute attribute = customAttribute.CreateInstance(type, appdomain) as Attribute;
				attributeTypes[i] = type.ReflectionType;
				customAttributes[i] = attribute;
			}
			catch
			{
				attributeTypes[i] = typeof(Attribute);
			}
		}
	}

	public override MethodInfo GetBaseDefinition()
	{
		return this;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		if (customAttributes == null)
		{
			InitializeCustomAttribute();
		}
		return customAttributes;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (customAttributes == null)
		{
			InitializeCustomAttribute();
		}
		List<Attribute> list = new List<Attribute>();
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (attributeTypes[i].Equals(attributeType))
			{
				list.Add(customAttributes[i]);
			}
		}
		return list.ToArray();
	}

	public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
	{
		throw new NotImplementedException();
	}

	public override ParameterInfo[] GetParameters()
	{
		return parameters;
	}

	public override MethodInfo MakeGenericMethod(params Type[] typeArguments)
	{
		IType[] array = new IType[typeArguments.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = appdomain.GetType(typeArguments[i]);
		}
		return ((ILMethod)method.MakeGenericMethod(array)).ReflectionMethodInfo;
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		if (method.HasThis)
		{
			object obj2 = appdomain.Invoke(method, obj, parameters);
			return ReturnType.CheckCLRTypes(obj2);
		}
		return appdomain.Invoke(method, null, parameters);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (customAttributes == null)
		{
			InitializeCustomAttribute();
		}
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (attributeTypes[i] == attributeType)
			{
				return true;
			}
		}
		return false;
	}

	public override Delegate CreateDelegate(Type t)
	{
		if (t is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)t).ILType;
			if (iLType.IsDelegate)
			{
				ILMethod iLMethod = ILMethod;
				if (iLMethod.DelegateAdapter == null)
				{
					ILMethod iLMethod2 = iLType.GetMethod("Invoke") as ILMethod;
					iLMethod.DelegateAdapter = appdomain.DelegateManager.FindDelegateAdapter(null, iLMethod, iLMethod2);
				}
				return iLMethod.DelegateAdapter.Delegate;
			}
			throw new NotSupportedException($"{t.FullName} is not Delegate");
		}
		if (t is ILRuntimeWrapperType)
		{
			ILRuntimeWrapperType iLRuntimeWrapperType = (ILRuntimeWrapperType)t;
			return appdomain.DelegateManager.FindDelegateAdapter(iLRuntimeWrapperType.CLRType, null, ILMethod).Delegate;
		}
		if (appdomain.GetType(t) is CLRType type)
		{
			return appdomain.DelegateManager.FindDelegateAdapter(type, null, ILMethod).Delegate;
		}
		throw new NotSupportedException();
	}

	public override Delegate CreateDelegate(Type delegateType, object target)
	{
		ILTypeInstance instance;
		if (target is ILTypeInstance)
		{
			instance = target as ILTypeInstance;
		}
		else
		{
			if (!(target is CrossBindingAdaptorType crossBindingAdaptorType))
			{
				return CreateDelegate(delegateType);
			}
			instance = crossBindingAdaptorType.ILInstance;
		}
		IDelegateAdapter delegateAdapter;
		if (iDelegate == null)
		{
			iDelegate = appdomain.DelegateManager.FindDelegateAdapter(instance, method, method);
			delegateAdapter = iDelegate;
		}
		else
		{
			delegateAdapter = iDelegate.Instantiate(appdomain, instance, iDelegate.Method);
		}
		return delegateAdapter.Delegate;
	}

	public override string ToString()
	{
		if (definition != null)
		{
			return definition.ToString();
		}
		return base.ToString();
	}
}
