using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SceneCaptureComponent", "Engine", UnrealModuleType.Engine)]
public class USceneCaptureComponent : USceneComponent
{
	private static bool PrimitiveRenderMode_IsValid;

	private static FFieldAddress PrimitiveRenderMode_PropertyAddress;

	private static int PrimitiveRenderMode_Offset;

	private static bool CaptureSource_IsValid;

	private static FFieldAddress CaptureSource_PropertyAddress;

	private static int CaptureSource_Offset;

	private static bool CaptureEveryFrame_IsValid;

	private static FFieldAddress CaptureEveryFrame_PropertyAddress;

	private static int CaptureEveryFrame_Offset;

	private static bool CaptureOnMovement_IsValid;

	private static FFieldAddress CaptureOnMovement_PropertyAddress;

	private static int CaptureOnMovement_Offset;

	private static bool AlwaysPersistRenderingState_IsValid;

	private static FFieldAddress AlwaysPersistRenderingState_PropertyAddress;

	private static int AlwaysPersistRenderingState_Offset;

	private static bool HiddenActors_IsValid;

	private static FFieldAddress HiddenActors_PropertyAddress;

	private static int HiddenActors_Offset;

	private TArrayReadWriteMarshaler<AActor> HiddenActors_MarshalerCached;

	private static bool ShowOnlyActors_IsValid;

	private static FFieldAddress ShowOnlyActors_PropertyAddress;

	private static int ShowOnlyActors_Offset;

	private TArrayReadWriteMarshaler<AActor> ShowOnlyActors_MarshalerCached;

	private static bool MaxViewDistanceOverride_IsValid;

	private static int MaxViewDistanceOverride_Offset;

	private static bool CaptureSortPriority_IsValid;

	private static int CaptureSortPriority_Offset;

	private static bool UseRayTracingIfEnabled_IsValid;

	private static FFieldAddress UseRayTracingIfEnabled_PropertyAddress;

	private static int UseRayTracingIfEnabled_Offset;

	private static bool ShowFlagSettings_IsValid;

	private static FFieldAddress ShowFlagSettings_PropertyAddress;

	private static int ShowFlagSettings_Offset;

	private TArrayReadWriteMarshaler<FEngineShowFlagsSetting> ShowFlagSettings_MarshalerCached;

	private static bool ProfilingEventName_IsValid;

	private static int ProfilingEventName_Offset;

	private static bool ShowOnlyComponent_IsValid;

	private static IntPtr ShowOnlyComponent_FunctionAddress;

	private static int ShowOnlyComponent_ParamsSize;

	private static bool ShowOnlyComponent_InComponent_IsValid;

	private static FFieldAddress ShowOnlyComponent_InComponent_PropertyAddress;

	private static int ShowOnlyComponent_InComponent_Offset;

	private static bool ShowOnlyActorComponents_IsValid;

	private static IntPtr ShowOnlyActorComponents_FunctionAddress;

	private static int ShowOnlyActorComponents_ParamsSize;

	private static bool ShowOnlyActorComponents_InActor_IsValid;

	private static FFieldAddress ShowOnlyActorComponents_InActor_PropertyAddress;

	private static int ShowOnlyActorComponents_InActor_Offset;

	private static bool ShowOnlyActorComponents_bIncludeFromChildActors_IsValid;

	private static FFieldAddress ShowOnlyActorComponents_bIncludeFromChildActors_PropertyAddress;

	private static int ShowOnlyActorComponents_bIncludeFromChildActors_Offset;

	private static bool SetCaptureSortPriority_IsValid;

	private static IntPtr SetCaptureSortPriority_FunctionAddress;

	private static int SetCaptureSortPriority_ParamsSize;

	private static bool SetCaptureSortPriority_NewCaptureSortPriority_IsValid;

	private static FFieldAddress SetCaptureSortPriority_NewCaptureSortPriority_PropertyAddress;

	private static int SetCaptureSortPriority_NewCaptureSortPriority_Offset;

	private static bool RemoveShowOnlyComponent_IsValid;

	private static IntPtr RemoveShowOnlyComponent_FunctionAddress;

	private static int RemoveShowOnlyComponent_ParamsSize;

	private static bool RemoveShowOnlyComponent_InComponent_IsValid;

	private static FFieldAddress RemoveShowOnlyComponent_InComponent_PropertyAddress;

