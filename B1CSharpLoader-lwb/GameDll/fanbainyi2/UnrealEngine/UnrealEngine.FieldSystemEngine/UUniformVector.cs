using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.UniformVector", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UUniformVector : UFieldNodeVector
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool Direction_IsValid;

	private static int Direction_Offset;

	private static bool SetUniformVector_IsValid;

	private static IntPtr SetUniformVector_FunctionAddress;

	private static int SetUniformVector_ParamsSize;

	private static bool SetUniformVector_Magnitude_IsValid;

	private static FFieldAddress SetUniformVector_Magnitude_PropertyAddress;

	private static int SetUniformVector_Magnitude_Offset;

	private static bool SetUniformVector_Direction_IsValid;

	private static FFieldAddress SetUniformVector_Direction_PropertyAddress;

	private static int SetUniformVector_Direction_Offset;

	private static bool SetUniformVector_ReturnValue_IsValid;

	private static FFieldAddress SetUniformVector_ReturnValue_PropertyAddress;

	private static int SetUniformVector_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.UniformVector:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformVector:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformVector:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.UniformVector:Direction")]
	public FVector Direction
	{
		get
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformVector:Direction");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Direction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.UniformVector:Direction");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Direction_Offset), value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.UniformVector:SetUniformVector")]
	public unsafe UUniformVector SetUniformVector(float Magnitude, FVector Direction)
	{
		CheckDestroyed();
		if (!SetUniformVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.UniformVector:SetUniformVector");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUniformVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUniformVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetUniformVector_Magnitude_Offset), 0, SetUniformVector_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetUniformVector_Direction_Offset), 0, SetUniformVector_Direction_PropertyAddress.Address, Direction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUniformVector_FunctionAddress, intPtr, SetUniformVector_ParamsSize);
		return UObjectMarshaler<UUniformVector>.FromNative(IntPtr.Add(intPtr, SetUniformVector_ReturnValue_Offset), 0, SetUniformVector_ReturnValue_PropertyAddress.Address);
	}

	static UUniformVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUniformVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUniformVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.UniformVector");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FStructProperty);
		SetUniformVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUniformVector");
		SetUniformVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUniformVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUniformVector_Magnitude_PropertyAddress, SetUniformVector_FunctionAddress, "Magnitude");
		SetUniformVector_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformVector_FunctionAddress, "Magnitude");
		SetUniformVector_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformVector_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUniformVector_Direction_PropertyAddress, SetUniformVector_FunctionAddress, "Direction");
		SetUniformVector_Direction_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformVector_FunctionAddress, "Direction");
		SetUniformVector_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformVector_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUniformVector_ReturnValue_PropertyAddress, SetUniformVector_FunctionAddress, "ReturnValue");
		SetUniformVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUniformVector_FunctionAddress, "ReturnValue");
		SetUniformVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUniformVector_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetUniformVector_IsValid = SetUniformVector_FunctionAddress != IntPtr.Zero && SetUniformVector_Magnitude_IsValid && SetUniformVector_Direction_IsValid && SetUniformVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.UniformVector:SetUniformVector", SetUniformVector_IsValid);
	}
}
