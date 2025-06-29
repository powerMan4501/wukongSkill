using System;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Property", "CoreUObject", UnrealModuleType.Engine)]
public class FProperty : IEquatable<FProperty>
{
	private CachedUObject<UStruct> ownerStruct;

	private CachedUObject<UClass> cachedClass;

	public IntPtr Address { get; internal set; }

	public virtual EPropertyType PropertyType => GetPropertyType(Address);

	public virtual bool IsBlittableType => GetIsBlittableType(Address);

	public bool IsBlittable
	{
		get
		{
			if (IsBlittableType)
			{
				return !IsFixedSizeArray;
			}
			return false;
		}
	}

	public bool IsFixedSizeArray => ArrayDim > 1;

	public int Offset => Native_FProperty.GetOffset_ForInternal(Address);

	public int ArrayDim
	{
		get
		{
			return Native_FProperty.Get_ArrayDim(Address);
		}
		set
		{
			Native_FProperty.Set_ArrayDim(Address, value);
		}
	}

	public int ElementSize
	{
		get
		{
			return Native_FProperty.Get_ElementSize(Address);
		}
		set
		{
			Native_FProperty.Set_ElementSize(Address, value);
		}
	}

	public EPropertyFlags PropertyFlags
	{
		get
		{
			return Native_FProperty.Get_PropertyFlags(Address);
		}
		set
		{
			Native_FProperty.Set_PropertyFlags(Address, value);
		}
	}

	public ushort RepIndex
	{
		get
		{
			return Native_FProperty.Get_RepIndex(Address);
		}
		set
		{
			Native_FProperty.Set_RepIndex(Address, value);
		}
	}

	public FName RepNotifyFunc
	{
		get
		{
			Native_FProperty.Get_RepNotifyFunc(Address, out var result);
			return result;
		}
		set
		{
			Native_FProperty.Set_RepNotifyFunc(Address, ref value);
		}
	}

	public IntPtr PropertyLinkNext
	{
		get
		{
			return Native_FProperty.Get_PropertyLinkNext(Address);
		}
		set
		{
			Native_FProperty.Set_PropertyLinkNext(Address, value);
		}
	}

	public IntPtr NextRef
	{
		get
		{
			return Native_FProperty.Get_NextRef(Address);
		}
		set
		{
			Native_FProperty.Set_NextRef(Address, value);
		}
	}

	public IntPtr DestructorLinkNext
	{
		get
		{
			return Native_FProperty.Get_DestructorLinkNext(Address);
		}
		set
		{
			Native_FProperty.Set_DestructorLinkNext(Address, value);
		}
	}

	public IntPtr PostConstructLinkNext
	{
		get
		{
			return Native_FProperty.Get_PostConstructLinkNext(Address);
		}
		set
		{
			Native_FProperty.Set_PostConstructLinkNext(Address, value);
		}
	}

	public UStruct OwnerStruct => ownerStruct.Update(Native_FField.GetOwnerStruct(Address));

	public FProperty()
	{
		Address = IntPtr.Zero;
	}

	public FProperty(IntPtr _propertyAddress)
	{
		Address = _propertyAddress;
	}

	public static bool operator ==(FProperty a, FProperty b)
	{
		if ((object)a == null)
		{
			if ((object)b == null)
			{
				return true;
			}
			return false;
		}
		return a.Equals(b);
	}

