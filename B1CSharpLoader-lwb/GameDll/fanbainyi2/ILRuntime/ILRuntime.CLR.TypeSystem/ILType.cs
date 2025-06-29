using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Collections.Generic;
using ILRuntime.Reflection;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Intepreter.OpCodes;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.CLR.TypeSystem;

public sealed class ILType : IType
{
	private Dictionary<string, List<ILMethod>> methods;

	private TypeReference typeRef;

	private TypeDefinition definition;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private bool staticConstructorCalled;

	private ILMethod staticConstructor;

	private List<ILMethod> constructors;

	private IType[] fieldTypes;

	private FieldDefinition[] fieldDefinitions;

	private IType[] staticFieldTypes;

	private FieldDefinition[] staticFieldDefinitions;

	private Dictionary<string, int> fieldMapping;

	private Dictionary<string, int> staticFieldMapping;

	private ILTypeStaticInstance staticInstance;

	private Dictionary<int, int> fieldTokenMapping = new Dictionary<int, int>();

	private int fieldStartIdx = -1;

	private int totalFieldCnt = -1;

	private KeyValuePair<string, IType>[] genericArguments;

	private IType baseType;

	private IType byRefType;

	private IType enumType;

	private IType elementType;

	private Dictionary<int, IType> arrayTypes;

	private Type arrayCLRType;

	private Type byRefCLRType;

	private IType[] interfaces;

	private bool baseTypeInitialized;

	private bool interfaceInitialized;

	private List<ILType> genericInstances;

	private bool isDelegate;

	private ILRuntimeType reflectionType;

	private ILType genericDefinition;

	private IType firstCLRBaseType;

	private IType firstCLRInterface;

	private int hashCode = -1;

	private int tIdx = -1;

	private static int instance_id = 268435456;

	private int jitFlags;

	private bool mToStringGot;

	private bool mEqualsGot;

	private bool mGetHashCodeGot;

	private IMethod mToString;

	private IMethod mEquals;

	private IMethod mGetHashCode;

	private int valuetypeFieldCount;

	private int valuetypeManagedCount;

	private bool valuetypeSizeCalculated;

	private bool? isValueType;

	private string fullName;

	private string fullNameForNested;

	public TypeDefinition TypeDefinition => definition;

	public IMethod ToStringMethod
	{
		get
		{
			if (!mToStringGot)
			{
				IMethod method = appdomain.ObjectType.GetMethod("ToString", 0, declaredOnly: true);
				mToString = GetVirtualMethod(method);
				mToStringGot = true;
			}
			return mToString;
		}
	}

	public IMethod EqualsMethod
	{
		get
		{
			if (!mEqualsGot)
			{
				IMethod method = appdomain.ObjectType.GetMethod("Equals", 1, declaredOnly: true);
				mEquals = GetVirtualMethod(method);
				mEqualsGot = true;
			}
			return mEquals;
		}
	}

	public IMethod GetHashCodeMethod
	{
		get
		{
			if (!mGetHashCodeGot)
			{
				IMethod method = appdomain.ObjectType.GetMethod("GetHashCode", 0, declaredOnly: true);
				mGetHashCode = GetVirtualMethod(method);
				mGetHashCodeGot = true;
			}
			return mGetHashCode;
		}
	}

	public TypeReference TypeReference
	{
		get
		{
			return typeRef;
		}
		set
		{
			typeRef = value;
			RetriveDefinitino(value);
		}
	}

	public IType BaseType
	{
		get
		{
			if (!baseTypeInitialized)
			{
				InitializeBaseType();
			}
			return baseType;
		}
	}

	public IType[] Implements
	{
		get
		{
			if (!interfaceInitialized)
			{
				InitializeInterfaces();
			}
			return interfaces;
		}
	}

