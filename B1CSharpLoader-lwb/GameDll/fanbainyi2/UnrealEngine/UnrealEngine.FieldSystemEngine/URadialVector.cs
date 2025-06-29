using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.RadialVector", "FieldSystemEngine", UnrealModuleType.Engine)]
public class URadialVector : UFieldNodeVector
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool Position_IsValid;

	private static int Position_Offset;

	private static bool SetRadialVector_IsValid;

	private static IntPtr SetRadialVector_FunctionAddress;

	private static int SetRadialVector_ParamsSize;

	private static bool SetRadialVector_Magnitude_IsValid;

	private static FFieldAddress SetRadialVector_Magnitude_PropertyAddress;

	private static int SetRadialVector_Magnitude_Offset;

	private static bool SetRadialVector_Position_IsValid;

	private static FFieldAddress SetRadialVector_Position_PropertyAddress;

	private static int SetRadialVector_Position_Offset;

	private static bool SetRadialVector_ReturnValue_IsValid;

	private static FFieldAddress SetRadialVector_ReturnValue_PropertyAddress;

	private static int SetRadialVector_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialVector:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialVector:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialVector:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialVector:Position")]
	public FVector Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialVector:Position");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Position_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialVector:Position");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Position_Offset), value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.RadialVector:SetRadialVector")]
	public unsafe URadialVector SetRadialVector(float Magnitude, FVector Position)
	{
		CheckDestroyed();
		if (!SetRadialVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.RadialVector:SetRadialVector");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadialVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadialVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialVector_Magnitude_Offset), 0, SetRadialVector_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRadialVector_Position_Offset), 0, SetRadialVector_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadialVector_FunctionAddress, intPtr, SetRadialVector_ParamsSize);
		return UObjectMarshaler<URadialVector>.FromNative(IntPtr.Add(intPtr, SetRadialVector_ReturnValue_Offset), 0, SetRadialVector_ReturnValue_PropertyAddress.Address);
	}

	static URadialVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URadialVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URadialVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.RadialVector");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		SetRadialVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadialVector");
		SetRadialVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadialVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadialVector_Magnitude_PropertyAddress, SetRadialVector_FunctionAddress, "Magnitude");
		SetRadialVector_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialVector_FunctionAddress, "Magnitude");
		SetRadialVector_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialVector_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialVector_Position_PropertyAddress, SetRadialVector_FunctionAddress, "Position");
		SetRadialVector_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialVector_FunctionAddress, "Position");
		SetRadialVector_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialVector_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialVector_ReturnValue_PropertyAddress, SetRadialVector_FunctionAddress, "ReturnValue");
		SetRadialVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialVector_FunctionAddress, "ReturnValue");
		SetRadialVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialVector_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetRadialVector_IsValid = SetRadialVector_FunctionAddress != IntPtr.Zero && SetRadialVector_Magnitude_IsValid && SetRadialVector_Position_IsValid && SetRadialVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.RadialVector:SetRadialVector", SetRadialVector_IsValid);
	}
}
