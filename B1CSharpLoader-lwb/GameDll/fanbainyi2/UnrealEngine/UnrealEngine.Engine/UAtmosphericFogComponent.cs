using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820523684uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AtmosphericFogComponent", "Engine", UnrealModuleType.Engine)]
public class UAtmosphericFogComponent : USkyAtmosphereComponent
{
	private static bool SetSunMultiplier_IsValid;

	private static IntPtr SetSunMultiplier_FunctionAddress;

	private static int SetSunMultiplier_ParamsSize;

	private static bool SetSunMultiplier_NewSunMultiplier_IsValid;

	private static FFieldAddress SetSunMultiplier_NewSunMultiplier_PropertyAddress;

	private static int SetSunMultiplier_NewSunMultiplier_Offset;

	private static bool SetStartDistance_IsValid;

	private static IntPtr SetStartDistance_FunctionAddress;

	private static int SetStartDistance_ParamsSize;

	private static bool SetStartDistance_NewStartDistance_IsValid;

	private static FFieldAddress SetStartDistance_NewStartDistance_PropertyAddress;

	private static int SetStartDistance_NewStartDistance_Offset;

	private static bool SetPrecomputeParams_IsValid;

	private static IntPtr SetPrecomputeParams_FunctionAddress;

	private static int SetPrecomputeParams_ParamsSize;

	private static bool SetPrecomputeParams_DensityHeight_IsValid;

	private static FFieldAddress SetPrecomputeParams_DensityHeight_PropertyAddress;

	private static int SetPrecomputeParams_DensityHeight_Offset;

	private static bool SetPrecomputeParams_MaxScatteringOrder_IsValid;

	private static FFieldAddress SetPrecomputeParams_MaxScatteringOrder_PropertyAddress;

	private static int SetPrecomputeParams_MaxScatteringOrder_Offset;

	private static bool SetPrecomputeParams_InscatterAltitudeSampleNum_IsValid;

	private static FFieldAddress SetPrecomputeParams_InscatterAltitudeSampleNum_PropertyAddress;

	private static int SetPrecomputeParams_InscatterAltitudeSampleNum_Offset;

	private static bool SetFogMultiplier_IsValid;

	private static IntPtr SetFogMultiplier_FunctionAddress;

	private static int SetFogMultiplier_ParamsSize;

	private static bool SetFogMultiplier_NewFogMultiplier_IsValid;

	private static FFieldAddress SetFogMultiplier_NewFogMultiplier_PropertyAddress;

	private static int SetFogMultiplier_NewFogMultiplier_Offset;

	private static bool SetDistanceScale_IsValid;

	private static IntPtr SetDistanceScale_FunctionAddress;

	private static int SetDistanceScale_ParamsSize;

	private static bool SetDistanceScale_NewDistanceScale_IsValid;

	private static FFieldAddress SetDistanceScale_NewDistanceScale_PropertyAddress;

	private static int SetDistanceScale_NewDistanceScale_Offset;

	private static bool SetDistanceOffset_IsValid;

	private static IntPtr SetDistanceOffset_FunctionAddress;

	private static int SetDistanceOffset_ParamsSize;

	private static bool SetDistanceOffset_NewDistanceOffset_IsValid;

	private static FFieldAddress SetDistanceOffset_NewDistanceOffset_PropertyAddress;

	private static int SetDistanceOffset_NewDistanceOffset_Offset;

	private static bool SetDensityOffset_IsValid;

	private static IntPtr SetDensityOffset_FunctionAddress;

	private static int SetDensityOffset_ParamsSize;

	private static bool SetDensityOffset_NewDensityOffset_IsValid;

	private static FFieldAddress SetDensityOffset_NewDensityOffset_PropertyAddress;

	private static int SetDensityOffset_NewDensityOffset_Offset;

	private static bool SetDensityMultiplier_IsValid;

	private static IntPtr SetDensityMultiplier_FunctionAddress;

	private static int SetDensityMultiplier_ParamsSize;

	private static bool SetDensityMultiplier_NewDensityMultiplier_IsValid;

	private static FFieldAddress SetDensityMultiplier_NewDensityMultiplier_PropertyAddress;

	private static int SetDensityMultiplier_NewDensityMultiplier_Offset;

	private static bool SetDefaultLightColor_IsValid;

	private static IntPtr SetDefaultLightColor_FunctionAddress;

	private static int SetDefaultLightColor_ParamsSize;

	private static bool SetDefaultLightColor_NewLightColor_IsValid;

	private static FFieldAddress SetDefaultLightColor_NewLightColor_PropertyAddress;

	private static int SetDefaultLightColor_NewLightColor_Offset;

