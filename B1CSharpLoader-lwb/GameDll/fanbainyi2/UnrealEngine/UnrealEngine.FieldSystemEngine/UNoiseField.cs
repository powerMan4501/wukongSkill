using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.NoiseField", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UNoiseField : UFieldNodeFloat
{
	private static bool MinRange_IsValid;

	private static int MinRange_Offset;

	private static bool MaxRange_IsValid;

	private static int MaxRange_Offset;

	private static bool Transform_IsValid;

	private static int Transform_Offset;

	private static bool SetNoiseField_IsValid;

	private static IntPtr SetNoiseField_FunctionAddress;

	private static int SetNoiseField_ParamsSize;

	private static bool SetNoiseField_MinRange_IsValid;

	private static FFieldAddress SetNoiseField_MinRange_PropertyAddress;

	private static int SetNoiseField_MinRange_Offset;

	private static bool SetNoiseField_MaxRange_IsValid;

	private static FFieldAddress SetNoiseField_MaxRange_PropertyAddress;

	private static int SetNoiseField_MaxRange_Offset;

	private static bool SetNoiseField_Transform_IsValid;

	private static FFieldAddress SetNoiseField_Transform_PropertyAddress;

	private static int SetNoiseField_Transform_Offset;

	private static bool SetNoiseField_ReturnValue_IsValid;

	private static FFieldAddress SetNoiseField_ReturnValue_PropertyAddress;

	private static int SetNoiseField_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.NoiseField:MinRange")]
	public float MinRange
	{
		get
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.NoiseField:MinRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.NoiseField:MinRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.NoiseField:MaxRange")]
	public float MaxRange
	{
		get
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.NoiseField:MaxRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.NoiseField:MaxRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/FieldSystemEngine.NoiseField:Transform")]
	public FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.NoiseField:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.NoiseField:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.NoiseField:SetNoiseField")]
	public unsafe UNoiseField SetNoiseField(float MinRange, float MaxRange, FTransform Transform)
	{
		CheckDestroyed();
		if (!SetNoiseField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.NoiseField:SetNoiseField");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNoiseField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNoiseField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNoiseField_MinRange_Offset), 0, SetNoiseField_MinRange_PropertyAddress.Address, MinRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNoiseField_MaxRange_Offset), 0, SetNoiseField_MaxRange_PropertyAddress.Address, MaxRange);
		NativeReflection.InitializeValue_InContainer(SetNoiseField_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetNoiseField_Transform_Offset), 0, SetNoiseField_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNoiseField_FunctionAddress, intPtr, SetNoiseField_ParamsSize);
		return UObjectMarshaler<UNoiseField>.FromNative(IntPtr.Add(intPtr, SetNoiseField_ReturnValue_Offset), 0, SetNoiseField_ReturnValue_PropertyAddress.Address);
	}

	static UNoiseField()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNoiseField)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNoiseField));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.NoiseField");
		MinRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinRange");
		MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinRange", Classes.FFloatProperty);
		MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRange");
		MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRange", Classes.FFloatProperty);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		SetNoiseField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNoiseField");
		SetNoiseField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNoiseField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNoiseField_MinRange_PropertyAddress, SetNoiseField_FunctionAddress, "MinRange");
		SetNoiseField_MinRange_Offset = NativeReflectionCached.GetPropertyOffset(SetNoiseField_FunctionAddress, "MinRange");
		SetNoiseField_MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNoiseField_FunctionAddress, "MinRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNoiseField_MaxRange_PropertyAddress, SetNoiseField_FunctionAddress, "MaxRange");
		SetNoiseField_MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(SetNoiseField_FunctionAddress, "MaxRange");
		SetNoiseField_MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNoiseField_FunctionAddress, "MaxRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNoiseField_Transform_PropertyAddress, SetNoiseField_FunctionAddress, "Transform");
		SetNoiseField_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SetNoiseField_FunctionAddress, "Transform");
		SetNoiseField_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNoiseField_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNoiseField_ReturnValue_PropertyAddress, SetNoiseField_FunctionAddress, "ReturnValue");
		SetNoiseField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNoiseField_FunctionAddress, "ReturnValue");
		SetNoiseField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNoiseField_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetNoiseField_IsValid = SetNoiseField_FunctionAddress != IntPtr.Zero && SetNoiseField_MinRange_IsValid && SetNoiseField_MaxRange_IsValid && SetNoiseField_Transform_IsValid && SetNoiseField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.NoiseField:SetNoiseField", SetNoiseField_IsValid);
	}
}
