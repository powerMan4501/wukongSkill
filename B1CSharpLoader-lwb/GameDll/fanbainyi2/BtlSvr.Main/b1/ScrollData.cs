using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ScrollData")]
public struct ScrollData
{
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("最大速度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ScrollData:MaxSpeed")]
	public float MaxSpeed;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("阻力")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ScrollData:Resistance")]
	public float Resistance;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("二阶运动参数|使用二阶运动")]
	[USharpPath("/Script/b1-Managed.ScrollData:UseSecOrdDyn")]
	public bool UseSecOrdDyn;

	[UMeta(MDProp.EditCondition, "UseSecOrdDyn")]
	[Tooltip("二阶运动参数|频率")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ScrollData:Frequency")]
	public float Frequency;

	[Tooltip("二阶运动参数|阻尼")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseSecOrdDyn")]
	[USharpPath("/Script/b1-Managed.ScrollData:Damping")]
	public float Damping;

	[UMeta(MDProp.EditCondition, "UseSecOrdDyn")]
	[Tooltip("二阶运动参数|初始响应")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ScrollData:InitResponse")]
	public float InitResponse;

	private static int ScrollData_StructSize;

	private static int ScrollData_IsValid;

	private static bool MaxSpeed_IsValid;

	private static int MaxSpeed_Offset;

	private static bool Resistance_IsValid;

	private static int Resistance_Offset;

	private static bool UseSecOrdDyn_IsValid;

	private static int UseSecOrdDyn_Offset;

	private static FFieldAddress UseSecOrdDyn_PropertyAddress;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	private static bool Damping_IsValid;

	private static int Damping_Offset;

	private static bool InitResponse_IsValid;

	private static int InitResponse_Offset;

	public ScrollData Copy()
	{
		return this;
	}

	public static ScrollData FromNative(IntPtr nativeBuffer)
	{
		return new ScrollData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ScrollData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ScrollData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ScrollData(IntPtr.Add(nativeBuffer, arrayIndex * ScrollData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ScrollData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ScrollData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ScrollData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ScrollData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSpeed_Offset), MaxSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Resistance_Offset), Resistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSecOrdDyn_Offset), 0, UseSecOrdDyn_PropertyAddress.Address, UseSecOrdDyn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Damping_Offset), Damping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InitResponse_Offset), InitResponse);
	}

	public ScrollData(IntPtr nativeStruct)
	{
		if (ScrollData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ScrollData");
			MaxSpeed = 0f;
			Resistance = 0f;
			UseSecOrdDyn = false;
			Frequency = 0f;
			Damping = 0f;
			InitResponse = 0f;
		}
		else
		{
			MaxSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSpeed_Offset));
			Resistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Resistance_Offset));
			UseSecOrdDyn = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSecOrdDyn_Offset), 0, UseSecOrdDyn_PropertyAddress.Address);
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Damping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Damping_Offset));
			InitResponse = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InitResponse_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ScrollData");
		ScrollData_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSpeed");
		MaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSpeed", Classes.FFloatProperty);
		Resistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "Resistance");
		Resistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Resistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseSecOrdDyn_PropertyAddress, intPtr, "UseSecOrdDyn");
		UseSecOrdDyn_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSecOrdDyn");
		UseSecOrdDyn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSecOrdDyn", Classes.FBoolProperty);
		Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Damping_Offset = NativeReflection.GetPropertyOffset(intPtr, "Damping");
		Damping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Damping", Classes.FFloatProperty);
		InitResponse_Offset = NativeReflection.GetPropertyOffset(intPtr, "InitResponse");
		InitResponse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InitResponse", Classes.FFloatProperty);
		ScrollData_IsValid = ((intPtr != IntPtr.Zero && MaxSpeed_IsValid && Resistance_IsValid && UseSecOrdDyn_IsValid && Frequency_IsValid && Damping_IsValid && InitResponse_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ScrollData", (byte)ScrollData_IsValid != 0);
	}

	static ScrollData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ScrollData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ScrollData));
	}
}