	private static bool SetDefaultBrightness_IsValid;

	private static IntPtr SetDefaultBrightness_FunctionAddress;

	private static int SetDefaultBrightness_ParamsSize;

	private static bool SetDefaultBrightness_NewBrightness_IsValid;

	private static FFieldAddress SetDefaultBrightness_NewBrightness_PropertyAddress;

	private static int SetDefaultBrightness_NewBrightness_Offset;

	private static bool SetAltitudeScale_IsValid;

	private static IntPtr SetAltitudeScale_FunctionAddress;

	private static int SetAltitudeScale_ParamsSize;

	private static bool SetAltitudeScale_NewAltitudeScale_IsValid;

	private static FFieldAddress SetAltitudeScale_NewAltitudeScale_PropertyAddress;

	private static int SetAltitudeScale_NewAltitudeScale_Offset;

	private static bool DisableSunDisk_IsValid;

	private static IntPtr DisableSunDisk_FunctionAddress;

	private static int DisableSunDisk_ParamsSize;

	private static bool DisableSunDisk_NewSunDisk_IsValid;

	private static FFieldAddress DisableSunDisk_NewSunDisk_PropertyAddress;

	private static int DisableSunDisk_NewSunDisk_Offset;

	private static bool DisableGroundScattering_IsValid;

	private static IntPtr DisableGroundScattering_FunctionAddress;

	private static int DisableGroundScattering_ParamsSize;

	private static bool DisableGroundScattering_NewGroundScattering_IsValid;

	private static FFieldAddress DisableGroundScattering_NewGroundScattering_PropertyAddress;

