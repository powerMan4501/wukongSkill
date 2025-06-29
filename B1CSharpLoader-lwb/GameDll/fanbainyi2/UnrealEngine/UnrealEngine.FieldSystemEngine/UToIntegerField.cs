using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.ToIntegerField", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UToIntegerField : UFieldNodeInt
{
	private static bool FloatField_IsValid;

	private static int FloatField_Offset;

	private static bool SetToIntegerField_IsValid;

	private static IntPtr SetToIntegerField_FunctionAddress;

	private static int SetToIntegerField_ParamsSize;

	private static bool SetToIntegerField_FloatField_IsValid;

	private static FFieldAddress SetToIntegerField_FloatField_PropertyAddress;

	private static int SetToIntegerField_FloatField_Offset;

	private static bool SetToIntegerField_ReturnValue_IsValid;

	private static FFieldAddress SetToIntegerField_ReturnValue_PropertyAddress;

	private static int SetToIntegerField_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/FieldSystemEngine.ToIntegerField:FloatField")]
	public UFieldNodeFloat FloatField
	{
		get
		{
			CheckDestroyed();
			if (!FloatField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.ToIntegerField:FloatField");
				return null;
			}
			return UObjectMarshaler<UFieldNodeFloat>.FromNative(IntPtr.Add(base.Address, FloatField_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloatField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.ToIntegerField:FloatField");
			}
			else
			{
				UObjectMarshaler<UFieldNodeFloat>.ToNative(IntPtr.Add(base.Address, FloatField_Offset), value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.ToIntegerField:SetToIntegerField")]
	public unsafe UToIntegerField SetToIntegerField(UFieldNodeFloat FloatField)
	{
		CheckDestroyed();
		if (!SetToIntegerField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.ToIntegerField:SetToIntegerField");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetToIntegerField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetToIntegerField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFieldNodeFloat>.ToNative(IntPtr.Add(intPtr, SetToIntegerField_FloatField_Offset), 0, SetToIntegerField_FloatField_PropertyAddress.Address, FloatField);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetToIntegerField_FunctionAddress, intPtr, SetToIntegerField_ParamsSize);
		return UObjectMarshaler<UToIntegerField>.FromNative(IntPtr.Add(intPtr, SetToIntegerField_ReturnValue_Offset), 0, SetToIntegerField_ReturnValue_PropertyAddress.Address);
	}

	static UToIntegerField()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UToIntegerField)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UToIntegerField));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.ToIntegerField");
		FloatField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatField");
		FloatField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatField", Classes.FObjectProperty);
		SetToIntegerField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetToIntegerField");
		SetToIntegerField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetToIntegerField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetToIntegerField_FloatField_PropertyAddress, SetToIntegerField_FunctionAddress, "FloatField");
		SetToIntegerField_FloatField_Offset = NativeReflectionCached.GetPropertyOffset(SetToIntegerField_FunctionAddress, "FloatField");
		SetToIntegerField_FloatField_IsValid = NativeReflectionCached.ValidatePropertyClass(SetToIntegerField_FunctionAddress, "FloatField", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetToIntegerField_ReturnValue_PropertyAddress, SetToIntegerField_FunctionAddress, "ReturnValue");
		SetToIntegerField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetToIntegerField_FunctionAddress, "ReturnValue");
		SetToIntegerField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetToIntegerField_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetToIntegerField_IsValid = SetToIntegerField_FunctionAddress != IntPtr.Zero && SetToIntegerField_FloatField_IsValid && SetToIntegerField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.ToIntegerField:SetToIntegerField", SetToIntegerField_IsValid);
	}
}