	public ILTypeStaticInstance StaticInstance
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			if (methods == null)
			{
				InitializeMethods();
			}
			if (staticInstance == null && staticFieldTypes != null)
			{
				staticInstance = new ILTypeStaticInstance(this);
			}
			if (staticInstance != null && !staticConstructorCalled)
			{
				staticConstructorCalled = true;
				if (staticConstructor != null && (!TypeReference.HasGenericParameters || IsGenericInstance))
				{
					appdomain.Invoke(staticConstructor, null, null);
				}
			}
			return staticInstance;
		}
	}

	public IType[] FieldTypes
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			return fieldTypes;
		}
	}

	public IType[] StaticFieldTypes
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			return staticFieldTypes;
		}
	}

	public FieldDefinition[] StaticFieldDefinitions
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			return staticFieldDefinitions;
		}
	}

	public Dictionary<string, int> FieldMapping
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			return fieldMapping;
		}
	}

	public IType FirstCLRBaseType
	{
		get
		{
			if (!baseTypeInitialized)
			{
				InitializeBaseType();
			}
			return firstCLRBaseType;
		}
	}

	public IType FirstCLRInterface
	{
		get
		{
			if (!interfaceInitialized)
			{
				InitializeInterfaces();
			}
			return firstCLRInterface;
		}
	}

	public bool HasGenericParameter
	{
		get
		{
			if (typeRef.HasGenericParameters)
			{
				return genericArguments == null;
			}
			return false;
		}
	}

	public bool IsGenericParameter
	{
		get
		{
			if (typeRef.IsGenericParameter)
			{
				return genericArguments == null;
			}
			return false;
		}
	}

	public Dictionary<string, int> StaticFieldMapping => staticFieldMapping;

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => appdomain;

	internal int FieldStartIndex
	{
		get
		{
			if (fieldStartIdx < 0)
			{
				if (BaseType != null)
				{
					if (BaseType is ILType)
					{
						fieldStartIdx = ((ILType)BaseType).TotalFieldCount;
					}
					else
					{
						fieldStartIdx = 0;
					}
				}
				else
				{
					fieldStartIdx = 0;
				}
			}
			return fieldStartIdx;
		}
	}

	public int TotalFieldCount
	{
		get
		{
			if (totalFieldCnt < 0)
			{
				if (fieldMapping == null)
				{
					InitializeFields();
				}
				if (BaseType != null)
				{
					if (BaseType is ILType)
					{
						totalFieldCnt = ((ILType)BaseType).TotalFieldCount + fieldTypes.Length;
					}
					else
					{
						totalFieldCnt = fieldTypes.Length;
					}
				}
				else
				{
					totalFieldCnt = fieldTypes.Length;
				}
			}
			return totalFieldCnt;
		}
	}

	internal List<ILType> GenericInstances => genericInstances;

	public bool IsGenericInstance => genericArguments != null;

	public KeyValuePair<string, IType>[] GenericArguments => genericArguments;

	public IType ElementType => elementType;

	public bool IsArray { get; private set; }

	public int ArrayRank { get; private set; }

	public bool IsByRef => typeRef.IsByReference;

	public bool IsValueType
	{
		get
		{
			if (IsArray)
			{
				return false;
			}
			if (!isValueType.HasValue)
			{
				isValueType = definition.IsValueType;
			}
			return isValueType.Value;
		}
	}

	public bool IsDelegate
	{
		get
		{
			if (!baseTypeInitialized)
			{
				InitializeBaseType();
			}
			return isDelegate;
		}
	}

	public bool IsPrimitive => false;

	public bool IsInterface => TypeDefinition.IsInterface;

	public Type TypeForCLR
	{
		get
		{
			if (!baseTypeInitialized)
			{
				InitializeBaseType();
			}
			if (typeRef is ArrayType)
			{
				return arrayCLRType;
			}
			if (typeRef is ByReferenceType)
			{
				return byRefCLRType;
			}
			if (IsEnum)
			{
				if (enumType == null)
				{
					InitializeFields();
				}
				return enumType.TypeForCLR;
			}
			if (FirstCLRBaseType != null && FirstCLRBaseType is CrossBindingAdaptor)
			{
				return ((CrossBindingAdaptor)FirstCLRBaseType).RuntimeType.TypeForCLR;
			}
			if (FirstCLRInterface != null && FirstCLRInterface is CrossBindingAdaptor)
			{
				return ((CrossBindingAdaptor)FirstCLRInterface).RuntimeType.TypeForCLR;
			}
			return typeof(ILTypeInstance);
		}
	}

	public Type ReflectionType
	{
		get
		{
			if (reflectionType == null)
			{
				reflectionType = new ILRuntimeType(this);
			}
			return reflectionType;
		}
	}

	public IType ByRefType => byRefType;

	public IType ArrayType
	{
		get
		{
			if (arrayTypes == null)
			{
				return null;
			}
			return arrayTypes[1];
		}
	}

	public bool IsEnum
	{
		get
		{
			if (definition == null)
			{
				return false;
			}
			return definition.IsEnum;
		}
	}

	public string FullNameForNested
	{
		get
		{
			if (string.IsNullOrEmpty(fullNameForNested))
			{
				if (typeRef.IsNested)
				{
					fullNameForNested = FullName.Replace("/", ".");
				}
				else
				{
					fullNameForNested = FullName;
				}
			}
			return fullNameForNested;
		}
	}

	public string FullName
	{
		get
		{
			if (string.IsNullOrEmpty(fullName))
			{
				if (typeRef.HasGenericParameters && genericArguments != null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(typeRef.FullName);
					stringBuilder.Append('<');
					bool flag = true;
					KeyValuePair<string, IType>[] array = genericArguments;
					foreach (KeyValuePair<string, IType> keyValuePair in array)
					{
						if (flag)
						{
							flag = false;
						}
						else
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(keyValuePair.Value.FullName);
					}
					stringBuilder.Append('>');
					fullName = stringBuilder.ToString();
				}
				else
				{
					fullName = typeRef.FullName;
				}
			}
			return fullName;
		}
	}

	public string Name => typeRef.Name;

	public StackObject DefaultObject => default(StackObject);

	public int TypeIndex
	{
		get
		{
			if (tIdx < 0)
			{
				tIdx = appdomain.AllocTypeIndex(this);
			}
			return tIdx;
		}
	}

	public ILType(TypeReference def, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		typeRef = def;
		RetriveDefinitino(def);
		appdomain = domain;
		jitFlags = domain.DefaultJITFlags;
	}

	private void RetriveDefinitino(TypeReference def)
	{
		if (def.IsGenericParameter || definition != null)
		{
			return;
		}
		if (def is TypeSpecification)
		{
			if (def.IsByReference || def is ArrayType)
			{
				definition = null;
			}
			else
			{
				RetriveDefinitino(((TypeSpecification)def).ElementType);
			}
		}
		else
		{
			definition = def as TypeDefinition;
		}
	}

	public ILType GetGenericDefinition()
	{
		return genericDefinition;
	}

	public List<IMethod> GetMethods()
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		List<IMethod> list = new List<IMethod>();
		foreach (KeyValuePair<string, List<ILMethod>> method in methods)
		{
			foreach (ILMethod item in method.Value)
			{
				list.Add(item);
			}
		}
		return list;
	}

	private void InitializeInterfaces()
	{
		interfaceInitialized = true;
		if (definition != null && definition.HasInterfaces)
		{
			interfaces = new IType[definition.Interfaces.Count];
			for (int i = 0; i < interfaces.Length; i++)
			{
				interfaces[i] = appdomain.GetType(definition.Interfaces[i].InterfaceType, this, null);
				if (interfaces[i] is CLRType && firstCLRInterface == null)
				{
					if (!appdomain.CrossBindingAdaptors.TryGetValue(interfaces[i].TypeForCLR, out var value))
					{
						throw new TypeLoadException("Cannot find Adaptor for:" + interfaces[i].TypeForCLR.ToString());
					}
					interfaces[i] = value;
					firstCLRInterface = value;
				}
			}
		}
		if (firstCLRInterface == null && BaseType != null && BaseType is ILType)
		{
			firstCLRInterface = ((ILType)BaseType).FirstCLRInterface;
		}
	}

	private void InitializeBaseType()
	{
		if (definition != null && definition.BaseType != null)
		{
			bool flag = false;
			List<int> list = null;
			if (definition.BaseType.IsGenericInstance)
			{
				GenericInstanceType genericInstanceType = definition.BaseType as GenericInstanceType;
				if (appdomain.GetType(genericInstanceType.ElementType, this, null) is CLRType)
				{
					for (int i = 0; i < genericInstanceType.GenericArguments.Count; i++)
					{
						if (genericInstanceType.GenericArguments[i] == typeRef)
						{
							flag = true;
							if (list == null)
							{
								list = new List<int>();
							}
							list.Add(i);
						}
					}
				}
			}
			if (flag)
			{
				IType type = appdomain.GetType(((GenericInstanceType)definition.BaseType).ElementType, this, null);
				foreach (KeyValuePair<Type, CrossBindingAdaptor> crossBindingAdaptor in appdomain.CrossBindingAdaptors)
				{
					if (!crossBindingAdaptor.Key.IsGenericType || crossBindingAdaptor.Key.IsGenericTypeDefinition || !(crossBindingAdaptor.Key.GetGenericTypeDefinition() == type.TypeForCLR))
					{
						continue;
					}
					Type[] array = crossBindingAdaptor.Key.GetGenericArguments();
					bool flag2 = true;
					foreach (int item in list)
					{
						if (array[item] != crossBindingAdaptor.Value.AdaptorType)
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						baseType = crossBindingAdaptor.Value;
						break;
					}
				}
				if (baseType == null)
				{
					throw new TypeLoadException("Cannot find Adaptor for:" + definition.BaseType.FullName);
				}
			}
			else
			{
				baseType = appdomain.GetType(definition.BaseType, this, null);
				if (baseType is CLRType)
				{
					if (baseType.TypeForCLR == typeof(Enum) || baseType.TypeForCLR == typeof(object) || baseType.TypeForCLR == typeof(ValueType) || baseType.TypeForCLR == typeof(Enum))
					{
						baseType = null;
					}
					else if (baseType.TypeForCLR == typeof(MulticastDelegate))
					{
						baseType = null;
						isDelegate = true;
					}
					else
					{
						if (!appdomain.CrossBindingAdaptors.TryGetValue(baseType.TypeForCLR, out var value))
						{
							throw new TypeLoadException("Cannot find Adaptor for:" + baseType.TypeForCLR.ToString());
						}
						baseType = value;
					}
				}
			}
		}
		IType type2 = baseType;
		while (type2 is ILType)
		{
			type2 = type2.BaseType;
		}
		firstCLRBaseType = type2;
		baseTypeInitialized = true;
	}

	public IMethod GetMethod(string name)
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		if (methods.TryGetValue(name, out var value))
		{
			return value[0];
		}
		return null;
	}

	public IMethod GetMethod(string name, int paramCount, bool declaredOnly = false)
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		if (methods.TryGetValue(name, out var value))
		{
			foreach (ILMethod item in value)
			{
				if (item.ParameterCount == paramCount)
				{
					return item;
				}
			}
		}
		if (declaredOnly)
		{
			return null;
		}
		if (BaseType != null && !(BaseType is CrossBindingAdaptor))
		{
			return BaseType.GetMethod(name, paramCount);
		}
		return null;
	}

	private void InitializeMethods()
	{
		methods = new Dictionary<string, List<ILMethod>>();
		constructors = new List<ILMethod>();
		if (definition == null)
		{
			return;
		}
		if (definition.HasCustomAttributes)
		{
			for (int i = 0; i < definition.CustomAttributes.Count; i++)
			{
				if (definition.CustomAttributes[i].GetJITFlags(AppDomain, out var flags))
				{
					jitFlags = flags;
					break;
				}
			}
		}
		foreach (MethodDefinition method in definition.Methods)
		{
			if (method.IsConstructor)
			{
				if (method.IsStatic)
				{
					staticConstructor = new ILMethod(method, this, appdomain, jitFlags);
				}
				else
				{
					constructors.Add(new ILMethod(method, this, appdomain, jitFlags));
				}
				continue;
			}
			if (!methods.TryGetValue(method.Name, out var value))
			{
				value = new List<ILMethod>();
				methods[method.Name] = value;
			}
			ILMethod item = new ILMethod(method, this, appdomain, jitFlags);
			value.Add(item);
		}
		foreach (EventDefinition @event in definition.Events)
		{
			int value2 = -1;
			InitializeFields();
			if (@event.AddMethod.IsStatic)
			{
				staticFieldMapping.TryGetValue(@event.Name, out value2);
			}
			else
			{
				fieldMapping.TryGetValue(@event.Name, out value2);
			}
			if (methods.TryGetValue(@event.AddMethod.Name, out var value3))
			{
				value3[0].SetEventAddOrRemove(isEventAdd: true, isEventRemove: false, value2);
			}
			if (methods.TryGetValue(@event.RemoveMethod.Name, out value3))
			{
				value3[0].SetEventAddOrRemove(isEventAdd: false, isEventRemove: true, value2);
			}
		}
		if (!appdomain.SuppressStaticConstructor && !staticConstructorCalled)
		{
			staticConstructorCalled = true;
			if (staticConstructor != null && (!TypeReference.HasGenericParameters || IsGenericInstance))
			{
				appdomain.Invoke(staticConstructor, null, null);
			}
		}
	}

	public IMethod GetVirtualMethod(IMethod method)
	{
		IType[] array = null;
		if (method.IsGenericInstance)
		{
			array = ((!(method is ILMethod)) ? ((CLRMethod)method).GenericArguments : ((ILMethod)method).GenericArugmentsArray);
		}
		IMethod method2 = GetMethod(method.Name, method.Parameters, array, method.ReturnType, declaredOnly: true);
		if (method2 == null && BaseType != null)
		{
			method2 = BaseType.GetVirtualMethod(method);
			if (method2 != null)
			{
				return method2;
			}
		}
		if (method2 == null && method.DeclearingType.IsInterface)
		{
			if (method.DeclearingType is ILType)
			{
				ILType iLType = (ILType)method.DeclearingType;
				method2 = GetMethod($"{iLType.FullNameForNested}.{method.Name}", method.Parameters, array, method.ReturnType, declaredOnly: true);
			}
			else
			{
				method2 = GetMethod($"{method.DeclearingType.FullName}.{method.Name}", method.Parameters, array, method.ReturnType, declaredOnly: true);
			}
		}
		if (method2 == null || method2.IsGenericInstance == method.IsGenericInstance)
		{
			return method2;
		}
		return method;
	}

	public IMethod GetMethod(string name, List<IType> param, IType[] genericArguments, IType returnType = null, bool declaredOnly = false)
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		IMethod method = null;
		if (methods.TryGetValue(name, out var value))
		{
			for (int i = 0; i < value.Count; i++)
			{
				ILMethod iLMethod = value[i];
				int num = param?.Count ?? 0;
				if (iLMethod.ParameterCount != num)
				{
					continue;
				}
				bool match = true;
				if (genericArguments != null && iLMethod.GenericParameterCount == genericArguments.Length && method == null)
				{
					method = CheckGenericParams(iLMethod, param, genericArguments, ref match);
					continue;
				}
				match = CheckGenericArguments(iLMethod, genericArguments);
				if (!match)
				{
					continue;
				}
				for (int j = 0; j < num; j++)
				{
					if (param[j] != iLMethod.Parameters[j])
					{
						match = false;
						break;
					}
				}
				if (match)
				{
					match = returnType == null || iLMethod.ReturnType == returnType;
				}
				if (match)
				{
					return iLMethod;
				}
			}
		}
		if (genericArguments != null && method != null)
		{
			IMethod method2 = method.MakeGenericMethod(genericArguments);
			value.Add((ILMethod)method2);
			return method2;
		}
		if (declaredOnly)
		{
			return null;
		}
		if (BaseType != null)
		{
			return BaseType.GetMethod(name, param, genericArguments, returnType);
		}
		return null;
	}

	private bool CheckGenericArguments(ILMethod i, IType[] genericArguments)
	{
		if (genericArguments == null)
		{
			return i.GenericArguments == null;
		}
		if (i.GenericArguments == null)
		{
			return false;
		}
		if (i.GenericArguments.Length != genericArguments.Length)
		{
			return false;
		}
		if (i.GenericArguments.Length == genericArguments.Length)
		{
			for (int j = 0; j < genericArguments.Length; j++)
			{
				if (i.GenericArguments[j].Value != genericArguments[j])
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private bool IsGenericArgumentMatch(IType p, IType p2, IType[] genericArguments)
	{
		bool flag = false;
		for (int i = 0; i < genericArguments.Length; i++)
		{
			if (genericArguments[i] == p2)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return false;
		}
		return true;
	}

	private ILMethod CheckGenericParams(ILMethod i, List<IType> param, IType[] genericArguments, ref bool match)
	{
		ILMethod result = null;
		if (param != null)
		{
			for (int j = 0; j < param.Count; j++)
			{
				IType type = i.Parameters[j];
				if (type.IsGenericParameter)
				{
					if (!IsGenericArgumentMatch(type, param[j], genericArguments))
					{
						match = false;
						break;
					}
					continue;
				}
				if (type.IsByRef)
				{
					type = type.ElementType;
				}
				if (type.IsArray)
				{
					type = type.ElementType;
				}
				IType type2 = param[j];
				if (type2.IsByRef)
				{
					type2 = type2.ElementType;
				}
				if (type2.IsArray)
				{
					type2 = type2.ElementType;
				}
				if (type.IsGenericParameter)
				{
					if (i.Parameters[j].IsByRef != param[j].IsByRef || i.Parameters[j].IsArray != param[j].IsArray || !IsGenericArgumentMatch(type, type2, genericArguments))
					{
						match = false;
						break;
					}
				}
				else if (type.HasGenericParameter)
				{
					if (type.Name != type2.Name)
					{
						match = false;
						break;
					}
				}
				else if (type2 != type)
				{
					match = false;
					break;
				}
			}
		}
		if (match)
		{
			result = i;
		}
		return result;
	}

	public List<ILMethod> GetConstructors()
	{
		if (constructors == null)
		{
			InitializeMethods();
		}
		return constructors;
	}

	public IMethod GetStaticConstroctor()
	{
		if (constructors == null)
		{
			InitializeMethods();
		}
		return staticConstructor;
	}

	public IMethod GetConstructor(int paramCnt)
	{
		if (constructors == null)
		{
			InitializeMethods();
		}
		foreach (ILMethod constructor in constructors)
		{
			if (constructor.ParameterCount == paramCnt)
			{
				return constructor;
			}
		}
		return null;
	}

	public IMethod GetConstructor(List<IType> param)
	{
		return GetConstructor(param, exactMatch: true);
	}

	public IMethod GetConstructor(List<IType> param, bool exactMatch = true)
	{
		if (constructors == null)
		{
			InitializeMethods();
		}
		foreach (ILMethod constructor in constructors)
		{
			if (constructor.ParameterCount != param.Count)
			{
				continue;
			}
			bool flag = true;
			for (int i = 0; i < param.Count; i++)
			{
				if ((exactMatch && param[i] != constructor.Parameters[i]) || !constructor.Parameters[i].CanAssignTo(param[i]))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return constructor;
			}
		}
		return null;
	}

	public int GetFieldIndex(object token)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		int key = token.GetHashCode();
		if (fieldTokenMapping.TryGetValue(key, out var value))
		{
			return value;
		}
		FieldReference fieldReference = token as FieldReference;
		if (staticFieldMapping != null && staticFieldMapping.TryGetValue(fieldReference.Name, out value))
		{
			fieldTokenMapping[key] = value;
			return value;
		}
		if (fieldMapping.TryGetValue(fieldReference.Name, out value))
		{
			fieldTokenMapping[key] = value;
			return value;
		}
		return -1;
	}

	public IType GetField(string name, out int fieldIdx)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		if (fieldMapping.TryGetValue(name, out fieldIdx))
		{
			return fieldTypes[fieldIdx - FieldStartIndex];
		}
		if (BaseType != null && BaseType is ILType)
		{
			return ((ILType)BaseType).GetField(name, out fieldIdx);
		}
		return null;
	}

	public IType GetField(int fieldIdx, out FieldDefinition fd)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		if (fieldIdx < FieldStartIndex)
		{
			return ((ILType)BaseType).GetField(fieldIdx, out fd);
		}
		fd = fieldDefinitions[fieldIdx - FieldStartIndex];
		return fieldTypes[fieldIdx - FieldStartIndex];
	}

	private void InitializeFields()
	{
		fieldMapping = new Dictionary<string, int>();
		if (definition == null)
		{
			fieldTypes = new IType[0];
			fieldDefinitions = new FieldDefinition[0];
			return;
		}
		fieldTypes = new IType[definition.Fields.Count];
		fieldDefinitions = new FieldDefinition[definition.Fields.Count];
		Collection<FieldDefinition> fields = definition.Fields;
		int num = FieldStartIndex;
		int num2 = 0;
		for (int i = 0; i < fields.Count; i++)
		{
			FieldDefinition fieldDefinition = fields[i];
			if (fieldDefinition.IsStatic)
			{
				if (!TypeReference.HasGenericParameters || IsGenericInstance)
				{
					if (staticFieldTypes == null)
					{
						staticFieldTypes = new IType[definition.Fields.Count];
						staticFieldDefinitions = new FieldDefinition[definition.Fields.Count];
						staticFieldMapping = new Dictionary<string, int>();
					}
					staticFieldMapping[fieldDefinition.Name] = num2;
					staticFieldDefinitions[num2] = fieldDefinition;
					if (fieldDefinition.FieldType.IsGenericParameter)
					{
						staticFieldTypes[num2] = FindGenericArgument(fieldDefinition.FieldType.Name);
					}
					else
					{
						staticFieldTypes[num2] = appdomain.GetType(fieldDefinition.FieldType, this, null);
					}
					num2++;
				}
			}
			else
			{
				fieldMapping[fieldDefinition.Name] = num;
				fieldDefinitions[num - FieldStartIndex] = fieldDefinition;
				if (fieldDefinition.FieldType.IsGenericParameter)
				{
					fieldTypes[num - FieldStartIndex] = FindGenericArgument(fieldDefinition.FieldType.Name);
				}
				else
				{
					fieldTypes[num - FieldStartIndex] = appdomain.GetType(fieldDefinition.FieldType, this, null);
				}
				if (IsEnum)
				{
					enumType = fieldTypes[num - FieldStartIndex];
				}
				num++;
			}
		}
		Array.Resize(ref fieldTypes, num - FieldStartIndex);
		Array.Resize(ref fieldDefinitions, num - FieldStartIndex);
		if (staticFieldTypes != null)
		{
			Array.Resize(ref staticFieldTypes, num2);
			Array.Resize(ref staticFieldDefinitions, num2);
		}
	}

	public IType FindGenericArgument(string key)
	{
		IType type = Generic(key);
		if (type == null && definition.GenericParameters != null)
		{
			for (int i = 0; i < definition.GenericParameters.Count; i++)
			{
				if (definition.GenericParameters[i].Name == key)
				{
					return Generic("!" + i);
				}
			}
		}
		return type;
	}

	private IType Generic(string key)
	{
		if (genericArguments != null)
		{
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (genericArguments[i].Key == key)
				{
					return genericArguments[i].Value;
				}
			}
		}
		return null;
	}

	public bool CanAssignTo(IType type)
	{
		bool flag = false;
		if (this == type)
		{
			return true;
		}
		if (IsEnum && type.TypeForCLR == typeof(Enum))
		{
			return true;
		}
		if (BaseType != null)
		{
			flag = BaseType.CanAssignTo(type);
			if (flag)
			{
				return true;
			}
		}
		if (Implements != null)
		{
			for (int i = 0; i < interfaces.Length; i++)
			{
				flag = interfaces[i].CanAssignTo(type);
				if (flag)
				{
					return true;
				}
			}
		}
		return flag;
	}

	public ILTypeInstance Instantiate(bool callDefaultConstructor = true)
	{
		ILTypeInstance iLTypeInstance = new ILTypeInstance(this);
		if (callDefaultConstructor)
		{
			IMethod constructor = GetConstructor(ILRuntime.CLR.Utils.Extensions.EmptyParamList);
			if (constructor != null)
			{
				appdomain.Invoke(constructor, iLTypeInstance, null);
			}
		}
		return iLTypeInstance;
	}

	public ILTypeInstance Instantiate(object[] args)
	{
		ILTypeInstance iLTypeInstance = new ILTypeInstance(this);
		List<IType> list = new List<IType>(args.Length);
		foreach (object obj in args)
		{
			if (obj is ILTypeInstance)
			{
				list.Add(((ILTypeInstance)obj).Type);
			}
			else
			{
				list.Add(appdomain.GetType(obj.GetType()));
			}
		}
		IMethod constructor = GetConstructor(list, exactMatch: false);
		if (constructor != null)
		{
			appdomain.Invoke(constructor, iLTypeInstance, args);
		}
		return iLTypeInstance;
	}

	public IType MakeGenericInstance(KeyValuePair<string, IType>[] genericArguments)
	{
		if (genericInstances == null)
		{
			genericInstances = new List<ILType>();
		}
		foreach (ILType genericInstance in genericInstances)
		{
			bool flag = true;
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (genericInstance.genericArguments[i].Value != genericArguments[i].Value)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return genericInstance;
			}
		}
		ILType iLType = new ILType(definition, appdomain);
		iLType.genericDefinition = this;
		iLType.genericArguments = genericArguments;
		genericInstances.Add(iLType);
		return iLType;
	}

	public IType MakeByRefType()
	{
		if (byRefType == null)
		{
			ByReferenceType def = new ByReferenceType(typeRef);
			byRefType = new ILType(def, appdomain);
			((ILType)byRefType).elementType = this;
			((ILType)byRefType).byRefCLRType = TypeForCLR.MakeByRefType();
		}
		return byRefType;
	}

	public IType MakeArrayType(int rank)
	{
		if (arrayTypes == null)
		{
			arrayTypes = new Dictionary<int, IType>();
		}
		if (!arrayTypes.TryGetValue(rank, out var value))
		{
			value = new ILType(new ArrayType(typeRef, rank), appdomain);
			((ILType)value).IsArray = true;
			((ILType)value).elementType = this;
			((ILType)value).arrayCLRType = ((rank > 1) ? TypeForCLR.MakeArrayType(rank) : TypeForCLR.MakeArrayType());
			arrayTypes[rank] = value;
		}
		return value;
	}

	public IType ResolveGenericType(IType contextType)
	{
		KeyValuePair<string, IType>[] array = contextType.GenericArguments;
		if (definition == null)
		{
			return null;
		}
		IType[] array2 = new IType[definition.GenericParameters.Count];
		for (int i = 0; i < array2.Length; i++)
		{
			string name = definition.GenericParameters[i].Name;
			KeyValuePair<string, IType>[] array3 = array;
			for (int j = 0; j < array3.Length; j++)
			{
				KeyValuePair<string, IType> keyValuePair = array3[j];
				if (keyValuePair.Key == name)
				{
					array2[i] = keyValuePair.Value;
					break;
				}
			}
		}
		foreach (ILType genericInstance in genericInstances)
		{
			bool flag = true;
			for (int k = 0; k < array2.Length; k++)
			{
				if (genericInstance.genericArguments[k].Value != array2[k])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return genericInstance;
			}
		}
		return null;
	}

	public int GetStaticFieldSizeInMemory(HashSet<object> traversed)
	{
		if (staticInstance == null)
		{
			return 0;
		}
		return staticInstance.GetSizeInMemory(traversed);
	}

	public unsafe int GetMethodBodySizeInMemory()
	{
		int num = 0;
		if (methods != null)
		{
			foreach (KeyValuePair<string, List<ILMethod>> method in methods)
			{
				foreach (ILMethod item in method.Value)
				{
					if (item.HasBody)
					{
						num += item.Body.Length * sizeof(OpCode);
					}
				}
			}
		}
		return num;
	}

	public void GetValueTypeSize(out int fieldCout, out int managedCount)
	{
		if (!valuetypeSizeCalculated)
		{
			valuetypeFieldCount = FieldTypes.Length + 1;
			valuetypeManagedCount = 0;
			for (int i = 0; i < FieldTypes.Length; i++)
			{
				IType type = FieldTypes[i];
				if (type.IsValueType)
				{
					if (!type.IsPrimitive && !type.IsEnum)
					{
						if (type is ILType || ((CLRType)type).ValueTypeBinder != null)
						{
							type.GetValueTypeSize(out var fieldCout2, out var managedCount2);
							valuetypeFieldCount += fieldCout2;
							valuetypeManagedCount += managedCount2;
						}
						else
						{
							valuetypeManagedCount++;
						}
					}
				}
				else
				{
					valuetypeManagedCount++;
				}
			}
			if (BaseType != null && BaseType is ILType)
			{
				BaseType.GetValueTypeSize(out var fieldCout3, out var managedCount3);
				valuetypeFieldCount += fieldCout3 - 1;
				valuetypeManagedCount += managedCount3;
			}
			valuetypeSizeCalculated = true;
		}
		fieldCout = valuetypeFieldCount;
		managedCount = valuetypeManagedCount;
	}

	public override int GetHashCode()
	{
		if (hashCode == -1)
		{
			hashCode = Interlocked.Add(ref instance_id, 1);
		}
		return hashCode;
	}

	public override string ToString()
	{
		return FullName;
	}
}
