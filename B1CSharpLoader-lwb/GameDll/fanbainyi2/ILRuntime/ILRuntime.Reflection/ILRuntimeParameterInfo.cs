using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Reflection;

public class ILRuntimeParameterInfo : ParameterInfo
{
	private ParameterDefinition definition;

	private Attribute[] customAttributes;

	private Type[] attributeTypes;

	public IType IType { get; private set; }

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain { get; private set; }

	public override bool HasDefaultValue => definition.HasDefault;

	public override object DefaultValue => DefaultValueImpl;

	public override object RawDefaultValue => DefaultValueImpl;

	public override int MetadataToken => definition.MetadataToken.ToInt32();

	public ILRuntimeParameterInfo(ParameterDefinition definition, IType type, MemberInfo member, ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		IType = type;
		this.definition = definition;
		AppDomain = appdomain;
		AttrsImpl = (System.Reflection.ParameterAttributes)definition.Attributes;
		ClassImpl = ((type is ILGenericParameterType) ? typeof(ILGenericParameterType) : type.ReflectionType);
		DefaultValueImpl = definition.Constant;
		MemberImpl = member;
		NameImpl = definition.Name;
		PositionImpl = definition.Index;
	}

	private void InitializeCustomAttribute()
	{
		customAttributes = new Attribute[definition.CustomAttributes.Count];
		attributeTypes = new Type[customAttributes.Length];
		for (int i = 0; i < definition.CustomAttributes.Count; i++)
		{
			CustomAttribute customAttribute = definition.CustomAttributes[i];
			IType type = AppDomain.GetType(customAttribute.AttributeType, null, null);
			try
			{
				Attribute attribute = customAttribute.CreateInstance(type, AppDomain) as Attribute;
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

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		object[] array = GetCustomAttributes(attributeType, inherit);
		if (array != null)
		{
			return array.Length != 0;
		}
		return false;
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
