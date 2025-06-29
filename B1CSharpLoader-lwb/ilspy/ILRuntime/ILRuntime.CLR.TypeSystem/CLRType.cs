using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using ILRuntime.CLR.Method;
using ILRuntime.Mono.Cecil;
using ILRuntime.Other;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.CLR.TypeSystem;

public sealed class CLRType : IType
{
	private Type clrType;

	private bool isPrimitive;

	private bool isValueType;

	private bool isEnum;

	private Dictionary<string, List<CLRMethod>> methods;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private List<CLRMethod> constructors;

	private KeyValuePair<string, IType>[] genericArguments;

	private List<CLRType> genericInstances;

	private Dictionary<string, int> fieldMapping;

	private Dictionary<int, FieldInfo> fieldInfoCache;

	private Dictionary<int, CLRFieldGetterDelegate> fieldGetterCache;

	private Dictionary<int, CLRFieldSetterDelegate> fieldSetterCache;

	private Dictionary<int, KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>> fieldBindingCache;

	private StackObject defaultObject;

	private Dictionary<int, int> fieldIdxMapping;

	private IType[] orderedFieldTypes;

	private CLRMemberwiseCloneDelegate memberwiseCloneDelegate;

	private CLRCreateDefaultInstanceDelegate createDefaultInstanceDelegate;

	private CLRCreateArrayInstanceDelegate createArrayInstanceDelegate;

	private Dictionary<int, int> fieldTokenMapping;

	private IType byRefType;

	private IType elementType;

	private Dictionary<int, IType> arrayTypes;

	private IType[] interfaces;

	private bool isDelegate;

	private IType baseType;

	private bool isBaseTypeInitialized;

	private bool interfaceInitialized;

	private bool valueTypeBinderGot;

	private ILRuntimeWrapperType wraperType;

	private ValueTypeBinder valueTypeBinder;

	private int valuetypeFieldCount;

	private int valuetypeManagedCount;

	private bool valuetypeSizeCalculated;

	private int hashCode = -1;

	private int tIdx = -1;

	private static int instance_id = 536870912;

