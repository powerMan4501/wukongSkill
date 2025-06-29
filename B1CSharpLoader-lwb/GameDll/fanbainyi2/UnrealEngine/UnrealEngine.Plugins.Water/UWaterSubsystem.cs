using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Water.WaterSubsystem", "Water", UnrealModuleType.EnginePlugin)]
public class UWaterSubsystem : UTickableWorldSubsystem
{
	private static IntPtr classAddress;

	private static bool OnCameraUnderwaterStateChanged_IsValid;

	private static int OnCameraUnderwaterStateChanged_Offset;

	private FOnCameraUnderwaterStateChanged OnCameraUnderwaterStateChanged_DelegateCached;

	private static bool OnWaterScalabilityChanged_IsValid;

	private static int OnWaterScalabilityChanged_Offset;

	private FOnWaterScalabilityChanged OnWaterScalabilityChanged_DelegateCached;

	private static bool SetOceanFloodHeight_IsValid;

	private static IntPtr SetOceanFloodHeight_FunctionAddress;

	private static int SetOceanFloodHeight_ParamsSize;

	private static bool SetOceanFloodHeight_InFloodHeight_IsValid;

	private static FFieldAddress SetOceanFloodHeight_InFloodHeight_PropertyAddress;

	private static int SetOceanFloodHeight_InFloodHeight_Offset;

	private static bool PrintToWaterLog_IsValid;

	private static IntPtr PrintToWaterLog_FunctionAddress;

	private static int PrintToWaterLog_ParamsSize;

	private static bool PrintToWaterLog_Message_IsValid;

	private static FFieldAddress PrintToWaterLog_Message_PropertyAddress;

	private static int PrintToWaterLog_Message_Offset;

	private static bool PrintToWaterLog_bWarning_IsValid;

	private static FFieldAddress PrintToWaterLog_bWarning_PropertyAddress;

	private static int PrintToWaterLog_bWarning_Offset;

	private static bool IsWaterRenderingEnabled_IsValid;

	private static IntPtr IsWaterRenderingEnabled_FunctionAddress;

	private static int IsWaterRenderingEnabled_ParamsSize;

	private static bool IsWaterRenderingEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsWaterRenderingEnabled_ReturnValue_PropertyAddress;

	private static int IsWaterRenderingEnabled_ReturnValue_Offset;

	private static bool IsUnderwaterPostProcessEnabled_IsValid;

	private static IntPtr IsUnderwaterPostProcessEnabled_FunctionAddress;

	private static int IsUnderwaterPostProcessEnabled_ParamsSize;

	private static bool IsUnderwaterPostProcessEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsUnderwaterPostProcessEnabled_ReturnValue_PropertyAddress;

	private static int IsUnderwaterPostProcessEnabled_ReturnValue_Offset;

	private static bool IsShallowWaterSimulationEnabled_IsValid;

	private static IntPtr IsShallowWaterSimulationEnabled_FunctionAddress;

	private static int IsShallowWaterSimulationEnabled_ParamsSize;

	private static bool IsShallowWaterSimulationEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsShallowWaterSimulationEnabled_ReturnValue_PropertyAddress;

	private static int IsShallowWaterSimulationEnabled_ReturnValue_Offset;

	private static bool GetWaterTimeSeconds_IsValid;

	private static IntPtr GetWaterTimeSeconds_FunctionAddress;

	private static int GetWaterTimeSeconds_ParamsSize;

	private static bool GetWaterTimeSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetWaterTimeSeconds_ReturnValue_PropertyAddress;

	private static int GetWaterTimeSeconds_ReturnValue_Offset;

	private static bool GetSmoothedWorldTimeSeconds_IsValid;

	private static IntPtr GetSmoothedWorldTimeSeconds_FunctionAddress;

	private static int GetSmoothedWorldTimeSeconds_ParamsSize;

	private static bool GetSmoothedWorldTimeSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetSmoothedWorldTimeSeconds_ReturnValue_PropertyAddress;

	private static int GetSmoothedWorldTimeSeconds_ReturnValue_Offset;

	private static bool GetShallowWaterSimulationRenderTargetSize_IsValid;

	private static IntPtr GetShallowWaterSimulationRenderTargetSize_FunctionAddress;

	private static int GetShallowWaterSimulationRenderTargetSize_ParamsSize;

	private static bool GetShallowWaterSimulationRenderTargetSize_ReturnValue_IsValid;

	private static FFieldAddress GetShallowWaterSimulationRenderTargetSize_ReturnValue_PropertyAddress;