	public static bool operator !=(FProperty a, FProperty b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as FProperty);
	}

	public bool Equals(FProperty other)
	{
		if ((object)other == null)
		{
			return false;
		}
		return Address.Equals(other.Address);
	}

	public override int GetHashCode()
	{
		return Address.GetHashCode();
	}

	public string GetCPPMacroType(string extendedTypeText)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(extendedTypeText);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FProperty.GetCPPMacroType(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public bool PassCPPArgsByRef()
	{
		return Native_FProperty.PassCPPArgsByRef(Address);
	}

	public string GetNameCPP()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FProperty.GetNameCPP(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public unsafe string GetCPPType(string extendedTypeText = null, uint cppExportFlags = 0u)
	{
		if (extendedTypeText == null)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe())
			{
				Native_FProperty.GetCPPType(Address, IntPtr.Zero, cppExportFlags, ref fStringUnsafe.Array);
				return fStringUnsafe.Value;
			}
		}
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(extendedTypeText);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		fixed (FScriptArray* array = &fStringUnsafe2.Array)
		{
			Native_FProperty.GetCPPType(Address, (IntPtr)array, cppExportFlags, ref fStringUnsafe3.Array);
			return fStringUnsafe3.Value;
		}
	}

	public int GetOffset_ForDebug()
	{
		return Native_FProperty.GetOffset_ForDebug(Address);
	}

	public int GetOffset_ForUFunction()
	{
		return Native_FProperty.GetOffset_ForUFunction(Address);
	}

	public int GetOffset_ForGC()
	{
		return Native_FProperty.GetOffset_ForGC(Address);
	}

	public int GetOffset_ForInternal()
	{
		return Native_FProperty.GetOffset_ForInternal(Address);
	}

	public int GetOffset_ReplaceWith_ContainerPtrToValuePtr()
	{
		return Native_FProperty.GetOffset_ReplaceWith_ContainerPtrToValuePtr(Address);
	}

	public IntPtr ContainerUObjectPtrToValuePtr(IntPtr container, int arrayIndex = 0)
	{
		return Native_FProperty.ContainerUObjectPtrToValuePtr(Address, container, arrayIndex);
	}

	public IntPtr ContainerPtrToValuePtr(UObject container, int arrayIndex = 0)
	{
		return ContainerUObjectPtrToValuePtr((container == null) ? IntPtr.Zero : container.Address, arrayIndex);
	}

	public IntPtr ContainerPtrToValuePtr(IntPtr container, int arrayIndex = 0)
	{
		return Native_FProperty.ContainerVoidPtrToValuePtr(Address, container, arrayIndex);
	}

	public uint GetValueTypeHash(IntPtr src)
	{
		return Native_FProperty.GetValueTypeHash(Address, src);
	}

	public bool ShouldPort(uint portFlags)
	{
		return Native_FProperty.ShouldPort(Address, portFlags);
	}

	public FName GetID()
	{
		Native_FProperty.GetID(Address, out var result);
		return result;
	}

	public int GetMinAlignment()
	{
		return Native_FProperty.GetMinAlignment(Address);
	}

	public bool ContainsObjectReference(List<FStructProperty> encounteredStructProps)
	{
		using TArrayUnsafe<FStructProperty> tArrayUnsafe = new TArrayUnsafe<FStructProperty>();
		bool result = Native_FProperty.ContainsObjectReference(Address, tArrayUnsafe.Address);
		if (encounteredStructProps != null)
		{
			encounteredStructProps.Clear();
			encounteredStructProps.AddRange(tArrayUnsafe);
		}
		return result;
	}

	public bool ContainsWeakObjectReference()
	{
		return Native_FProperty.ContainsWeakObjectReference(Address);
	}

	public bool ContainsInstancedObjectProperty()
	{
		return Native_FProperty.ContainsInstancedObjectProperty(Address);
	}

	public void EmitReferenceInfo(UClass unrealClass, int baseOffset, List<FStructProperty> encounteredStructProps)
	{
		throw new NotImplementedException();
	}

	public int GetSize()
	{
		return Native_FProperty.GetSize(Address);
	}

	public bool ShouldDuplicateValue()
	{
		return Native_FProperty.ShouldDuplicateValue(Address);
	}

	public IntPtr GetOwnerProperty()
	{
		return Native_FProperty.GetOwnerProperty(Address);
	}

	public EPropertyFlags GetPropertyFlags()
	{
		return Native_FProperty.GetPropertyFlags(Address);
	}

	public void SetPropertyFlags(EPropertyFlags newFlags)
	{
		Native_FProperty.SetPropertyFlags(Address, newFlags);
	}

	public void ClearPropertyFlags(EPropertyFlags newFlags)
	{
		Native_FProperty.ClearPropertyFlags(Address, newFlags);
	}

	public bool HasAnyPropertyFlags(EPropertyFlags flagsToCheck)
	{
		return Native_FProperty.HasAnyPropertyFlags(Address, flagsToCheck);
	}

	public bool HasAllPropertyFlags(EPropertyFlags flagsToCheck)
	{
		return Native_FProperty.HasAllPropertyFlags(Address, flagsToCheck);
	}

	public IntPtr GetRepOwner()
	{
		return Native_FProperty.GetRepOwner(Address);
	}

	public bool IsEditorOnlyProperty()
	{
		return Native_FProperty.IsEditorOnlyProperty(Address);
	}

	public bool SameType(FProperty other)
	{
		return Native_FProperty.SameType(Address, (other == null) ? IntPtr.Zero : other.Address);
	}

	public string GetName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FProperty.GetName(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public FName GetFName()
	{
		Native_FProperty.GetFName(Address, out var result);
		return result;
	}

	public string GetPathName(UObject stopOuter = null)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FProperty.GetPathName(Address, (stopOuter == null) ? IntPtr.Zero : stopOuter.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public UStruct GetOwnerStruct()
	{
		return OwnerStruct;
	}

	public UClass GetClass()
	{
		return cachedClass.Update(Native_FField.GetOwnerClass(Address));
	}

	public string GetMetaData(string key)
	{
		if (Native_FField.GetMetaData == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FField.GetMetaData(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public string GetMetaData(FName key)
	{
		if (Native_FField.GetMetaDataF == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FField.GetMetaDataF(Address, ref key, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public string GetMetaData<TEnum>(TEnum key) where TEnum : struct
	{
		return GetMetaData(UMeta.GetKey(key));
	}

	public void SetMetaData(string key, string value)
	{
		if (Native_FField.SetMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(value);
		Native_FField.SetMetaData(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public bool GetBoolMetaData(string key)
	{
		if (Native_FField.GetBoolMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_FField.GetBoolMetaData(Address, ref fStringUnsafe.Array);
	}

	public bool GetBoolMetaData<TEnum>(TEnum key) where TEnum : struct
	{
		return GetBoolMetaData(UMeta.GetKey(key));
	}

	public bool HasMetaData(string key)
	{
		if (Native_FField.HasMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_FField.HasMetaData(Address, ref fStringUnsafe.Array);
	}

	public static EPropertyType GetPropertyType(IntPtr propAddress)
	{
		FProperty fProperty = new FProperty(propAddress);
		if (fProperty == null || fProperty.Address == IntPtr.Zero)
		{
			return EPropertyType.Unknown;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 131072uL))
		{
			return EPropertyType.Bool;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 64uL))
		{
			return EPropertyType.Byte;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 2uL))
		{
			return EPropertyType.Int8;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 262144uL))
		{
			return EPropertyType.UInt16;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 2147483648uL))
		{
			return EPropertyType.Int16;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 2048uL))
		{
			return EPropertyType.UInt32;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 128uL))
		{
			return EPropertyType.Int;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 512uL))
		{
			return EPropertyType.UInt64;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 4194304uL))
		{
			return EPropertyType.Int64;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 256uL))
		{
			return EPropertyType.Float;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 4294967296uL))
		{
			return EPropertyType.Double;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 281474976710656uL))
		{
			return EPropertyType.Enum;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 16384uL))
		{
			return EPropertyType.Str;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 8192uL))
		{
			return EPropertyType.Name;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 1073741824uL))
		{
			return EPropertyType.Text;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 4096uL))
		{
			return EPropertyType.Interface;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 1048576uL))
		{
			return EPropertyType.Struct;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 1024uL))
		{
			return EPropertyType.Class;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 65536uL))
		{
			return EPropertyType.Object;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 268435456uL))
		{
			return EPropertyType.LazyObject;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 134217728uL))
		{
			return EPropertyType.WeakObject;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 8589934592uL))
		{
			return EPropertyType.SoftClass;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 536870912uL))
		{
			return EPropertyType.SoftObject;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 8388608uL))
		{
			return EPropertyType.Delegate;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 33554432uL))
		{
			return EPropertyType.MulticastDelegate;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 2097152uL))
		{
			return EPropertyType.Array;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 140737488355328uL))
		{
			return EPropertyType.Set;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 70368744177664uL))
		{
			return EPropertyType.Map;
		}
		return EPropertyType.Unknown;
	}

	public static bool GetIsBlittableType(IntPtr propAddress)
	{
		FProperty fProperty = new FProperty(propAddress);
		if (fProperty == null || fProperty.Address == IntPtr.Zero)
		{
			return false;
		}
		if ((bool)Native_FField.HasAnyCastFlags(propAddress, 281474976710656uL) || (bool)Native_FField.HasAnyCastFlags(propAddress, 8192uL) || (bool)Native_FField.HasAnyCastFlags(propAddress, 16777216uL))
		{
			return true;
		}
		return false;
	}

	public static Type GetTypeFromProperty(IntPtr propAddress)
	{
		FProperty fProperty = new FProperty(propAddress);
		if (fProperty == null || fProperty.Address == IntPtr.Zero)
		{
			return null;
		}
		EPropertyType propertyType = GetPropertyType(fProperty.Address);
		switch (propertyType)
		{
		case EPropertyType.Bool:
			return typeof(bool);
		case EPropertyType.Int8:
			return typeof(sbyte);
		case EPropertyType.Byte:
			return typeof(byte);
		case EPropertyType.Int16:
			return typeof(short);
		case EPropertyType.UInt16:
			return typeof(ushort);
		case EPropertyType.Int:
			return typeof(int);
		case EPropertyType.UInt32:
			return typeof(uint);
		case EPropertyType.Int64:
			return typeof(long);
		case EPropertyType.UInt64:
			return typeof(ulong);
		case EPropertyType.Float:
			return typeof(float);
		case EPropertyType.Double:
			return typeof(double);
		case EPropertyType.Enum:
		{
			UEnum uEnum = new FEnumProperty(fProperty.Address).GetEnum();
			if (uEnum == null)
			{
				return null;
			}
			ManagedUnrealModuleInfo.AllKnownUnrealTypes.TryGetValue(uEnum.GetPathName(), out var value3);
			return value3;
		}
		case EPropertyType.Str:
			return typeof(string);
		case EPropertyType.Name:
			return typeof(FName);
		case EPropertyType.Text:
			return typeof(FText);
		case EPropertyType.Interface:
		{
			UClass interfaceClass = new FInterfaceProperty(fProperty.Address).InterfaceClass;
			if (interfaceClass == null)
			{
				return null;
			}
			ManagedUnrealModuleInfo.AllKnownUnrealTypes.TryGetValue(interfaceClass.GetPathName(), out var value);
			return value;
		}
		case EPropertyType.Struct:
		{
			UScriptStruct uScriptStruct = new FStructProperty(fProperty.Address).Struct;
			if (uScriptStruct == null)
			{
				return null;
			}
			ManagedUnrealModuleInfo.AllKnownUnrealTypes.TryGetValue(uScriptStruct.GetPathName(), out var value5);
			return value5;
		}
		case EPropertyType.Class:
		case EPropertyType.Object:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.SoftClass:
		case EPropertyType.SoftObject:
		{
			UClass uClass = new FObjectPropertyBase(fProperty.Address).PropertyClass;
			switch (propertyType)
			{
			case EPropertyType.Class:
				uClass = new FClassProperty(fProperty.Address).MetaClass;
				break;
			case EPropertyType.SoftClass:
				uClass = new FSoftClassProperty(fProperty.Address).MetaClass;
				break;
			}
			Type value4 = null;
			if (uClass != null)
			{
				ManagedUnrealModuleInfo.AllKnownUnrealTypes.TryGetValue(uClass.GetPathName(), out value4);
			}
			if (value4 == null)
			{
				return null;
			}
			return propertyType switch
			{
				EPropertyType.Class => typeof(TSubclassOf<>).MakeGenericType(value4), 
				EPropertyType.LazyObject => typeof(TLazyObject<>).MakeGenericType(value4), 
				EPropertyType.WeakObject => typeof(TWeakObject<>).MakeGenericType(value4), 
				EPropertyType.SoftClass => typeof(TSoftClass<>).MakeGenericType(value4), 
				EPropertyType.SoftObject => typeof(TSoftObject<>).MakeGenericType(value4), 
				EPropertyType.Object => value4, 
				_ => value4, 
			};
		}
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
		{
			Type value2 = null;
			UFunction uFunction = null;
			switch (propertyType)
			{
			case EPropertyType.Delegate:
				uFunction = new FDelegateProperty(fProperty.Address).SignatureFunction;
				break;
			case EPropertyType.MulticastDelegate:
				uFunction = new FMulticastDelegateProperty(fProperty.Address).SignatureFunction;
				break;
			}
			if (uFunction != null && ManagedUnrealModuleInfo.AllKnownUnrealTypes.TryGetValue(uFunction.GetPathName(), out value2))
			{
				switch (propertyType)
				{
				case EPropertyType.Delegate:
					if (!value2.IsSameOrSubclassOfGeneric(typeof(FDelegate<>)))
					{
						value2 = null;
					}
					break;
				case EPropertyType.MulticastDelegate:
					if (!value2.IsSameOrSubclassOfGeneric(typeof(FMulticastDelegate<>)))
					{
						value2 = null;
					}
					break;
				}
			}
			return value2;
		}
		case EPropertyType.Array:
		{
			Type typeFromProperty4 = GetTypeFromProperty(new FArrayProperty(fProperty.Address).Inner);
			if (typeFromProperty4 != null)
			{
				return typeof(IList<>).MakeGenericType(typeFromProperty4);
			}
			return null;
		}
		case EPropertyType.Set:
		{
			Type typeFromProperty3 = GetTypeFromProperty(new FSetProperty(fProperty.Address).ElementProp);
			if (typeFromProperty3 != null)
			{
				return typeof(ISet<>).MakeGenericType(typeFromProperty3);
			}
			return null;
		}
		case EPropertyType.Map:
		{
			FMapProperty fMapProperty = new FMapProperty(fProperty.Address);
			Type typeFromProperty = GetTypeFromProperty(fMapProperty.KeyProp);
			Type typeFromProperty2 = GetTypeFromProperty(fMapProperty.ValueProp);
			if (typeFromProperty != null && typeFromProperty2 != null)
			{
				return typeof(IDictionary<, >).MakeGenericType(typeFromProperty, typeFromProperty2);
			}
			return null;
		}
		default:
			return null;
		}
	}

	public bool IsA<T>() where T : FProperty
	{
		IntPtr intPtr = IntPtr.Zero;
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == typeof(FNumericProperty))
		{
			intPtr = Classes.FNumericProperty;
		}
		else if (typeFromHandle == typeof(FBoolProperty))
		{
			intPtr = Classes.FBoolProperty;
		}
		else if (typeFromHandle == typeof(FByteProperty))
		{
			intPtr = Classes.FByteProperty;
		}
		else if (typeFromHandle == typeof(FInt8Property))
		{
			intPtr = Classes.FInt8Property;
		}
		else if (typeFromHandle == typeof(FUInt16Property))
		{
			intPtr = Classes.FUInt16Property;
		}
		else if (typeFromHandle == typeof(FInt16Property))
		{
			intPtr = Classes.FInt16Property;
		}
		else if (typeFromHandle == typeof(FUInt32Property))
		{
			intPtr = Classes.FUInt32Property;
		}
		else if (typeFromHandle == typeof(FIntProperty))
		{
			intPtr = Classes.FIntProperty;
		}
		else if (typeFromHandle == typeof(FUInt64Property))
		{
			intPtr = Classes.FUInt64Property;
		}
		else if (typeFromHandle == typeof(FInt64Property))
		{
			intPtr = Classes.FInt64Property;
		}
		else if (typeFromHandle == typeof(FFloatProperty))
		{
			intPtr = Classes.FFloatProperty;
		}
		else if (typeFromHandle == typeof(FDoubleProperty))
		{
			intPtr = Classes.FDoubleProperty;
		}
		else if (typeFromHandle == typeof(FEnumProperty))
		{
			intPtr = Classes.FEnumProperty;
		}
		else if (typeFromHandle == typeof(FStrProperty))
		{
			intPtr = Classes.FStrProperty;
		}
		else if (typeFromHandle == typeof(FNameProperty))
		{
			intPtr = Classes.FNameProperty;
		}
		else if (typeFromHandle == typeof(FTextProperty))
		{
			intPtr = Classes.FTextProperty;
		}
		else if (typeFromHandle == typeof(FInterfaceProperty))
		{
			intPtr = Classes.FInterfaceProperty;
		}
		else if (typeFromHandle == typeof(FStructProperty))
		{
			intPtr = Classes.FStructProperty;
		}
		else if (typeFromHandle == typeof(FClassProperty))
		{
			intPtr = Classes.FClassProperty;
		}
		else if (typeFromHandle == typeof(FSoftClassProperty))
		{
			intPtr = Classes.FSoftClassProperty;
		}
		else if (typeFromHandle == typeof(FObjectPropertyBase))
		{
			intPtr = Classes.FObjectPropertyBase;
		}
		else if (typeFromHandle == typeof(FObjectProperty))
		{
			intPtr = Classes.FObjectProperty;
		}
		else if (typeFromHandle == typeof(FLazyObjectProperty))
		{
			intPtr = Classes.FLazyObjectProperty;
		}
		else if (typeFromHandle == typeof(FWeakObjectProperty))
		{
			intPtr = Classes.FWeakObjectProperty;
		}
		else if (typeFromHandle == typeof(FSoftObjectProperty))
		{
			intPtr = Classes.FSoftObjectProperty;
		}
		else if (typeFromHandle == typeof(FDelegateProperty))
		{
			intPtr = Classes.FDelegateProperty;
		}
		else if (typeFromHandle == typeof(FMulticastDelegateProperty))
		{
			intPtr = Classes.FMulticastDelegateProperty;
		}
		else if (typeFromHandle == typeof(FMulticastSparseDelegateProperty))
		{
			intPtr = Classes.FMulticastSparseDelegateProperty;
		}
		else if (typeFromHandle == typeof(FMulticastInlineDelegateProperty))
		{
			intPtr = Classes.FMulticastInlineDelegateProperty;
		}
		else if (typeFromHandle == typeof(FArrayProperty))
		{
			intPtr = Classes.FArrayProperty;
		}
		else if (typeFromHandle == typeof(FSetProperty))
		{
			intPtr = Classes.FSetProperty;
		}
		else if (typeFromHandle == typeof(FMapProperty))
		{
			intPtr = Classes.FMapProperty;
		}
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		return Native_FField.IsA(Address, intPtr);
	}

	public static string GetNameSafe(FProperty property)
	{
		if (property == null || property.Address == IntPtr.Zero)
		{
			return "None";
		}
		return new FField(property.Address).GetName();
	}

	public static IntPtr GetPropertyClassByAddress(IntPtr propAddress)
	{
		if (propAddress == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return GetPropertyType(propAddress) switch
		{
			EPropertyType.Bool => Classes.FBoolProperty, 
			EPropertyType.Byte => Classes.FByteProperty, 
			EPropertyType.Int8 => Classes.FInt8Property, 
			EPropertyType.UInt16 => Classes.FUInt16Property, 
			EPropertyType.Int16 => Classes.FInt16Property, 
			EPropertyType.UInt32 => Classes.FUInt32Property, 
			EPropertyType.Int => Classes.FIntProperty, 
			EPropertyType.UInt64 => Classes.FUInt64Property, 
			EPropertyType.Int64 => Classes.FInt64Property, 
			EPropertyType.Float => Classes.FFloatProperty, 
			EPropertyType.Double => Classes.FDoubleProperty, 
			EPropertyType.Enum => Classes.FEnumProperty, 
			EPropertyType.Str => Classes.FStrProperty, 
			EPropertyType.Name => Classes.FNameProperty, 
			EPropertyType.Text => Classes.FTextProperty, 
			EPropertyType.Interface => Classes.FInterfaceProperty, 
			EPropertyType.Struct => Classes.FStructProperty, 
			EPropertyType.Class => Classes.FClassProperty, 
			EPropertyType.SoftClass => Classes.FSoftClassProperty, 
			EPropertyType.Object => Classes.FObjectProperty, 
			EPropertyType.LazyObject => Classes.FLazyObjectProperty, 
			EPropertyType.WeakObject => Classes.FWeakObjectProperty, 
			EPropertyType.SoftObject => Classes.FSoftObjectProperty, 
			EPropertyType.Delegate => Classes.FDelegateProperty, 
			EPropertyType.MulticastDelegate => Classes.FMulticastDelegateProperty, 
			EPropertyType.Array => Classes.FArrayProperty, 
			EPropertyType.Set => Classes.FSetProperty, 
			EPropertyType.Map => Classes.FMapProperty, 
			_ => IntPtr.Zero, 
		};
	}

	public static bool PropertyIsChildOfNumericProperty(IntPtr propAddress)
	{
		if (propAddress != IntPtr.Zero)
		{
			return Native_FField.IsA(propAddress, Classes.FNumericProperty);
		}
		return false;
	}
}