	public Dictionary<int, FieldInfo> Fields
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			return fieldInfoCache;
		}
	}

	public Dictionary<int, int> FieldIndexMapping => fieldIdxMapping;

	public IType[] OrderedFieldTypes
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			return orderedFieldTypes;
		}
	}

	public int TotalFieldCount
	{
		get
		{
			if (fieldMapping == null)
			{
				InitializeFields();
			}
			if (fieldIdxMapping != null)
			{
				return fieldIdxMapping.Count;
			}
			throw new NotSupportedException("Cannot find ValueTypeBinder for type:" + clrType.FullName);
		}
	}

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => appdomain;

	public bool IsGenericInstance => genericArguments != null;

	public KeyValuePair<string, IType>[] GenericArguments => genericArguments;

	public IType ElementType => elementType;

	public bool HasGenericParameter
	{
		get
		{
			if (genericArguments != null)
			{
				KeyValuePair<string, IType>[] array = genericArguments;
				for (int i = 0; i < array.Length; i++)
				{
					KeyValuePair<string, IType> keyValuePair = array[i];
					if (keyValuePair.Value is ILType && keyValuePair.Value.HasGenericParameter)
					{
						return true;
					}
				}
			}
			return clrType.ContainsGenericParameters;
		}
	}

	public bool IsGenericParameter => clrType.IsGenericParameter;

	public bool IsInterface => clrType.IsInterface;

	public Type TypeForCLR => clrType;

	public Type ReflectionType
	{
		get
		{
			if (wraperType == null)
			{
				wraperType = new ILRuntimeWrapperType(this);
			}
			return wraperType;
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

	public bool IsArray { get; private set; }

	public int ArrayRank { get; private set; }

	public bool IsValueType => isValueType;

	public bool IsByRef => clrType.IsByRef;

	public bool IsDelegate => isDelegate;

	public bool IsPrimitive => isPrimitive;

	public bool IsEnum => isEnum;

	public string FullName => clrType.FullName;

	public string Name => clrType.Name;

	public IType BaseType
	{
		get
		{
			if (!isBaseTypeInitialized)
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

	public ValueTypeBinder ValueTypeBinder
	{
		get
		{
			if (clrType.IsValueType)
			{
				if (!valueTypeBinderGot)
				{
					valueTypeBinderGot = true;
					appdomain.ValueTypeBinders.TryGetValue(clrType, out valueTypeBinder);
				}
				return valueTypeBinder;
			}
			return null;
		}
	}

	public StackObject DefaultObject => defaultObject;

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

	public CLRType(Type clrType, ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		this.clrType = clrType;
		this.appdomain = appdomain;
		isPrimitive = clrType.IsPrimitive;
		isEnum = clrType.IsEnum;
		isValueType = clrType.IsValueType;
		isDelegate = clrType.BaseType == typeof(MulticastDelegate) || clrType == typeof(Delegate);
		if (isPrimitive)
		{
			Type typeForCLR = TypeForCLR;
			if (typeForCLR == typeof(int) || typeForCLR == typeof(uint) || typeForCLR == typeof(short) || typeForCLR == typeof(ushort) || typeForCLR == typeof(byte) || typeForCLR == typeof(sbyte) || typeForCLR == typeof(char) || typeForCLR == typeof(bool))
			{
				defaultObject.ObjectType = ObjectTypes.Integer;
				defaultObject.Value = 0;
				defaultObject.ValueLow = 0;
			}
			else if (typeForCLR == typeof(long) || typeForCLR == typeof(ulong))
			{
				defaultObject.ObjectType = ObjectTypes.Long;
				defaultObject.Value = 0;
				defaultObject.ValueLow = 0;
			}
			else if (typeForCLR == typeof(float))
			{
				defaultObject.ObjectType = ObjectTypes.Float;
				defaultObject.Value = 0;
				defaultObject.ValueLow = 0;
			}
			else if (typeForCLR == typeof(double))
			{
				defaultObject.ObjectType = ObjectTypes.Double;
				defaultObject.Value = 0;
				defaultObject.ValueLow = 0;
			}
		}
	}

	public object PerformMemberwiseClone(object target)
	{
		if (memberwiseCloneDelegate == null && !AppDomain.MemberwiseCloneMap.TryGetValue(clrType, out memberwiseCloneDelegate))
		{
			MethodInfo method = clrType.GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);
			if (!(method != null))
			{
				throw new InvalidOperationException("Memberwise clone method not found for " + clrType.FullName);
			}
			Func<object, object> del = (Func<object, object>)Delegate.CreateDelegate(typeof(Func<object, object>), method);
			memberwiseCloneDelegate = delegate(ref object t)
			{
				return del(t);
			};
		}
		return memberwiseCloneDelegate(ref target);
	}

	private void InitializeBaseType()
	{
		baseType = appdomain.GetType(clrType.BaseType);
		if (baseType.TypeForCLR == typeof(Enum) || baseType.TypeForCLR == typeof(object) || baseType.TypeForCLR == typeof(ValueType) || baseType.TypeForCLR == typeof(Enum))
		{
			baseType = null;
		}
		isBaseTypeInitialized = true;
	}

	private void InitializeInterfaces()
	{
		interfaceInitialized = true;
		Type[] array = clrType.GetInterfaces();
		if (array.Length != 0)
		{
			interfaces = new IType[array.Length];
			for (int i = 0; i < interfaces.Length; i++)
			{
				interfaces[i] = appdomain.GetType(array[i]);
			}
		}
	}

	public object GetFieldValue(int hash, object target)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		CLRFieldGetterDelegate fieldGetter = GetFieldGetter(hash);
		if (fieldGetter != null)
		{
			return fieldGetter(ref target);
		}
		FieldInfo field = GetField(hash);
		if (field != null)
		{
			return field.GetValue(target);
		}
		return null;
	}

	public unsafe bool CopyFieldToStack(int hash, object target, ILIntepreter intp, ref StackObject* esp, UncheckedList<object> mStack)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		if (fieldBindingCache == null)
		{
			return false;
		}
		KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate> fieldBinding = GetFieldBinding(hash);
		if (fieldBinding.Key != null)
		{
			esp = fieldBinding.Key(ref target, intp, esp, mStack);
			return true;
		}
		return false;
	}

	public unsafe bool AssignFieldFromStack(int hash, ref object target, ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		if (fieldBindingCache == null)
		{
			return false;
		}
		KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate> fieldBinding = GetFieldBinding(hash);
		if (fieldBinding.Value != null)
		{
			esp = fieldBinding.Value(ref target, intp, esp, mStack);
			return true;
		}
		return false;
	}

	public void SetStaticFieldValue(int hash, object value)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		CLRFieldSetterDelegate fieldSetter = GetFieldSetter(hash);
		object target = null;
		if (fieldSetter != null)
		{
			fieldSetter(ref target, value);
			return;
		}
		FieldInfo field = GetField(hash);
		if (field != null)
		{
			field.SetValue(null, value);
		}
	}

	public void SetFieldValue(int hash, ref object target, object value, bool directSet = false)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		if (!directSet)
		{
			CLRFieldSetterDelegate fieldSetter = GetFieldSetter(hash);
			if (fieldSetter != null)
			{
				fieldSetter(ref target, value);
				return;
			}
		}
		FieldInfo field = GetField(hash);
		if (field != null)
		{
			field.SetValue(target, value);
		}
	}

	private KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate> GetFieldBinding(int hash)
	{
		Dictionary<int, KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>> dictionary = fieldBindingCache;
		if (dictionary != null && dictionary.TryGetValue(hash, out var value))
		{
			return value;
		}
		if (BaseType != null)
		{
			return ((CLRType)BaseType).GetFieldBinding(hash);
		}
		return default(KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>);
	}

	private CLRFieldGetterDelegate GetFieldGetter(int hash)
	{
		Dictionary<int, CLRFieldGetterDelegate> dictionary = fieldGetterCache;
		if (dictionary != null && dictionary.TryGetValue(hash, out var value))
		{
			return value;
		}
		if (BaseType != null)
		{
			return ((CLRType)BaseType).GetFieldGetter(hash);
		}
		return null;
	}

	private CLRFieldSetterDelegate GetFieldSetter(int hash)
	{
		Dictionary<int, CLRFieldSetterDelegate> dictionary = fieldSetterCache;
		if (dictionary != null && dictionary.TryGetValue(hash, out var value))
		{
			return value;
		}
		if (BaseType != null)
		{
			return ((CLRType)BaseType).GetFieldSetter(hash);
		}
		return null;
	}

	public FieldInfo GetField(int hash)
	{
		if (Fields.TryGetValue(hash, out var value))
		{
			return value;
		}
		if (BaseType != null)
		{
			return ((CLRType)BaseType).GetField(hash);
		}
		return null;
	}

	private void InitializeMethods()
	{
		methods = new Dictionary<string, List<CLRMethod>>();
		constructors = new List<CLRMethod>();
		MethodInfo[] array = clrType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in array)
		{
			if (!methodInfo.IsPrivate)
			{
				if (!methods.TryGetValue(methodInfo.Name, out var value))
				{
					value = new List<CLRMethod>();
					methods[methodInfo.Name] = value;
				}
				value.Add(new CLRMethod(methodInfo, this, appdomain));
			}
		}
		ConstructorInfo[] array2 = clrType.GetConstructors();
		foreach (ConstructorInfo def in array2)
		{
			constructors.Add(new CLRMethod(def, this, appdomain));
		}
	}

	public List<IMethod> GetMethods()
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		List<IMethod> list = new List<IMethod>();
		foreach (KeyValuePair<string, List<CLRMethod>> method in methods)
		{
			foreach (CLRMethod item in method.Value)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public IMethod GetVirtualMethod(IMethod method)
	{
		IMethod method2 = GetMethod(method.Name, method.Parameters, null, method.ReturnType);
		if (method2 == null)
		{
			return method;
		}
		return method2;
	}

	private void InitializeFields()
	{
		fieldMapping = new Dictionary<string, int>();
		fieldInfoCache = new Dictionary<int, FieldInfo>();
		List<FieldInfo> list = clrType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).ToList();
		int num = 0;
		bool flag = ValueTypeBinder != null;
		if (flag)
		{
			fieldIdxMapping = new Dictionary<int, int>();
		}
		if (flag || isEnum)
		{
			orderedFieldTypes = new IType[list.Count];
		}
		list.Sort((FieldInfo a, FieldInfo b) => a.MetadataToken - b.MetadataToken);
		foreach (FieldInfo item in list)
		{
			int num2 = item.GetHashCode();
			if (item.IsPublic || item.IsFamily || flag)
			{
				fieldMapping[item.Name] = num2;
				fieldInfoCache[num2] = item;
			}
			if ((flag || isEnum) && !item.IsStatic)
			{
				orderedFieldTypes[num] = appdomain.GetType(item.FieldType);
				if (flag)
				{
					fieldIdxMapping[num2] = num++;
				}
				else
				{
					num++;
				}
			}
			if (AppDomain.FieldGetterMap.TryGetValue(item, out var value))
			{
				if (fieldGetterCache == null)
				{
					fieldGetterCache = new Dictionary<int, CLRFieldGetterDelegate>();
				}
				fieldGetterCache[num2] = value;
			}
			if (AppDomain.FieldSetterMap.TryGetValue(item, out var value2))
			{
				if (fieldSetterCache == null)
				{
					fieldSetterCache = new Dictionary<int, CLRFieldSetterDelegate>();
				}
				fieldSetterCache[num2] = value2;
			}
			if (AppDomain.FieldBindingMap.TryGetValue(item, out var value3))
			{
				if (fieldBindingCache == null)
				{
					fieldBindingCache = new Dictionary<int, KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>>();
				}
				fieldBindingCache[num2] = value3;
			}
		}
		if (orderedFieldTypes != null)
		{
			Array.Resize(ref orderedFieldTypes, num);
		}
	}

	public int GetFieldIndex(object token)
	{
		if (fieldMapping == null)
		{
			InitializeFields();
		}
		int key = token.GetHashCode();
		if (fieldTokenMapping == null)
		{
			fieldTokenMapping = new Dictionary<int, int>();
		}
		if (fieldTokenMapping.TryGetValue(key, out var value))
		{
			return value;
		}
		FieldReference fieldReference = token as FieldReference;
		if (fieldMapping.TryGetValue(fieldReference.Name, out value))
		{
			fieldTokenMapping[key] = value;
			return value;
		}
		return -1;
	}

	public IType FindGenericArgument(string key)
	{
		IType type = Generic(key);
		if (type == null)
		{
			Type[] array = TypeForCLR.GetGenericArguments();
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Name == key)
					{
						return Generic("!" + i);
					}
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

	public IMethod GetMethod(string name, int paramCount, bool declaredOnly = false)
	{
		if (methods == null)
		{
			InitializeMethods();
		}
		if (methods.TryGetValue(name, out var value))
		{
			foreach (CLRMethod item in value)
			{
				if (item.ParameterCount == paramCount)
				{
					return item;
				}
			}
		}
		return null;
	}

	private bool MatchGenericParameters(Type[] args, Type type, Type q, IType[] genericArguments)
	{
		if (type.IsGenericParameter)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] == type)
				{
					return q == genericArguments[i].TypeForCLR;
				}
			}
			throw new NotSupportedException();
		}
		if (type.IsArray)
		{
			if (q.IsArray)
			{
				return MatchGenericParameters(args, type.GetElementType(), q.GetElementType(), genericArguments);
			}
			return false;
		}
		if (type.IsByRef)
		{
			if (q.IsByRef)
			{
				return MatchGenericParameters(args, type.GetElementType(), q.GetElementType(), genericArguments);
			}
			return false;
		}
		if (type.IsGenericType)
		{
			if (q.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				Type genericTypeDefinition2 = q.GetGenericTypeDefinition();
				if (genericTypeDefinition == genericTypeDefinition2)
				{
					Type[] array = type.GetGenericArguments();
					Type[] array2 = q.GetGenericArguments();
					if (array.Length == array2.Length)
					{
						for (int j = 0; j < array.Length; j++)
						{
							if (!MatchGenericParameters(args, array[j], array2[j], genericArguments))
							{
								return false;
							}
						}
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return type == q;
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
			int count = param.Count;
			foreach (CLRMethod item in value)
			{
				if (item.ParameterCount != count)
				{
					continue;
				}
				bool flag = true;
				if (genericArguments != null && item.GenericParameterCount == genericArguments.Length)
				{
					for (int i = 0; i < count; i++)
					{
						Type typeForCLR = item.Parameters[i].TypeForCLR;
						Type typeForCLR2 = param[i].TypeForCLR;
						if (item.Parameters[i].HasGenericParameter)
						{
							if (!MatchGenericParameters(item.GenericArgumentsCLR, item.ParametersCLR[i].ParameterType, typeForCLR2, genericArguments))
							{
								flag = false;
								break;
							}
						}
						else if (typeForCLR2 != typeForCLR)
						{
							flag = false;
							break;
						}
					}
					if (flag && method == null)
					{
						method = item;
					}
					continue;
				}
				IType[] array = item.GenericArguments;
				flag = ((genericArguments == null) ? (array == null) : (array != null && array.Length == genericArguments.Length));
				if (!flag)
				{
					continue;
				}
				for (int j = 0; j < count; j++)
				{
					Type typeForCLR3 = param[j].TypeForCLR;
					Type typeForCLR4 = item.Parameters[j].TypeForCLR;
					if (typeForCLR3 != typeForCLR4)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					try
					{
						flag = returnType == null || (item.ReturnType != null && item.ReturnType.TypeForCLR == returnType.TypeForCLR);
					}
					catch
					{
					}
				}
				if (!flag)
				{
					continue;
				}
				if (item.IsGenericInstance)
				{
					if (array.Length != genericArguments.Length)
					{
						continue;
					}
					for (int k = 0; k < genericArguments.Length; k++)
					{
						if (array[k] != genericArguments[k])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return item;
					}
					continue;
				}
				return item;
			}
		}
		if (genericArguments != null && method != null)
		{
			IMethod method2 = method.MakeGenericMethod(genericArguments);
			value.Add((CLRMethod)method2);
			return method2;
		}
		return null;
	}

	public bool CanAssignTo(IType type)
	{
		if (this == type)
		{
			return true;
		}
		if (type is ILType)
		{
			return false;
		}
		Type c = ((type != null) ? type.TypeForCLR : typeof(object));
		return TypeForCLR.IsAssignableFrom(c);
	}

	public IMethod GetConstructor(List<IType> param)
	{
		if (constructors == null)
		{
			InitializeMethods();
		}
		foreach (CLRMethod constructor in constructors)
		{
			if (constructor.ParameterCount != param.Count)
			{
				continue;
			}
			bool flag = true;
			for (int i = 0; i < param.Count; i++)
			{
				if (param[i].TypeForCLR != constructor.Parameters[i].TypeForCLR)
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

	public IType MakeGenericInstance(KeyValuePair<string, IType>[] genericArguments)
	{
		lock (this)
		{
			if (genericInstances == null)
			{
				genericInstances = new List<CLRType>();
			}
			foreach (CLRType genericInstance in genericInstances)
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
			Type[] array = new Type[genericArguments.Length];
			for (int j = 0; j < genericArguments.Length; j++)
			{
				array[j] = genericArguments[j].Value.TypeForCLR;
			}
			CLRType cLRType = new CLRType(clrType.MakeGenericType(array), appdomain);
			cLRType.genericArguments = genericArguments;
			genericInstances.Add(cLRType);
			return cLRType;
		}
	}

	public object CreateDefaultInstance()
	{
		if (createDefaultInstanceDelegate == null && !AppDomain.CreateDefaultInstanceMap.TryGetValue(clrType, out createDefaultInstanceDelegate))
		{
			createDefaultInstanceDelegate = () => Activator.CreateInstance(TypeForCLR);
		}
		return createDefaultInstanceDelegate();
	}

	public object CreateArrayInstance(int size)
	{
		if (createArrayInstanceDelegate == null && !AppDomain.CreateArrayInstanceMap.TryGetValue(clrType, out createArrayInstanceDelegate))
		{
			createArrayInstanceDelegate = (int s) => Array.CreateInstance(TypeForCLR, s);
		}
		return createArrayInstanceDelegate(size);
	}

	public IType MakeByRefType()
	{
		if (byRefType == null)
		{
			Type type = clrType.MakeByRefType();
			byRefType = new CLRType(type, appdomain);
			((CLRType)byRefType).elementType = this;
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
			value = new CLRType((rank > 1) ? clrType.MakeArrayType(rank) : clrType.MakeArrayType(), appdomain);
			((CLRType)value).elementType = this;
			((CLRType)value).IsArray = true;
			((CLRType)value).ArrayRank = rank;
			arrayTypes[rank] = value;
		}
		return value;
	}

	public IType ResolveGenericType(IType contextType)
	{
		throw new NotImplementedException();
	}

	public void GetValueTypeSize(out int fieldCout, out int managedCount)
	{
		if (!valuetypeSizeCalculated)
		{
			int totalFieldCount = TotalFieldCount;
			valuetypeFieldCount = totalFieldCount + 1;
			valuetypeManagedCount = 0;
			for (int i = 0; i < totalFieldCount; i++)
			{
				CLRType cLRType = OrderedFieldTypes[i] as CLRType;
				if (cLRType.IsValueType)
				{
					if (!cLRType.IsPrimitive && !cLRType.IsEnum)
					{
						if (cLRType.ValueTypeBinder != null)
						{
							cLRType.GetValueTypeSize(out var fieldCout2, out var managedCount2);
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
		return clrType.ToString();
	}
}
