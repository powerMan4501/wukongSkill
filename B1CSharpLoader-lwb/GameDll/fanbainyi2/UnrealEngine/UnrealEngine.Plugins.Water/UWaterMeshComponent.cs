using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Water.WaterMeshComponent", "Water", UnrealModuleType.EnginePlugin)]
public class UWaterMeshComponent : UMeshComponent
{
	private static bool RTWorldLocation_IsValid;

	private static int RTWorldLocation_Offset;

	private static bool RTWorldSizeVector_IsValid;

	private static int RTWorldSizeVector_Offset;

	private static bool IsEnabled_IsValid;

	private static IntPtr IsEnabled_FunctionAddress;

	private static int IsEnabled_ParamsSize;

	private static bool IsEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsEnabled_ReturnValue_PropertyAddress;

	private static int IsEnabled_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Water.WaterMeshComponent:RTWorldLocation")]
	public FVector RTWorldLocation
	{
		get
		{
			CheckDestroyed();
			if (!RTWorldLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterMeshComponent:RTWorldLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RTWorldLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RTWorldLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterMeshComponent:RTWorldLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RTWorldLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Water.WaterMeshComponent:RTWorldSizeVector")]
	public FVector RTWorldSizeVector
	{
		get
		{
			CheckDestroyed();
			if (!RTWorldSizeVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterMeshComponent:RTWorldSizeVector");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RTWorldSizeVector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RTWorldSizeVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterMeshComponent:RTWorldSizeVector");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RTWorldSizeVector_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterMeshComponent:IsEnabled")]
	public unsafe bool IsEnabled()
	{
		CheckDestroyed();
		if (!IsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterMeshComponent:IsEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEnabled_FunctionAddress, intPtr, IsEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEnabled_ReturnValue_Offset), 0, IsEnabled_ReturnValue_PropertyAddress.Address);
	}

	static UWaterMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaterMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaterMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Water.WaterMeshComponent");
		RTWorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RTWorldLocation");
		RTWorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RTWorldLocation", Classes.FStructProperty);
		RTWorldSizeVector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RTWorldSizeVector");
		RTWorldSizeVector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RTWorldSizeVector", Classes.FStructProperty);
		IsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEnabled");
		IsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEnabled_ReturnValue_PropertyAddress, IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEnabled_IsValid = IsEnabled_FunctionAddress != IntPtr.Zero && IsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterMeshComponent:IsEnabled", IsEnabled_IsValid);
	}
}
