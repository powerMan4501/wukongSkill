using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.UniformInteger", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UUniformInteger : UFieldNodeInt
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool SetUniformInteger_IsValid;

	private static IntPtr SetUniformInteger_FunctionAddress;

	private static int SetUniformInteger_ParamsSize;

	private static bool SetUniformInteger_Magnitude_IsValid;

	private static FFieldAddress SetUniformInteger_Magnitude_PropertyAddress;

	private static int SetUniformInteger_Magnitude_Offset;

	private static bool SetUniformInteger_ReturnValue_IsValid;

	private static FFieldAddress SetUniformInteger_ReturnValue_PropertyAddress;

	private static int SetUniformInteger_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.UniformInteger:Magnitude")]
	public int Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformInteger:Magnitude");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformInteger:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.UniformInteger:SetUniformInteger")]
	public unsafe UUniformInteger SetUniformInteger(int Magnitude)
	{
		CheckDestroyed();
		if (!SetUniformInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.UniformInteger:SetUniformInteger");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUniformInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUniformInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUniformInteger_Magnitude_Offset), 0, SetUniformInteger_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUniformInteger_FunctionAddress, intPtr, SetUniformInteger_ParamsSize);
		return UObjectMarshaler<UUniformInteger>.FromNative(IntPtr.Add(intPtr, SetUniformInteger_ReturnValue_Offset), 0, SetUniformInteger_ReturnValue_PropertyAddress.Address);
	}

	static UUniformInteger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUniformInteger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUniformInteger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.UniformInteger");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FIntProperty);
		SetUniformInteger_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUniformInteger");
		SetUniformInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUniformInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUniformInteger_Magnitude_PropertyAddress, SetUniformInteger_FunctionAddress, "Magnitude");
		SetUniformInteger_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformInteger_FunctionAddress, "Magnitude");
		SetUniformInteger_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformInteger_FunctionAddress, "Magnitude", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUniformInteger_ReturnValue_PropertyAddress, SetUniformInteger_FunctionAddress, "ReturnValue");
		SetUniformInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformInteger_FunctionAddress, "ReturnValue");
		SetUniformInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformInteger_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetUniformInteger_IsValid = SetUniformInteger_FunctionAddress != IntPtr.Zero && SetUniformInteger_Magnitude_IsValid && SetUniformInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.UniformInteger:SetUniformInteger", SetUniformInteger_IsValid);
	}
}
