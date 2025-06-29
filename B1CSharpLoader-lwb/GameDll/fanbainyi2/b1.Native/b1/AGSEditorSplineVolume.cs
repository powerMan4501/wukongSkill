using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSEditorSplineVolume", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSEditorSplineVolume : AVolume
{
	private static bool Spline_IsValid;

	private static int Spline_Offset;

	private static bool EncompassesPointBP_IsValid;

	private static IntPtr EncompassesPointBP_FunctionAddress;

	private static int EncompassesPointBP_ParamsSize;

	private static bool EncompassesPointBP_Point_IsValid;

	private static FFieldAddress EncompassesPointBP_Point_PropertyAddress;

	private static int EncompassesPointBP_Point_Offset;

	private static bool EncompassesPointBP_SphereRadius_IsValid;

	private static FFieldAddress EncompassesPointBP_SphereRadius_PropertyAddress;

	private static int EncompassesPointBP_SphereRadius_Offset;

	private static bool EncompassesPointBP_OutDistanceToPoint_IsValid;

	private static FFieldAddress EncompassesPointBP_OutDistanceToPoint_PropertyAddress;

	private static int EncompassesPointBP_OutDistanceToPoint_Offset;

	private static bool EncompassesPointBP_ReturnValue_IsValid;

	private static FFieldAddress EncompassesPointBP_ReturnValue_PropertyAddress;

	private static int EncompassesPointBP_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSplineVolume:Spline")]
	public USplineComponent Spline
	{
		get
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorSplineVolume:Spline");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, Spline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorSplineVolume:Spline");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, Spline_Offset), value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSplineVolume:EncompassesPointBP")]
	public unsafe bool EncompassesPointBP(FVector Point, float SphereRadius, out float OutDistanceToPoint)
	{
		CheckDestroyed();
		if (!EncompassesPointBP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSplineVolume:EncompassesPointBP");
			OutDistanceToPoint = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EncompassesPointBP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EncompassesPointBP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, EncompassesPointBP_Point_Offset), 0, EncompassesPointBP_Point_PropertyAddress.Address, Point);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EncompassesPointBP_SphereRadius_Offset), 0, EncompassesPointBP_SphereRadius_PropertyAddress.Address, SphereRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, EncompassesPointBP_FunctionAddress, intPtr, EncompassesPointBP_ParamsSize);
		OutDistanceToPoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, EncompassesPointBP_OutDistanceToPoint_Offset), 0, EncompassesPointBP_OutDistanceToPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EncompassesPointBP_ReturnValue_Offset), 0, EncompassesPointBP_ReturnValue_PropertyAddress.Address);
	}

	static AGSEditorSplineVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSEditorSplineVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSEditorSplineVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorSplineVolume");
		Spline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Spline");
		Spline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Spline", Classes.FObjectProperty);
		EncompassesPointBP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EncompassesPointBP");
		EncompassesPointBP_ParamsSize = NativeReflection.GetFunctionParamsSize(EncompassesPointBP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPointBP_Point_PropertyAddress, EncompassesPointBP_FunctionAddress, "Point");
		EncompassesPointBP_Point_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPointBP_FunctionAddress, "Point");
		EncompassesPointBP_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPointBP_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPointBP_SphereRadius_PropertyAddress, EncompassesPointBP_FunctionAddress, "SphereRadius");
		EncompassesPointBP_SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPointBP_FunctionAddress, "SphereRadius");
		EncompassesPointBP_SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPointBP_FunctionAddress, "SphereRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPointBP_OutDistanceToPoint_PropertyAddress, EncompassesPointBP_FunctionAddress, "OutDistanceToPoint");
		EncompassesPointBP_OutDistanceToPoint_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPointBP_FunctionAddress, "OutDistanceToPoint");
		EncompassesPointBP_OutDistanceToPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPointBP_FunctionAddress, "OutDistanceToPoint", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EncompassesPointBP_ReturnValue_PropertyAddress, EncompassesPointBP_FunctionAddress, "ReturnValue");
		EncompassesPointBP_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EncompassesPointBP_FunctionAddress, "ReturnValue");
		EncompassesPointBP_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EncompassesPointBP_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EncompassesPointBP_IsValid = EncompassesPointBP_FunctionAddress != IntPtr.Zero && EncompassesPointBP_Point_IsValid && EncompassesPointBP_SphereRadius_IsValid && EncompassesPointBP_OutDistanceToPoint_IsValid && EncompassesPointBP_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSplineVolume:EncompassesPointBP", EncompassesPointBP_IsValid);
	}
}
