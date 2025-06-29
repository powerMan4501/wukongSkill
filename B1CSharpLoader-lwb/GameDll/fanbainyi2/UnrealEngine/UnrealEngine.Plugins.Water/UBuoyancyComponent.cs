using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.BuoyancyComponent", "Water", UnrealModuleType.EnginePlugin)]
public class UBuoyancyComponent : UActorComponent
{
	private static bool OnEnteredWaterDelegate_IsValid;

	private static int OnEnteredWaterDelegate_Offset;

	private FOnPontoonEnteredWater OnEnteredWaterDelegate_DelegateCached;

	private static bool OnExitedWaterDelegate_IsValid;

	private static int OnExitedWaterDelegate_Offset;

	private FOnPontoonExitedWater OnExitedWaterDelegate_DelegateCached;

	private static bool OnPontoonExitedWater_IsValid;

	private static IntPtr OnPontoonExitedWater_FunctionAddress;

	private static int OnPontoonExitedWater_ParamsSize;

	private static bool OnPontoonExitedWater_Pontoon_IsValid;

	private static FFieldAddress OnPontoonExitedWater_Pontoon_PropertyAddress;

	private static int OnPontoonExitedWater_Pontoon_Offset;

	private static bool OnPontoonEnteredWater_IsValid;

	private static IntPtr OnPontoonEnteredWater_FunctionAddress;

	private static int OnPontoonEnteredWater_ParamsSize;

	private static bool OnPontoonEnteredWater_Pontoon_IsValid;

	private static FFieldAddress OnPontoonEnteredWater_Pontoon_PropertyAddress;

	private static int OnPontoonEnteredWater_Pontoon_Offset;

	private static bool IsOverlappingWaterBody_IsValid;

	private static IntPtr IsOverlappingWaterBody_FunctionAddress;

	private static int IsOverlappingWaterBody_ParamsSize;

	private static bool IsOverlappingWaterBody_ReturnValue_IsValid;

	private static FFieldAddress IsOverlappingWaterBody_ReturnValue_PropertyAddress;

	private static int IsOverlappingWaterBody_ReturnValue_Offset;

	private static bool IsInWaterBody_IsValid;

	private static IntPtr IsInWaterBody_FunctionAddress;

	private static int IsInWaterBody_ParamsSize;

	private static bool IsInWaterBody_ReturnValue_IsValid;

	private static FFieldAddress IsInWaterBody_ReturnValue_PropertyAddress;

	private static int IsInWaterBody_ReturnValue_Offset;

	private static bool GetLastWaterSurfaceInfo_IsValid;

	private static IntPtr GetLastWaterSurfaceInfo_FunctionAddress;

	private static int GetLastWaterSurfaceInfo_ParamsSize;

	private static bool GetLastWaterSurfaceInfo_OutWaterPlaneLocation_IsValid;

	private static FFieldAddress GetLastWaterSurfaceInfo_OutWaterPlaneLocation_PropertyAddress;

	private static int GetLastWaterSurfaceInfo_OutWaterPlaneLocation_Offset;

	private static bool GetLastWaterSurfaceInfo_OutWaterPlaneNormal_IsValid;

	private static FFieldAddress GetLastWaterSurfaceInfo_OutWaterPlaneNormal_PropertyAddress;

	private static int GetLastWaterSurfaceInfo_OutWaterPlaneNormal_Offset;

	private static bool GetLastWaterSurfaceInfo_OutWaterSurfacePosition_IsValid;

	private static FFieldAddress GetLastWaterSurfaceInfo_OutWaterSurfacePosition_PropertyAddress;

	private static int GetLastWaterSurfaceInfo_OutWaterSurfacePosition_Offset;

	private static bool GetLastWaterSurfaceInfo_OutWaterDepth_IsValid;

	private static FFieldAddress GetLastWaterSurfaceInfo_OutWaterDepth_PropertyAddress;

	private static int GetLastWaterSurfaceInfo_OutWaterDepth_Offset;

	private static bool GetLastWaterSurfaceInfo_OutWaterBodyIdx_IsValid;

	private static FFieldAddress GetLastWaterSurfaceInfo_OutWaterBodyIdx_PropertyAddress;

	private static int GetLastWaterSurfaceInfo_OutWaterBodyIdx_Offset;

	private static bool GetLastWaterSurfaceInfo_OutWaterVelocity_IsValid;

	private static FFieldAddress GetLastWaterSurfaceInfo_OutWaterVelocity_PropertyAddress;

	private static int GetLastWaterSurfaceInfo_OutWaterVelocity_Offset;

	private static bool GetCurrentWaterBodyComponents_IsValid;

	private static IntPtr GetCurrentWaterBodyComponents_FunctionAddress;