	private static int DisableGroundScattering_NewGroundScattering_Offset;

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetSunMultiplier")]
	public unsafe void SetSunMultiplier(float NewSunMultiplier)
	{
		CheckDestroyed();
		if (!SetSunMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetSunMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSunMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSunMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSunMultiplier_NewSunMultiplier_Offset), 0, SetSunMultiplier_NewSunMultiplier_PropertyAddress.Address, NewSunMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSunMultiplier_FunctionAddress, intPtr, SetSunMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetStartDistance")]
	public unsafe void SetStartDistance(float NewStartDistance)
	{
		CheckDestroyed();
		if (!SetStartDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetStartDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartDistance_NewStartDistance_Offset), 0, SetStartDistance_NewStartDistance_PropertyAddress.Address, NewStartDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartDistance_FunctionAddress, intPtr, SetStartDistance_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetPrecomputeParams")]
	public unsafe void SetPrecomputeParams(float DensityHeight, int MaxScatteringOrder, int InscatterAltitudeSampleNum)
	{
		CheckDestroyed();
		if (!SetPrecomputeParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetPrecomputeParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPrecomputeParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPrecomputeParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPrecomputeParams_DensityHeight_Offset), 0, SetPrecomputeParams_DensityHeight_PropertyAddress.Address, DensityHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPrecomputeParams_MaxScatteringOrder_Offset), 0, SetPrecomputeParams_MaxScatteringOrder_PropertyAddress.Address, MaxScatteringOrder);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPrecomputeParams_InscatterAltitudeSampleNum_Offset), 0, SetPrecomputeParams_InscatterAltitudeSampleNum_PropertyAddress.Address, InscatterAltitudeSampleNum);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPrecomputeParams_FunctionAddress, intPtr, SetPrecomputeParams_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetFogMultiplier")]
	public unsafe void SetFogMultiplier(float NewFogMultiplier)
	{
		CheckDestroyed();
		if (!SetFogMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetFogMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFogMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFogMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFogMultiplier_NewFogMultiplier_Offset), 0, SetFogMultiplier_NewFogMultiplier_PropertyAddress.Address, NewFogMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFogMultiplier_FunctionAddress, intPtr, SetFogMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetDistanceScale")]
	public unsafe void SetDistanceScale(float NewDistanceScale)
	{
		CheckDestroyed();
		if (!SetDistanceScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetDistanceScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDistanceScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDistanceScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDistanceScale_NewDistanceScale_Offset), 0, SetDistanceScale_NewDistanceScale_PropertyAddress.Address, NewDistanceScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDistanceScale_FunctionAddress, intPtr, SetDistanceScale_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetDistanceOffset")]
	public unsafe void SetDistanceOffset(float NewDistanceOffset)
	{
		CheckDestroyed();
		if (!SetDistanceOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetDistanceOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDistanceOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDistanceOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDistanceOffset_NewDistanceOffset_Offset), 0, SetDistanceOffset_NewDistanceOffset_PropertyAddress.Address, NewDistanceOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDistanceOffset_FunctionAddress, intPtr, SetDistanceOffset_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetDensityOffset")]
	public unsafe void SetDensityOffset(float NewDensityOffset)
	{
		CheckDestroyed();
		if (!SetDensityOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetDensityOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDensityOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDensityOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDensityOffset_NewDensityOffset_Offset), 0, SetDensityOffset_NewDensityOffset_PropertyAddress.Address, NewDensityOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDensityOffset_FunctionAddress, intPtr, SetDensityOffset_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetDensityMultiplier")]
	public unsafe void SetDensityMultiplier(float NewDensityMultiplier)
	{
		CheckDestroyed();
		if (!SetDensityMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetDensityMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDensityMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDensityMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDensityMultiplier_NewDensityMultiplier_Offset), 0, SetDensityMultiplier_NewDensityMultiplier_PropertyAddress.Address, NewDensityMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDensityMultiplier_FunctionAddress, intPtr, SetDensityMultiplier_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetDefaultLightColor")]
	public unsafe void SetDefaultLightColor(FLinearColor NewLightColor)
	{
		CheckDestroyed();
		if (!SetDefaultLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetDefaultLightColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultLightColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetDefaultLightColor_NewLightColor_Offset), 0, SetDefaultLightColor_NewLightColor_PropertyAddress.Address, NewLightColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultLightColor_FunctionAddress, intPtr, SetDefaultLightColor_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetDefaultBrightness")]
	public unsafe void SetDefaultBrightness(float NewBrightness)
	{
		CheckDestroyed();
		if (!SetDefaultBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetDefaultBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDefaultBrightness_NewBrightness_Offset), 0, SetDefaultBrightness_NewBrightness_PropertyAddress.Address, NewBrightness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultBrightness_FunctionAddress, intPtr, SetDefaultBrightness_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:SetAltitudeScale")]
	public unsafe void SetAltitudeScale(float NewAltitudeScale)
	{
		CheckDestroyed();
		if (!SetAltitudeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:SetAltitudeScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAltitudeScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAltitudeScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAltitudeScale_NewAltitudeScale_Offset), 0, SetAltitudeScale_NewAltitudeScale_PropertyAddress.Address, NewAltitudeScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAltitudeScale_FunctionAddress, intPtr, SetAltitudeScale_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:DisableSunDisk")]
	public unsafe void DisableSunDisk(bool NewSunDisk)
	{
		CheckDestroyed();
		if (!DisableSunDisk_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:DisableSunDisk");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableSunDisk_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableSunDisk_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DisableSunDisk_NewSunDisk_Offset), 0, DisableSunDisk_NewSunDisk_PropertyAddress.Address, NewSunDisk);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisableSunDisk_FunctionAddress, intPtr, DisableSunDisk_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AtmosphericFogComponent:DisableGroundScattering")]
	public unsafe void DisableGroundScattering(bool NewGroundScattering)
	{
		CheckDestroyed();
		if (!DisableGroundScattering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AtmosphericFogComponent:DisableGroundScattering");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableGroundScattering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableGroundScattering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DisableGroundScattering_NewGroundScattering_Offset), 0, DisableGroundScattering_NewGroundScattering_PropertyAddress.Address, NewGroundScattering);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisableGroundScattering_FunctionAddress, intPtr, DisableGroundScattering_ParamsSize);
	}

	static UAtmosphericFogComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAtmosphericFogComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAtmosphericFogComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AtmosphericFogComponent");
		SetSunMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSunMultiplier");
		SetSunMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSunMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSunMultiplier_NewSunMultiplier_PropertyAddress, SetSunMultiplier_FunctionAddress, "NewSunMultiplier");
		SetSunMultiplier_NewSunMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetSunMultiplier_FunctionAddress, "NewSunMultiplier");
		SetSunMultiplier_NewSunMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSunMultiplier_FunctionAddress, "NewSunMultiplier", Classes.FFloatProperty);
		SetSunMultiplier_IsValid = SetSunMultiplier_FunctionAddress != IntPtr.Zero && SetSunMultiplier_NewSunMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetSunMultiplier", SetSunMultiplier_IsValid);
		SetStartDistance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartDistance");
		SetStartDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartDistance_NewStartDistance_PropertyAddress, SetStartDistance_FunctionAddress, "NewStartDistance");
		SetStartDistance_NewStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetStartDistance_FunctionAddress, "NewStartDistance");
		SetStartDistance_NewStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartDistance_FunctionAddress, "NewStartDistance", Classes.FFloatProperty);
		SetStartDistance_IsValid = SetStartDistance_FunctionAddress != IntPtr.Zero && SetStartDistance_NewStartDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetStartDistance", SetStartDistance_IsValid);
		SetPrecomputeParams_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPrecomputeParams");
		SetPrecomputeParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPrecomputeParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPrecomputeParams_DensityHeight_PropertyAddress, SetPrecomputeParams_FunctionAddress, "DensityHeight");
		SetPrecomputeParams_DensityHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetPrecomputeParams_FunctionAddress, "DensityHeight");
		SetPrecomputeParams_DensityHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPrecomputeParams_FunctionAddress, "DensityHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPrecomputeParams_MaxScatteringOrder_PropertyAddress, SetPrecomputeParams_FunctionAddress, "MaxScatteringOrder");
		SetPrecomputeParams_MaxScatteringOrder_Offset = NativeReflectionCached.GetPropertyOffset(SetPrecomputeParams_FunctionAddress, "MaxScatteringOrder");
		SetPrecomputeParams_MaxScatteringOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPrecomputeParams_FunctionAddress, "MaxScatteringOrder", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPrecomputeParams_InscatterAltitudeSampleNum_PropertyAddress, SetPrecomputeParams_FunctionAddress, "InscatterAltitudeSampleNum");
		SetPrecomputeParams_InscatterAltitudeSampleNum_Offset = NativeReflectionCached.GetPropertyOffset(SetPrecomputeParams_FunctionAddress, "InscatterAltitudeSampleNum");
		SetPrecomputeParams_InscatterAltitudeSampleNum_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPrecomputeParams_FunctionAddress, "InscatterAltitudeSampleNum", Classes.FIntProperty);
		SetPrecomputeParams_IsValid = SetPrecomputeParams_FunctionAddress != IntPtr.Zero && SetPrecomputeParams_DensityHeight_IsValid && SetPrecomputeParams_MaxScatteringOrder_IsValid && SetPrecomputeParams_InscatterAltitudeSampleNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetPrecomputeParams", SetPrecomputeParams_IsValid);
		SetFogMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFogMultiplier");
		SetFogMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFogMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFogMultiplier_NewFogMultiplier_PropertyAddress, SetFogMultiplier_FunctionAddress, "NewFogMultiplier");
		SetFogMultiplier_NewFogMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetFogMultiplier_FunctionAddress, "NewFogMultiplier");
		SetFogMultiplier_NewFogMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFogMultiplier_FunctionAddress, "NewFogMultiplier", Classes.FFloatProperty);
		SetFogMultiplier_IsValid = SetFogMultiplier_FunctionAddress != IntPtr.Zero && SetFogMultiplier_NewFogMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetFogMultiplier", SetFogMultiplier_IsValid);
		SetDistanceScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDistanceScale");
		SetDistanceScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDistanceScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDistanceScale_NewDistanceScale_PropertyAddress, SetDistanceScale_FunctionAddress, "NewDistanceScale");
		SetDistanceScale_NewDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(SetDistanceScale_FunctionAddress, "NewDistanceScale");
		SetDistanceScale_NewDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDistanceScale_FunctionAddress, "NewDistanceScale", Classes.FFloatProperty);
		SetDistanceScale_IsValid = SetDistanceScale_FunctionAddress != IntPtr.Zero && SetDistanceScale_NewDistanceScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetDistanceScale", SetDistanceScale_IsValid);
		SetDistanceOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDistanceOffset");
		SetDistanceOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDistanceOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDistanceOffset_NewDistanceOffset_PropertyAddress, SetDistanceOffset_FunctionAddress, "NewDistanceOffset");
		SetDistanceOffset_NewDistanceOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetDistanceOffset_FunctionAddress, "NewDistanceOffset");
		SetDistanceOffset_NewDistanceOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDistanceOffset_FunctionAddress, "NewDistanceOffset", Classes.FFloatProperty);
		SetDistanceOffset_IsValid = SetDistanceOffset_FunctionAddress != IntPtr.Zero && SetDistanceOffset_NewDistanceOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetDistanceOffset", SetDistanceOffset_IsValid);
		SetDensityOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDensityOffset");
		SetDensityOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDensityOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDensityOffset_NewDensityOffset_PropertyAddress, SetDensityOffset_FunctionAddress, "NewDensityOffset");
		SetDensityOffset_NewDensityOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetDensityOffset_FunctionAddress, "NewDensityOffset");
		SetDensityOffset_NewDensityOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDensityOffset_FunctionAddress, "NewDensityOffset", Classes.FFloatProperty);
		SetDensityOffset_IsValid = SetDensityOffset_FunctionAddress != IntPtr.Zero && SetDensityOffset_NewDensityOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetDensityOffset", SetDensityOffset_IsValid);
		SetDensityMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDensityMultiplier");
		SetDensityMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDensityMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDensityMultiplier_NewDensityMultiplier_PropertyAddress, SetDensityMultiplier_FunctionAddress, "NewDensityMultiplier");
		SetDensityMultiplier_NewDensityMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetDensityMultiplier_FunctionAddress, "NewDensityMultiplier");
		SetDensityMultiplier_NewDensityMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDensityMultiplier_FunctionAddress, "NewDensityMultiplier", Classes.FFloatProperty);
		SetDensityMultiplier_IsValid = SetDensityMultiplier_FunctionAddress != IntPtr.Zero && SetDensityMultiplier_NewDensityMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetDensityMultiplier", SetDensityMultiplier_IsValid);
		SetDefaultLightColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDefaultLightColor");
		SetDefaultLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultLightColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultLightColor_NewLightColor_PropertyAddress, SetDefaultLightColor_FunctionAddress, "NewLightColor");
		SetDefaultLightColor_NewLightColor_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultLightColor_FunctionAddress, "NewLightColor");
		SetDefaultLightColor_NewLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultLightColor_FunctionAddress, "NewLightColor", Classes.FStructProperty);
		SetDefaultLightColor_IsValid = SetDefaultLightColor_FunctionAddress != IntPtr.Zero && SetDefaultLightColor_NewLightColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetDefaultLightColor", SetDefaultLightColor_IsValid);
		SetDefaultBrightness_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDefaultBrightness");
		SetDefaultBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultBrightness_NewBrightness_PropertyAddress, SetDefaultBrightness_FunctionAddress, "NewBrightness");
		SetDefaultBrightness_NewBrightness_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultBrightness_FunctionAddress, "NewBrightness");
		SetDefaultBrightness_NewBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultBrightness_FunctionAddress, "NewBrightness", Classes.FFloatProperty);
		SetDefaultBrightness_IsValid = SetDefaultBrightness_FunctionAddress != IntPtr.Zero && SetDefaultBrightness_NewBrightness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetDefaultBrightness", SetDefaultBrightness_IsValid);
		SetAltitudeScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAltitudeScale");
		SetAltitudeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAltitudeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAltitudeScale_NewAltitudeScale_PropertyAddress, SetAltitudeScale_FunctionAddress, "NewAltitudeScale");
		SetAltitudeScale_NewAltitudeScale_Offset = NativeReflectionCached.GetPropertyOffset(SetAltitudeScale_FunctionAddress, "NewAltitudeScale");
		SetAltitudeScale_NewAltitudeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAltitudeScale_FunctionAddress, "NewAltitudeScale", Classes.FFloatProperty);
		SetAltitudeScale_IsValid = SetAltitudeScale_FunctionAddress != IntPtr.Zero && SetAltitudeScale_NewAltitudeScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:SetAltitudeScale", SetAltitudeScale_IsValid);
		DisableSunDisk_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DisableSunDisk");
		DisableSunDisk_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableSunDisk_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableSunDisk_NewSunDisk_PropertyAddress, DisableSunDisk_FunctionAddress, "NewSunDisk");
		DisableSunDisk_NewSunDisk_Offset = NativeReflectionCached.GetPropertyOffset(DisableSunDisk_FunctionAddress, "NewSunDisk");
		DisableSunDisk_NewSunDisk_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableSunDisk_FunctionAddress, "NewSunDisk", Classes.FBoolProperty);
		DisableSunDisk_IsValid = DisableSunDisk_FunctionAddress != IntPtr.Zero && DisableSunDisk_NewSunDisk_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:DisableSunDisk", DisableSunDisk_IsValid);
		DisableGroundScattering_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DisableGroundScattering");
		DisableGroundScattering_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableGroundScattering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableGroundScattering_NewGroundScattering_PropertyAddress, DisableGroundScattering_FunctionAddress, "NewGroundScattering");
		DisableGroundScattering_NewGroundScattering_Offset = NativeReflectionCached.GetPropertyOffset(DisableGroundScattering_FunctionAddress, "NewGroundScattering");
		DisableGroundScattering_NewGroundScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableGroundScattering_FunctionAddress, "NewGroundScattering", Classes.FBoolProperty);
		DisableGroundScattering_IsValid = DisableGroundScattering_FunctionAddress != IntPtr.Zero && DisableGroundScattering_NewGroundScattering_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AtmosphericFogComponent:DisableGroundScattering", DisableGroundScattering_IsValid);
	}
}
