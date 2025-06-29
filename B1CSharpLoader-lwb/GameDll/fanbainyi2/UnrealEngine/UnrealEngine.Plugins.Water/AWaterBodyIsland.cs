using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.WaterBodyIsland", "Water", UnrealModuleType.EnginePlugin)]
public class AWaterBodyIsland : AActor, IWaterBrushActorInterface, IInterface
{
	private static bool WaterCurveSettings_IsValid;

	private static int WaterCurveSettings_Offset;

	private static bool WaterHeightmapSettings_IsValid;

	private static int WaterHeightmapSettings_Offset;

	private static bool WaterWeightmapSettings_IsValid;

	private static FFieldAddress WaterWeightmapSettings_PropertyAddress;

	private static int WaterWeightmapSettings_Offset;

	private TMapReadWriteMarshaler<FName, FWaterBodyWeightmapSettings> WaterWeightmapSettings_MarshalerCached;

	private static bool SplineComp_IsValid;

	private static int SplineComp_Offset;

	private static bool GetWaterSpline_IsValid;

	private static IntPtr GetWaterSpline_FunctionAddress;

	private static int GetWaterSpline_ParamsSize;

	private static bool GetWaterSpline_ReturnValue_IsValid;

	private static FFieldAddress GetWaterSpline_ReturnValue_PropertyAddress;

	private static int GetWaterSpline_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503702706585605uL)]
	[UMetaPath("/Script/Water.WaterBodyIsland:WaterCurveSettings")]
	public FWaterCurveSettings WaterCurveSettings
	{
		get
		{
			CheckDestroyed();
			if (!WaterCurveSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:WaterCurveSettings");
				return default(FWaterCurveSettings);
			}
			return FWaterCurveSettings.FromNative(IntPtr.Add(base.Address, WaterCurveSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterCurveSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:WaterCurveSettings");
			}
			else
			{
				FWaterCurveSettings.ToNative(IntPtr.Add(base.Address, WaterCurveSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503702706585605uL)]
	[UMetaPath("/Script/Water.WaterBodyIsland:WaterHeightmapSettings")]
	public FWaterBodyHeightmapSettings WaterHeightmapSettings
	{
		get
		{
			CheckDestroyed();
			if (!WaterHeightmapSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:WaterHeightmapSettings");
				return default(FWaterBodyHeightmapSettings);
			}
			return FWaterBodyHeightmapSettings.FromNative(IntPtr.Add(base.Address, WaterHeightmapSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterHeightmapSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:WaterHeightmapSettings");
			}
			else
			{
				FWaterBodyHeightmapSettings.ToNative(IntPtr.Add(base.Address, WaterHeightmapSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503633987108869uL)]
	[UMetaPath("/Script/Water.WaterBodyIsland:WaterWeightmapSettings")]
	public TMapReadWrite<FName, FWaterBodyWeightmapSettings> WaterWeightmapSettings
	{
		get
		{
			CheckDestroyed();
			if (!WaterWeightmapSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:WaterWeightmapSettings");
				return null;
			}
			if (WaterWeightmapSettings_MarshalerCached == null)
			{
				WaterWeightmapSettings_MarshalerCached = new TMapReadWriteMarshaler<FName, FWaterBodyWeightmapSettings>(1, WaterWeightmapSettings_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FWaterBodyWeightmapSettings, FWaterBodyWeightmapSettings>.FromNative, CachedMarshalingDelegates<FWaterBodyWeightmapSettings, FWaterBodyWeightmapSettings>.ToNative);
			}
			return WaterWeightmapSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, WaterWeightmapSettings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864955322909uL)]
	[UMetaPath("/Script/Water.WaterBodyIsland:SplineComp")]
	protected UWaterSplineComponent SplineComp
	{
		get
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:SplineComp");
				return null;
			}
			return UObjectMarshaler<UWaterSplineComponent>.FromNative(IntPtr.Add(base.Address, SplineComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyIsland:SplineComp");
			}
			else
			{
				UObjectMarshaler<UWaterSplineComponent>.ToNative(IntPtr.Add(base.Address, SplineComp_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyIsland:GetWaterSpline")]
	public unsafe UWaterSplineComponent GetWaterSpline()
	{
		CheckDestroyed();
		if (!GetWaterSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyIsland:GetWaterSpline");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterSpline_FunctionAddress, intPtr, GetWaterSpline_ParamsSize);
		return UObjectMarshaler<UWaterSplineComponent>.FromNative(IntPtr.Add(intPtr, GetWaterSpline_ReturnValue_Offset), 0, GetWaterSpline_ReturnValue_PropertyAddress.Address);
	}

	static AWaterBodyIsland()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWaterBodyIsland)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWaterBodyIsland));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Water.WaterBodyIsland");
		WaterCurveSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterCurveSettings");
		WaterCurveSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterCurveSettings", Classes.FStructProperty);
		WaterHeightmapSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterHeightmapSettings");
		WaterHeightmapSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterHeightmapSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WaterWeightmapSettings_PropertyAddress, intPtr, "WaterWeightmapSettings");
		WaterWeightmapSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterWeightmapSettings");
		WaterWeightmapSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterWeightmapSettings", Classes.FMapProperty);
		SplineComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SplineComp");
		SplineComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SplineComp", Classes.FObjectProperty);
		GetWaterSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterSpline");
		GetWaterSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSpline_ReturnValue_PropertyAddress, GetWaterSpline_FunctionAddress, "ReturnValue");
		GetWaterSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSpline_FunctionAddress, "ReturnValue");
		GetWaterSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSpline_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterSpline_IsValid = GetWaterSpline_FunctionAddress != IntPtr.Zero && GetWaterSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyIsland:GetWaterSpline", GetWaterSpline_IsValid);
	}
}
