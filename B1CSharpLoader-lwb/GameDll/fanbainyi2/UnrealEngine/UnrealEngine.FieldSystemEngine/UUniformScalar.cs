using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.UniformScalar", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UUniformScalar : UFieldNodeFloat
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool SetUniformScalar_IsValid;

	private static IntPtr SetUniformScalar_FunctionAddress;

	private static int SetUniformScalar_ParamsSize;

	private static bool SetUniformScalar_Magnitude_IsValid;

	private static FFieldAddress SetUniformScalar_Magnitude_PropertyAddress;

	private static int SetUniformScalar_Magnitude_Offset;

	private static bool SetUniformScalar_ReturnValue_IsValid;

	private static FFieldAddress SetUniformScalar_ReturnValue_PropertyAddress;

	private static int SetUniformScalar_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.UniformScalar:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformScalar:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformScalar:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.UniformScalar:SetUniformScalar")]
	public unsafe UUniformScalar SetUniformScalar(float Magnitude)
	{
		CheckDestroyed();
		if (!SetUniformScalar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.UniformScalar:SetUniformScalar");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUniformScalar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUniformScalar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetUniformScalar_Magnitude_Offset), 0, SetUniformScalar_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUniformScalar_FunctionAddress, intPtr, SetUniformScalar_ParamsSize);
		return UObjectMarshaler<UUniformScalar>.FromNative(IntPtr.Add(intPtr, SetUniformScalar_ReturnValue_Offset), 0, SetUniformScalar_ReturnValue_PropertyAddress.Address);
	}

	static UUniformScalar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUniformScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUniformScalar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.UniformScalar");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		SetUniformScalar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUniformScalar");
		SetUniformScalar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUniformScalar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUniformScalar_Magnitude_PropertyAddress, SetUniformScalar_FunctionAddress, "Magnitude");
		SetUniformScalar_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformScalar_FunctionAddress, "Magnitude");
		SetUniformScalar_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformScalar_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUniformScalar_ReturnValue_PropertyAddress, SetUniformScalar_FunctionAddress, "ReturnValue");
		SetUniformScalar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformScalar_FunctionAddress, "ReturnValue");
		SetUniformScalar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformScalar_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetUniformScalar_IsValid = SetUniformScalar_FunctionAddress != IntPtr.Zero && SetUniformScalar_Magnitude_IsValid && SetUniformScalar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.UniformScalar:SetUniformScalar", SetUniformScalar_IsValid);
	}
}
