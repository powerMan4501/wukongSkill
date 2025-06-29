using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

namespace UnrealEngine.Runtime;

public class ManagedUnrealTypeInfo : ManagedUnrealReflectionBase
{
	public string FullName { get; set; }

	public EPropertyType TypeCode { get; set; }

	public string ClassConfigName { get; set; }

	public uint Flags { get; set; }

	[ManagedUnrealReflectIgnore]
	public EClassFlags ClassFlags
	{
		get
		{
			return (EClassFlags)Flags;
		}
		set
		{
			Flags = (uint)value;
		}
	}

	[ManagedUnrealReflectIgnore]
	public EStructFlags StructFlags
	{
		get
		{
			return (EStructFlags)Flags;
		}
		set
		{
			Flags = (uint)value;
		}
	}

	public ManagedUnrealTypeInfoFlags AdditionalFlags { get; set; }

	public ManagedUnrealBlittableKind BlittableKind { get; set; }

	public bool IsBlittable => BlittableKind == ManagedUnrealBlittableKind.Blittable;

	[ManagedUnrealReflectIgnore]
	public bool IsStructAsClass
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.StructAsClass);
		}
		set
		{
			SetFlag(ManagedUnrealTypeInfoFlags.StructAsClass, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool OverridesObjectInitializer
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.OverridesObjectInitializer);
		}
		set
		{
			SetFlag(ManagedUnrealTypeInfoFlags.OverridesObjectInitializer, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool OverridesObjectInitializerHierarchical
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.OverridesObjectInitializerHierarchical);
		}
		set
		{
			SetFlag(ManagedUnrealTypeInfoFlags.OverridesObjectInitializerHierarchical, value);
		}
	}

	public bool IsStruct => TypeCode == EPropertyType.Struct;

	public bool IsClass => TypeCode == EPropertyType.Object;

	public bool IsInterface => TypeCode == EPropertyType.Interface;

	public List<ManagedUnrealPropertyInfo> Properties { get; set; }

	public List<ManagedUnrealFunctionInfo> Functions { get; set; }

	public List<ManagedUnrealTypeInfoReference> BaseTypes { get; set; }

	public bool IsDelegate
	{
		get
		{
			if (TypeCode != EPropertyType.Delegate)
			{
				return TypeCode == EPropertyType.MulticastDelegate;
			}
			return true;
		}
	}

	public ManagedUnrealTypeInfo()
	{
		Properties = new List<ManagedUnrealPropertyInfo>();
		Functions = new List<ManagedUnrealFunctionInfo>();
		BaseTypes = new List<ManagedUnrealTypeInfoReference>();
	}

	private void SetFlag(EClassFlags flag, bool set)
	{
		if (ClassFlags.HasFlag(flag) != set)
		{
			ClassFlags ^= flag;
		}
	}

	private void SetFlag(ManagedUnrealTypeInfoFlags flag, bool set)
	{
		if (AdditionalFlags.HasFlag(flag) != set)
		{
			AdditionalFlags ^= flag;
		}
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		WriteEnum(writer, AdditionalFlags);
		WriteTypeReferences(writer, BaseTypes);
		WriteEnum(writer, BlittableKind);
		WriteString(writer, ClassConfigName);
		writer.Write(Flags);
		WriteString(writer, FullName);
		WriteObjects(writer, Functions);
		WriteObjects(writer, Properties);
		WriteEnum(writer, TypeCode);
	}

	public override void Deserialize(BinaryReader reader)
	{
		base.Deserialize(reader);
		AdditionalFlags = ReadEnum<ManagedUnrealTypeInfoFlags>(reader);
		BaseTypes = ReadTypeReferences(reader);
		BlittableKind = ReadEnum<ManagedUnrealBlittableKind>(reader);
		ClassConfigName = ReadString(reader);
		Flags = reader.ReadUInt32();
		FullName = ReadString(reader);
		Functions = ReadObjects<ManagedUnrealFunctionInfo>(reader);
		Properties = ReadObjects<ManagedUnrealPropertyInfo>(reader);
		TypeCode = ReadEnum<EPropertyType>(reader);
	}

	public static bool DoesBlueprintSupportType(ManagedUnrealPropertyInfo propertyInfo, bool memberVariable)
	{
		if (propertyInfo.IsCollection)
		{
			foreach (ManagedUnrealTypeInfoReference genericArg in propertyInfo.GenericArgs)
			{
				if (!DoesBlueprintSupportType(genericArg.TypeCode, memberVariable: false, collectionArg: true))
				{
					return false;
				}
			}
			EPropertyType typeCode = propertyInfo.Type.TypeCode;
			if ((uint)(typeCode - 24) <= 1u)
			{
				EPropertyType typeCode2 = propertyInfo.GenericArgs[0].TypeCode;
				if (typeCode2 == EPropertyType.Interface || typeCode2 == EPropertyType.Text)
				{
					return false;
				}
			}
			return true;
		}
		return DoesBlueprintSupportType(propertyInfo.Type.TypeCode, memberVariable, collectionArg: false);
	}

	public static bool DoesBlueprintSupportType(EPropertyType typeCode, bool memberVariable, bool collectionArg)
	{
		switch (typeCode)
		{
		case EPropertyType.Int8:
		case EPropertyType.Int16:
		case EPropertyType.UInt16:
		case EPropertyType.UInt32:
		case EPropertyType.UInt64:
		case EPropertyType.Double:
		case EPropertyType.LazyObject:
		case EPropertyType.InternalNativeFixedSizeArray:
		case EPropertyType.InternalManagedFixedSizeArray:
			return false;
		case EPropertyType.WeakObject:
		case EPropertyType.MulticastDelegate:
			return memberVariable;
		case EPropertyType.Array:
		case EPropertyType.Map:
		case EPropertyType.Set:
			return !collectionArg;
		default:
			return true;
		}
	}

	public static bool IsExportableType(Type type)
	{
		bool flag = false;
		switch (GetTypeCode(type))
		{
		case EPropertyType.Object:
			flag = IsExportableType(type, ManagedUnrealVisibility.ClassRequirement, typeof(UClassAttribute));
			break;
		case EPropertyType.Enum:
			flag = IsExportableType(type, ManagedUnrealVisibility.EnumRequirement, typeof(UEnumAttribute));
			break;
		case EPropertyType.Interface:
			flag = IsExportableType(type, ManagedUnrealVisibility.InterfaceRequirement, typeof(UInterfaceAttribute));
			break;
		case EPropertyType.Struct:
			flag = ((!type.IsSubclassOf(typeof(StructAsClass))) ? IsExportableType(type, ManagedUnrealVisibility.StructRequirement, typeof(UStructAttribute)) : IsExportableType(type, ManagedUnrealVisibility.StructRequirement, typeof(UStructAttribute)));
			break;
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			flag = IsExportableType(type, ManagedUnrealVisibility.DelegateRequirement, typeof(UDelegateAttribute));
			break;
		}
		if (type.IsGenericType)
		{
			if (!ManagedUnrealModuleInfo.SkipValidation && flag)
			{
				throw new UnrealTypeGenericsNotSupportedException(type);
			}
			return false;
		}
		return flag;
	}

	private static bool IsExportableType(Type type, ManagedUnrealVisibility.Requirement requirement, Type attribute)
	{
		switch (requirement)
		{
		case ManagedUnrealVisibility.Requirement.MainAttribute:
			if (type.GetCustomAttribute(attribute, inherit: false) == null)
			{
				return false;
			}
			break;
		case ManagedUnrealVisibility.Requirement.AnyAttribute:
			if (!type.HasCustomAttribute<ManagedUnrealAttributeBase>(inherit: false) && !type.HasCustomAttribute<UMetaAttribute>(inherit: false))
			{
				return false;
			}
			break;
		}
		if (UnrealTypes.IsNativeUnrealType(type))
		{
			return false;
		}
		if (type == typeof(FDelegate<>) || type == typeof(FMulticastDelegate<>))
		{
			return false;
		}
		return true;
	}

	public static EPropertyType GetTypeCode(Type type)
	{
		if (type.IsArray)
		{
			return EPropertyType.InternalManagedFixedSizeArray;
		}
		if (type.IsByRef && type.HasElementType)
		{
			type = type.GetElementType();
		}
		if (type.IsEnum)
		{
			return EPropertyType.Enum;
		}
		switch (Type.GetTypeCode(type))
		{
		case System.TypeCode.Boolean:
			return EPropertyType.Bool;
		case System.TypeCode.SByte:
			return EPropertyType.Int8;
		case System.TypeCode.Int16:
			return EPropertyType.Int16;
		case System.TypeCode.Int32:
			return EPropertyType.Int;
		case System.TypeCode.Int64:
			return EPropertyType.Int64;
		case System.TypeCode.Byte:
			return EPropertyType.Byte;
		case System.TypeCode.UInt16:
			return EPropertyType.UInt16;
		case System.TypeCode.UInt32:
			return EPropertyType.UInt32;
		case System.TypeCode.UInt64:
			return EPropertyType.UInt64;
		case System.TypeCode.Double:
			return EPropertyType.Double;
		case System.TypeCode.Single:
			return EPropertyType.Float;
		case System.TypeCode.String:
			return EPropertyType.Str;
		default:
			if (type.IsSameOrSubclassOf(typeof(UObject)))
			{
				return EPropertyType.Object;
			}
			if (type.IsInterface)
			{
				if (type.IsSameOrSubclassOfGeneric(typeof(ISet<>)))
				{
					return EPropertyType.Set;
				}
				if (type.IsSameOrSubclassOfGeneric(typeof(IDictionary<, >)) || type.IsSameOrSubclassOfGeneric(typeof(IReadOnlyDictionary<, >)))
				{
					return EPropertyType.Map;
				}
				if (type.IsSameOrSubclassOfGeneric(typeof(IList<>)) || type.IsSameOrSubclassOfGeneric(typeof(IReadOnlyList<>)))
				{
					return EPropertyType.Array;
				}
				if (typeof(IInterface).IsAssignableFrom(type) && type != typeof(IInterface))
				{
					return EPropertyType.Interface;
				}
				return EPropertyType.Unknown;
			}
			if (type == typeof(FName))
			{
				return EPropertyType.Name;
			}
			if (type == typeof(FText))
			{
				return EPropertyType.Text;
			}
			if (type.IsSubclassOf(typeof(StructAsClass)) && !type.IsAbstract)
			{
				return EPropertyType.Struct;
			}
			if (type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition.IsSameOrSubclassOf(typeof(TLazyObject<>)))
				{
					return EPropertyType.LazyObject;
				}
				if (genericTypeDefinition.IsSameOrSubclassOf(typeof(TWeakObject<>)))
				{
					return EPropertyType.WeakObject;
				}
				if (genericTypeDefinition.IsSameOrSubclassOf(typeof(TSubclassOf<>)) || genericTypeDefinition.IsSameOrSubclassOf(typeof(TSubclassOfInterface<>)))
				{
					return EPropertyType.Class;
				}
				if (genericTypeDefinition.IsSameOrSubclassOf(typeof(TSoftClass<>)))
				{
					return EPropertyType.SoftClass;
				}
				if (genericTypeDefinition.IsSameOrSubclassOf(typeof(TSoftObject<>)))
				{
					return EPropertyType.SoftObject;
				}
				if (type.IsSameOrSubclassOfGeneric(typeof(TFixedSizeArrayBase<>)))
				{
					return EPropertyType.InternalNativeFixedSizeArray;
				}
				Type[] interfaces = genericTypeDefinition.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					if (interfaces[i].IsGenericType)
					{
						Type genericTypeDefinition2 = interfaces[i].GetGenericTypeDefinition();
						if (genericTypeDefinition2.IsSameOrSubclassOf(typeof(ISet<>)))
						{
							return EPropertyType.Set;
						}
						if (genericTypeDefinition2.IsSameOrSubclassOf(typeof(IDictionary<, >)) || genericTypeDefinition2.IsSameOrSubclassOf(typeof(IReadOnlyDictionary<, >)))
						{
							return EPropertyType.Map;
						}
						if (genericTypeDefinition2.IsSameOrSubclassOf(typeof(IList<>)) || genericTypeDefinition2.IsSameOrSubclassOf(typeof(IReadOnlyList<>)))
						{
							return EPropertyType.Array;
						}
					}
				}
			}
			if (type.IsSameOrSubclassOfGeneric(typeof(FDelegate<>)))
			{
				return EPropertyType.Delegate;
			}
			if (type.IsSameOrSubclassOfGeneric(typeof(FMulticastDelegate<>)))
			{
				return EPropertyType.MulticastDelegate;
			}
			if (type.IsValueType)
			{
				return EPropertyType.Struct;
			}
			return EPropertyType.Unknown;
		}
	}

	public static bool HasGetTypeHash(EPropertyType typeCode)
	{
		if (typeCode == EPropertyType.WeakObject || (uint)(typeCode - 21) <= 1u)
		{
			return false;
		}
		return true;
	}

	public static string GetTypeNameWithoutPrefix(Type type, EPropertyType typeCode)
	{
		string text = type.Name;
		char[] array = null;
		switch (typeCode)
		{
		case EPropertyType.Object:
			array = new char[2] { 'A', 'U' };
			break;
		case EPropertyType.Struct:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			array = new char[1] { 'F' };
			break;
		case EPropertyType.Enum:
			array = new char[1] { 'E' };
			break;
		case EPropertyType.Interface:
			array = new char[1] { 'I' };
			break;
		}
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (text.Length > 2 && text[0] == array[i] && char.IsUpper(text[1]) && char.IsLower(text[2]))
				{
					text = text.Substring(1);
					break;
				}
			}
		}
		return text;
	}

	public static bool RequiresNativePropertyField(ManagedUnrealPropertyInfo propertyInfo, bool lazyFunctionParamInit)
	{
		switch (propertyInfo.Type.TypeCode)
		{
		case EPropertyType.Bool:
		case EPropertyType.Enum:
		case EPropertyType.Array:
		case EPropertyType.Map:
		case EPropertyType.Set:
		case EPropertyType.InternalNativeFixedSizeArray:
		case EPropertyType.InternalManagedFixedSizeArray:
			return true;
		default:
			if (!lazyFunctionParamInit && (propertyInfo.IsFunctionParam || propertyInfo.IsFunctionReturnValue) && (PropertyRequiresInit(propertyInfo) || PropertyRequiresDestroy(propertyInfo)))
			{
				return true;
			}
			return false;
		}
	}

	public static bool MarshalerRequiresNativePropertyField(EPropertyType typeCode)
	{
		if (typeCode == EPropertyType.Bool || typeCode == EPropertyType.Enum || (uint)(typeCode - 29) <= 1u)
		{
			return true;
		}
		return false;
	}

	public static Type MakeGenericTypeWithPropertyArgs(Type type, ManagedUnrealPropertyInfo propertyInfo)
	{
		List<Type> list = new List<Type>();
		foreach (ManagedUnrealTypeInfoReference genericArg in propertyInfo.GenericArgs)
		{
			list.Add(GetTypeFromTypeInfo(genericArg));
		}
		return type.MakeGenericType(list.ToArray());
	}

	public static Type GetTypeFromPropertyInfo(ManagedUnrealPropertyInfo propertyInfo)
	{
		Type type = null;
		type = ((!propertyInfo.IsFixedSizeArray) ? GetTypeFromTypeInfo(propertyInfo.Type) : GetTypeFromTypeInfo(propertyInfo.GenericArgs[0]));
		if (propertyInfo.IsCollection)
		{
			return MakeGenericTypeWithPropertyArgs(type, propertyInfo);
		}
		return type;
	}

	public static Type GetTypeFromTypeInfo(ManagedUnrealTypeInfo typeInfo)
	{
		return GetTypeFromTypeInfo(typeInfo.TypeCode, typeInfo.Path);
	}

	public static Type GetTypeFromTypeInfo(ManagedUnrealTypeInfoReference typeInfo)
	{
		return GetTypeFromTypeInfo(typeInfo.TypeCode, typeInfo.Path);
	}

	public static Type GetTypeFromTypeInfo(EPropertyType typeCode, string typePath)
	{
		switch (typeCode)
		{
		case EPropertyType.Bool:
			return typeof(bool);
		case EPropertyType.Int8:
			return typeof(sbyte);
		case EPropertyType.Int16:
			return typeof(short);
		case EPropertyType.Int:
			return typeof(int);
		case EPropertyType.Int64:
			return typeof(long);
		case EPropertyType.Byte:
			return typeof(byte);
		case EPropertyType.UInt16:
			return typeof(ushort);
		case EPropertyType.UInt32:
			return typeof(uint);
		case EPropertyType.UInt64:
			return typeof(ulong);
		case EPropertyType.Float:
			return typeof(float);
		case EPropertyType.Double:
			return typeof(double);
		case EPropertyType.Name:
			return typeof(FName);
		case EPropertyType.Text:
			return typeof(FText);
		case EPropertyType.Str:
			return typeof(string);
		case EPropertyType.Array:
			return typeof(IList<>);
		case EPropertyType.Map:
			return typeof(IDictionary<, >);
		case EPropertyType.Set:
			return typeof(ISet<>);
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
		{
			Type type4 = FindTypeByPath(typePath);
			if (type4 != null)
			{
				return type4;
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Enum:
		{
			Type type2 = FindTypeByPath(typePath);
			if (type2 != null)
			{
				return type2;
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Interface:
		{
			Type type11 = FindTypeByPath(typePath);
			if (type11 != null)
			{
				return type11;
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Struct:
		{
			Type type10 = FindTypeByPath(typePath);
			if (type10 != null)
			{
				return type10;
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Class:
		{
			Type type8 = FindTypeByPath(typePath);
			if (type8 != null)
			{
				Type type9 = null;
				type9 = ((!type8.IsInterface) ? typeof(TSubclassOf<>) : typeof(TSubclassOfInterface<>));
				return type9.MakeGenericType(type8);
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Object:
		{
			Type type7 = FindTypeByPath(typePath);
			if (type7 != null)
			{
				return type7;
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.LazyObject:
		{
			Type typeFromHandle4 = typeof(TLazyObject<>);
			Type type6 = FindTypeByPath(typePath);
			if (type6 != null)
			{
				return typeFromHandle4.MakeGenericType(type6);
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.WeakObject:
		{
			Type typeFromHandle3 = typeof(TWeakObject<>);
			Type type5 = FindTypeByPath(typePath);
			if (type5 != null)
			{
				return typeFromHandle3.MakeGenericType(type5);
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.SoftClass:
		{
			Type typeFromHandle2 = typeof(TSoftClass<>);
			Type type3 = FindTypeByPath(typePath);
			if (type3 != null)
			{
				return typeFromHandle2.MakeGenericType(type3);
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.SoftObject:
		{
			Type typeFromHandle = typeof(TSoftObject<>);
			Type type = FindTypeByPath(typePath);
			if (type != null)
			{
				return typeFromHandle.MakeGenericType(type);
			}
			throw new UnrealTypeNotFoundException(typeCode, typePath);
		}
		default:
			throw new NotImplementedException("Unhandled type " + typeCode);
		}
	}

	public static Type FindTypeByPath(string typePath)
	{
		ManagedUnrealModuleInfo.AllTypesByPath.TryGetValue(typePath, out var value);
		return value;
	}

	public static ManagedUnrealTypeInfo FindTypeInfoByPath(string typePath)
	{
		ManagedUnrealModuleInfo.AllTypeInfosByPath.TryGetValue(typePath, out var value);
		return value;
	}

	public static ManagedUnrealTypeInfo FindTypeInfoFromType(Type type)
	{
		if (ManagedUnrealModuleInfo.ModulesByType.TryGetValue(type, out var value))
		{
			value.TypeInfosByType.TryGetValue(type, out var value2);
			return value2;
		}
		return null;
	}

	public static Type GetDowngradedCollectionType(ManagedUnrealPropertyInfo propertyInfo, ManagedUnrealMarshalerType marshalerType)
	{
		return propertyInfo.Type.TypeCode switch
		{
			EPropertyType.Array => MakeGenericTypeWithPropertyArgs(typeof(IList<>), propertyInfo), 
			EPropertyType.Map => MakeGenericTypeWithPropertyArgs(typeof(IDictionary<, >), propertyInfo), 
			EPropertyType.Set => MakeGenericTypeWithPropertyArgs(typeof(ISet<>), propertyInfo), 
			_ => null, 
		};
	}

	public static bool IsCollectionType(EPropertyType typeCode)
	{
		if ((uint)(typeCode - 23) <= 2u)
		{
			return true;
		}
		return false;
	}

	public static bool IsDelegateType(EPropertyType typeCode)
	{
		if ((uint)(typeCode - 21) <= 1u)
		{
			return true;
		}
		return false;
	}

	public static Type GetCollectionType(ManagedUnrealPropertyInfo propertyInfo, ManagedUnrealMarshalerType marshalerType)
	{
		return GetTypeFromMarshalerInfo(new ManagedUnrealMarshalerInfo(propertyInfo, marshalerType));
	}

	public static Type GetCollectionType(EPropertyType typeCode, ManagedUnrealMarshalerType marshalerType)
	{
		switch (typeCode)
		{
		case EPropertyType.Array:
			switch (marshalerType)
			{
			case ManagedUnrealMarshalerType.Default:
				return typeof(TArrayReadWrite<>);
			case ManagedUnrealMarshalerType.ReadOnly:
				return typeof(TArrayReadOnly<>);
			case ManagedUnrealMarshalerType.Copy:
				return typeof(IList<>);
			}
			break;
		case EPropertyType.Map:
			switch (marshalerType)
			{
			case ManagedUnrealMarshalerType.Default:
				return typeof(TMapReadWrite<, >);
			case ManagedUnrealMarshalerType.ReadOnly:
				return typeof(TMapReadOnly<, >);
			case ManagedUnrealMarshalerType.Copy:
				return typeof(IDictionary<, >);
			}
			break;
		case EPropertyType.Set:
			switch (marshalerType)
			{
			case ManagedUnrealMarshalerType.Default:
				return typeof(TSetReadWrite<>);
			case ManagedUnrealMarshalerType.ReadOnly:
				return typeof(TSetReadOnly<>);
			case ManagedUnrealMarshalerType.Copy:
				return typeof(ISet<>);
			}
			break;
		}
		return null;
	}

	public static Type GetMarshalerType(ManagedUnrealMarshalerType marshalerType, ManagedUnrealTypeInfo typeInfo)
	{
		return GetMarshalerType(marshalerType, typeInfo.TypeCode, typeInfo.Path);
	}

	public static Type GetMarshalerType(ManagedUnrealMarshalerType marshalerType, ManagedUnrealTypeInfoReference typeInfo)
	{
		return GetMarshalerType(marshalerType, typeInfo.TypeCode, typeInfo.Path);
	}

	public static Type GetMarshalerType(ManagedUnrealMarshalerType marshalerType, ManagedUnrealPropertyInfo propertyInfo)
	{
		ManagedUnrealTypeInfoReference managedUnrealTypeInfoReference = ((propertyInfo.GenericArgs.Count >= 1) ? propertyInfo.GenericArgs[0] : null);
		ManagedUnrealTypeInfoReference managedUnrealTypeInfoReference2 = ((propertyInfo.GenericArgs.Count >= 2) ? propertyInfo.GenericArgs[1] : null);
		return GetMarshalerType(marshalerType, propertyInfo.Type.TypeCode, propertyInfo.Type.Path, managedUnrealTypeInfoReference?.TypeCode ?? EPropertyType.Unknown, managedUnrealTypeInfoReference?.Path, managedUnrealTypeInfoReference2?.TypeCode ?? EPropertyType.Unknown, managedUnrealTypeInfoReference2?.Path);
	}

	public static Type GetMarshalerType(ManagedUnrealMarshalerType marshalerType, EPropertyType typeCode, string typePath, EPropertyType arg1TypeCode = EPropertyType.Unknown, string arg1TypePath = null, EPropertyType arg2TypeCode = EPropertyType.Unknown, string arg2TypePath = null)
	{
		return GetTypeFromMarshalerInfo(new ManagedUnrealMarshalerInfo(typeCode, typePath, arg1TypeCode, arg1TypePath, arg2TypeCode, arg2TypePath, marshalerType));
	}

	public static Type GetTypeFromMarshalerInfo(ManagedUnrealMarshalerInfo marshalerInfo)
	{
		switch (marshalerInfo.Type)
		{
		case EPropertyType.InternalNativeFixedSizeArray:
		{
			Type type2 = null;
			type2 = ((marshalerInfo.MarshalerType != ManagedUnrealMarshalerType.ReadOnly) ? typeof(TFixedSizeArray<>) : typeof(TFixedSizeArrayReadOnly<>));
			Type typeFromTypeInfo2 = GetTypeFromTypeInfo(marshalerInfo.Arg1Type, marshalerInfo.Arg1Path);
			return type2.MakeGenericType(typeFromTypeInfo2);
		}
		case EPropertyType.InternalManagedFixedSizeArray:
		{
			Type typeFromTypeInfo5 = GetTypeFromTypeInfo(marshalerInfo.Arg1Type, marshalerInfo.Arg1Path);
			return typeof(TFixedSizeArrayMarshaler<>).MakeGenericType(typeFromTypeInfo5);
		}
		case EPropertyType.Array:
		{
			Type type4 = null;
			switch (marshalerInfo.MarshalerType)
			{
			case ManagedUnrealMarshalerType.Default:
				type4 = typeof(TArrayReadWriteMarshaler<>);
				break;
			case ManagedUnrealMarshalerType.ReadOnly:
				type4 = typeof(TArrayReadOnlyMarshaler<>);
				break;
			case ManagedUnrealMarshalerType.Copy:
				type4 = typeof(TArrayCopyMarshaler<>);
				break;
			}
			Type typeFromTypeInfo6 = GetTypeFromTypeInfo(marshalerInfo.Arg1Type, marshalerInfo.Arg1Path);
			return type4.MakeGenericType(typeFromTypeInfo6);
		}
		case EPropertyType.Map:
		{
			Type type3 = null;
			switch (marshalerInfo.MarshalerType)
			{
			case ManagedUnrealMarshalerType.Default:
				type3 = typeof(TMapReadWriteMarshaler<, >);
				break;
			case ManagedUnrealMarshalerType.ReadOnly:
				type3 = typeof(TMapReadOnlyMarshaler<, >);
				break;
			case ManagedUnrealMarshalerType.Copy:
				type3 = typeof(TMapCopyMarshaler<, >);
				break;
			}
			Type typeFromTypeInfo3 = GetTypeFromTypeInfo(marshalerInfo.Arg1Type, marshalerInfo.Arg1Path);
			Type typeFromTypeInfo4 = GetTypeFromTypeInfo(marshalerInfo.Arg2Type, marshalerInfo.Arg2Path);
			return type3.MakeGenericType(typeFromTypeInfo3, typeFromTypeInfo4);
		}
		case EPropertyType.Set:
		{
			Type type = null;
			switch (marshalerInfo.MarshalerType)
			{
			case ManagedUnrealMarshalerType.Default:
				type = typeof(TSetReadWriteMarshaler<>);
				break;
			case ManagedUnrealMarshalerType.ReadOnly:
				type = typeof(TSetReadOnlyMarshaler<>);
				break;
			case ManagedUnrealMarshalerType.Copy:
				type = typeof(TSetCopyMarshaler<>);
				break;
			}
			Type typeFromTypeInfo = GetTypeFromTypeInfo(marshalerInfo.Arg1Type, marshalerInfo.Arg1Path);
			return type.MakeGenericType(typeFromTypeInfo);
		}
		default:
			return GetTypeFromMarshalerInfo(marshalerInfo.Type, marshalerInfo.Path);
		}
	}

	public static Type GetTypeFromMarshalerInfo(EPropertyType typeCode, string typePath)
	{
		switch (typeCode)
		{
		case EPropertyType.Bool:
			return typeof(BoolMarshaler);
		case EPropertyType.Int8:
			return typeof(BlittableTypeMarshaler<sbyte>);
		case EPropertyType.Int16:
			return typeof(BlittableTypeMarshaler<short>);
		case EPropertyType.Int:
			return typeof(BlittableTypeMarshaler<int>);
		case EPropertyType.Int64:
			return typeof(BlittableTypeMarshaler<long>);
		case EPropertyType.Byte:
			return typeof(BlittableTypeMarshaler<byte>);
		case EPropertyType.UInt16:
			return typeof(BlittableTypeMarshaler<ushort>);
		case EPropertyType.UInt32:
			return typeof(BlittableTypeMarshaler<uint>);
		case EPropertyType.UInt64:
			return typeof(BlittableTypeMarshaler<ulong>);
		case EPropertyType.Float:
			return typeof(BlittableTypeMarshaler<float>);
		case EPropertyType.Double:
			return typeof(BlittableTypeMarshaler<double>);
		case EPropertyType.Name:
			return typeof(BlittableTypeMarshaler<FName>);
		case EPropertyType.Text:
			return typeof(FTextMarshaler);
		case EPropertyType.Str:
			return typeof(FStringMarshaler);
		case EPropertyType.Enum:
		{
			Type typeFromHandle9 = typeof(EnumMarshaler<>);
			Type type12 = FindTypeByPath(typePath);
			if (type12 != null)
			{
				return typeFromHandle9.MakeGenericType(type12);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Interface:
		{
			Type typeFromHandle2 = typeof(InterfaceMarshaler<>);
			Type type2 = FindTypeByPath(typePath);
			if (type2 != null)
			{
				return typeFromHandle2.MakeGenericType(type2);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Struct:
		{
			Type type4 = FindTypeByPath(typePath);
			if (type4 != null)
			{
				if (type4.IsSubclassOf(typeof(StructAsClass)))
				{
					return typeof(StructAsClassMarshaler<>).MakeGenericType(type4);
				}
				ManagedUnrealTypeInfo managedUnrealTypeInfo = FindTypeInfoFromType(type4);
				if (managedUnrealTypeInfo != null)
				{
					if (managedUnrealTypeInfo.IsBlittable)
					{
						return typeof(BlittableTypeMarshaler<>).MakeGenericType(type4);
					}
					return type4;
				}
				if (ManagedUnrealModuleInfo.AllKnownBlittableTypes.ContainsKey(typePath))
				{
					return typeof(BlittableTypeMarshaler<>).MakeGenericType(type4);
				}
				if (ManagedUnrealModuleInfo.AllKnownNonBlittableTypes.ContainsKey(typePath))
				{
					return type4;
				}
				throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Class:
		{
			Type type10 = FindTypeByPath(typePath);
			if (type10 != null)
			{
				Type type11 = null;
				type11 = ((!type10.IsInterface) ? typeof(TSubclassOfMarshaler<>) : typeof(TSubclassOfInterfaceMarshaler<>));
				return type11.MakeGenericType(type10);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Object:
		{
			Type typeFromHandle8 = typeof(UObjectMarshaler<>);
			Type type9 = FindTypeByPath(typePath);
			if (type9 != null)
			{
				return typeFromHandle8.MakeGenericType(type9);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.LazyObject:
		{
			Type typeFromHandle7 = typeof(TLazyObjectMarshaler<>);
			Type type8 = FindTypeByPath(typePath);
			if (type8 != null)
			{
				return typeFromHandle7.MakeGenericType(type8);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.WeakObject:
		{
			Type typeFromHandle6 = typeof(TWeakObjectMarshaler<>);
			Type type7 = FindTypeByPath(typePath);
			if (type7 != null)
			{
				return typeFromHandle6.MakeGenericType(type7);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.SoftClass:
		{
			Type typeFromHandle5 = typeof(TSoftClassMarshaler<>);
			Type type6 = FindTypeByPath(typePath);
			if (type6 != null)
			{
				return typeFromHandle5.MakeGenericType(type6);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.SoftObject:
		{
			Type typeFromHandle4 = typeof(TSoftObjectMarshaler<>);
			Type type5 = FindTypeByPath(typePath);
			if (type5 != null)
			{
				return typeFromHandle4.MakeGenericType(type5);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.Delegate:
		{
			Type typeFromHandle3 = typeof(FDelegateMarshaler<>);
			Type type3 = FindTypeByPath(typePath);
			if (type3 != null)
			{
				return typeFromHandle3.MakeGenericType(type3);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		case EPropertyType.MulticastDelegate:
		{
			Type typeFromHandle = typeof(FMulticastDelegateMarshaler<>);
			Type type = FindTypeByPath(typePath);
			if (type != null)
			{
				return typeFromHandle.MakeGenericType(type);
			}
			throw new UnrealMarshalerTypeNotFoundException(typeCode, typePath);
		}
		default:
			throw new NotImplementedException("Unhandled marshaler type " + typeCode);
		}
	}

	public static Type GetMarshalingDelegatesDelegate(ManagedUnrealTypeInfo typeInfo, bool fromNative)
	{
		return GetMarshalingDelegatesDelegate(typeInfo.TypeCode, typeInfo.Path, fromNative);
	}

	public static Type GetMarshalingDelegatesDelegate(ManagedUnrealTypeInfoReference typeInfo, bool fromNative)
	{
		return GetMarshalingDelegatesDelegate(typeInfo.TypeCode, typeInfo.Path, fromNative);
	}

	public static Type GetMarshalingDelegatesDelegate(EPropertyType typeCode, string typePath, bool fromNative)
	{
		if (fromNative)
		{
			return typeof(MarshalingDelegates<>.FromNative).MakeGenericType(GetTypeFromTypeInfo(typeCode, typePath));
		}
		return typeof(MarshalingDelegates<>.ToNative).MakeGenericType(GetTypeFromTypeInfo(typeCode, typePath));
	}

	public static Type GetCachedMarshalingDelegatesType(ManagedUnrealMarshalerType marshalerType, ManagedUnrealTypeInfoReference typeInfo)
	{
		return typeof(CachedMarshalingDelegates<, >).MakeGenericType(GetTypeFromTypeInfo(typeInfo), GetMarshalerType(marshalerType, typeInfo));
	}

	public static FieldInfo GetCachedMarshalingDelegatesDelegate(Type cachedMarshalingDelegatesType, bool fromNative)
	{
		FieldInfo fieldInfo = null;
		if (fromNative)
		{
			return cachedMarshalingDelegatesType.GetField("FromNative");
		}
		return cachedMarshalingDelegatesType.GetField("ToNative");
	}

	public static bool PropertyRequiresMarshalerInstance(ManagedUnrealPropertyInfo propertyInfo)
	{
		return propertyInfo.IsCollection;
	}

	public static bool IsPropertyMarshalerStruct(ManagedUnrealPropertyInfo propertyInfo)
	{
		if (propertyInfo.IsCollection)
		{
			return true;
		}
		return false;
	}

	public static bool PropertyRequiresInit(ManagedUnrealPropertyInfo propertyInfo)
	{
		switch (propertyInfo.Type.TypeCode)
		{
		case EPropertyType.Bool:
		case EPropertyType.Int8:
		case EPropertyType.Int16:
		case EPropertyType.Int:
		case EPropertyType.Int64:
		case EPropertyType.Byte:
		case EPropertyType.UInt16:
		case EPropertyType.UInt32:
		case EPropertyType.UInt64:
		case EPropertyType.Double:
		case EPropertyType.Float:
		case EPropertyType.Enum:
		case EPropertyType.Interface:
		case EPropertyType.Class:
		case EPropertyType.Object:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
		case EPropertyType.Name:
			return false;
		case EPropertyType.SoftClass:
		case EPropertyType.SoftObject:
		case EPropertyType.Array:
		case EPropertyType.Map:
		case EPropertyType.Set:
		case EPropertyType.Str:
		case EPropertyType.Text:
			return false;
		case EPropertyType.InternalNativeFixedSizeArray:
		case EPropertyType.InternalManagedFixedSizeArray:
			return true;
		case EPropertyType.Struct:
		{
			EStructFlags eStructFlags = EStructFlags.NoFlags;
			Type type = FindTypeByPath(propertyInfo.Type.Path);
			if (type != null)
			{
				eStructFlags = ResolveStructCtorDtorFlags(type);
			}
			return !eStructFlags.HasFlag(EStructFlags.ZeroConstructor);
		}
		default:
			throw new NotImplementedException("Unhandled type " + propertyInfo.Type.TypeCode);
		}
	}

	public static bool PropertyRequiresDestroy(ManagedUnrealPropertyInfo propertyInfo)
	{
		switch (propertyInfo.Type.TypeCode)
		{
		case EPropertyType.Bool:
		case EPropertyType.Int8:
		case EPropertyType.Int16:
		case EPropertyType.Int:
		case EPropertyType.Int64:
		case EPropertyType.Byte:
		case EPropertyType.UInt16:
		case EPropertyType.UInt32:
		case EPropertyType.UInt64:
		case EPropertyType.Double:
		case EPropertyType.Float:
		case EPropertyType.Enum:
		case EPropertyType.Interface:
		case EPropertyType.Class:
		case EPropertyType.Object:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
		case EPropertyType.Name:
			return false;
		case EPropertyType.SoftClass:
		case EPropertyType.SoftObject:
		case EPropertyType.Array:
		case EPropertyType.Map:
		case EPropertyType.Set:
		case EPropertyType.Str:
		case EPropertyType.Text:
			return true;
		case EPropertyType.InternalNativeFixedSizeArray:
		case EPropertyType.InternalManagedFixedSizeArray:
			return true;
		case EPropertyType.Struct:
		{
			EStructFlags eStructFlags = EStructFlags.NoFlags;
			Type type = FindTypeByPath(propertyInfo.Type.Path);
			if (type != null)
			{
				eStructFlags = ResolveStructCtorDtorFlags(type);
			}
			return !eStructFlags.HasFlag(EStructFlags.NoDestructor);
		}
		default:
			throw new NotImplementedException("Unhandled type " + propertyInfo.Type.TypeCode);
		}
	}

	private static EStructFlags ResolveStructCtorDtorFlags(Type structType)
	{
		if (!ManagedUnrealModuleInfo.resolvedStructCtorDtorFlags.TryGetValue(structType, out var value))
		{
			value = EStructFlags.NoDestructor | EStructFlags.ZeroConstructor;
			ManagedUnrealTypeInfo managedUnrealTypeInfo = FindTypeInfoFromType(structType);
			if (managedUnrealTypeInfo == null)
			{
				return EStructFlags.NoFlags;
			}
			foreach (ManagedUnrealPropertyInfo property in managedUnrealTypeInfo.Properties)
			{
				if (property.Type.TypeCode == EPropertyType.Struct)
				{
					value = (EStructFlags)((uint)value & 0xFFFF7FFFu);
					value = (EStructFlags)((uint)value & 0xFFFFBFFFu);
					break;
				}
				if (PropertyRequiresInit(property))
				{
					value = (EStructFlags)((uint)value & 0xFFFF7FFFu);
				}
				if (PropertyRequiresDestroy(property))
				{
					value = (EStructFlags)((uint)value & 0xFFFFBFFFu);
				}
			}
			ManagedUnrealModuleInfo.resolvedStructCtorDtorFlags.Add(structType, value);
		}
		return value;
	}

	public static bool IsSamePropertyType(ManagedUnrealPropertyInfo prop, ManagedUnrealPropertyInfo other)
	{
		if (prop.Type.TypeCode != other.Type.TypeCode || prop.Type.Path != other.Type.Path)
		{
			return false;
		}
		if (prop.GenericArgs.Count != other.GenericArgs.Count)
		{
			return false;
		}
		for (int i = 0; i < prop.GenericArgs.Count; i++)
		{
			if (prop.GenericArgs[i].TypeCode != other.GenericArgs[i].TypeCode || prop.GenericArgs[i].TypeCode != other.GenericArgs[i].TypeCode)
			{
				return false;
			}
		}
		return true;
	}
}
