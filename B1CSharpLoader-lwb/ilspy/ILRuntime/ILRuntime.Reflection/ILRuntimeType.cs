using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Reflection;

public class ILRuntimeType : Type
{
	private ILType type;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private Attribute[] customAttributes;

	private Type[] attributeTypes;

	private ILRuntimeFieldInfo[] fields;

	private ILRuntimePropertyInfo[] properties;

	private ILRuntimeMethodInfo[] methods;

	public ILType ILType => type;

	public override Assembly Assembly => typeof(ILRuntimeType).Assembly;

	public override string AssemblyQualifiedName => type.FullName;

	public override Type BaseType
	{
		get
		{
			if (type.IsEnum)
			{
				return typeof(Enum);
			}
			if (type.IsArray)
			{
				return typeof(Array);
			}
			if (type.BaseType == null)
			{
				return null;
			}
			return type.BaseType.ReflectionType;
		}
	}

	public override string FullName => type.FullName;

	public override Guid GUID
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override Module Module
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override string Name => type.Name;

	public override string Namespace => type.TypeDefinition.Namespace;

	public override Type UnderlyingSystemType => typeof(ILTypeInstance);

	public override bool IsGenericType
	{
		get
		{
			if (!type.HasGenericParameter)
			{
				return type.GenericArguments != null;
			}
			return true;
		}
	}

	public override bool IsGenericTypeDefinition => type.HasGenericParameter;

	public ILRuntimeType(ILType t)
	{
		type = t;
		appdomain = t.AppDomain;
	}

	private void InitializeCustomAttribute()
	{
		if (this.type.TypeDefinition == null)
		{
			customAttributes = new Attribute[0];
			attributeTypes = new Type[0];
			return;
		}
		customAttributes = new Attribute[this.type.TypeDefinition.CustomAttributes.Count];
		attributeTypes = new Type[customAttributes.Length];
		for (int i = 0; i < this.type.TypeDefinition.CustomAttributes.Count; i++)
		{
			CustomAttribute customAttribute = this.type.TypeDefinition.CustomAttributes[i];
			IType type = appdomain.GetType(customAttribute.AttributeType, this.type, null);
			try
			{
				Attribute attribute = customAttribute.CreateInstance(type, appdomain) as Attribute;
				attributeTypes[i] = ((type.ReflectionType is ILRuntimeWrapperType) ? type.TypeForCLR : type.ReflectionType);
				customAttributes[i] = attribute;
			}
			catch
			{
				attributeTypes[i] = typeof(Attribute);
			}
		}
	}

	private void InitializeProperties()
	{
		if (type.TypeDefinition == null)
		{
			properties = new ILRuntimePropertyInfo[0];
			return;
		}
		int num = (type.TypeDefinition.HasProperties ? type.TypeDefinition.Properties.Count : 0);
		properties = new ILRuntimePropertyInfo[num];
		for (int i = 0; i < num; i++)
		{
			PropertyDefinition propertyDefinition = type.TypeDefinition.Properties[i];
			ILRuntimePropertyInfo iLRuntimePropertyInfo = new ILRuntimePropertyInfo(propertyDefinition, type);
			properties[i] = iLRuntimePropertyInfo;
			if (propertyDefinition.GetMethod != null)
			{
				iLRuntimePropertyInfo.Getter = type.GetMethod(propertyDefinition.GetMethod.Name, propertyDefinition.GetMethod.Parameters.Select((ParameterDefinition p) => type.AppDomain.GetType(p.ParameterType, type, null)).ToList(), null) as ILMethod;
			}
			if (propertyDefinition.SetMethod != null)
			{
				iLRuntimePropertyInfo.Setter = type.GetMethod(propertyDefinition.SetMethod.Name, propertyDefinition.SetMethod.Parameters.Select((ParameterDefinition p) => type.AppDomain.GetType(p.ParameterType, type, null)).ToList(), null) as ILMethod;
			}
		}
	}

	private void InitializeMethods()
	{
		List<IMethod> list = type.GetMethods();
		methods = new ILRuntimeMethodInfo[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			methods[i] = (ILRuntimeMethodInfo)((ILMethod)list[i]).ReflectionMethodInfo;
		}
	}

