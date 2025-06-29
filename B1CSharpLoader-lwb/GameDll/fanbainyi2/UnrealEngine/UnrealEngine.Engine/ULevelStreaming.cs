using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818942113uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.LevelStreaming", "Engine", UnrealModuleType.Engine)]
public class ULevelStreaming : UObject
{
	private static bool WorldAsset_IsValid;

	private static int WorldAsset_Offset;

	private static bool StreamingPriority_IsValid;

	private static int StreamingPriority_Offset;

	private static bool LevelTransform_IsValid;

	private static int LevelTransform_Offset;

	private static bool ShouldBeLoaded_IsValid;

	private static FFieldAddress ShouldBeLoaded_PropertyAddress;

	private static int ShouldBeLoaded_Offset;

	private static bool ShouldBlockOnLoad_IsValid;

	private static FFieldAddress ShouldBlockOnLoad_PropertyAddress;

	private static int ShouldBlockOnLoad_Offset;

	private static bool ShouldBlockOnUnload_IsValid;

	private static FFieldAddress ShouldBlockOnUnload_PropertyAddress;

	private static int ShouldBlockOnUnload_Offset;

	private static bool DisableDistanceStreaming_IsValid;

	private static FFieldAddress DisableDistanceStreaming_PropertyAddress;

	private static int DisableDistanceStreaming_Offset;

	private static bool OnLevelLoaded_IsValid;

	private static int OnLevelLoaded_Offset;

	private FLevelStreamingLoadedStatus OnLevelLoaded_DelegateCached;

	private static bool OnLevelUnloaded_IsValid;

	private static int OnLevelUnloaded_Offset;

	private FLevelStreamingLoadedStatus OnLevelUnloaded_DelegateCached;

	private static bool OnLevelShown_IsValid;

	private static int OnLevelShown_Offset;

	private FLevelStreamingVisibilityStatus OnLevelShown_DelegateCached;

	private static bool OnLevelHidden_IsValid;

	private static int OnLevelHidden_Offset;

	private FLevelStreamingVisibilityStatus OnLevelHidden_DelegateCached;

	private static bool ShouldBeLoaded_18D4FF06_IsValid;

	private static IntPtr ShouldBeLoaded_18D4FF06_FunctionAddress;

	private static int ShouldBeLoaded_18D4FF06_ParamsSize;

	private static bool ShouldBeLoaded_18D4FF06_ReturnValue_IsValid;

	private static FFieldAddress ShouldBeLoaded_18D4FF06_ReturnValue_PropertyAddress;

	private static int ShouldBeLoaded_18D4FF06_ReturnValue_Offset;

	private static bool SetShouldBeVisible_IsValid;

	private static IntPtr SetShouldBeVisible_FunctionAddress;

	private static int SetShouldBeVisible_ParamsSize;

	private static bool SetShouldBeVisible_bInShouldBeVisible_IsValid;

	private static FFieldAddress SetShouldBeVisible_bInShouldBeVisible_PropertyAddress;

	private static int SetShouldBeVisible_bInShouldBeVisible_Offset;

	private static bool SetShouldBeLoaded_IsValid;

	private static IntPtr SetShouldBeLoaded_FunctionAddress;

	private static int SetShouldBeLoaded_ParamsSize;

	private static bool SetShouldBeLoaded_bInShouldBeLoaded_IsValid;

	private static FFieldAddress SetShouldBeLoaded_bInShouldBeLoaded_PropertyAddress;

	private static int SetShouldBeLoaded_bInShouldBeLoaded_Offset;

	private static bool SetPriority_IsValid;

	private static IntPtr SetPriority_FunctionAddress;

	private static int SetPriority_ParamsSize;

	private static bool SetPriority_NewPriority_IsValid;

	private static FFieldAddress SetPriority_NewPriority_PropertyAddress;

	private static int SetPriority_NewPriority_Offset;

	private static bool SetLevelLODIndex_IsValid;

	private static IntPtr SetLevelLODIndex_FunctionAddress;

	private static int SetLevelLODIndex_ParamsSize;

	private static bool SetLevelLODIndex_LODIndex_IsValid;

	private static FFieldAddress SetLevelLODIndex_LODIndex_PropertyAddress;

	private static int SetLevelLODIndex_LODIndex_Offset;

