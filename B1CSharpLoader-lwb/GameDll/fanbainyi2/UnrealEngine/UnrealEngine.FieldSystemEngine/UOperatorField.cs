using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.OperatorField", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UOperatorField : UFieldNodeBase
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool RightField_IsValid;

	private static int RightField_Offset;

	private static bool LeftField_IsValid;

	private static int LeftField_Offset;

	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool SetOperatorField_IsValid;

	private static IntPtr SetOperatorField_FunctionAddress;

	private static int SetOperatorField_ParamsSize;

	private static bool SetOperatorField_Magnitude_IsValid;

	private static FFieldAddress SetOperatorField_Magnitude_PropertyAddress;

	private static int SetOperatorField_Magnitude_Offset;

	private static bool SetOperatorField_LeftField_IsValid;

	private static FFieldAddress SetOperatorField_LeftField_PropertyAddress;

	private static int SetOperatorField_LeftField_Offset;

	private static bool SetOperatorField_RightField_IsValid;

	private static FFieldAddress SetOperatorField_RightField_PropertyAddress;

	private static int SetOperatorField_RightField_Offset;

	private static bool SetOperatorField_Operation_IsValid;

	private static FFieldAddress SetOperatorField_Operation_PropertyAddress;

	private static int SetOperatorField_Operation_Offset;

	private static bool SetOperatorField_ReturnValue_IsValid;

	private static FFieldAddress SetOperatorField_ReturnValue_PropertyAddress;

	private static int SetOperatorField_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.OperatorField:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/FieldSystemEngine.OperatorField:RightField")]
	public UFieldNodeBase RightField
	{
		get
		{
			CheckDestroyed();
			if (!RightField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:RightField");
				return null;
			}
			return UObjectMarshaler<UFieldNodeBase>.FromNative(IntPtr.Add(base.Address, RightField_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:RightField");
			}
			else
			{
				UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(base.Address, RightField_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/FieldSystemEngine.OperatorField:LeftField")]
	public UFieldNodeBase LeftField
	{
		get
		{
			CheckDestroyed();
			if (!LeftField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:LeftField");
				return null;
			}
			return UObjectMarshaler<UFieldNodeBase>.FromNative(IntPtr.Add(base.Address, LeftField_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:LeftField");
			}
			else
			{
				UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(base.Address, LeftField_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.OperatorField:Operation")]
	public EFieldOperationType Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:Operation");
				return EFieldOperationType.Field_Multiply;
			}
			return EnumMarshaler<EFieldOperationType>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.OperatorField:Operation");
			}
			else
			{
				EnumMarshaler<EFieldOperationType>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.OperatorField:SetOperatorField")]
	public unsafe UOperatorField SetOperatorField(float Magnitude, UFieldNodeBase LeftField, UFieldNodeBase RightField, EFieldOperationType Operation)
	{
		CheckDestroyed();
		if (!SetOperatorField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.OperatorField:SetOperatorField");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOperatorField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOperatorField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOperatorField_Magnitude_Offset), 0, SetOperatorField_Magnitude_PropertyAddress.Address, Magnitude);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, SetOperatorField_LeftField_Offset), 0, SetOperatorField_LeftField_PropertyAddress.Address, LeftField);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, SetOperatorField_RightField_Offset), 0, SetOperatorField_RightField_PropertyAddress.Address, RightField);
		EnumMarshaler<EFieldOperationType>.ToNative(IntPtr.Add(intPtr, SetOperatorField_Operation_Offset), 0, SetOperatorField_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOperatorField_FunctionAddress, intPtr, SetOperatorField_ParamsSize);
		return UObjectMarshaler<UOperatorField>.FromNative(IntPtr.Add(intPtr, SetOperatorField_ReturnValue_Offset), 0, SetOperatorField_ReturnValue_PropertyAddress.Address);
	}

	static UOperatorField()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOperatorField)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOperatorField));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.OperatorField");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		RightField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightField");
		RightField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightField", Classes.FObjectProperty);
		LeftField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftField");
		LeftField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftField", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, intPtr, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Operation", Classes.FByteProperty);
		SetOperatorField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOperatorField");
		SetOperatorField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOperatorField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOperatorField_Magnitude_PropertyAddress, SetOperatorField_FunctionAddress, "Magnitude");
		SetOperatorField_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetOperatorField_FunctionAddress, "Magnitude");
		SetOperatorField_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOperatorField_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOperatorField_LeftField_PropertyAddress, SetOperatorField_FunctionAddress, "LeftField");
		SetOperatorField_LeftField_Offset = NativeReflectionCached.GetPropertyOffset(SetOperatorField_FunctionAddress, "LeftField");
		SetOperatorField_LeftField_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOperatorField_FunctionAddress, "LeftField", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOperatorField_RightField_PropertyAddress, SetOperatorField_FunctionAddress, "RightField");
		SetOperatorField_RightField_Offset = NativeReflectionCached.GetPropertyOffset(SetOperatorField_FunctionAddress, "RightField");
		SetOperatorField_RightField_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOperatorField_FunctionAddress, "RightField", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOperatorField_Operation_PropertyAddress, SetOperatorField_FunctionAddress, "Operation");
		SetOperatorField_Operation_Offset = NativeReflectionCached.GetPropertyOffset(SetOperatorField_FunctionAddress, "Operation");
		SetOperatorField_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOperatorField_FunctionAddress, "Operation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOperatorField_ReturnValue_PropertyAddress, SetOperatorField_FunctionAddress, "ReturnValue");
		SetOperatorField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOperatorField_FunctionAddress, "ReturnValue");
		SetOperatorField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOperatorField_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetOperatorField_IsValid = SetOperatorField_FunctionAddress != IntPtr.Zero && SetOperatorField_Magnitude_IsValid && SetOperatorField_LeftField_IsValid && SetOperatorField_RightField_IsValid && SetOperatorField_Operation_IsValid && SetOperatorField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.OperatorField:SetOperatorField", SetOperatorField_IsValid);
	}
}