	private static int GetShallowWaterSimulationRenderTargetSize_ReturnValue_Offset;

	private static bool GetShallowWaterMaxImpulseForces_IsValid;

	private static IntPtr GetShallowWaterMaxImpulseForces_FunctionAddress;

	private static int GetShallowWaterMaxImpulseForces_ParamsSize;

	private static bool GetShallowWaterMaxImpulseForces_ReturnValue_IsValid;

	private static FFieldAddress GetShallowWaterMaxImpulseForces_ReturnValue_PropertyAddress;

	private static int GetShallowWaterMaxImpulseForces_ReturnValue_Offset;

	private static bool GetShallowWaterMaxDynamicForces_IsValid;

	private static IntPtr GetShallowWaterMaxDynamicForces_FunctionAddress;

	private static int GetShallowWaterMaxDynamicForces_ParamsSize;

	private static bool GetShallowWaterMaxDynamicForces_ReturnValue_IsValid;

	private static FFieldAddress GetShallowWaterMaxDynamicForces_ReturnValue_PropertyAddress;

	private static int GetShallowWaterMaxDynamicForces_ReturnValue_Offset;

	private static bool GetOceanTotalHeight_IsValid;

	private static IntPtr GetOceanTotalHeight_FunctionAddress;

	private static int GetOceanTotalHeight_ParamsSize;

	private static bool GetOceanTotalHeight_ReturnValue_IsValid;

	private static FFieldAddress GetOceanTotalHeight_ReturnValue_PropertyAddress;

	private static int GetOceanTotalHeight_ReturnValue_Offset;

	private static bool GetOceanFloodHeight_IsValid;

	private static IntPtr GetOceanFloodHeight_FunctionAddress;

	private static int GetOceanFloodHeight_ParamsSize;

	private static bool GetOceanFloodHeight_ReturnValue_IsValid;

	private static FFieldAddress GetOceanFloodHeight_ReturnValue_PropertyAddress;

	private static int GetOceanFloodHeight_ReturnValue_Offset;

	private static bool GetOceanBaseHeight_IsValid;

	private static IntPtr GetOceanBaseHeight_FunctionAddress;

	private static int GetOceanBaseHeight_ParamsSize;

	private static bool GetOceanBaseHeight_ReturnValue_IsValid;

	private static FFieldAddress GetOceanBaseHeight_ReturnValue_PropertyAddress;

	private static int GetOceanBaseHeight_ReturnValue_Offset;

	private static bool GetCameraUnderwaterDepth_IsValid;

	private static IntPtr GetCameraUnderwaterDepth_FunctionAddress;

	private static int GetCameraUnderwaterDepth_ParamsSize;

	private static bool GetCameraUnderwaterDepth_ReturnValue_IsValid;

	private static FFieldAddress GetCameraUnderwaterDepth_ReturnValue_PropertyAddress;

