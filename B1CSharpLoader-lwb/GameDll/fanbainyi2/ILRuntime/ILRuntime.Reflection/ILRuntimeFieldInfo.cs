using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Reflection;

public class ILRuntimeFieldInfo : FieldInfo
{
	private System.Reflection.FieldAttributes attr;

	private ILRuntimeType dType;

	private ILType ilType;

	private IType fieldType;

	private bool isStatic;

	private int fieldIdx;

	private string name;

	private FieldDefinition definition;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private Attribute[] customAttributes;

	private Type[] attributeTypes;

	public IType ILFieldType => fieldType;

	public override System.Reflection.FieldAttributes Attributes => attr;

	public override Type DeclaringType => dType;

	public override RuntimeFieldHandle FieldHandle
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override Type FieldType => fieldType.ReflectionType;

	public override string Name => name;

	public override Type ReflectedType => fieldType.ReflectionType;

	public ILRuntimeFieldInfo(FieldDefinition def, ILRuntimeType declaredType, bool isStatic, int fieldIdx)
	{
		definition = def;
		name = def.Name;
		dType = declaredType;
		ilType = dType.ILType;
		appdomain = ilType.AppDomain;
		this.isStatic = isStatic;
		this.fieldIdx = fieldIdx;
		if (isStatic)
		{
			attr |= System.Reflection.FieldAttributes.Static;
		}
		if (def.IsPublic)
		{
			attr |= System.Reflection.FieldAttributes.Public;
		}
		else
		{
			attr |= System.Reflection.FieldAttributes.Private;
		}
		fieldType = (isStatic ? ilType.StaticFieldTypes[fieldIdx] : ilType.FieldTypes[fieldIdx]);
	}

	public ILRuntimeFieldInfo(FieldDefinition def, ILRuntimeType declaredType, int fieldIdx, IType fieldType)
	{
		definition = def;
		name = def.Name;
		dType = declaredType;
		ilType = dType.ILType;
		appdomain = ilType.AppDomain;
		isStatic = false;
		this.fieldIdx = fieldIdx;
		if (isStatic)
		{
			attr |= System.Reflection.FieldAttributes.Static;
		}
		if (def.IsPublic)
		{
			attr |= System.Reflection.FieldAttributes.Public;
		}
		else
		{
			attr |= System.Reflection.FieldAttributes.Private;
		}
		this.fieldType = fieldType;
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
		List<Attribute> list = new List<Attribute>();
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (attributeTypes[i].Equals(attributeType) || attributeTypes[i].IsSubclassOf(attributeType))
			{
				list.Add(customAttributes[i]);
			}
		}
		return list.ToArray();
	}

	public override object GetRawConstantValue()
	{
		return definition.Constant;
	}

	public override object GetValue(object obj)
	{
		ILTypeInstance iLTypeInstance;
		if (!isStatic)
		{
			iLTypeInstance = ((!(obj is ILTypeInstance)) ? ((CrossBindingAdaptorType)obj).ILInstance : ((ILTypeInstance)obj));
		}
		else
		{
			if (definition.HasConstant)
			{
				return definition.Constant;
			}
			iLTypeInstance = ilType.StaticInstance;
		}
		return fieldType.TypeForCLR.CheckCLRTypes(iLTypeInstance[fieldIdx]);
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

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
		if (value is CrossBindingAdaptorType)
		{
			value = ((CrossBindingAdaptorType)value).ILInstance;
		}
		ILTypeInstance iLTypeInstance = (isStatic ? ilType.StaticInstance : ((!(obj is ILTypeInstance)) ? ((CrossBindingAdaptorType)obj).ILInstance : ((ILTypeInstance)obj)));
		iLTypeInstance[fieldIdx] = value;
	}
}