	private static int GetCurrentWaterBodyComponents_ParamsSize;

	private static bool GetCurrentWaterBodyComponents_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentWaterBodyComponents_ReturnValue_PropertyAddress;

	private static int GetCurrentWaterBodyComponents_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Water.BuoyancyComponent:OnEnteredWaterDelegate")]
	public FOnPontoonEnteredWater OnEnteredWaterDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnEnteredWaterDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.BuoyancyComponent:OnEnteredWaterDelegate");
				return new FOnPontoonEnteredWater();
			}
			if (OnEnteredWaterDelegate_DelegateCached == null)
			{
				OnEnteredWaterDelegate_DelegateCached = new FOnPontoonEnteredWater();
				OnEnteredWaterDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEnteredWaterDelegate_Offset));
			}
			return OnEnteredWaterDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Water.BuoyancyComponent:OnExitedWaterDelegate")]
	public FOnPontoonExitedWater OnExitedWaterDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnExitedWaterDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.BuoyancyComponent:OnExitedWaterDelegate");
				return new FOnPontoonExitedWater();
			}
			if (OnExitedWaterDelegate_DelegateCached == null)
			{
				OnExitedWaterDelegate_DelegateCached = new FOnPontoonExitedWater();
				OnExitedWaterDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnExitedWaterDelegate_Offset));
			}
			return OnExitedWaterDelegate_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Water.BuoyancyComponent:OnPontoonExitedWater")]
	public unsafe void OnPontoonExitedWater(FSphericalPontoon Pontoon)
	{
		CheckDestroyed();
		if (!OnPontoonExitedWater_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.BuoyancyComponent:OnPontoonExitedWater");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPontoonExitedWater_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPontoonExitedWater_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPontoonExitedWater_Pontoon_PropertyAddress.Address, intPtr);
		FSphericalPontoon.ToNative(IntPtr.Add(intPtr, OnPontoonExitedWater_Pontoon_Offset), 0, OnPontoonExitedWater_Pontoon_PropertyAddress.Address, Pontoon);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPontoonExitedWater_FunctionAddress, intPtr, OnPontoonExitedWater_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPontoonExitedWater_Pontoon_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Water.BuoyancyComponent:OnPontoonEnteredWater")]
	public unsafe void OnPontoonEnteredWater(FSphericalPontoon Pontoon)
	{
		CheckDestroyed();
		if (!OnPontoonEnteredWater_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.BuoyancyComponent:OnPontoonEnteredWater");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPontoonEnteredWater_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPontoonEnteredWater_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPontoonEnteredWater_Pontoon_PropertyAddress.Address, intPtr);
		FSphericalPontoon.ToNative(IntPtr.Add(intPtr, OnPontoonEnteredWater_Pontoon_Offset), 0, OnPontoonEnteredWater_Pontoon_PropertyAddress.Address, Pontoon);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPontoonEnteredWater_FunctionAddress, intPtr, OnPontoonEnteredWater_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPontoonEnteredWater_Pontoon_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.BuoyancyComponent:IsOverlappingWaterBody")]
	public unsafe bool IsOverlappingWaterBody()
	{
		CheckDestroyed();
		if (!IsOverlappingWaterBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.BuoyancyComponent:IsOverlappingWaterBody");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverlappingWaterBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverlappingWaterBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOverlappingWaterBody_FunctionAddress, intPtr, IsOverlappingWaterBody_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverlappingWaterBody_ReturnValue_Offset), 0, IsOverlappingWaterBody_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.BuoyancyComponent:IsInWaterBody")]
	public unsafe bool IsInWaterBody()
	{
		CheckDestroyed();
		if (!IsInWaterBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.BuoyancyComponent:IsInWaterBody");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInWaterBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInWaterBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInWaterBody_FunctionAddress, intPtr, IsInWaterBody_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInWaterBody_ReturnValue_Offset), 0, IsInWaterBody_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Water.BuoyancyComponent:GetLastWaterSurfaceInfo")]
	public unsafe void GetLastWaterSurfaceInfo(out FVector OutWaterPlaneLocation, out FVector OutWaterPlaneNormal, out FVector OutWaterSurfacePosition, out float OutWaterDepth, out int OutWaterBodyIdx, out FVector OutWaterVelocity)
	{
		CheckDestroyed();
		if (!GetLastWaterSurfaceInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.BuoyancyComponent:GetLastWaterSurfaceInfo");
			OutWaterPlaneLocation = default(FVector);
			OutWaterPlaneNormal = default(FVector);
			OutWaterSurfacePosition = default(FVector);
			OutWaterDepth = 0f;
			OutWaterBodyIdx = 0;
			OutWaterVelocity = default(FVector);
		}
		else
		{
			byte* ptr = stackalloc byte[(int)(uint)(GetLastWaterSurfaceInfo_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastWaterSurfaceInfo_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InvokeFunctionOptimized(base.Address, GetLastWaterSurfaceInfo_FunctionAddress, intPtr, GetLastWaterSurfaceInfo_ParamsSize);
			OutWaterPlaneLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastWaterSurfaceInfo_OutWaterPlaneLocation_Offset), 0, GetLastWaterSurfaceInfo_OutWaterPlaneLocation_PropertyAddress.Address);
			OutWaterPlaneNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastWaterSurfaceInfo_OutWaterPlaneNormal_Offset), 0, GetLastWaterSurfaceInfo_OutWaterPlaneNormal_PropertyAddress.Address);
			OutWaterSurfacePosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastWaterSurfaceInfo_OutWaterSurfacePosition_Offset), 0, GetLastWaterSurfaceInfo_OutWaterSurfacePosition_PropertyAddress.Address);
			OutWaterDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLastWaterSurfaceInfo_OutWaterDepth_Offset), 0, GetLastWaterSurfaceInfo_OutWaterDepth_PropertyAddress.Address);
			OutWaterBodyIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLastWaterSurfaceInfo_OutWaterBodyIdx_Offset), 0, GetLastWaterSurfaceInfo_OutWaterBodyIdx_PropertyAddress.Address);
			OutWaterVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastWaterSurfaceInfo_OutWaterVelocity_Offset), 0, GetLastWaterSurfaceInfo_OutWaterVelocity_PropertyAddress.Address);
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.BuoyancyComponent:GetCurrentWaterBodyComponents")]
	public unsafe List<UWaterBodyComponent> GetCurrentWaterBodyComponents()
	{
		CheckDestroyed();
		if (!GetCurrentWaterBodyComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.BuoyancyComponent:GetCurrentWaterBodyComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentWaterBodyComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentWaterBodyComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentWaterBodyComponents_FunctionAddress, intPtr, GetCurrentWaterBodyComponents_ParamsSize);
		List<UWaterBodyComponent> result = new TArrayCopyMarshaler<UWaterBodyComponent>(1, GetCurrentWaterBodyComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWaterBodyComponent, UObjectMarshaler<UWaterBodyComponent>>.FromNative, CachedMarshalingDelegates<UWaterBodyComponent, UObjectMarshaler<UWaterBodyComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurrentWaterBodyComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurrentWaterBodyComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UBuoyancyComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBuoyancyComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBuoyancyComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Water.BuoyancyComponent");
		OnEnteredWaterDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEnteredWaterDelegate");
		OnEnteredWaterDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEnteredWaterDelegate", Classes.FMulticastDelegateProperty);
		OnExitedWaterDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnExitedWaterDelegate");
		OnExitedWaterDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnExitedWaterDelegate", Classes.FMulticastDelegateProperty);
		OnPontoonExitedWater_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPontoonExitedWater");
		OnPontoonExitedWater_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPontoonExitedWater_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPontoonExitedWater_Pontoon_PropertyAddress, OnPontoonExitedWater_FunctionAddress, "Pontoon");
		OnPontoonExitedWater_Pontoon_Offset = NativeReflectionCached.GetPropertyOffset(OnPontoonExitedWater_FunctionAddress, "Pontoon");
		OnPontoonExitedWater_Pontoon_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPontoonExitedWater_FunctionAddress, "Pontoon", Classes.FStructProperty);
		OnPontoonExitedWater_IsValid = OnPontoonExitedWater_FunctionAddress != IntPtr.Zero && OnPontoonExitedWater_Pontoon_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.BuoyancyComponent:OnPontoonExitedWater", OnPontoonExitedWater_IsValid);
		OnPontoonEnteredWater_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPontoonEnteredWater");
		OnPontoonEnteredWater_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPontoonEnteredWater_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPontoonEnteredWater_Pontoon_PropertyAddress, OnPontoonEnteredWater_FunctionAddress, "Pontoon");
		OnPontoonEnteredWater_Pontoon_Offset = NativeReflectionCached.GetPropertyOffset(OnPontoonEnteredWater_FunctionAddress, "Pontoon");
		OnPontoonEnteredWater_Pontoon_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPontoonEnteredWater_FunctionAddress, "Pontoon", Classes.FStructProperty);
		OnPontoonEnteredWater_IsValid = OnPontoonEnteredWater_FunctionAddress != IntPtr.Zero && OnPontoonEnteredWater_Pontoon_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.BuoyancyComponent:OnPontoonEnteredWater", OnPontoonEnteredWater_IsValid);
		IsOverlappingWaterBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverlappingWaterBody");
		IsOverlappingWaterBody_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverlappingWaterBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingWaterBody_ReturnValue_PropertyAddress, IsOverlappingWaterBody_FunctionAddress, "ReturnValue");
		IsOverlappingWaterBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingWaterBody_FunctionAddress, "ReturnValue");
		IsOverlappingWaterBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingWaterBody_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverlappingWaterBody_IsValid = IsOverlappingWaterBody_FunctionAddress != IntPtr.Zero && IsOverlappingWaterBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.BuoyancyComponent:IsOverlappingWaterBody", IsOverlappingWaterBody_IsValid);
		IsInWaterBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInWaterBody");
		IsInWaterBody_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInWaterBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInWaterBody_ReturnValue_PropertyAddress, IsInWaterBody_FunctionAddress, "ReturnValue");
		IsInWaterBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInWaterBody_FunctionAddress, "ReturnValue");
		IsInWaterBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInWaterBody_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInWaterBody_IsValid = IsInWaterBody_FunctionAddress != IntPtr.Zero && IsInWaterBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.BuoyancyComponent:IsInWaterBody", IsInWaterBody_IsValid);
		GetLastWaterSurfaceInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastWaterSurfaceInfo");
		GetLastWaterSurfaceInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastWaterSurfaceInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastWaterSurfaceInfo_OutWaterPlaneLocation_PropertyAddress, GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterPlaneLocation");
		GetLastWaterSurfaceInfo_OutWaterPlaneLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterPlaneLocation");
		GetLastWaterSurfaceInfo_OutWaterPlaneLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterPlaneLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastWaterSurfaceInfo_OutWaterPlaneNormal_PropertyAddress, GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterPlaneNormal");
		GetLastWaterSurfaceInfo_OutWaterPlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterPlaneNormal");
		GetLastWaterSurfaceInfo_OutWaterPlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterPlaneNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastWaterSurfaceInfo_OutWaterSurfacePosition_PropertyAddress, GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterSurfacePosition");
		GetLastWaterSurfaceInfo_OutWaterSurfacePosition_Offset = NativeReflectionCached.GetPropertyOffset(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterSurfacePosition");
		GetLastWaterSurfaceInfo_OutWaterSurfacePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterSurfacePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastWaterSurfaceInfo_OutWaterDepth_PropertyAddress, GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterDepth");
		GetLastWaterSurfaceInfo_OutWaterDepth_Offset = NativeReflectionCached.GetPropertyOffset(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterDepth");
		GetLastWaterSurfaceInfo_OutWaterDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterDepth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastWaterSurfaceInfo_OutWaterBodyIdx_PropertyAddress, GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterBodyIdx");
		GetLastWaterSurfaceInfo_OutWaterBodyIdx_Offset = NativeReflectionCached.GetPropertyOffset(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterBodyIdx");
		GetLastWaterSurfaceInfo_OutWaterBodyIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterBodyIdx", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastWaterSurfaceInfo_OutWaterVelocity_PropertyAddress, GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterVelocity");
		GetLastWaterSurfaceInfo_OutWaterVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterVelocity");
		GetLastWaterSurfaceInfo_OutWaterVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastWaterSurfaceInfo_FunctionAddress, "OutWaterVelocity", Classes.FStructProperty);
		GetLastWaterSurfaceInfo_IsValid = GetLastWaterSurfaceInfo_FunctionAddress != IntPtr.Zero && GetLastWaterSurfaceInfo_OutWaterPlaneLocation_IsValid && GetLastWaterSurfaceInfo_OutWaterPlaneNormal_IsValid && GetLastWaterSurfaceInfo_OutWaterSurfacePosition_IsValid && GetLastWaterSurfaceInfo_OutWaterDepth_IsValid && GetLastWaterSurfaceInfo_OutWaterBodyIdx_IsValid && GetLastWaterSurfaceInfo_OutWaterVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.BuoyancyComponent:GetLastWaterSurfaceInfo", GetLastWaterSurfaceInfo_IsValid);
		GetCurrentWaterBodyComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentWaterBodyComponents");
		GetCurrentWaterBodyComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentWaterBodyComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentWaterBodyComponents_ReturnValue_PropertyAddress, GetCurrentWaterBodyComponents_FunctionAddress, "ReturnValue");
		GetCurrentWaterBodyComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentWaterBodyComponents_FunctionAddress, "ReturnValue");
		GetCurrentWaterBodyComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentWaterBodyComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurrentWaterBodyComponents_IsValid = GetCurrentWaterBodyComponents_FunctionAddress != IntPtr.Zero && GetCurrentWaterBodyComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.BuoyancyComponent:GetCurrentWaterBodyComponents", GetCurrentWaterBodyComponents_IsValid);
	}
}
