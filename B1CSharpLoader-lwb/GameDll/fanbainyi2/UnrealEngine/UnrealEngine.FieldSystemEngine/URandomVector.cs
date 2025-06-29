using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.RandomVector", "FieldSystemEngine", UnrealModuleType.Engine)]
public class URandomVector : UFieldNodeVector
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool SetRandomVector_IsValid;

	private static IntPtr SetRandomVector_FunctionAddress;

	private static int SetRandomVector_ParamsSize;

	private static bool SetRandomVector_Magnitude_IsValid;

	private static FFieldAddress SetRandomVector_Magnitude_PropertyAddress;

	private static int SetRandomVector_Magnitude_Offset;

	private static bool SetRandomVector_ReturnValue_IsValid;

	private static FFieldAddress SetRandomVector_ReturnValue_PropertyAddress;

	private static int SetRandomVector_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RandomVector:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RandomVector:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RandomVector:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.RandomVector:SetRandomVector")]
	public unsafe URandomVector SetRandomVector(float Magnitude)
	{
		CheckDestroyed();
		if (!SetRandomVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.RandomVector:SetRandomVector");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRandomVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRandomVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRandomVector_Magnitude_Offset), 0, SetRandomVector_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRandomVector_FunctionAddress, intPtr, SetRandomVector_ParamsSize);
		return UObjectMarshaler<URandomVector>.FromNative(IntPtr.Add(intPtr, SetRandomVector_ReturnValue_Offset), 0, SetRandomVector_ReturnValue_PropertyAddress.Address);
	}

	static URandomVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URandomVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URandomVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.RandomVector");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		SetRandomVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRandomVector");
		SetRandomVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRandomVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRandomVector_Magnitude_PropertyAddress, SetRandomVector_FunctionAddress, "Magnitude");
		SetRandomVector_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetRandomVector_FunctionAddress, "Magnitude");
		SetRandomVector_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRandomVector_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRandomVector_ReturnValue_PropertyAddress, SetRandomVector_FunctionAddress, "ReturnValue");
		SetRandomVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRandomVector_FunctionAddress, "ReturnValue");
		SetRandomVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRandomVector_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetRandomVector_IsValid = SetRandomVector_FunctionAddress != IntPtr.Zero && SetRandomVector_Magnitude_IsValid && SetRandomVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.RandomVector:SetRandomVector", SetRandomVector_IsValid);
	}
}