	private static bool SetIsRequestingUnloadAndRemoval_IsValid;

	private static IntPtr SetIsRequestingUnloadAndRemoval_FunctionAddress;

	private static int SetIsRequestingUnloadAndRemoval_ParamsSize;

	private static bool SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_IsValid;

	private static FFieldAddress SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_PropertyAddress;

	private static int SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_Offset;

	private static bool IsStreamingStatePending_IsValid;

	private static IntPtr IsStreamingStatePending_FunctionAddress;

	private static int IsStreamingStatePending_ParamsSize;

	private static bool IsStreamingStatePending_ReturnValue_IsValid;

	private static FFieldAddress IsStreamingStatePending_ReturnValue_PropertyAddress;

	private static int IsStreamingStatePending_ReturnValue_Offset;

	private static bool IsLevelVisible_IsValid;

	private static IntPtr IsLevelVisible_FunctionAddress;

	private static int IsLevelVisible_ParamsSize;

	private static bool IsLevelVisible_ReturnValue_IsValid;

	private static FFieldAddress IsLevelVisible_ReturnValue_PropertyAddress;

	private static int IsLevelVisible_ReturnValue_Offset;

	private static bool IsLevelLoaded_IsValid;

	private static IntPtr IsLevelLoaded_FunctionAddress;

	private static int IsLevelLoaded_ParamsSize;

	private static bool IsLevelLoaded_ReturnValue_IsValid;

	private static FFieldAddress IsLevelLoaded_ReturnValue_PropertyAddress;

	private static int IsLevelLoaded_ReturnValue_Offset;

	private static bool GetWorldAssetPackageFName_IsValid;

	private static IntPtr GetWorldAssetPackageFName_FunctionAddress;

	private static int GetWorldAssetPackageFName_ParamsSize;

	private static bool GetWorldAssetPackageFName_ReturnValue_IsValid;

	private static FFieldAddress GetWorldAssetPackageFName_ReturnValue_PropertyAddress;

	private static int GetWorldAssetPackageFName_ReturnValue_Offset;

	private static bool GetLoadedLevel_IsValid;

	private static IntPtr GetLoadedLevel_FunctionAddress;

	private static int GetLoadedLevel_ParamsSize;

	private static bool GetLoadedLevel_ReturnValue_IsValid;

	private static FFieldAddress GetLoadedLevel_ReturnValue_PropertyAddress;

	private static int GetLoadedLevel_ReturnValue_Offset;

	private static bool GetIsRequestingUnloadAndRemoval_IsValid;

	private static IntPtr GetIsRequestingUnloadAndRemoval_FunctionAddress;

	private static int GetIsRequestingUnloadAndRemoval_ParamsSize;

	private static bool GetIsRequestingUnloadAndRemoval_ReturnValue_IsValid;

	private static FFieldAddress GetIsRequestingUnloadAndRemoval_ReturnValue_PropertyAddress;

	private static int GetIsRequestingUnloadAndRemoval_ReturnValue_Offset;

	private static bool CreateInstance_IsValid;

	private static IntPtr CreateInstance_FunctionAddress;

	private static int CreateInstance_ParamsSize;

	private static bool CreateInstance_UniqueInstanceName_IsValid;

	private static FFieldAddress CreateInstance_UniqueInstanceName_PropertyAddress;

	private static int CreateInstance_UniqueInstanceName_Offset;

	private static bool CreateInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateInstance_ReturnValue_PropertyAddress;

