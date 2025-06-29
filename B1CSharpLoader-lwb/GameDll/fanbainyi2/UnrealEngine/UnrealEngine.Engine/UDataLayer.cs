using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810550432uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.DataLayer", "Engine", UnrealModuleType.Engine)]
public class UDataLayer : UObject
{
	private static bool IsVisible_IsValid;

	private static IntPtr IsVisible_FunctionAddress;

	private static int IsVisible_ParamsSize;

	private static bool IsVisible_ReturnValue_IsValid;

	private static FFieldAddress IsVisible_ReturnValue_PropertyAddress;

	private static int IsVisible_ReturnValue_Offset;

	private static bool IsRuntime_IsValid;

	private static IntPtr IsRuntime_FunctionAddress;

	private static int IsRuntime_ParamsSize;

	private static bool IsRuntime_ReturnValue_IsValid;

	private static FFieldAddress IsRuntime_ReturnValue_PropertyAddress;

	private static int IsRuntime_ReturnValue_Offset;

	private static bool IsInitiallyVisible_IsValid;

	private static IntPtr IsInitiallyVisible_FunctionAddress;

	private static int IsInitiallyVisible_ParamsSize;

	private static bool IsInitiallyVisible_ReturnValue_IsValid;

	private static FFieldAddress IsInitiallyVisible_ReturnValue_PropertyAddress;

	private static int IsInitiallyVisible_ReturnValue_Offset;

	private static bool IsEffectiveVisible_IsValid;

	private static IntPtr IsEffectiveVisible_FunctionAddress;

	private static int IsEffectiveVisible_ParamsSize;

	private static bool IsEffectiveVisible_ReturnValue_IsValid;

	private static FFieldAddress IsEffectiveVisible_ReturnValue_PropertyAddress;

	private static int IsEffectiveVisible_ReturnValue_Offset;

	private static bool GetInitialRuntimeState_IsValid;

	private static IntPtr GetInitialRuntimeState_FunctionAddress;

	private static int GetInitialRuntimeState_ParamsSize;

	private static bool GetInitialRuntimeState_ReturnValue_IsValid;

	private static FFieldAddress GetInitialRuntimeState_ReturnValue_PropertyAddress;

	private static int GetInitialRuntimeState_ReturnValue_Offset;

	private static bool GetDebugColor_IsValid;

	private static IntPtr GetDebugColor_FunctionAddress;

	private static int GetDebugColor_ParamsSize;

	private static bool GetDebugColor_ReturnValue_IsValid;

	private static FFieldAddress GetDebugColor_ReturnValue_PropertyAddress;

	private static int GetDebugColor_ReturnValue_Offset;

	private static bool GetDataLayerLabel_IsValid;

	private static IntPtr GetDataLayerLabel_FunctionAddress;

	private static int GetDataLayerLabel_ParamsSize;

	private static bool GetDataLayerLabel_ReturnValue_IsValid;

	private static FFieldAddress GetDataLayerLabel_ReturnValue_PropertyAddress;

	private static int GetDataLayerLabel_ReturnValue_Offset;

	private static bool Equals_IsValid;

	private static IntPtr Equals_FunctionAddress;

	private static int Equals_ParamsSize;

	private static bool Equals_ActorDataLayer_IsValid;

	private static FFieldAddress Equals_ActorDataLayer_PropertyAddress;

	private static int Equals_ActorDataLayer_Offset;

	private static bool Equals_ReturnValue_IsValid;

	private static FFieldAddress Equals_ReturnValue_PropertyAddress;

