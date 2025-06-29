using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWSplinePrismVolume", "b1", UnrealModuleType.Game)]
public class ABGWSplinePrismVolume : AVolume
{
	private static bool Spline_IsValid;

	private static int Spline_Offset;

	private static bool MidPoint_IsValid;

	private static int MidPoint_Offset;

	private static bool EncompassesPoint_IsValid;

	private static IntPtr EncompassesPoint_FunctionAddress;

	private static int EncompassesPoint_ParamsSize;

	private static bool EncompassesPoint_InPoint_IsValid;

	private static FFieldAddress EncompassesPoint_InPoint_PropertyAddress;

	private static int EncompassesPoint_InPoint_Offset;

	private static bool EncompassesPoint_OutDistanceToPoint_IsValid;

	private static FFieldAddress EncompassesPoint_OutDistanceToPoint_PropertyAddress;

	private static int EncompassesPoint_OutDistanceToPoint_Offset;

	private static bool EncompassesPoint_SphereRadius_IsValid;

	private static FFieldAddress EncompassesPoint_SphereRadius_PropertyAddress;

	private static int EncompassesPoint_SphereRadius_Offset;

	private static bool EncompassesPoint_ReturnValue_IsValid;

	private static FFieldAddress EncompassesPoint_ReturnValue_PropertyAddress;

	private static int EncompassesPoint_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/b1.BGWSplinePrismVolume:Spline")]
	public USplineComponent Spline
	{
		get
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSplinePrismVolume:Spline");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, Spline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSplinePrismVolume:Spline");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, Spline_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/b1.BGWSplinePrismVolume:MidPoint")]
	public USphereComponent MidPoint
	{
		get
		{
			CheckDestroyed();
			if (!MidPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSplinePrismVolume:MidPoint");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, MidPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MidPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSplinePrismVolume:MidPoint");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, MidPoint_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1422001153u, OriginalName = "K2_EncompassesPoint")]
	[UMetaPath("/Script/b1.BGWSplinePrismVolume:K2_EncompassesPoint")]
	public unsafe bool EncompassesPoint(FVector InPoint, out float OutDistanceToPoint, float SphereRadius = 0f)
	{
		CheckDestroyed();
		if (!EncompassesPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWSplinePrismVolume:K2_EncompassesPoint");
			OutDistanceToPoint = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EncompassesPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EncompassesPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, EncompassesPoint_InPoint_Offset), 0, EncompassesPoint_InPoint_PropertyAddress.Address, InPoint);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EncompassesPoint_SphereRadius_Offset), 0, EncompassesPoint_SphereRadius_PropertyAddress.Address, SphereRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, EncompassesPoint_FunctionAddress, intPtr, EncompassesPoint_ParamsSize);
		OutDistanceToPoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, EncompassesPoint_OutDistanceToPoint_Offset), 0, EncompassesPoint_OutDistanceToPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EncompassesPoint_ReturnValue_Offset), 0, EncompassesPoint_ReturnValue_PropertyAddress.Address);
	}

	static ABGWSplinePrismVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWSplinePrismVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWSplinePrismVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGWSplinePrismVolume");
		Spline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Spline");
		Spline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Spline", Classes.FObjectProperty);
		MidPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MidPoint");
		MidPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MidPoint", Classes.FObjectProperty);
		EncompassesPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_EncompassesPoint");
		EncompassesPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(EncompassesPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPoint_InPoint_PropertyAddress, EncompassesPoint_FunctionAddress, "InPoint");
		EncompassesPoint_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPoint_FunctionAddress, "InPoint");
		EncompassesPoint_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPoint_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPoint_OutDistanceToPoint_PropertyAddress, EncompassesPoint_FunctionAddress, "OutDistanceToPoint");
		EncompassesPoint_OutDistanceToPoint_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPoint_FunctionAddress, "OutDistanceToPoint");
		EncompassesPoint_OutDistanceToPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPoint_FunctionAddress, "OutDistanceToPoint", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPoint_SphereRadius_PropertyAddress, EncompassesPoint_FunctionAddress, "SphereRadius");
		EncompassesPoint_SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPoint_FunctionAddress, "SphereRadius");
		EncompassesPoint_SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPoint_FunctionAddress, "SphereRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPoint_ReturnValue_PropertyAddress, EncompassesPoint_FunctionAddress, "ReturnValue");
		EncompassesPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPoint_FunctionAddress, "ReturnValue");
		EncompassesPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EncompassesPoint_IsValid = EncompassesPoint_FunctionAddress != IntPtr.Zero && EncompassesPoint_InPoint_IsValid && EncompassesPoint_OutDistanceToPoint_IsValid && EncompassesPoint_SphereRadius_IsValid && EncompassesPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWSplinePrismVolume:K2_EncompassesPoint", EncompassesPoint_IsValid);
	}
}
