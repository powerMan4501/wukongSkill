using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.ToFloatField", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UToFloatField : UFieldNodeFloat
{
	private static bool IntField_IsValid;

	private static int IntField_Offset;

	private static bool SetToFloatField_IsValid;

	private static IntPtr SetToFloatField_FunctionAddress;

	private static int SetToFloatField_ParamsSize;

	private static bool SetToFloatField_IntegerField_IsValid;

	private static FFieldAddress SetToFloatField_IntegerField_PropertyAddress;

	private static int SetToFloatField_IntegerField_Offset;

	private static bool SetToFloatField_ReturnValue_IsValid;

	private static FFieldAddress SetToFloatField_ReturnValue_PropertyAddress;

	private static int SetToFloatField_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/FieldSystemEngine.ToFloatField:IntField")]
	public UFieldNodeInt IntField
	{
		get
		{
			CheckDestroyed();
			if (!IntField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.ToFloatField:IntField");
				return null;
			}
			return UObjectMarshaler<UFieldNodeInt>.FromNative(IntPtr.Add(base.Address, IntField_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.ToFloatField:IntField");
			}
			else
			{
				UObjectMarshaler<UFieldNodeInt>.ToNative(IntPtr.Add(base.Address, IntField_Offset), value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.ToFloatField:SetToFloatField")]
	public unsafe UToFloatField SetToFloatField(UFieldNodeInt IntegerField)
	{
		CheckDestroyed();
		if (!SetToFloatField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.ToFloatField:SetToFloatField");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetToFloatField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetToFloatField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFieldNodeInt>.ToNative(IntPtr.Add(intPtr, SetToFloatField_IntegerField_Offset), 0, SetToFloatField_IntegerField_PropertyAddress.Address, IntegerField);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetToFloatField_FunctionAddress, intPtr, SetToFloatField_ParamsSize);
		return UObjectMarshaler<UToFloatField>.FromNative(IntPtr.Add(intPtr, SetToFloatField_ReturnValue_Offset), 0, SetToFloatField_ReturnValue_PropertyAddress.Address);
	}

	static UToFloatField()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UToFloatField)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UToFloatField));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.ToFloatField");
		IntField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntField");
		IntField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntField", Classes.FObjectProperty);
		SetToFloatField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetToFloatField");
		SetToFloatField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetToFloatField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetToFloatField_IntegerField_PropertyAddress, SetToFloatField_FunctionAddress, "IntegerField");
		SetToFloatField_IntegerField_Offset = NativeReflectionCached.GetPropertyOffset(SetToFloatField_FunctionAddress, "IntegerField");
		SetToFloatField_IntegerField_IsValid = NativeReflectionCached.ValidatePropertyClass(SetToFloatField_FunctionAddress, "IntegerField", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetToFloatField_ReturnValue_PropertyAddress, SetToFloatField_FunctionAddress, "ReturnValue");
		SetToFloatField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetToFloatField_FunctionAddress, "ReturnValue");
		SetToFloatField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetToFloatField_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetToFloatField_IsValid = SetToFloatField_FunctionAddress != IntPtr.Zero && SetToFloatField_IntegerField_IsValid && SetToFloatField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.ToFloatField:SetToFloatField", SetToFloatField_IsValid);
	}
}
