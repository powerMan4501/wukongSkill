using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.VectorFieldComponent", "Engine", UnrealModuleType.Engine)]
public class UVectorFieldComponent : UPrimitiveComponent
{
	private static bool VectorField_IsValid;

	private static int VectorField_Offset;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	private static bool Tightness_IsValid;

	private static int Tightness_Offset;

	private static bool SetIntensity_IsValid;

	private static IntPtr SetIntensity_FunctionAddress;

	private static int SetIntensity_ParamsSize;

	private static bool SetIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetIntensity_NewIntensity_PropertyAddress;

	private static int SetIntensity_NewIntensity_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.VectorFieldComponent:VectorField")]
	public UVectorField VectorField
	{
		get
		{
			CheckDestroyed();
			if (!VectorField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldComponent:VectorField");
				return null;
			}
			return UObjectMarshaler<UVectorField>.FromNative(IntPtr.Add(base.Address, VectorField_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VectorField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldComponent:VectorField");
			}
			else
			{
				UObjectMarshaler<UVectorField>.ToNative(IntPtr.Add(base.Address, VectorField_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.VectorFieldComponent:Intensity")]
	public float Intensity
	{
		get
		{
			CheckDestroyed();
			if (!Intensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldComponent:Intensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Intensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Intensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldComponent:Intensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Intensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.VectorFieldComponent:Tightness")]
	public float Tightness
	{
		get
		{
			CheckDestroyed();
			if (!Tightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldComponent:Tightness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Tightness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldComponent:Tightness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Tightness_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.VectorFieldComponent:SetIntensity")]
	public unsafe void SetIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VectorFieldComponent:SetIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIntensity_NewIntensity_Offset), 0, SetIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntensity_FunctionAddress, intPtr, SetIntensity_ParamsSize);
	}

	static UVectorFieldComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVectorFieldComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVectorFieldComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.VectorFieldComponent");
		VectorField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VectorField");
		VectorField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VectorField", Classes.FObjectProperty);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		Tightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tightness");
		Tightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tightness", Classes.FFloatProperty);
		SetIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIntensity");
		SetIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntensity_NewIntensity_PropertyAddress, SetIntensity_FunctionAddress, "NewIntensity");
		SetIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetIntensity_FunctionAddress, "NewIntensity");
		SetIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetIntensity_IsValid = SetIntensity_FunctionAddress != IntPtr.Zero && SetIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VectorFieldComponent:SetIntensity", SetIntensity_IsValid);
	}
}
