using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Reflection;

public class ILRuntimePropertyInfo : PropertyInfo
{
	private ILMethod getter;

	private ILMethod setter;

	private ILType dType;

	private PropertyDefinition definition;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private ILRuntimeParameterInfo[] parameters;

	private Attribute[] customAttributes;

	private Type[] attributeTypes;

	public ILMethod Getter
	{
		get
		{
			return getter;
		}
		set
		{
			getter = value;
		}
	}

	public ILMethod Setter
	{
		get
		{
			return setter;
		}
		set
		{
			setter = value;
		}
	}

	public bool IsPublic
	{
		get
		{
			if (getter != null)
			{
				return getter.Definition.IsPublic;
			}
			return setter.Definition.IsPublic;
		}
	}

	public bool IsStatic
	{
		get
		{
			if (getter != null)
			{
				return getter.IsStatic;
			}
			return setter.IsStatic;
		}
	}

	public override string Name => definition.Name;

	public override Type ReflectedType => dType.ReflectionType;

	public override System.Reflection.PropertyAttributes Attributes => System.Reflection.PropertyAttributes.None;

	public override bool CanRead => getter != null;

	public override bool CanWrite => setter != null;

	public override Type PropertyType
	{
		get
		{
			if (getter != null)
			{
				return getter.ReturnType.ReflectionType;
			}
			return setter.Parameters[0].ReflectionType;
		}
	}

	public TypeReference Definition
	{
		get
		{
			if (definition.GetMethod == null)
			{
				return definition.SetMethod.Parameters[0].ParameterType;
			}
			return definition.GetMethod.ReturnType;
		}
	}

	public override Type DeclaringType => dType.ReflectionType;

	public ILRuntimePropertyInfo(PropertyDefinition definition, ILType dType)
	{
		this.definition = definition;
		this.dType = dType;
		appdomain = dType.AppDomain;
		parameters = new ILRuntimeParameterInfo[definition.Parameters.Count];
		for (int i = 0; i < definition.Parameters.Count; i++)
		{
			ParameterDefinition parameterDefinition = definition.Parameters[i];
			IType type = dType.AppDomain.GetType(parameterDefinition.ParameterType, null, null);
			parameters[i] = new ILRuntimeParameterInfo(parameterDefinition, type, this, appdomain);
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
		List<object> list = new List<object>();
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (attributeTypes[i].Equals(attributeType))
			{
				list.Add(customAttributes[i]);
			}
		}
		return list.ToArray();
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (customAttributes == null)
		{
			InitializeCustomAttribute();
		}
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (attributeTypes[i].Equals(attributeType))
			{
				return true;
			}
		}
		return false;
	}

	public override MethodInfo[] GetAccessors(bool nonPublic)
	{
		throw new NotImplementedException();
	}

	public override MethodInfo GetGetMethod(bool nonPublic)
	{
		if (getter != null)
		{
			return getter.ReflectionMethodInfo;
		}
		return null;
	}

	public override ParameterInfo[] GetIndexParameters()
	{
		return parameters;
	}

	public override MethodInfo GetSetMethod(bool nonPublic)
	{
		if (setter != null)
		{
			return setter.ReflectionMethodInfo;
		}
		return null;
	}

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		int num = ((index != null) ? index.Length : 0);
		if (getter.ParameterCount <= num)
		{
			using (InvocationContext invocationContext = appdomain.BeginInvoke(getter))
			{
				if (!IsStatic)
				{
					invocationContext.PushObject(obj);
				}
				for (int i = 0; i < getter.ParameterCount; i++)
				{
					invocationContext.PushObject(index[i], !getter.Parameters[i].IsValueType);
				}
				invocationContext.Invoke();
				return invocationContext.ReadObject(getter.ReturnType.TypeForCLR);
			}
		}
		throw new ArgumentException("Index count mismatch");
	}

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		int num = ((index != null) ? index.Length : 0);
		if (setter.ParameterCount <= num + 1)
		{
			using (InvocationContext invocationContext = appdomain.BeginInvoke(setter))
			{
				if (!IsStatic)
				{
					invocationContext.PushObject(obj);
				}
				for (int i = 0; i < setter.ParameterCount - 1; i++)
				{
					invocationContext.PushObject(index[i], !setter.Parameters[i].IsValueType);
				}
				invocationContext.PushObject(value, !setter.Parameters[setter.ParameterCount - 1].IsValueType);
				invocationContext.Invoke();
				return;
			}
		}
		throw new ArgumentException("Index count mismatch");
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