	private static int RemoveShowOnlyComponent_InComponent_Offset;

	private static bool RemoveShowOnlyActorComponents_IsValid;

	private static IntPtr RemoveShowOnlyActorComponents_FunctionAddress;

	private static int RemoveShowOnlyActorComponents_ParamsSize;

	private static bool RemoveShowOnlyActorComponents_InActor_IsValid;

	private static FFieldAddress RemoveShowOnlyActorComponents_InActor_PropertyAddress;

	private static int RemoveShowOnlyActorComponents_InActor_Offset;

	private static bool RemoveShowOnlyActorComponents_bIncludeFromChildActors_IsValid;

	private static FFieldAddress RemoveShowOnlyActorComponents_bIncludeFromChildActors_PropertyAddress;

	private static int RemoveShowOnlyActorComponents_bIncludeFromChildActors_Offset;

	private static bool HideComponent_IsValid;

	private static IntPtr HideComponent_FunctionAddress;

	private static int HideComponent_ParamsSize;

	private static bool HideComponent_InComponent_IsValid;

	private static FFieldAddress HideComponent_InComponent_PropertyAddress;

	private static int HideComponent_InComponent_Offset;

	private static bool HideActorComponents_IsValid;

	private static IntPtr HideActorComponents_FunctionAddress;

	private static int HideActorComponents_ParamsSize;

	private static bool HideActorComponents_InActor_IsValid;

	private static FFieldAddress HideActorComponents_InActor_PropertyAddress;

	private static int HideActorComponents_InActor_Offset;

	private static bool HideActorComponents_bIncludeFromChildActors_IsValid;

	private static FFieldAddress HideActorComponents_bIncludeFromChildActors_PropertyAddress;

	private static int HideActorComponents_bIncludeFromChildActors_Offset;

	private static bool ClearShowOnlyComponents_IsValid;

	private static IntPtr ClearShowOnlyComponents_FunctionAddress;

	private static int ClearShowOnlyComponents_ParamsSize;

	private static bool ClearHiddenComponents_IsValid;

	private static IntPtr ClearHiddenComponents_FunctionAddress;