	private static int CreateInstance_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393695068422165uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:WorldAsset")]
	protected TSoftObject<UWorld> WorldAsset
	{
		get
		{
			CheckDestroyed();
			if (!WorldAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:WorldAsset");
				return default(TSoftObject<UWorld>);
			}
			return TSoftObjectMarshaler<UWorld>.FromNative(IntPtr.Add(base.Address, WorldAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WorldAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:WorldAsset");
			}
			else
			{
				TSoftObjectMarshaler<UWorld>.ToNative(IntPtr.Add(base.Address, WorldAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:StreamingPriority")]
	protected int StreamingPriority
	{
		get
		{
			CheckDestroyed();
			if (!StreamingPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:StreamingPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StreamingPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:StreamingPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StreamingPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:LevelTransform")]
	public FTransform LevelTransform
	{
		get
		{
			CheckDestroyed();
			if (!LevelTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:LevelTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, LevelTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:LevelTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, LevelTransform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925188uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:bShouldBeLoaded")]
	protected bool ShouldBeLoaded
	{
		get
		{
			CheckDestroyed();
			if (!ShouldBeLoaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bShouldBeLoaded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldBeLoaded_Offset), 0, ShouldBeLoaded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldBeLoaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bShouldBeLoaded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldBeLoaded_Offset), 0, ShouldBeLoaded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:bShouldBlockOnLoad")]
	public bool ShouldBlockOnLoad
	{
		get
		{
			CheckDestroyed();
			if (!ShouldBlockOnLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bShouldBlockOnLoad");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldBlockOnLoad_Offset), 0, ShouldBlockOnLoad_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldBlockOnLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bShouldBlockOnLoad");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldBlockOnLoad_Offset), 0, ShouldBlockOnLoad_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:bShouldBlockOnUnload")]
	public bool ShouldBlockOnUnload
	{
		get
		{
			CheckDestroyed();
			if (!ShouldBlockOnUnload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bShouldBlockOnUnload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldBlockOnUnload_Offset), 0, ShouldBlockOnUnload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldBlockOnUnload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bShouldBlockOnUnload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldBlockOnUnload_Offset), 0, ShouldBlockOnUnload_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160540676uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:bDisableDistanceStreaming")]
	public bool DisableDistanceStreaming
	{
		get
		{
			CheckDestroyed();
			if (!DisableDistanceStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bDisableDistanceStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableDistanceStreaming_Offset), 0, DisableDistanceStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableDistanceStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:bDisableDistanceStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableDistanceStreaming_Offset), 0, DisableDistanceStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:OnLevelLoaded")]
	public FLevelStreamingLoadedStatus OnLevelLoaded
	{
		get
		{
			CheckDestroyed();
			if (!OnLevelLoaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:OnLevelLoaded");
				return new FLevelStreamingLoadedStatus();
			}
			if (OnLevelLoaded_DelegateCached == null)
			{
				OnLevelLoaded_DelegateCached = new FLevelStreamingLoadedStatus();
				OnLevelLoaded_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLevelLoaded_Offset));
			}
			return OnLevelLoaded_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:OnLevelUnloaded")]
	public FLevelStreamingLoadedStatus OnLevelUnloaded
	{
		get
		{
			CheckDestroyed();
			if (!OnLevelUnloaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:OnLevelUnloaded");
				return new FLevelStreamingLoadedStatus();
			}
			if (OnLevelUnloaded_DelegateCached == null)
			{
				OnLevelUnloaded_DelegateCached = new FLevelStreamingLoadedStatus();
				OnLevelUnloaded_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLevelUnloaded_Offset));
			}
			return OnLevelUnloaded_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:OnLevelShown")]
	public FLevelStreamingVisibilityStatus OnLevelShown
	{
		get
		{
			CheckDestroyed();
			if (!OnLevelShown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:OnLevelShown");
				return new FLevelStreamingVisibilityStatus();
			}
			if (OnLevelShown_DelegateCached == null)
			{
				OnLevelShown_DelegateCached = new FLevelStreamingVisibilityStatus();
				OnLevelShown_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLevelShown_Offset));
			}
			return OnLevelShown_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.LevelStreaming:OnLevelHidden")]
	public FLevelStreamingVisibilityStatus OnLevelHidden
	{
		get
		{
			CheckDestroyed();
			if (!OnLevelHidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreaming:OnLevelHidden");
				return new FLevelStreamingVisibilityStatus();
			}
			if (OnLevelHidden_DelegateCached == null)
			{
				OnLevelHidden_DelegateCached = new FLevelStreamingVisibilityStatus();
				OnLevelHidden_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLevelHidden_Offset));
			}
			return OnLevelHidden_DelegateCached;
		}
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.LevelStreaming:ShouldBeLoaded")]
	public unsafe bool ShouldBeLoaded_18D4FF06()
	{
		CheckDestroyed();
		if (!ShouldBeLoaded_18D4FF06_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:ShouldBeLoaded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldBeLoaded_18D4FF06_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldBeLoaded_18D4FF06_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldBeLoaded_18D4FF06_FunctionAddress, intPtr, ShouldBeLoaded_18D4FF06_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldBeLoaded_18D4FF06_ReturnValue_Offset), 0, ShouldBeLoaded_18D4FF06_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LevelStreaming:SetShouldBeVisible")]
	public unsafe void SetShouldBeVisible(bool bInShouldBeVisible)
	{
		CheckDestroyed();
		if (!SetShouldBeVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:SetShouldBeVisible");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShouldBeVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShouldBeVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetShouldBeVisible_bInShouldBeVisible_Offset), 0, SetShouldBeVisible_bInShouldBeVisible_PropertyAddress.Address, bInShouldBeVisible);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShouldBeVisible_FunctionAddress, intPtr, SetShouldBeVisible_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.LevelStreaming:SetShouldBeLoaded")]
	public unsafe void SetShouldBeLoaded(bool bInShouldBeLoaded)
	{
		CheckDestroyed();
		if (!SetShouldBeLoaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:SetShouldBeLoaded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShouldBeLoaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShouldBeLoaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetShouldBeLoaded_bInShouldBeLoaded_Offset), 0, SetShouldBeLoaded_bInShouldBeLoaded_PropertyAddress.Address, bInShouldBeLoaded);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShouldBeLoaded_FunctionAddress, intPtr, SetShouldBeLoaded_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LevelStreaming:SetPriority")]
	public unsafe void SetPriority(int NewPriority)
	{
		CheckDestroyed();
		if (!SetPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:SetPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPriority_NewPriority_Offset), 0, SetPriority_NewPriority_PropertyAddress.Address, NewPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPriority_FunctionAddress, intPtr, SetPriority_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LevelStreaming:SetLevelLODIndex")]
	public unsafe void SetLevelLODIndex(int LODIndex)
	{
		CheckDestroyed();
		if (!SetLevelLODIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:SetLevelLODIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelLODIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelLODIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLevelLODIndex_LODIndex_Offset), 0, SetLevelLODIndex_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLevelLODIndex_FunctionAddress, intPtr, SetLevelLODIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LevelStreaming:SetIsRequestingUnloadAndRemoval")]
	public unsafe void SetIsRequestingUnloadAndRemoval(bool bInIsRequestingUnloadAndRemoval)
	{
		CheckDestroyed();
		if (!SetIsRequestingUnloadAndRemoval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:SetIsRequestingUnloadAndRemoval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsRequestingUnloadAndRemoval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsRequestingUnloadAndRemoval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_Offset), 0, SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_PropertyAddress.Address, bInIsRequestingUnloadAndRemoval);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsRequestingUnloadAndRemoval_FunctionAddress, intPtr, SetIsRequestingUnloadAndRemoval_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.LevelStreaming:IsStreamingStatePending")]
	public unsafe bool IsStreamingStatePending()
	{
		CheckDestroyed();
		if (!IsStreamingStatePending_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:IsStreamingStatePending");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStreamingStatePending_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStreamingStatePending_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStreamingStatePending_FunctionAddress, intPtr, IsStreamingStatePending_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStreamingStatePending_ReturnValue_Offset), 0, IsStreamingStatePending_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.LevelStreaming:IsLevelVisible")]
	public unsafe bool IsLevelVisible()
	{
		CheckDestroyed();
		if (!IsLevelVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:IsLevelVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLevelVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLevelVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLevelVisible_FunctionAddress, intPtr, IsLevelVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLevelVisible_ReturnValue_Offset), 0, IsLevelVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.LevelStreaming:IsLevelLoaded")]
	public unsafe bool IsLevelLoaded()
	{
		CheckDestroyed();
		if (!IsLevelLoaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:IsLevelLoaded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLevelLoaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLevelLoaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLevelLoaded_FunctionAddress, intPtr, IsLevelLoaded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLevelLoaded_ReturnValue_Offset), 0, IsLevelLoaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.LevelStreaming:GetWorldAssetPackageFName")]
	public unsafe FName GetWorldAssetPackageFName()
	{
		CheckDestroyed();
		if (!GetWorldAssetPackageFName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:GetWorldAssetPackageFName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldAssetPackageFName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldAssetPackageFName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldAssetPackageFName_FunctionAddress, intPtr, GetWorldAssetPackageFName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetWorldAssetPackageFName_ReturnValue_Offset), 0, GetWorldAssetPackageFName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.LevelStreaming:GetLoadedLevel")]
	public unsafe ULevel GetLoadedLevel()
	{
		CheckDestroyed();
		if (!GetLoadedLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:GetLoadedLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoadedLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoadedLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLoadedLevel_FunctionAddress, intPtr, GetLoadedLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetLoadedLevel_ReturnValue_Offset), 0, GetLoadedLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.LevelStreaming:GetIsRequestingUnloadAndRemoval")]
	public unsafe bool GetIsRequestingUnloadAndRemoval()
	{
		CheckDestroyed();
		if (!GetIsRequestingUnloadAndRemoval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:GetIsRequestingUnloadAndRemoval");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsRequestingUnloadAndRemoval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsRequestingUnloadAndRemoval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsRequestingUnloadAndRemoval_FunctionAddress, intPtr, GetIsRequestingUnloadAndRemoval_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsRequestingUnloadAndRemoval_ReturnValue_Offset), 0, GetIsRequestingUnloadAndRemoval_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LevelStreaming:CreateInstance")]
	public unsafe ULevelStreaming CreateInstance(string UniqueInstanceName)
	{
		CheckDestroyed();
		if (!CreateInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreaming:CreateInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateInstance_UniqueInstanceName_Offset), 0, CreateInstance_UniqueInstanceName_PropertyAddress.Address, UniqueInstanceName);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateInstance_FunctionAddress, intPtr, CreateInstance_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateInstance_UniqueInstanceName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ULevelStreaming>.FromNative(IntPtr.Add(intPtr, CreateInstance_ReturnValue_Offset), 0, CreateInstance_ReturnValue_PropertyAddress.Address);
	}

	static ULevelStreaming()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelStreaming)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelStreaming));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.LevelStreaming");
		WorldAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorldAsset");
		WorldAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorldAsset", Classes.FSoftObjectProperty);
		StreamingPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingPriority");
		StreamingPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingPriority", Classes.FIntProperty);
		LevelTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LevelTransform");
		LevelTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LevelTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldBeLoaded_PropertyAddress, intPtr, "bShouldBeLoaded");
		ShouldBeLoaded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBeLoaded");
		ShouldBeLoaded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBeLoaded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldBlockOnLoad_PropertyAddress, intPtr, "bShouldBlockOnLoad");
		ShouldBlockOnLoad_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBlockOnLoad");
		ShouldBlockOnLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBlockOnLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldBlockOnUnload_PropertyAddress, intPtr, "bShouldBlockOnUnload");
		ShouldBlockOnUnload_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBlockOnUnload");
		ShouldBlockOnUnload_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBlockOnUnload", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableDistanceStreaming_PropertyAddress, intPtr, "bDisableDistanceStreaming");
		DisableDistanceStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableDistanceStreaming");
		DisableDistanceStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableDistanceStreaming", Classes.FBoolProperty);
		OnLevelLoaded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnLevelLoaded");
		OnLevelLoaded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnLevelLoaded", Classes.FMulticastDelegateProperty);
		OnLevelUnloaded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnLevelUnloaded");
		OnLevelUnloaded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnLevelUnloaded", Classes.FMulticastDelegateProperty);
		OnLevelShown_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnLevelShown");
		OnLevelShown_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnLevelShown", Classes.FMulticastDelegateProperty);
		OnLevelHidden_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnLevelHidden");
		OnLevelHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnLevelHidden", Classes.FMulticastDelegateProperty);
		ShouldBeLoaded_18D4FF06_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldBeLoaded");
		ShouldBeLoaded_18D4FF06_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldBeLoaded_18D4FF06_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldBeLoaded_18D4FF06_ReturnValue_PropertyAddress, ShouldBeLoaded_18D4FF06_FunctionAddress, "ReturnValue");
		ShouldBeLoaded_18D4FF06_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldBeLoaded_18D4FF06_FunctionAddress, "ReturnValue");
		ShouldBeLoaded_18D4FF06_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldBeLoaded_18D4FF06_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldBeLoaded_18D4FF06_IsValid = ShouldBeLoaded_18D4FF06_FunctionAddress != IntPtr.Zero && ShouldBeLoaded_18D4FF06_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:ShouldBeLoaded", ShouldBeLoaded_18D4FF06_IsValid);
		SetShouldBeVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShouldBeVisible");
		SetShouldBeVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShouldBeVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShouldBeVisible_bInShouldBeVisible_PropertyAddress, SetShouldBeVisible_FunctionAddress, "bInShouldBeVisible");
		SetShouldBeVisible_bInShouldBeVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetShouldBeVisible_FunctionAddress, "bInShouldBeVisible");
		SetShouldBeVisible_bInShouldBeVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShouldBeVisible_FunctionAddress, "bInShouldBeVisible", Classes.FBoolProperty);
		SetShouldBeVisible_IsValid = SetShouldBeVisible_FunctionAddress != IntPtr.Zero && SetShouldBeVisible_bInShouldBeVisible_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:SetShouldBeVisible", SetShouldBeVisible_IsValid);
		SetShouldBeLoaded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShouldBeLoaded");
		SetShouldBeLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShouldBeLoaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShouldBeLoaded_bInShouldBeLoaded_PropertyAddress, SetShouldBeLoaded_FunctionAddress, "bInShouldBeLoaded");
		SetShouldBeLoaded_bInShouldBeLoaded_Offset = NativeReflectionCached.GetPropertyOffset(SetShouldBeLoaded_FunctionAddress, "bInShouldBeLoaded");
		SetShouldBeLoaded_bInShouldBeLoaded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShouldBeLoaded_FunctionAddress, "bInShouldBeLoaded", Classes.FBoolProperty);
		SetShouldBeLoaded_IsValid = SetShouldBeLoaded_FunctionAddress != IntPtr.Zero && SetShouldBeLoaded_bInShouldBeLoaded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:SetShouldBeLoaded", SetShouldBeLoaded_IsValid);
		SetPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPriority");
		SetPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPriority_NewPriority_PropertyAddress, SetPriority_FunctionAddress, "NewPriority");
		SetPriority_NewPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetPriority_FunctionAddress, "NewPriority");
		SetPriority_NewPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPriority_FunctionAddress, "NewPriority", Classes.FIntProperty);
		SetPriority_IsValid = SetPriority_FunctionAddress != IntPtr.Zero && SetPriority_NewPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:SetPriority", SetPriority_IsValid);
		SetLevelLODIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLevelLODIndex");
		SetLevelLODIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelLODIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelLODIndex_LODIndex_PropertyAddress, SetLevelLODIndex_FunctionAddress, "LODIndex");
		SetLevelLODIndex_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelLODIndex_FunctionAddress, "LODIndex");
		SetLevelLODIndex_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelLODIndex_FunctionAddress, "LODIndex", Classes.FIntProperty);
		SetLevelLODIndex_IsValid = SetLevelLODIndex_FunctionAddress != IntPtr.Zero && SetLevelLODIndex_LODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:SetLevelLODIndex", SetLevelLODIndex_IsValid);
		SetIsRequestingUnloadAndRemoval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsRequestingUnloadAndRemoval");
		SetIsRequestingUnloadAndRemoval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsRequestingUnloadAndRemoval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_PropertyAddress, SetIsRequestingUnloadAndRemoval_FunctionAddress, "bInIsRequestingUnloadAndRemoval");
		SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_Offset = NativeReflectionCached.GetPropertyOffset(SetIsRequestingUnloadAndRemoval_FunctionAddress, "bInIsRequestingUnloadAndRemoval");
		SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsRequestingUnloadAndRemoval_FunctionAddress, "bInIsRequestingUnloadAndRemoval", Classes.FBoolProperty);
		SetIsRequestingUnloadAndRemoval_IsValid = SetIsRequestingUnloadAndRemoval_FunctionAddress != IntPtr.Zero && SetIsRequestingUnloadAndRemoval_bInIsRequestingUnloadAndRemoval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:SetIsRequestingUnloadAndRemoval", SetIsRequestingUnloadAndRemoval_IsValid);
		IsStreamingStatePending_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsStreamingStatePending");
		IsStreamingStatePending_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStreamingStatePending_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStreamingStatePending_ReturnValue_PropertyAddress, IsStreamingStatePending_FunctionAddress, "ReturnValue");
		IsStreamingStatePending_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamingStatePending_FunctionAddress, "ReturnValue");
		IsStreamingStatePending_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamingStatePending_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStreamingStatePending_IsValid = IsStreamingStatePending_FunctionAddress != IntPtr.Zero && IsStreamingStatePending_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:IsStreamingStatePending", IsStreamingStatePending_IsValid);
		IsLevelVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLevelVisible");
		IsLevelVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLevelVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLevelVisible_ReturnValue_PropertyAddress, IsLevelVisible_FunctionAddress, "ReturnValue");
		IsLevelVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLevelVisible_FunctionAddress, "ReturnValue");
		IsLevelVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLevelVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLevelVisible_IsValid = IsLevelVisible_FunctionAddress != IntPtr.Zero && IsLevelVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:IsLevelVisible", IsLevelVisible_IsValid);
		IsLevelLoaded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLevelLoaded");
		IsLevelLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLevelLoaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLevelLoaded_ReturnValue_PropertyAddress, IsLevelLoaded_FunctionAddress, "ReturnValue");
		IsLevelLoaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLevelLoaded_FunctionAddress, "ReturnValue");
		IsLevelLoaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLevelLoaded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLevelLoaded_IsValid = IsLevelLoaded_FunctionAddress != IntPtr.Zero && IsLevelLoaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:IsLevelLoaded", IsLevelLoaded_IsValid);
		GetWorldAssetPackageFName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWorldAssetPackageFName");
		GetWorldAssetPackageFName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldAssetPackageFName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldAssetPackageFName_ReturnValue_PropertyAddress, GetWorldAssetPackageFName_FunctionAddress, "ReturnValue");
		GetWorldAssetPackageFName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldAssetPackageFName_FunctionAddress, "ReturnValue");
		GetWorldAssetPackageFName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldAssetPackageFName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetWorldAssetPackageFName_IsValid = GetWorldAssetPackageFName_FunctionAddress != IntPtr.Zero && GetWorldAssetPackageFName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:GetWorldAssetPackageFName", GetWorldAssetPackageFName_IsValid);
		GetLoadedLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLoadedLevel");
		GetLoadedLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoadedLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoadedLevel_ReturnValue_PropertyAddress, GetLoadedLevel_FunctionAddress, "ReturnValue");
		GetLoadedLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLoadedLevel_FunctionAddress, "ReturnValue");
		GetLoadedLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoadedLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLoadedLevel_IsValid = GetLoadedLevel_FunctionAddress != IntPtr.Zero && GetLoadedLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:GetLoadedLevel", GetLoadedLevel_IsValid);
		GetIsRequestingUnloadAndRemoval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIsRequestingUnloadAndRemoval");
		GetIsRequestingUnloadAndRemoval_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsRequestingUnloadAndRemoval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsRequestingUnloadAndRemoval_ReturnValue_PropertyAddress, GetIsRequestingUnloadAndRemoval_FunctionAddress, "ReturnValue");
		GetIsRequestingUnloadAndRemoval_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsRequestingUnloadAndRemoval_FunctionAddress, "ReturnValue");
		GetIsRequestingUnloadAndRemoval_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsRequestingUnloadAndRemoval_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsRequestingUnloadAndRemoval_IsValid = GetIsRequestingUnloadAndRemoval_FunctionAddress != IntPtr.Zero && GetIsRequestingUnloadAndRemoval_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:GetIsRequestingUnloadAndRemoval", GetIsRequestingUnloadAndRemoval_IsValid);
		CreateInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateInstance");
		CreateInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInstance_UniqueInstanceName_PropertyAddress, CreateInstance_FunctionAddress, "UniqueInstanceName");
		CreateInstance_UniqueInstanceName_Offset = NativeReflectionCached.GetPropertyOffset(CreateInstance_FunctionAddress, "UniqueInstanceName");
		CreateInstance_UniqueInstanceName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInstance_FunctionAddress, "UniqueInstanceName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInstance_ReturnValue_PropertyAddress, CreateInstance_FunctionAddress, "ReturnValue");
		CreateInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateInstance_FunctionAddress, "ReturnValue");
		CreateInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateInstance_IsValid = CreateInstance_FunctionAddress != IntPtr.Zero && CreateInstance_UniqueInstanceName_IsValid && CreateInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreaming:CreateInstance", CreateInstance_IsValid);
	}
}
