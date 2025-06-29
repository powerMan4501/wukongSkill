using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataFilter", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UFieldSystemMetaDataFilter : UFieldSystemMetaData
{
	private static bool FilterType_IsValid;

	private static FFieldAddress FilterType_PropertyAddress;

	private static int FilterType_Offset;

	private static bool ObjectType_IsValid;

	private static FFieldAddress ObjectType_PropertyAddress;

	private static int ObjectType_Offset;

	private static bool PositionType_IsValid;

	private static FFieldAddress PositionType_PropertyAddress;

	private static int PositionType_Offset;

	private static bool SetMetaDataFilterType_IsValid;

	private static IntPtr SetMetaDataFilterType_FunctionAddress;

	private static int SetMetaDataFilterType_ParamsSize;

	private static bool SetMetaDataFilterType_FilterType_IsValid;

	private static FFieldAddress SetMetaDataFilterType_FilterType_PropertyAddress;

	private static int SetMetaDataFilterType_FilterType_Offset;

	private static bool SetMetaDataFilterType_ObjectType_IsValid;

	private static FFieldAddress SetMetaDataFilterType_ObjectType_PropertyAddress;

	private static int SetMetaDataFilterType_ObjectType_Offset;

	private static bool SetMetaDataFilterType_PositionType_IsValid;

	private static FFieldAddress SetMetaDataFilterType_PositionType_PropertyAddress;

	private static int SetMetaDataFilterType_PositionType_Offset;

	private static bool SetMetaDataFilterType_ReturnValue_IsValid;

	private static FFieldAddress SetMetaDataFilterType_ReturnValue_PropertyAddress;

	private static int SetMetaDataFilterType_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:FilterType")]
	public EFieldFilterType FilterType
	{
		get
		{
			CheckDestroyed();
			if (!FilterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:FilterType");
				return EFieldFilterType.Field_Filter_Dynamic;
			}
			return EnumMarshaler<EFieldFilterType>.FromNative(IntPtr.Add(base.Address, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FilterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:FilterType");
			}
			else
			{
				EnumMarshaler<EFieldFilterType>.ToNative(IntPtr.Add(base.Address, FilterType_Offset), 0, FilterType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:ObjectType")]
	public EFieldObjectType ObjectType
	{
		get
		{
			CheckDestroyed();
			if (!ObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:ObjectType");
				return EFieldObjectType.Field_Object_Rigid;
			}
			return EnumMarshaler<EFieldObjectType>.FromNative(IntPtr.Add(base.Address, ObjectType_Offset), 0, ObjectType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:ObjectType");
			}
			else
			{
				EnumMarshaler<EFieldObjectType>.ToNative(IntPtr.Add(base.Address, ObjectType_Offset), 0, ObjectType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:PositionType")]
	public EFieldPositionType PositionType
	{
		get
		{
			CheckDestroyed();
			if (!PositionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:PositionType");
				return EFieldPositionType.Field_Position_CenterOfMass;
			}
			return EnumMarshaler<EFieldPositionType>.FromNative(IntPtr.Add(base.Address, PositionType_Offset), 0, PositionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PositionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:PositionType");
			}
			else
			{
				EnumMarshaler<EFieldPositionType>.ToNative(IntPtr.Add(base.Address, PositionType_Offset), 0, PositionType_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:SetMetaDataFilterType")]
	public unsafe UFieldSystemMetaDataFilter SetMetaDataFilterType(EFieldFilterType FilterType, EFieldObjectType ObjectType, EFieldPositionType PositionType)
	{
		CheckDestroyed();
		if (!SetMetaDataFilterType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:SetMetaDataFilterType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMetaDataFilterType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMetaDataFilterType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFieldFilterType>.ToNative(IntPtr.Add(intPtr, SetMetaDataFilterType_FilterType_Offset), 0, SetMetaDataFilterType_FilterType_PropertyAddress.Address, FilterType);
		EnumMarshaler<EFieldObjectType>.ToNative(IntPtr.Add(intPtr, SetMetaDataFilterType_ObjectType_Offset), 0, SetMetaDataFilterType_ObjectType_PropertyAddress.Address, ObjectType);
		EnumMarshaler<EFieldPositionType>.ToNative(IntPtr.Add(intPtr, SetMetaDataFilterType_PositionType_Offset), 0, SetMetaDataFilterType_PositionType_PropertyAddress.Address, PositionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMetaDataFilterType_FunctionAddress, intPtr, SetMetaDataFilterType_ParamsSize);
		return UObjectMarshaler<UFieldSystemMetaDataFilter>.FromNative(IntPtr.Add(intPtr, SetMetaDataFilterType_ReturnValue_Offset), 0, SetMetaDataFilterType_ReturnValue_PropertyAddress.Address);
	}

	static UFieldSystemMetaDataFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFieldSystemMetaDataFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFieldSystemMetaDataFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.FieldSystemMetaDataFilter");
		NativeReflectionCached.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectType_PropertyAddress, intPtr, "ObjectType");
		ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectType");
		ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PositionType_PropertyAddress, intPtr, "PositionType");
		PositionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionType");
		PositionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionType", Classes.FByteProperty);
		SetMetaDataFilterType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMetaDataFilterType");
		SetMetaDataFilterType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMetaDataFilterType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataFilterType_FilterType_PropertyAddress, SetMetaDataFilterType_FunctionAddress, "FilterType");
		SetMetaDataFilterType_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataFilterType_FunctionAddress, "FilterType");
		SetMetaDataFilterType_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataFilterType_FunctionAddress, "FilterType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataFilterType_ObjectType_PropertyAddress, SetMetaDataFilterType_FunctionAddress, "ObjectType");
		SetMetaDataFilterType_ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataFilterType_FunctionAddress, "ObjectType");
		SetMetaDataFilterType_ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataFilterType_FunctionAddress, "ObjectType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataFilterType_PositionType_PropertyAddress, SetMetaDataFilterType_FunctionAddress, "PositionType");
		SetMetaDataFilterType_PositionType_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataFilterType_FunctionAddress, "PositionType");
		SetMetaDataFilterType_PositionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataFilterType_FunctionAddress, "PositionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataFilterType_ReturnValue_PropertyAddress, SetMetaDataFilterType_FunctionAddress, "ReturnValue");
		SetMetaDataFilterType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataFilterType_FunctionAddress, "ReturnValue");
		SetMetaDataFilterType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataFilterType_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMetaDataFilterType_IsValid = SetMetaDataFilterType_FunctionAddress != IntPtr.Zero && SetMetaDataFilterType_FilterType_IsValid && SetMetaDataFilterType_ObjectType_IsValid && SetMetaDataFilterType_PositionType_IsValid && SetMetaDataFilterType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemMetaDataFilter:SetMetaDataFilterType", SetMetaDataFilterType_IsValid);
	}
}