	private static int Equals_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DataLayer:IsVisible")]
	public unsafe bool IsVisible()
	{
		CheckDestroyed();
		if (!IsVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:IsVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVisible_FunctionAddress, intPtr, IsVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVisible_ReturnValue_Offset), 0, IsVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DataLayer:IsRuntime")]
	public unsafe bool IsRuntime()
	{
		CheckDestroyed();
		if (!IsRuntime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:IsRuntime");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRuntime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRuntime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRuntime_FunctionAddress, intPtr, IsRuntime_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRuntime_ReturnValue_Offset), 0, IsRuntime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DataLayer:IsInitiallyVisible")]
	public unsafe bool IsInitiallyVisible()
	{
		CheckDestroyed();
		if (!IsInitiallyVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:IsInitiallyVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInitiallyVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInitiallyVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInitiallyVisible_FunctionAddress, intPtr, IsInitiallyVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInitiallyVisible_ReturnValue_Offset), 0, IsInitiallyVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DataLayer:IsEffectiveVisible")]
	public unsafe bool IsEffectiveVisible()
	{
		CheckDestroyed();
		if (!IsEffectiveVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:IsEffectiveVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEffectiveVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEffectiveVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEffectiveVisible_FunctionAddress, intPtr, IsEffectiveVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEffectiveVisible_ReturnValue_Offset), 0, IsEffectiveVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DataLayer:GetInitialRuntimeState")]
	public unsafe EDataLayerRuntimeState GetInitialRuntimeState()
	{
		CheckDestroyed();
		if (!GetInitialRuntimeState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:GetInitialRuntimeState");
			return EDataLayerRuntimeState.Unloaded;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInitialRuntimeState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInitialRuntimeState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInitialRuntimeState_FunctionAddress, intPtr, GetInitialRuntimeState_ParamsSize);
		return EnumMarshaler<EDataLayerRuntimeState>.FromNative(IntPtr.Add(intPtr, GetInitialRuntimeState_ReturnValue_Offset), 0, GetInitialRuntimeState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.DataLayer:GetDebugColor")]
	public unsafe FColor GetDebugColor()
	{
		CheckDestroyed();
		if (!GetDebugColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:GetDebugColor");
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDebugColor_FunctionAddress, intPtr, GetDebugColor_ParamsSize);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, GetDebugColor_ReturnValue_Offset), 0, GetDebugColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DataLayer:GetDataLayerLabel")]
	public unsafe FName GetDataLayerLabel()
	{
		CheckDestroyed();
		if (!GetDataLayerLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:GetDataLayerLabel");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataLayerLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataLayerLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDataLayerLabel_FunctionAddress, intPtr, GetDataLayerLabel_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetDataLayerLabel_ReturnValue_Offset), 0, GetDataLayerLabel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.DataLayer:Equals")]
	public unsafe bool Equals(FActorDataLayer ActorDataLayer)
	{
		CheckDestroyed();
		if (!Equals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataLayer:Equals");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Equals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Equals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Equals_ActorDataLayer_PropertyAddress.Address, intPtr);
		FActorDataLayer.ToNative(IntPtr.Add(intPtr, Equals_ActorDataLayer_Offset), 0, Equals_ActorDataLayer_PropertyAddress.Address, ActorDataLayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, Equals_FunctionAddress, intPtr, Equals_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Equals_ReturnValue_Offset), 0, Equals_ReturnValue_PropertyAddress.Address);
	}

	static UDataLayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataLayer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.DataLayer");
		IsVisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsVisible");
		IsVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVisible_ReturnValue_PropertyAddress, IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVisible_IsValid = IsVisible_FunctionAddress != IntPtr.Zero && IsVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:IsVisible", IsVisible_IsValid);
		IsRuntime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsRuntime");
		IsRuntime_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRuntime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRuntime_ReturnValue_PropertyAddress, IsRuntime_FunctionAddress, "ReturnValue");
		IsRuntime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRuntime_FunctionAddress, "ReturnValue");
		IsRuntime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRuntime_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRuntime_IsValid = IsRuntime_FunctionAddress != IntPtr.Zero && IsRuntime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:IsRuntime", IsRuntime_IsValid);
		IsInitiallyVisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInitiallyVisible");
		IsInitiallyVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInitiallyVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInitiallyVisible_ReturnValue_PropertyAddress, IsInitiallyVisible_FunctionAddress, "ReturnValue");
		IsInitiallyVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInitiallyVisible_FunctionAddress, "ReturnValue");
		IsInitiallyVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInitiallyVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInitiallyVisible_IsValid = IsInitiallyVisible_FunctionAddress != IntPtr.Zero && IsInitiallyVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:IsInitiallyVisible", IsInitiallyVisible_IsValid);
		IsEffectiveVisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEffectiveVisible");
		IsEffectiveVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEffectiveVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEffectiveVisible_ReturnValue_PropertyAddress, IsEffectiveVisible_FunctionAddress, "ReturnValue");
		IsEffectiveVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEffectiveVisible_FunctionAddress, "ReturnValue");
		IsEffectiveVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEffectiveVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEffectiveVisible_IsValid = IsEffectiveVisible_FunctionAddress != IntPtr.Zero && IsEffectiveVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:IsEffectiveVisible", IsEffectiveVisible_IsValid);
		GetInitialRuntimeState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInitialRuntimeState");
		GetInitialRuntimeState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInitialRuntimeState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInitialRuntimeState_ReturnValue_PropertyAddress, GetInitialRuntimeState_FunctionAddress, "ReturnValue");
		GetInitialRuntimeState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialRuntimeState_FunctionAddress, "ReturnValue");
		GetInitialRuntimeState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialRuntimeState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetInitialRuntimeState_IsValid = GetInitialRuntimeState_FunctionAddress != IntPtr.Zero && GetInitialRuntimeState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:GetInitialRuntimeState", GetInitialRuntimeState_IsValid);
		GetDebugColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDebugColor");
		GetDebugColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugColor_ReturnValue_PropertyAddress, GetDebugColor_FunctionAddress, "ReturnValue");
		GetDebugColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugColor_FunctionAddress, "ReturnValue");
		GetDebugColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDebugColor_IsValid = GetDebugColor_FunctionAddress != IntPtr.Zero && GetDebugColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:GetDebugColor", GetDebugColor_IsValid);
		GetDataLayerLabel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDataLayerLabel");
		GetDataLayerLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataLayerLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataLayerLabel_ReturnValue_PropertyAddress, GetDataLayerLabel_FunctionAddress, "ReturnValue");
		GetDataLayerLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDataLayerLabel_FunctionAddress, "ReturnValue");
		GetDataLayerLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataLayerLabel_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetDataLayerLabel_IsValid = GetDataLayerLabel_FunctionAddress != IntPtr.Zero && GetDataLayerLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:GetDataLayerLabel", GetDataLayerLabel_IsValid);
		Equals_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Equals");
		Equals_ParamsSize = NativeReflection.GetFunctionParamsSize(Equals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Equals_ActorDataLayer_PropertyAddress, Equals_FunctionAddress, "ActorDataLayer");
		Equals_ActorDataLayer_Offset = NativeReflectionCached.GetPropertyOffset(Equals_FunctionAddress, "ActorDataLayer");
		Equals_ActorDataLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(Equals_FunctionAddress, "ActorDataLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Equals_ReturnValue_PropertyAddress, Equals_FunctionAddress, "ReturnValue");
		Equals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Equals_FunctionAddress, "ReturnValue");
		Equals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Equals_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Equals_IsValid = Equals_FunctionAddress != IntPtr.Zero && Equals_ActorDataLayer_IsValid && Equals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataLayer:Equals", Equals_IsValid);
	}
}