	private static int ClearHiddenComponents_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:PrimitiveRenderMode")]
	public ESceneCapturePrimitiveRenderMode PrimitiveRenderMode
	{
		get
		{
			CheckDestroyed();
			if (!PrimitiveRenderMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:PrimitiveRenderMode");
				return ESceneCapturePrimitiveRenderMode.PRM_LegacySceneCapture;
			}
			return EnumMarshaler<ESceneCapturePrimitiveRenderMode>.FromNative(IntPtr.Add(base.Address, PrimitiveRenderMode_Offset), 0, PrimitiveRenderMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PrimitiveRenderMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:PrimitiveRenderMode");
			}
			else
			{
				EnumMarshaler<ESceneCapturePrimitiveRenderMode>.ToNative(IntPtr.Add(base.Address, PrimitiveRenderMode_Offset), 0, PrimitiveRenderMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:CaptureSource")]
	public ESceneCaptureSource CaptureSource
	{
		get
		{
			CheckDestroyed();
			if (!CaptureSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:CaptureSource");
				return ESceneCaptureSource.SCS_SceneColorHDR;
			}
			return EnumMarshaler<ESceneCaptureSource>.FromNative(IntPtr.Add(base.Address, CaptureSource_Offset), 0, CaptureSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:CaptureSource");
			}
			else
			{
				EnumMarshaler<ESceneCaptureSource>.ToNative(IntPtr.Add(base.Address, CaptureSource_Offset), 0, CaptureSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:bCaptureEveryFrame")]
	public bool CaptureEveryFrame
	{
		get
		{
			CheckDestroyed();
			if (!CaptureEveryFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bCaptureEveryFrame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureEveryFrame_Offset), 0, CaptureEveryFrame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureEveryFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bCaptureEveryFrame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureEveryFrame_Offset), 0, CaptureEveryFrame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:bCaptureOnMovement")]
	public bool CaptureOnMovement
	{
		get
		{
			CheckDestroyed();
			if (!CaptureOnMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bCaptureOnMovement");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureOnMovement_Offset), 0, CaptureOnMovement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureOnMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bCaptureOnMovement");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureOnMovement_Offset), 0, CaptureOnMovement_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:bAlwaysPersistRenderingState")]
	public bool AlwaysPersistRenderingState
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysPersistRenderingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bAlwaysPersistRenderingState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysPersistRenderingState_Offset), 0, AlwaysPersistRenderingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysPersistRenderingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bAlwaysPersistRenderingState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysPersistRenderingState_Offset), 0, AlwaysPersistRenderingState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534215685uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:HiddenActors")]
	public TArrayReadWrite<AActor> HiddenActors
	{
		get
		{
			CheckDestroyed();
			if (!HiddenActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:HiddenActors");
				return null;
			}
			if (HiddenActors_MarshalerCached == null)
			{
				HiddenActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, HiddenActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return HiddenActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, HiddenActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5629499534215685uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ShowOnlyActors")]
	public TArrayReadWrite<AActor> ShowOnlyActors
	{
		get
		{
			CheckDestroyed();
			if (!ShowOnlyActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:ShowOnlyActors");
				return null;
			}
			if (ShowOnlyActors_MarshalerCached == null)
			{
				ShowOnlyActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, ShowOnlyActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return ShowOnlyActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, ShowOnlyActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:MaxViewDistanceOverride")]
	public float MaxViewDistanceOverride
	{
		get
		{
			CheckDestroyed();
			if (!MaxViewDistanceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:MaxViewDistanceOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxViewDistanceOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxViewDistanceOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:MaxViewDistanceOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxViewDistanceOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:CaptureSortPriority")]
	public int CaptureSortPriority
	{
		get
		{
			CheckDestroyed();
			if (!CaptureSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:CaptureSortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CaptureSortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:CaptureSortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CaptureSortPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:bUseRayTracingIfEnabled")]
	public bool UseRayTracingIfEnabled
	{
		get
		{
			CheckDestroyed();
			if (!UseRayTracingIfEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bUseRayTracingIfEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseRayTracingIfEnabled_Offset), 0, UseRayTracingIfEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseRayTracingIfEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:bUseRayTracingIfEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseRayTracingIfEnabled_Offset), 0, UseRayTracingIfEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503608217305605uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ShowFlagSettings")]
	public TArrayReadWrite<FEngineShowFlagsSetting> ShowFlagSettings
	{
		get
		{
			CheckDestroyed();
			if (!ShowFlagSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:ShowFlagSettings");
				return null;
			}
			if (ShowFlagSettings_MarshalerCached == null)
			{
				ShowFlagSettings_MarshalerCached = new TArrayReadWriteMarshaler<FEngineShowFlagsSetting>(1, ShowFlagSettings_PropertyAddress, CachedMarshalingDelegates<FEngineShowFlagsSetting, FEngineShowFlagsSetting>.FromNative, CachedMarshalingDelegates<FEngineShowFlagsSetting, FEngineShowFlagsSetting>.ToNative);
			}
			return ShowFlagSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, ShowFlagSettings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755408030990853uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ProfilingEventName")]
	public string ProfilingEventName
	{
		get
		{
			CheckDestroyed();
			if (!ProfilingEventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:ProfilingEventName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ProfilingEventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProfilingEventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent:ProfilingEventName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ProfilingEventName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ShowOnlyComponent")]
	public unsafe void ShowOnlyComponent(UPrimitiveComponent InComponent)
	{
		CheckDestroyed();
		if (!ShowOnlyComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:ShowOnlyComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowOnlyComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowOnlyComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ShowOnlyComponent_InComponent_Offset), 0, ShowOnlyComponent_InComponent_PropertyAddress.Address, InComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShowOnlyComponent_FunctionAddress, intPtr, ShowOnlyComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ShowOnlyActorComponents")]
	public unsafe void ShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
	{
		CheckDestroyed();
		if (!ShowOnlyActorComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:ShowOnlyActorComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowOnlyActorComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowOnlyActorComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ShowOnlyActorComponents_InActor_Offset), 0, ShowOnlyActorComponents_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ShowOnlyActorComponents_bIncludeFromChildActors_Offset), 0, ShowOnlyActorComponents_bIncludeFromChildActors_PropertyAddress.Address, bIncludeFromChildActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShowOnlyActorComponents_FunctionAddress, intPtr, ShowOnlyActorComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:SetCaptureSortPriority")]
	public unsafe void SetCaptureSortPriority(int NewCaptureSortPriority)
	{
		CheckDestroyed();
		if (!SetCaptureSortPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:SetCaptureSortPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCaptureSortPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCaptureSortPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCaptureSortPriority_NewCaptureSortPriority_Offset), 0, SetCaptureSortPriority_NewCaptureSortPriority_PropertyAddress.Address, NewCaptureSortPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCaptureSortPriority_FunctionAddress, intPtr, SetCaptureSortPriority_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:RemoveShowOnlyComponent")]
	public unsafe void RemoveShowOnlyComponent(UPrimitiveComponent InComponent)
	{
		CheckDestroyed();
		if (!RemoveShowOnlyComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:RemoveShowOnlyComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveShowOnlyComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveShowOnlyComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, RemoveShowOnlyComponent_InComponent_Offset), 0, RemoveShowOnlyComponent_InComponent_PropertyAddress.Address, InComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveShowOnlyComponent_FunctionAddress, intPtr, RemoveShowOnlyComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:RemoveShowOnlyActorComponents")]
	public unsafe void RemoveShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
	{
		CheckDestroyed();
		if (!RemoveShowOnlyActorComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:RemoveShowOnlyActorComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveShowOnlyActorComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveShowOnlyActorComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveShowOnlyActorComponents_InActor_Offset), 0, RemoveShowOnlyActorComponents_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveShowOnlyActorComponents_bIncludeFromChildActors_Offset), 0, RemoveShowOnlyActorComponents_bIncludeFromChildActors_PropertyAddress.Address, bIncludeFromChildActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveShowOnlyActorComponents_FunctionAddress, intPtr, RemoveShowOnlyActorComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:HideComponent")]
	public unsafe void HideComponent(UPrimitiveComponent InComponent)
	{
		CheckDestroyed();
		if (!HideComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:HideComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, HideComponent_InComponent_Offset), 0, HideComponent_InComponent_PropertyAddress.Address, InComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, HideComponent_FunctionAddress, intPtr, HideComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:HideActorComponents")]
	public unsafe void HideActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
	{
		CheckDestroyed();
		if (!HideActorComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:HideActorComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideActorComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideActorComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, HideActorComponents_InActor_Offset), 0, HideActorComponents_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HideActorComponents_bIncludeFromChildActors_Offset), 0, HideActorComponents_bIncludeFromChildActors_PropertyAddress.Address, bIncludeFromChildActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, HideActorComponents_FunctionAddress, intPtr, HideActorComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ClearShowOnlyComponents")]
	public unsafe void ClearShowOnlyComponents()
	{
		CheckDestroyed();
		if (!ClearShowOnlyComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:ClearShowOnlyComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearShowOnlyComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearShowOnlyComponents_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearShowOnlyComponents_FunctionAddress, argsSize: ClearShowOnlyComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent:ClearHiddenComponents")]
	public unsafe void ClearHiddenComponents()
	{
		CheckDestroyed();
		if (!ClearHiddenComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent:ClearHiddenComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearHiddenComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearHiddenComponents_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearHiddenComponents_FunctionAddress, argsSize: ClearHiddenComponents_ParamsSize);
	}

	static USceneCaptureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USceneCaptureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USceneCaptureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SceneCaptureComponent");
		NativeReflectionCached.GetPropertyRef(ref PrimitiveRenderMode_PropertyAddress, intPtr, "PrimitiveRenderMode");
		PrimitiveRenderMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrimitiveRenderMode");
		PrimitiveRenderMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrimitiveRenderMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureSource_PropertyAddress, intPtr, "CaptureSource");
		CaptureSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureSource");
		CaptureSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureSource", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureEveryFrame_PropertyAddress, intPtr, "bCaptureEveryFrame");
		CaptureEveryFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCaptureEveryFrame");
		CaptureEveryFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCaptureEveryFrame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureOnMovement_PropertyAddress, intPtr, "bCaptureOnMovement");
		CaptureOnMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCaptureOnMovement");
		CaptureOnMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCaptureOnMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysPersistRenderingState_PropertyAddress, intPtr, "bAlwaysPersistRenderingState");
		AlwaysPersistRenderingState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysPersistRenderingState");
		AlwaysPersistRenderingState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysPersistRenderingState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HiddenActors_PropertyAddress, intPtr, "HiddenActors");
		HiddenActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HiddenActors");
		HiddenActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HiddenActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowOnlyActors_PropertyAddress, intPtr, "ShowOnlyActors");
		ShowOnlyActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowOnlyActors");
		ShowOnlyActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowOnlyActors", Classes.FArrayProperty);
		MaxViewDistanceOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxViewDistanceOverride");
		MaxViewDistanceOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxViewDistanceOverride", Classes.FFloatProperty);
		CaptureSortPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureSortPriority");
		CaptureSortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureSortPriority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UseRayTracingIfEnabled_PropertyAddress, intPtr, "bUseRayTracingIfEnabled");
		UseRayTracingIfEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseRayTracingIfEnabled");
		UseRayTracingIfEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseRayTracingIfEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowFlagSettings_PropertyAddress, intPtr, "ShowFlagSettings");
		ShowFlagSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowFlagSettings");
		ShowFlagSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowFlagSettings", Classes.FArrayProperty);
		ProfilingEventName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProfilingEventName");
		ProfilingEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProfilingEventName", Classes.FStrProperty);
		ShowOnlyComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowOnlyComponent");
		ShowOnlyComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowOnlyComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowOnlyComponent_InComponent_PropertyAddress, ShowOnlyComponent_FunctionAddress, "InComponent");
		ShowOnlyComponent_InComponent_Offset = NativeReflectionCached.GetPropertyOffset(ShowOnlyComponent_FunctionAddress, "InComponent");
		ShowOnlyComponent_InComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowOnlyComponent_FunctionAddress, "InComponent", Classes.FObjectProperty);
		ShowOnlyComponent_IsValid = ShowOnlyComponent_FunctionAddress != IntPtr.Zero && ShowOnlyComponent_InComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:ShowOnlyComponent", ShowOnlyComponent_IsValid);
		ShowOnlyActorComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowOnlyActorComponents");
		ShowOnlyActorComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowOnlyActorComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowOnlyActorComponents_InActor_PropertyAddress, ShowOnlyActorComponents_FunctionAddress, "InActor");
		ShowOnlyActorComponents_InActor_Offset = NativeReflectionCached.GetPropertyOffset(ShowOnlyActorComponents_FunctionAddress, "InActor");
		ShowOnlyActorComponents_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowOnlyActorComponents_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowOnlyActorComponents_bIncludeFromChildActors_PropertyAddress, ShowOnlyActorComponents_FunctionAddress, "bIncludeFromChildActors");
		ShowOnlyActorComponents_bIncludeFromChildActors_Offset = NativeReflectionCached.GetPropertyOffset(ShowOnlyActorComponents_FunctionAddress, "bIncludeFromChildActors");
		ShowOnlyActorComponents_bIncludeFromChildActors_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowOnlyActorComponents_FunctionAddress, "bIncludeFromChildActors", Classes.FBoolProperty);
		ShowOnlyActorComponents_IsValid = ShowOnlyActorComponents_FunctionAddress != IntPtr.Zero && ShowOnlyActorComponents_InActor_IsValid && ShowOnlyActorComponents_bIncludeFromChildActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:ShowOnlyActorComponents", ShowOnlyActorComponents_IsValid);
		SetCaptureSortPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCaptureSortPriority");
		SetCaptureSortPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCaptureSortPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCaptureSortPriority_NewCaptureSortPriority_PropertyAddress, SetCaptureSortPriority_FunctionAddress, "NewCaptureSortPriority");
		SetCaptureSortPriority_NewCaptureSortPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetCaptureSortPriority_FunctionAddress, "NewCaptureSortPriority");
		SetCaptureSortPriority_NewCaptureSortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCaptureSortPriority_FunctionAddress, "NewCaptureSortPriority", Classes.FIntProperty);
		SetCaptureSortPriority_IsValid = SetCaptureSortPriority_FunctionAddress != IntPtr.Zero && SetCaptureSortPriority_NewCaptureSortPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:SetCaptureSortPriority", SetCaptureSortPriority_IsValid);
		RemoveShowOnlyComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveShowOnlyComponent");
		RemoveShowOnlyComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveShowOnlyComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveShowOnlyComponent_InComponent_PropertyAddress, RemoveShowOnlyComponent_FunctionAddress, "InComponent");
		RemoveShowOnlyComponent_InComponent_Offset = NativeReflectionCached.GetPropertyOffset(RemoveShowOnlyComponent_FunctionAddress, "InComponent");
		RemoveShowOnlyComponent_InComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveShowOnlyComponent_FunctionAddress, "InComponent", Classes.FObjectProperty);
		RemoveShowOnlyComponent_IsValid = RemoveShowOnlyComponent_FunctionAddress != IntPtr.Zero && RemoveShowOnlyComponent_InComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:RemoveShowOnlyComponent", RemoveShowOnlyComponent_IsValid);
		RemoveShowOnlyActorComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveShowOnlyActorComponents");
		RemoveShowOnlyActorComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveShowOnlyActorComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveShowOnlyActorComponents_InActor_PropertyAddress, RemoveShowOnlyActorComponents_FunctionAddress, "InActor");
		RemoveShowOnlyActorComponents_InActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveShowOnlyActorComponents_FunctionAddress, "InActor");
		RemoveShowOnlyActorComponents_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveShowOnlyActorComponents_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveShowOnlyActorComponents_bIncludeFromChildActors_PropertyAddress, RemoveShowOnlyActorComponents_FunctionAddress, "bIncludeFromChildActors");
		RemoveShowOnlyActorComponents_bIncludeFromChildActors_Offset = NativeReflectionCached.GetPropertyOffset(RemoveShowOnlyActorComponents_FunctionAddress, "bIncludeFromChildActors");
		RemoveShowOnlyActorComponents_bIncludeFromChildActors_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveShowOnlyActorComponents_FunctionAddress, "bIncludeFromChildActors", Classes.FBoolProperty);
		RemoveShowOnlyActorComponents_IsValid = RemoveShowOnlyActorComponents_FunctionAddress != IntPtr.Zero && RemoveShowOnlyActorComponents_InActor_IsValid && RemoveShowOnlyActorComponents_bIncludeFromChildActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:RemoveShowOnlyActorComponents", RemoveShowOnlyActorComponents_IsValid);
		HideComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HideComponent");
		HideComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(HideComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HideComponent_InComponent_PropertyAddress, HideComponent_FunctionAddress, "InComponent");
		HideComponent_InComponent_Offset = NativeReflectionCached.GetPropertyOffset(HideComponent_FunctionAddress, "InComponent");
		HideComponent_InComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(HideComponent_FunctionAddress, "InComponent", Classes.FObjectProperty);
		HideComponent_IsValid = HideComponent_FunctionAddress != IntPtr.Zero && HideComponent_InComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:HideComponent", HideComponent_IsValid);
		HideActorComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HideActorComponents");
		HideActorComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(HideActorComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HideActorComponents_InActor_PropertyAddress, HideActorComponents_FunctionAddress, "InActor");
		HideActorComponents_InActor_Offset = NativeReflectionCached.GetPropertyOffset(HideActorComponents_FunctionAddress, "InActor");
		HideActorComponents_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(HideActorComponents_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HideActorComponents_bIncludeFromChildActors_PropertyAddress, HideActorComponents_FunctionAddress, "bIncludeFromChildActors");
		HideActorComponents_bIncludeFromChildActors_Offset = NativeReflectionCached.GetPropertyOffset(HideActorComponents_FunctionAddress, "bIncludeFromChildActors");
		HideActorComponents_bIncludeFromChildActors_IsValid = NativeReflectionCached.ValidatePropertyClass(HideActorComponents_FunctionAddress, "bIncludeFromChildActors", Classes.FBoolProperty);
		HideActorComponents_IsValid = HideActorComponents_FunctionAddress != IntPtr.Zero && HideActorComponents_InActor_IsValid && HideActorComponents_bIncludeFromChildActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:HideActorComponents", HideActorComponents_IsValid);
		ClearShowOnlyComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearShowOnlyComponents");
		ClearShowOnlyComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearShowOnlyComponents_FunctionAddress);
		ClearShowOnlyComponents_IsValid = ClearShowOnlyComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:ClearShowOnlyComponents", ClearShowOnlyComponents_IsValid);
		ClearHiddenComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearHiddenComponents");
		ClearHiddenComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearHiddenComponents_FunctionAddress);
		ClearHiddenComponents_IsValid = ClearHiddenComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent:ClearHiddenComponents", ClearHiddenComponents_IsValid);
	}
}
