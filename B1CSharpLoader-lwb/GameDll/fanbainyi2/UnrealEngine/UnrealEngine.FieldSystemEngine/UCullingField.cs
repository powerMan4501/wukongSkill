using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.CullingField", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UCullingField : UFieldNodeBase
{
	private static bool Culling_IsValid;

	private static int Culling_Offset;

	private static bool Field_IsValid;

	private static int Field_Offset;

	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool SetCullingField_IsValid;

	private static IntPtr SetCullingField_FunctionAddress;

	private static int SetCullingField_ParamsSize;

	private static bool SetCullingField_Culling_IsValid;

	private static FFieldAddress SetCullingField_Culling_PropertyAddress;

	private static int SetCullingField_Culling_Offset;

	private static bool SetCullingField_Field_IsValid;

	private static FFieldAddress SetCullingField_Field_PropertyAddress;

	private static int SetCullingField_Field_Offset;

	private static bool SetCullingField_Operation_IsValid;

	private static FFieldAddress SetCullingField_Operation_PropertyAddress;

	private static int SetCullingField_Operation_Offset;

	private static bool SetCullingField_ReturnValue_IsValid;

	private static FFieldAddress SetCullingField_ReturnValue_PropertyAddress;

	private static int SetCullingField_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/FieldSystemEngine.CullingField:Culling")]
	public UFieldNodeBase Culling
	{
		get
		{
			CheckDestroyed();
			if (!Culling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.CullingField:Culling");
				return null;
			}
			return UObjectMarshaler<UFieldNodeBase>.FromNative(IntPtr.Add(base.Address, Culling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Culling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.CullingField:Culling");
			}
			else
			{
				UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(base.Address, Culling_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/FieldSystemEngine.CullingField:Field")]
	public UFieldNodeBase Field
	{
		get
		{
			CheckDestroyed();
			if (!Field_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.CullingField:Field");
				return null;
			}
			return UObjectMarshaler<UFieldNodeBase>.FromNative(IntPtr.Add(base.Address, Field_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Field_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.CullingField:Field");
			}
			else
			{
				UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(base.Address, Field_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.CullingField:Operation")]
	public EFieldCullingOperationType Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.CullingField:Operation");
				return EFieldCullingOperationType.Field_Culling_Inside;
			}
			return EnumMarshaler<EFieldCullingOperationType>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.CullingField:Operation");
			}
			else
			{
				EnumMarshaler<EFieldCullingOperationType>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.CullingField:SetCullingField")]
	public unsafe UCullingField SetCullingField(UFieldNodeBase Culling, UFieldNodeBase Field, EFieldCullingOperationType Operation)
	{
		CheckDestroyed();
		if (!SetCullingField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.CullingField:SetCullingField");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCullingField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCullingField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, SetCullingField_Culling_Offset), 0, SetCullingField_Culling_PropertyAddress.Address, Culling);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, SetCullingField_Field_Offset), 0, SetCullingField_Field_PropertyAddress.Address, Field);
		EnumMarshaler<EFieldCullingOperationType>.ToNative(IntPtr.Add(intPtr, SetCullingField_Operation_Offset), 0, SetCullingField_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCullingField_FunctionAddress, intPtr, SetCullingField_ParamsSize);
		return UObjectMarshaler<UCullingField>.FromNative(IntPtr.Add(intPtr, SetCullingField_ReturnValue_Offset), 0, SetCullingField_ReturnValue_PropertyAddress.Address);
	}

	static UCullingField()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCullingField)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCullingField));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.CullingField");
		Culling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Culling");
		Culling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Culling", Classes.FObjectProperty);
		Field_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Field");
		Field_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Field", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, intPtr, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Operation", Classes.FByteProperty);
		SetCullingField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCullingField");
		SetCullingField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCullingField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCullingField_Culling_PropertyAddress, SetCullingField_FunctionAddress, "Culling");
		SetCullingField_Culling_Offset = NativeReflectionCached.GetPropertyOffset(SetCullingField_FunctionAddress, "Culling");
		SetCullingField_Culling_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullingField_FunctionAddress, "Culling", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullingField_Field_PropertyAddress, SetCullingField_FunctionAddress, "Field");
		SetCullingField_Field_Offset = NativeReflectionCached.GetPropertyOffset(SetCullingField_FunctionAddress, "Field");
		SetCullingField_Field_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullingField_FunctionAddress, "Field", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullingField_Operation_PropertyAddress, SetCullingField_FunctionAddress, "Operation");
		SetCullingField_Operation_Offset = NativeReflectionCached.GetPropertyOffset(SetCullingField_FunctionAddress, "Operation");
		SetCullingField_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullingField_FunctionAddress, "Operation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullingField_ReturnValue_PropertyAddress, SetCullingField_FunctionAddress, "ReturnValue");
		SetCullingField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCullingField_FunctionAddress, "ReturnValue");
		SetCullingField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullingField_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetCullingField_IsValid = SetCullingField_FunctionAddress != IntPtr.Zero && SetCullingField_Culling_IsValid && SetCullingField_Field_IsValid && SetCullingField_Operation_IsValid && SetCullingField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.CullingField:SetCullingField", SetCullingField_IsValid);
	}
}