	private static int GetCameraUnderwaterDepth_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Water.WaterSubsystem:OnCameraUnderwaterStateChanged")]
	public FOnCameraUnderwaterStateChanged OnCameraUnderwaterStateChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnCameraUnderwaterStateChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterSubsystem:OnCameraUnderwaterStateChanged");
				return new FOnCameraUnderwaterStateChanged();
			}
			if (OnCameraUnderwaterStateChanged_DelegateCached == null)
			{
				OnCameraUnderwaterStateChanged_DelegateCached = new FOnCameraUnderwaterStateChanged();
				OnCameraUnderwaterStateChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCameraUnderwaterStateChanged_Offset));
			}
			return OnCameraUnderwaterStateChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Water.WaterSubsystem:OnWaterScalabilityChanged")]
	public FOnWaterScalabilityChanged OnWaterScalabilityChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnWaterScalabilityChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterSubsystem:OnWaterScalabilityChanged");
				return new FOnWaterScalabilityChanged();
			}
			if (OnWaterScalabilityChanged_DelegateCached == null)
			{
				OnWaterScalabilityChanged_DelegateCached = new FOnWaterScalabilityChanged();
				OnWaterScalabilityChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnWaterScalabilityChanged_Offset));
			}
			return OnWaterScalabilityChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Water.WaterSubsystem:SetOceanFloodHeight")]
	public unsafe void SetOceanFloodHeight(float InFloodHeight)
	{
		CheckDestroyed();
		if (!SetOceanFloodHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:SetOceanFloodHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOceanFloodHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOceanFloodHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOceanFloodHeight_InFloodHeight_Offset), 0, SetOceanFloodHeight_InFloodHeight_PropertyAddress.Address, InFloodHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOceanFloodHeight_FunctionAddress, intPtr, SetOceanFloodHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Water.WaterSubsystem:PrintToWaterLog")]
	public unsafe void PrintToWaterLog(string Message, bool bWarning)
	{
		CheckDestroyed();
		if (!PrintToWaterLog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:PrintToWaterLog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrintToWaterLog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrintToWaterLog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrintToWaterLog_Message_Offset), 0, PrintToWaterLog_Message_PropertyAddress.Address, Message);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PrintToWaterLog_bWarning_Offset), 0, PrintToWaterLog_bWarning_PropertyAddress.Address, bWarning);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrintToWaterLog_FunctionAddress, intPtr, PrintToWaterLog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrintToWaterLog_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:IsWaterRenderingEnabled")]
	public unsafe bool IsWaterRenderingEnabled()
	{
		CheckDestroyed();
		if (!IsWaterRenderingEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:IsWaterRenderingEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWaterRenderingEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWaterRenderingEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsWaterRenderingEnabled_FunctionAddress, intPtr, IsWaterRenderingEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWaterRenderingEnabled_ReturnValue_Offset), 0, IsWaterRenderingEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:IsUnderwaterPostProcessEnabled")]
	public unsafe bool IsUnderwaterPostProcessEnabled()
	{
		CheckDestroyed();
		if (!IsUnderwaterPostProcessEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:IsUnderwaterPostProcessEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUnderwaterPostProcessEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUnderwaterPostProcessEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsUnderwaterPostProcessEnabled_FunctionAddress, intPtr, IsUnderwaterPostProcessEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUnderwaterPostProcessEnabled_ReturnValue_Offset), 0, IsUnderwaterPostProcessEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:IsShallowWaterSimulationEnabled")]
	public unsafe bool IsShallowWaterSimulationEnabled()
	{
		CheckDestroyed();
		if (!IsShallowWaterSimulationEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:IsShallowWaterSimulationEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsShallowWaterSimulationEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsShallowWaterSimulationEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsShallowWaterSimulationEnabled_FunctionAddress, intPtr, IsShallowWaterSimulationEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsShallowWaterSimulationEnabled_ReturnValue_Offset), 0, IsShallowWaterSimulationEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetWaterTimeSeconds")]
	public unsafe float GetWaterTimeSeconds()
	{
		CheckDestroyed();
		if (!GetWaterTimeSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetWaterTimeSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterTimeSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterTimeSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterTimeSeconds_FunctionAddress, intPtr, GetWaterTimeSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWaterTimeSeconds_ReturnValue_Offset), 0, GetWaterTimeSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetSmoothedWorldTimeSeconds")]
	public unsafe float GetSmoothedWorldTimeSeconds()
	{
		CheckDestroyed();
		if (!GetSmoothedWorldTimeSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetSmoothedWorldTimeSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSmoothedWorldTimeSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSmoothedWorldTimeSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSmoothedWorldTimeSeconds_FunctionAddress, intPtr, GetSmoothedWorldTimeSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSmoothedWorldTimeSeconds_ReturnValue_Offset), 0, GetSmoothedWorldTimeSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetShallowWaterSimulationRenderTargetSize")]
	public unsafe static int GetShallowWaterSimulationRenderTargetSize()
	{
		if (!GetShallowWaterSimulationRenderTargetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetShallowWaterSimulationRenderTargetSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShallowWaterSimulationRenderTargetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShallowWaterSimulationRenderTargetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetShallowWaterSimulationRenderTargetSize_FunctionAddress, intPtr, GetShallowWaterSimulationRenderTargetSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShallowWaterSimulationRenderTargetSize_ReturnValue_Offset), 0, GetShallowWaterSimulationRenderTargetSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetShallowWaterMaxImpulseForces")]
	public unsafe static int GetShallowWaterMaxImpulseForces()
	{
		if (!GetShallowWaterMaxImpulseForces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetShallowWaterMaxImpulseForces");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShallowWaterMaxImpulseForces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShallowWaterMaxImpulseForces_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetShallowWaterMaxImpulseForces_FunctionAddress, intPtr, GetShallowWaterMaxImpulseForces_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShallowWaterMaxImpulseForces_ReturnValue_Offset), 0, GetShallowWaterMaxImpulseForces_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetShallowWaterMaxDynamicForces")]
	public unsafe static int GetShallowWaterMaxDynamicForces()
	{
		if (!GetShallowWaterMaxDynamicForces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetShallowWaterMaxDynamicForces");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShallowWaterMaxDynamicForces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShallowWaterMaxDynamicForces_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetShallowWaterMaxDynamicForces_FunctionAddress, intPtr, GetShallowWaterMaxDynamicForces_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShallowWaterMaxDynamicForces_ReturnValue_Offset), 0, GetShallowWaterMaxDynamicForces_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetOceanTotalHeight")]
	public unsafe float GetOceanTotalHeight()
	{
		CheckDestroyed();
		if (!GetOceanTotalHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetOceanTotalHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOceanTotalHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOceanTotalHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOceanTotalHeight_FunctionAddress, intPtr, GetOceanTotalHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetOceanTotalHeight_ReturnValue_Offset), 0, GetOceanTotalHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetOceanFloodHeight")]
	public unsafe float GetOceanFloodHeight()
	{
		CheckDestroyed();
		if (!GetOceanFloodHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetOceanFloodHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOceanFloodHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOceanFloodHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOceanFloodHeight_FunctionAddress, intPtr, GetOceanFloodHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetOceanFloodHeight_ReturnValue_Offset), 0, GetOceanFloodHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetOceanBaseHeight")]
	public unsafe float GetOceanBaseHeight()
	{
		CheckDestroyed();
		if (!GetOceanBaseHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetOceanBaseHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOceanBaseHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOceanBaseHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOceanBaseHeight_FunctionAddress, intPtr, GetOceanBaseHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetOceanBaseHeight_ReturnValue_Offset), 0, GetOceanBaseHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterSubsystem:GetCameraUnderwaterDepth")]
	public unsafe float GetCameraUnderwaterDepth()
	{
		CheckDestroyed();
		if (!GetCameraUnderwaterDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterSubsystem:GetCameraUnderwaterDepth");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraUnderwaterDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraUnderwaterDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraUnderwaterDepth_FunctionAddress, intPtr, GetCameraUnderwaterDepth_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCameraUnderwaterDepth_ReturnValue_Offset), 0, GetCameraUnderwaterDepth_ReturnValue_PropertyAddress.Address);
	}

	static UWaterSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaterSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaterSubsystem));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Water.WaterSubsystem");
		OnCameraUnderwaterStateChanged_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnCameraUnderwaterStateChanged");
		OnCameraUnderwaterStateChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnCameraUnderwaterStateChanged", Classes.FMulticastDelegateProperty);
		OnWaterScalabilityChanged_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnWaterScalabilityChanged");
		OnWaterScalabilityChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnWaterScalabilityChanged", Classes.FMulticastDelegateProperty);
		SetOceanFloodHeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOceanFloodHeight");
		SetOceanFloodHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOceanFloodHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOceanFloodHeight_InFloodHeight_PropertyAddress, SetOceanFloodHeight_FunctionAddress, "InFloodHeight");
		SetOceanFloodHeight_InFloodHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetOceanFloodHeight_FunctionAddress, "InFloodHeight");
		SetOceanFloodHeight_InFloodHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOceanFloodHeight_FunctionAddress, "InFloodHeight", Classes.FFloatProperty);
		SetOceanFloodHeight_IsValid = SetOceanFloodHeight_FunctionAddress != IntPtr.Zero && SetOceanFloodHeight_InFloodHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:SetOceanFloodHeight", SetOceanFloodHeight_IsValid);
		PrintToWaterLog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrintToWaterLog");
		PrintToWaterLog_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintToWaterLog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrintToWaterLog_Message_PropertyAddress, PrintToWaterLog_FunctionAddress, "Message");
		PrintToWaterLog_Message_Offset = NativeReflectionCached.GetPropertyOffset(PrintToWaterLog_FunctionAddress, "Message");
		PrintToWaterLog_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(PrintToWaterLog_FunctionAddress, "Message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PrintToWaterLog_bWarning_PropertyAddress, PrintToWaterLog_FunctionAddress, "bWarning");
		PrintToWaterLog_bWarning_Offset = NativeReflectionCached.GetPropertyOffset(PrintToWaterLog_FunctionAddress, "bWarning");
		PrintToWaterLog_bWarning_IsValid = NativeReflectionCached.ValidatePropertyClass(PrintToWaterLog_FunctionAddress, "bWarning", Classes.FBoolProperty);
		PrintToWaterLog_IsValid = PrintToWaterLog_FunctionAddress != IntPtr.Zero && PrintToWaterLog_Message_IsValid && PrintToWaterLog_bWarning_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:PrintToWaterLog", PrintToWaterLog_IsValid);
		IsWaterRenderingEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsWaterRenderingEnabled");
		IsWaterRenderingEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWaterRenderingEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWaterRenderingEnabled_ReturnValue_PropertyAddress, IsWaterRenderingEnabled_FunctionAddress, "ReturnValue");
		IsWaterRenderingEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWaterRenderingEnabled_FunctionAddress, "ReturnValue");
		IsWaterRenderingEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWaterRenderingEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWaterRenderingEnabled_IsValid = IsWaterRenderingEnabled_FunctionAddress != IntPtr.Zero && IsWaterRenderingEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:IsWaterRenderingEnabled", IsWaterRenderingEnabled_IsValid);
		IsUnderwaterPostProcessEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsUnderwaterPostProcessEnabled");
		IsUnderwaterPostProcessEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUnderwaterPostProcessEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUnderwaterPostProcessEnabled_ReturnValue_PropertyAddress, IsUnderwaterPostProcessEnabled_FunctionAddress, "ReturnValue");
		IsUnderwaterPostProcessEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderwaterPostProcessEnabled_FunctionAddress, "ReturnValue");
		IsUnderwaterPostProcessEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderwaterPostProcessEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUnderwaterPostProcessEnabled_IsValid = IsUnderwaterPostProcessEnabled_FunctionAddress != IntPtr.Zero && IsUnderwaterPostProcessEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:IsUnderwaterPostProcessEnabled", IsUnderwaterPostProcessEnabled_IsValid);
		IsShallowWaterSimulationEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsShallowWaterSimulationEnabled");
		IsShallowWaterSimulationEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShallowWaterSimulationEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsShallowWaterSimulationEnabled_ReturnValue_PropertyAddress, IsShallowWaterSimulationEnabled_FunctionAddress, "ReturnValue");
		IsShallowWaterSimulationEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsShallowWaterSimulationEnabled_FunctionAddress, "ReturnValue");
		IsShallowWaterSimulationEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShallowWaterSimulationEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShallowWaterSimulationEnabled_IsValid = IsShallowWaterSimulationEnabled_FunctionAddress != IntPtr.Zero && IsShallowWaterSimulationEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:IsShallowWaterSimulationEnabled", IsShallowWaterSimulationEnabled_IsValid);
		GetWaterTimeSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWaterTimeSeconds");
		GetWaterTimeSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterTimeSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterTimeSeconds_ReturnValue_PropertyAddress, GetWaterTimeSeconds_FunctionAddress, "ReturnValue");
		GetWaterTimeSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterTimeSeconds_FunctionAddress, "ReturnValue");
		GetWaterTimeSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterTimeSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWaterTimeSeconds_IsValid = GetWaterTimeSeconds_FunctionAddress != IntPtr.Zero && GetWaterTimeSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetWaterTimeSeconds", GetWaterTimeSeconds_IsValid);
		GetSmoothedWorldTimeSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSmoothedWorldTimeSeconds");
		GetSmoothedWorldTimeSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSmoothedWorldTimeSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSmoothedWorldTimeSeconds_ReturnValue_PropertyAddress, GetSmoothedWorldTimeSeconds_FunctionAddress, "ReturnValue");
		GetSmoothedWorldTimeSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSmoothedWorldTimeSeconds_FunctionAddress, "ReturnValue");
		GetSmoothedWorldTimeSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSmoothedWorldTimeSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSmoothedWorldTimeSeconds_IsValid = GetSmoothedWorldTimeSeconds_FunctionAddress != IntPtr.Zero && GetSmoothedWorldTimeSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetSmoothedWorldTimeSeconds", GetSmoothedWorldTimeSeconds_IsValid);
		GetShallowWaterSimulationRenderTargetSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShallowWaterSimulationRenderTargetSize");
		GetShallowWaterSimulationRenderTargetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShallowWaterSimulationRenderTargetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShallowWaterSimulationRenderTargetSize_ReturnValue_PropertyAddress, GetShallowWaterSimulationRenderTargetSize_FunctionAddress, "ReturnValue");
		GetShallowWaterSimulationRenderTargetSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShallowWaterSimulationRenderTargetSize_FunctionAddress, "ReturnValue");
		GetShallowWaterSimulationRenderTargetSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShallowWaterSimulationRenderTargetSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShallowWaterSimulationRenderTargetSize_IsValid = GetShallowWaterSimulationRenderTargetSize_FunctionAddress != IntPtr.Zero && GetShallowWaterSimulationRenderTargetSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetShallowWaterSimulationRenderTargetSize", GetShallowWaterSimulationRenderTargetSize_IsValid);
		GetShallowWaterMaxImpulseForces_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShallowWaterMaxImpulseForces");
		GetShallowWaterMaxImpulseForces_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShallowWaterMaxImpulseForces_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShallowWaterMaxImpulseForces_ReturnValue_PropertyAddress, GetShallowWaterMaxImpulseForces_FunctionAddress, "ReturnValue");
		GetShallowWaterMaxImpulseForces_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShallowWaterMaxImpulseForces_FunctionAddress, "ReturnValue");
		GetShallowWaterMaxImpulseForces_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShallowWaterMaxImpulseForces_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShallowWaterMaxImpulseForces_IsValid = GetShallowWaterMaxImpulseForces_FunctionAddress != IntPtr.Zero && GetShallowWaterMaxImpulseForces_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetShallowWaterMaxImpulseForces", GetShallowWaterMaxImpulseForces_IsValid);
		GetShallowWaterMaxDynamicForces_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShallowWaterMaxDynamicForces");
		GetShallowWaterMaxDynamicForces_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShallowWaterMaxDynamicForces_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShallowWaterMaxDynamicForces_ReturnValue_PropertyAddress, GetShallowWaterMaxDynamicForces_FunctionAddress, "ReturnValue");
		GetShallowWaterMaxDynamicForces_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShallowWaterMaxDynamicForces_FunctionAddress, "ReturnValue");
		GetShallowWaterMaxDynamicForces_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShallowWaterMaxDynamicForces_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShallowWaterMaxDynamicForces_IsValid = GetShallowWaterMaxDynamicForces_FunctionAddress != IntPtr.Zero && GetShallowWaterMaxDynamicForces_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetShallowWaterMaxDynamicForces", GetShallowWaterMaxDynamicForces_IsValid);
		GetOceanTotalHeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOceanTotalHeight");
		GetOceanTotalHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOceanTotalHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOceanTotalHeight_ReturnValue_PropertyAddress, GetOceanTotalHeight_FunctionAddress, "ReturnValue");
		GetOceanTotalHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOceanTotalHeight_FunctionAddress, "ReturnValue");
		GetOceanTotalHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOceanTotalHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetOceanTotalHeight_IsValid = GetOceanTotalHeight_FunctionAddress != IntPtr.Zero && GetOceanTotalHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetOceanTotalHeight", GetOceanTotalHeight_IsValid);
		GetOceanFloodHeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOceanFloodHeight");
		GetOceanFloodHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOceanFloodHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOceanFloodHeight_ReturnValue_PropertyAddress, GetOceanFloodHeight_FunctionAddress, "ReturnValue");
		GetOceanFloodHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOceanFloodHeight_FunctionAddress, "ReturnValue");
		GetOceanFloodHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOceanFloodHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetOceanFloodHeight_IsValid = GetOceanFloodHeight_FunctionAddress != IntPtr.Zero && GetOceanFloodHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetOceanFloodHeight", GetOceanFloodHeight_IsValid);
		GetOceanBaseHeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOceanBaseHeight");
		GetOceanBaseHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOceanBaseHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOceanBaseHeight_ReturnValue_PropertyAddress, GetOceanBaseHeight_FunctionAddress, "ReturnValue");
		GetOceanBaseHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOceanBaseHeight_FunctionAddress, "ReturnValue");
		GetOceanBaseHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOceanBaseHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetOceanBaseHeight_IsValid = GetOceanBaseHeight_FunctionAddress != IntPtr.Zero && GetOceanBaseHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetOceanBaseHeight", GetOceanBaseHeight_IsValid);
		GetCameraUnderwaterDepth_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraUnderwaterDepth");
		GetCameraUnderwaterDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraUnderwaterDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraUnderwaterDepth_ReturnValue_PropertyAddress, GetCameraUnderwaterDepth_FunctionAddress, "ReturnValue");
		GetCameraUnderwaterDepth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraUnderwaterDepth_FunctionAddress, "ReturnValue");
		GetCameraUnderwaterDepth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraUnderwaterDepth_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCameraUnderwaterDepth_IsValid = GetCameraUnderwaterDepth_FunctionAddress != IntPtr.Zero && GetCameraUnderwaterDepth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterSubsystem:GetCameraUnderwaterDepth", GetCameraUnderwaterDepth_IsValid);
	}
}