	public override Type MakeGenericType(params Type[] typeArguments)
	{
		if (ILType.TypeReference.HasGenericParameters)
		{
			KeyValuePair<string, IType>[] array = new KeyValuePair<string, IType>[typeArguments.Length];
			for (int i = 0; i < array.Length; i++)
			{
				string name = ILType.TypeReference.GenericParameters[i].Name;
				if (typeArguments[i] is ILRuntimeType)
				{
					array[i] = new KeyValuePair<string, IType>(name, ((ILRuntimeType)typeArguments[i]).ILType);
				}
				else
				{
					array[i] = new KeyValuePair<string, IType>(name, ILType.AppDomain.GetType(typeArguments[i]));
				}
			}
			return ILType.MakeGenericInstance(array).ReflectionType;
		}
		throw new NotSupportedException();
	}

	private void InitializeFields()
	{
		int num = ((type.StaticFieldTypes != null) ? type.StaticFieldTypes.Length : 0);
		fields = new ILRuntimeFieldInfo[type.TotalFieldCount + num];
		for (int i = 0; i < type.TotalFieldCount; i++)
		{
			FieldDefinition fd;
			IType field = type.GetField(i, out fd);
			fields[i] = new ILRuntimeFieldInfo(fd, this, i, field);
		}
		for (int j = type.TotalFieldCount; j < type.TotalFieldCount + num; j++)
		{
			fields[j] = new ILRuntimeFieldInfo(type.StaticFieldDefinitions[j - type.TotalFieldCount], this, isStatic: true, j - type.TotalFieldCount);
		}
	}

	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		List<ILMethod> constructors = type.GetConstructors();
		ConstructorInfo[] array = new ConstructorInfo[constructors.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = constructors[i].ReflectionConstructorInfo;
		}
		return array;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		if (customAttributes == null)
		{
			InitializeCustomAttribute();
		}
		if (inherit && BaseType != null)
		{
			List<Attribute> list = new List<Attribute>();
			list.AddRange(customAttributes);
			if (BaseType.GetCustomAttributes(inherit) is Attribute[] collection)
			{
				list.AddRange(collection);
			}
			return list.ToArray();
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
			if (attributeTypes[i].Equals((object?)attributeType))
			{
				list.Add(customAttributes[i]);
			}
		}
		if (inherit && BaseType != null && BaseType.GetCustomAttributes(attributeType, inherit) is Attribute[] collection)
		{
			list.AddRange(collection);
		}
		return list.ToArray();
	}

	public override bool IsAssignableFrom(Type c)
	{
		IType type = ((c is ILRuntimeWrapperType) ? ((ILRuntimeWrapperType)c).CLRType : ((!(c is ILRuntimeType)) ? ILType.AppDomain.GetType(c) : ((ILRuntimeType)c).ILType));
		return type.CanAssignTo(ILType);
	}

	public override bool IsInstanceOfType(object o)
	{
		if (o == null)
		{
			return false;
		}
		ILTypeInstance iLTypeInstance = o as ILTypeInstance;
		return IsAssignableFrom((iLTypeInstance != null) ? iLTypeInstance.Type.ReflectionType : o.GetType());
	}

	public override Type GetElementType()
	{
		if (type.IsArray)
		{
			return type.ElementType.ReflectionType;
		}
		throw new NotImplementedException();
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		throw new NotImplementedException();
	}

	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		throw new NotImplementedException();
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		if (fields == null)
		{
			InitializeFields();
		}
		bool flag = (bindingAttr & BindingFlags.Public) == BindingFlags.Public;
		bool flag2 = (bindingAttr & BindingFlags.NonPublic) == BindingFlags.NonPublic;
		bool flag3 = (bindingAttr & BindingFlags.Static) == BindingFlags.Static;
		bool flag4 = (bindingAttr & BindingFlags.Instance) == BindingFlags.Instance;
		bool flag5 = (bindingAttr & BindingFlags.DeclaredOnly) == BindingFlags.DeclaredOnly;
		for (int i = 0; i < fields.Length; i++)
		{
			FieldInfo fieldInfo = fields[i];
			if ((flag == fieldInfo.IsPublic || flag2 == !fieldInfo.IsPublic) && (flag3 == fieldInfo.IsStatic || flag4 == !fieldInfo.IsStatic) && (!flag5 || i >= type.FieldStartIndex) && fieldInfo.Name == name)
			{
				return fieldInfo;
			}
		}
		if (BaseType != null && BaseType is ILRuntimeWrapperType)
		{
			return BaseType.GetField(name, bindingAttr);
		}
		return null;
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		if (fields == null)
		{
			InitializeFields();
		}
		bool flag = (bindingAttr & BindingFlags.Public) == BindingFlags.Public;
		bool flag2 = (bindingAttr & BindingFlags.NonPublic) == BindingFlags.NonPublic;
		bool flag3 = (bindingAttr & BindingFlags.Static) == BindingFlags.Static;
		bool flag4 = (bindingAttr & BindingFlags.Instance) == BindingFlags.Instance;
		bool flag5 = (bindingAttr & BindingFlags.DeclaredOnly) == BindingFlags.DeclaredOnly;
		List<FieldInfo> list = new List<FieldInfo>();
		for (int i = 0; i < fields.Length; i++)
		{
			FieldInfo fieldInfo = fields[i];
			if ((flag == fieldInfo.IsPublic || flag2 == !fieldInfo.IsPublic) && (flag3 == fieldInfo.IsStatic || flag4 == !fieldInfo.IsStatic) && (!flag5 || i >= type.FieldStartIndex))
			{
				list.Add(fieldInfo);
			}
		}
		if ((bindingAttr & BindingFlags.DeclaredOnly) != BindingFlags.DeclaredOnly && BaseType != null && BaseType is ILRuntimeWrapperType)
		{
			list.AddRange(BaseType.GetFields(bindingAttr));
		}
		return list.ToArray();
	}

	public override Type GetInterface(string name, bool ignoreCase)
	{
		if (type.FirstCLRInterface != null)
		{
			if (type.FirstCLRInterface.Name == name)
			{
				return type.FirstCLRInterface.TypeForCLR;
			}
			return null;
		}
		return null;
	}

	public override Type[] GetInterfaces()
	{
		if (this.type.Implements == null)
		{
			return new Type[0];
		}
		Type[] array = new Type[this.type.Implements.Length];
		int i = 0;
		for (int num = this.type.Implements.Length; i < num; i++)
		{
			IType type = this.type.Implements[i];
			if (type != null)
			{
				array[i] = type.ReflectionType;
			}
		}
		return array;
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		if (fields == null)
		{
			InitializeFields();
		}
		if (properties == null)
		{
			InitializeProperties();
		}
		MemberInfo[] array = new MemberInfo[methods.Length + fields.Length + properties.Length];
		for (int i = 0; i < methods.Length; i++)
		{
			array[i] = methods[i];
		}
		for (int j = methods.Length; j < methods.Length + fields.Length; j++)
		{
			array[j] = fields[j - methods.Length];
		}
		for (int k = methods.Length + fields.Length; k < array.Length; k++)
		{
			array[k] = properties[k - methods.Length - fields.Length];
		}
		return array;
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		bool flag = (bindingAttr & BindingFlags.Public) == BindingFlags.Public;
		bool flag2 = (bindingAttr & BindingFlags.NonPublic) == BindingFlags.NonPublic;
		bool flag3 = (bindingAttr & BindingFlags.Static) == BindingFlags.Static;
		bool flag4 = (bindingAttr & BindingFlags.Instance) == BindingFlags.Instance;
		List<MethodInfo> list = new List<MethodInfo>();
		ILRuntimeMethodInfo[] array = methods;
		foreach (ILRuntimeMethodInfo iLRuntimeMethodInfo in array)
		{
			if ((flag == iLRuntimeMethodInfo.IsPublic || flag2 == !iLRuntimeMethodInfo.IsPublic) && (flag3 == iLRuntimeMethodInfo.IsStatic || flag4 == !iLRuntimeMethodInfo.IsStatic))
			{
				list.Add(iLRuntimeMethodInfo);
			}
		}
		if ((bindingAttr & BindingFlags.DeclaredOnly) != BindingFlags.DeclaredOnly && BaseType != null)
		{
			list.AddRange(BaseType.GetMethods(bindingAttr));
		}
		return list.ToArray();
	}

	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		throw new NotImplementedException();
	}

	public override Type[] GetNestedTypes(BindingFlags bindingAttr)
	{
		throw new NotImplementedException();
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		if (properties == null)
		{
			InitializeProperties();
		}
		bool flag = (bindingAttr & BindingFlags.Public) == BindingFlags.Public;
		bool flag2 = (bindingAttr & BindingFlags.NonPublic) == BindingFlags.NonPublic;
		bool flag3 = (bindingAttr & BindingFlags.Static) == BindingFlags.Static;
		bool flag4 = (bindingAttr & BindingFlags.Instance) == BindingFlags.Instance;
		List<PropertyInfo> list = new List<PropertyInfo>();
		ILRuntimePropertyInfo[] array = properties;
		foreach (ILRuntimePropertyInfo iLRuntimePropertyInfo in array)
		{
			if ((flag == iLRuntimePropertyInfo.IsPublic || flag2 == !iLRuntimePropertyInfo.IsPublic) && (flag3 == iLRuntimePropertyInfo.IsStatic || flag4 == !iLRuntimePropertyInfo.IsStatic))
			{
				list.Add(iLRuntimePropertyInfo);
			}
		}
		if ((bindingAttr & BindingFlags.DeclaredOnly) != BindingFlags.DeclaredOnly && BaseType != null)
		{
			list.AddRange(BaseType.GetProperties(bindingAttr));
		}
		return list.ToArray();
	}

	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		throw new NotImplementedException();
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

	protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl()
	{
		System.Reflection.TypeAttributes typeAttributes = System.Reflection.TypeAttributes.Public;
		if (type.TypeDefinition == null)
		{
			return System.Reflection.TypeAttributes.NotPublic;
		}
		if (type.TypeDefinition.IsAbstract)
		{
			typeAttributes |= System.Reflection.TypeAttributes.Abstract;
		}
		if (!type.IsValueType)
		{
			typeAttributes |= System.Reflection.TypeAttributes.NotPublic;
		}
		if (type.TypeDefinition.IsSealed)
		{
			typeAttributes |= System.Reflection.TypeAttributes.Sealed;
		}
		return typeAttributes;
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		List<IType> list = new List<IType>();
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] is ILRuntimeType)
			{
				list.Add(((ILRuntimeType)types[i]).type);
				continue;
			}
			IType type = appdomain.GetType(types[i]);
			if (type == null)
			{
				type = appdomain.GetType(types[i].AssemblyQualifiedName);
			}
			if (type == null)
			{
				throw new TypeLoadException();
			}
			list.Add(type);
		}
		IMethod constructor = this.type.GetConstructor(list);
		if (constructor != null)
		{
			return ((ILMethod)constructor).ReflectionConstructorInfo;
		}
		return null;
	}

	public override Type[] GetGenericArguments()
	{
		KeyValuePair<string, IType>[] genericArguments = type.GenericArguments;
		Type[] array = new Type[genericArguments.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = genericArguments[i].Value.ReflectionType;
		}
		return array;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		bool flag = (bindingAttr & BindingFlags.DeclaredOnly) == BindingFlags.DeclaredOnly;
		IMethod method;
		if (types == null)
		{
			method = this.type.GetMethod(name);
			if (method == null && !flag)
			{
				return BaseType.GetMethod(name, bindingAttr);
			}
		}
		else
		{
			List<IType> list = new List<IType>();
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] is ILRuntimeType)
				{
					list.Add(((ILRuntimeType)types[i]).type);
					continue;
				}
				IType type = appdomain.GetType(types[i]);
				if (type == null)
				{
					type = appdomain.GetType(types[i].AssemblyQualifiedName);
				}
				if (type == null)
				{
					throw new TypeLoadException();
				}
				list.Add(type);
			}
			method = this.type.GetMethod(name, list, null, null, flag);
		}
		if (method != null)
		{
			return ((ILMethod)method).ReflectionMethodInfo;
		}
		return null;
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		if (properties == null)
		{
			InitializeProperties();
		}
		ILRuntimePropertyInfo[] array = properties;
		foreach (ILRuntimePropertyInfo iLRuntimePropertyInfo in array)
		{
			if (iLRuntimePropertyInfo.Name == name)
			{
				return iLRuntimePropertyInfo;
			}
		}
		if ((bindingAttr & BindingFlags.DeclaredOnly) != BindingFlags.DeclaredOnly && BaseType != null)
		{
			return BaseType.GetProperty(name, bindingAttr);
		}
		return null;
	}

	protected override bool HasElementTypeImpl()
	{
		return false;
	}

	protected override bool IsArrayImpl()
	{
		return type.IsArray;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}

	public override string ToString()
	{
		return type.FullName;
	}

	public override int GetHashCode()
	{
		return type.GetHashCode();
	}

	public override bool Equals(Type o)
	{
		if (!(o is ILRuntimeType))
		{
			return false;
		}
		return ((ILRuntimeType)o).type == type;
	}

	public override bool Equals(object o)
	{
		if (!(o is ILRuntimeType))
		{
			return false;
		}
		return ((ILRuntimeType)o).type == type;
	}

	public override Type GetGenericTypeDefinition()
	{
		return type.GetGenericDefinition()?.ReflectionType;
	}
}
