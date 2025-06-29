using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneDataLayerSection : UMovieSceneSection, IMovieSceneEntityProvider, IInterface
{
	private static bool SetPrerollState_IsValid;

	private static IntPtr SetPrerollState_FunctionAddress;

	private static int SetPrerollState_ParamsSize;

	private static bool SetPrerollState_InPrerollState_IsValid;

	private static FFieldAddress SetPrerollState_InPrerollState_PropertyAddress;

	private static int SetPrerollState_InPrerollState_Offset;

	private static bool SetFlushOnUnload_IsValid;

	private static IntPtr SetFlushOnUnload_FunctionAddress;

	private static int SetFlushOnUnload_ParamsSize;

	private static bool SetFlushOnUnload_bFlushOnUnload_IsValid;

	private static FFieldAddress SetFlushOnUnload_bFlushOnUnload_PropertyAddress;

	private static int SetFlushOnUnload_bFlushOnUnload_Offset;

	private static bool SetDesiredState_IsValid;

	private static IntPtr SetDesiredState_FunctionAddress;

	private static int SetDesiredState_ParamsSize;

	private static bool SetDesiredState_InDesiredState_IsValid;

	private static FFieldAddress SetDesiredState_InDesiredState_PropertyAddress;

	private static int SetDesiredState_InDesiredState_Offset;

	private static bool SetDataLayers_IsValid;

	private static IntPtr SetDataLayers_FunctionAddress;

	private static int SetDataLayers_ParamsSize;

	private static bool SetDataLayers_InDataLayers_IsValid;

	private static FFieldAddress SetDataLayers_InDataLayers_PropertyAddress;

	private static int SetDataLayers_InDataLayers_Offset;

	private static bool GetPrerollState_IsValid;

	private static IntPtr GetPrerollState_FunctionAddress;

	private static int GetPrerollState_ParamsSize;

	private static bool GetPrerollState_ReturnValue_IsValid;

	private static FFieldAddress GetPrerollState_ReturnValue_PropertyAddress;

	private static int GetPrerollState_ReturnValue_Offset;

	private static bool GetFlushOnUnload_IsValid;

	private static IntPtr GetFlushOnUnload_FunctionAddress;

	private static int GetFlushOnUnload_ParamsSize;

	private static bool GetFlushOnUnload_ReturnValue_IsValid;

	private static FFieldAddress GetFlushOnUnload_ReturnValue_PropertyAddress;

	private static int GetFlushOnUnload_ReturnValue_Offset;

	private static bool GetDesiredState_IsValid;

	private static IntPtr GetDesiredState_FunctionAddress;

	private static int GetDesiredState_ParamsSize;

	private static bool GetDesiredState_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredState_ReturnValue_PropertyAddress;

	private static int GetDesiredState_ReturnValue_Offset;

	private static bool GetDataLayers_IsValid;

	private static IntPtr GetDataLayers_FunctionAddress;

	private static int GetDataLayers_ParamsSize;

	private static bool GetDataLayers_ReturnValue_IsValid;

	private static FFieldAddress GetDataLayers_ReturnValue_PropertyAddress;

	private static int GetDataLayers_ReturnValue_Offset;

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetPrerollState")]
	public unsafe void SetPrerollState(EDataLayerRuntimeState InPrerollState)
	{
		CheckDestroyed();
		if (!SetPrerollState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetPrerollState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPrerollState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPrerollState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDataLayerRuntimeState>.ToNative(IntPtr.Add(intPtr, SetPrerollState_InPrerollState_Offset), 0, SetPrerollState_InPrerollState_PropertyAddress.Address, InPrerollState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPrerollState_FunctionAddress, intPtr, SetPrerollState_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetFlushOnUnload")]
	public unsafe void SetFlushOnUnload(bool bFlushOnUnload)
	{
		CheckDestroyed();
		if (!SetFlushOnUnload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetFlushOnUnload");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFlushOnUnload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFlushOnUnload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFlushOnUnload_bFlushOnUnload_Offset), 0, SetFlushOnUnload_bFlushOnUnload_PropertyAddress.Address, bFlushOnUnload);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFlushOnUnload_FunctionAddress, intPtr, SetFlushOnUnload_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetDesiredState")]
	public unsafe void SetDesiredState(EDataLayerRuntimeState InDesiredState)
	{
		CheckDestroyed();
		if (!SetDesiredState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetDesiredState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDataLayerRuntimeState>.ToNative(IntPtr.Add(intPtr, SetDesiredState_InDesiredState_Offset), 0, SetDesiredState_InDesiredState_PropertyAddress.Address, InDesiredState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDesiredState_FunctionAddress, intPtr, SetDesiredState_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetDataLayers")]
	public unsafe void SetDataLayers(List<FActorDataLayer> InDataLayers)
	{
		CheckDestroyed();
		if (!SetDataLayers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetDataLayers");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDataLayers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDataLayers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FActorDataLayer>(1, SetDataLayers_InDataLayers_PropertyAddress, CachedMarshalingDelegates<FActorDataLayer, FActorDataLayer>.FromNative, CachedMarshalingDelegates<FActorDataLayer, FActorDataLayer>.ToNative).ToNative(IntPtr.Add(intPtr, SetDataLayers_InDataLayers_Offset), InDataLayers);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDataLayers_FunctionAddress, intPtr, SetDataLayers_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDataLayers_InDataLayers_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetPrerollState")]
	public unsafe EDataLayerRuntimeState GetPrerollState()
	{
		CheckDestroyed();
		if (!GetPrerollState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetPrerollState");
			return EDataLayerRuntimeState.Unloaded;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrerollState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrerollState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPrerollState_FunctionAddress, intPtr, GetPrerollState_ParamsSize);
		return EnumMarshaler<EDataLayerRuntimeState>.FromNative(IntPtr.Add(intPtr, GetPrerollState_ReturnValue_Offset), 0, GetPrerollState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetFlushOnUnload")]
	public unsafe bool GetFlushOnUnload()
	{
		CheckDestroyed();
		if (!GetFlushOnUnload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetFlushOnUnload");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFlushOnUnload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFlushOnUnload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFlushOnUnload_FunctionAddress, intPtr, GetFlushOnUnload_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFlushOnUnload_ReturnValue_Offset), 0, GetFlushOnUnload_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetDesiredState")]
	public unsafe EDataLayerRuntimeState GetDesiredState()
	{
		CheckDestroyed();
		if (!GetDesiredState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetDesiredState");
			return EDataLayerRuntimeState.Unloaded;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredState_FunctionAddress, intPtr, GetDesiredState_ParamsSize);
		return EnumMarshaler<EDataLayerRuntimeState>.FromNative(IntPtr.Add(intPtr, GetDesiredState_ReturnValue_Offset), 0, GetDesiredState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetDataLayers")]
	public unsafe List<FActorDataLayer> GetDataLayers()
	{
		CheckDestroyed();
		if (!GetDataLayers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetDataLayers");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataLayers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataLayers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDataLayers_FunctionAddress, intPtr, GetDataLayers_ParamsSize);
		List<FActorDataLayer> result = new TArrayCopyMarshaler<FActorDataLayer>(1, GetDataLayers_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FActorDataLayer, FActorDataLayer>.FromNative, CachedMarshalingDelegates<FActorDataLayer, FActorDataLayer>.ToNative).FromNative(IntPtr.Add(intPtr, GetDataLayers_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDataLayers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMovieSceneDataLayerSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneDataLayerSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneDataLayerSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneDataLayerSection");
		SetPrerollState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPrerollState");
		SetPrerollState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPrerollState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPrerollState_InPrerollState_PropertyAddress, SetPrerollState_FunctionAddress, "InPrerollState");
		SetPrerollState_InPrerollState_Offset = NativeReflectionCached.GetPropertyOffset(SetPrerollState_FunctionAddress, "InPrerollState");
		SetPrerollState_InPrerollState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPrerollState_FunctionAddress, "InPrerollState", Classes.FEnumProperty);
		SetPrerollState_IsValid = SetPrerollState_FunctionAddress != IntPtr.Zero && SetPrerollState_InPrerollState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetPrerollState", SetPrerollState_IsValid);
		SetFlushOnUnload_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFlushOnUnload");
		SetFlushOnUnload_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFlushOnUnload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFlushOnUnload_bFlushOnUnload_PropertyAddress, SetFlushOnUnload_FunctionAddress, "bFlushOnUnload");
		SetFlushOnUnload_bFlushOnUnload_Offset = NativeReflectionCached.GetPropertyOffset(SetFlushOnUnload_FunctionAddress, "bFlushOnUnload");
		SetFlushOnUnload_bFlushOnUnload_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFlushOnUnload_FunctionAddress, "bFlushOnUnload", Classes.FBoolProperty);
		SetFlushOnUnload_IsValid = SetFlushOnUnload_FunctionAddress != IntPtr.Zero && SetFlushOnUnload_bFlushOnUnload_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetFlushOnUnload", SetFlushOnUnload_IsValid);
		SetDesiredState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDesiredState");
		SetDesiredState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredState_InDesiredState_PropertyAddress, SetDesiredState_FunctionAddress, "InDesiredState");
		SetDesiredState_InDesiredState_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredState_FunctionAddress, "InDesiredState");
		SetDesiredState_InDesiredState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredState_FunctionAddress, "InDesiredState", Classes.FEnumProperty);
		SetDesiredState_IsValid = SetDesiredState_FunctionAddress != IntPtr.Zero && SetDesiredState_InDesiredState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetDesiredState", SetDesiredState_IsValid);
		SetDataLayers_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDataLayers");
		SetDataLayers_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDataLayers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDataLayers_InDataLayers_PropertyAddress, SetDataLayers_FunctionAddress, "InDataLayers");
		SetDataLayers_InDataLayers_Offset = NativeReflectionCached.GetPropertyOffset(SetDataLayers_FunctionAddress, "InDataLayers");
		SetDataLayers_InDataLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDataLayers_FunctionAddress, "InDataLayers", Classes.FArrayProperty);
		SetDataLayers_IsValid = SetDataLayers_FunctionAddress != IntPtr.Zero && SetDataLayers_InDataLayers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:SetDataLayers", SetDataLayers_IsValid);
		GetPrerollState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPrerollState");
		GetPrerollState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrerollState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrerollState_ReturnValue_PropertyAddress, GetPrerollState_FunctionAddress, "ReturnValue");
		GetPrerollState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrerollState_FunctionAddress, "ReturnValue");
		GetPrerollState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrerollState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPrerollState_IsValid = GetPrerollState_FunctionAddress != IntPtr.Zero && GetPrerollState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetPrerollState", GetPrerollState_IsValid);
		GetFlushOnUnload_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFlushOnUnload");
		GetFlushOnUnload_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFlushOnUnload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFlushOnUnload_ReturnValue_PropertyAddress, GetFlushOnUnload_FunctionAddress, "ReturnValue");
		GetFlushOnUnload_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFlushOnUnload_FunctionAddress, "ReturnValue");
		GetFlushOnUnload_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFlushOnUnload_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetFlushOnUnload_IsValid = GetFlushOnUnload_FunctionAddress != IntPtr.Zero && GetFlushOnUnload_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetFlushOnUnload", GetFlushOnUnload_IsValid);
		GetDesiredState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDesiredState");
		GetDesiredState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredState_ReturnValue_PropertyAddress, GetDesiredState_FunctionAddress, "ReturnValue");
		GetDesiredState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredState_FunctionAddress, "ReturnValue");
		GetDesiredState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDesiredState_IsValid = GetDesiredState_FunctionAddress != IntPtr.Zero && GetDesiredState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetDesiredState", GetDesiredState_IsValid);
		GetDataLayers_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDataLayers");
		GetDataLayers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataLayers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataLayers_ReturnValue_PropertyAddress, GetDataLayers_FunctionAddress, "ReturnValue");
		GetDataLayers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDataLayers_FunctionAddress, "ReturnValue");
		GetDataLayers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataLayers_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDataLayers_IsValid = GetDataLayers_FunctionAddress != IntPtr.Zero && GetDataLayers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneDataLayerSection:GetDataLayers", GetDataLayers_IsValid);
	}
}
