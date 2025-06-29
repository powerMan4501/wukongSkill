using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase", "b1", UnrealModuleType.Game)]
public class ABGUPlacedEditorUtilityBase : AActor
{
	private static bool HelpText_IsValid;

	private static int HelpText_Offset;

	private static bool SetLevelViewportCameraInfo_IsValid;

	private static IntPtr SetLevelViewportCameraInfo_FunctionAddress;

	private static int SetLevelViewportCameraInfo_ParamsSize;

	private static bool SetLevelViewportCameraInfo_CameraLocation_IsValid;

	private static FFieldAddress SetLevelViewportCameraInfo_CameraLocation_PropertyAddress;

	private static int SetLevelViewportCameraInfo_CameraLocation_Offset;

	private static bool SetLevelViewportCameraInfo_CameraRotation_IsValid;

	private static FFieldAddress SetLevelViewportCameraInfo_CameraRotation_PropertyAddress;

	private static int SetLevelViewportCameraInfo_CameraRotation_Offset;

	private static bool SetActorSelectionState_IsValid;

	private static IntPtr SetActorSelectionState_FunctionAddress;

	private static int SetActorSelectionState_ParamsSize;

	private static bool SetActorSelectionState_Actor_IsValid;

	private static FFieldAddress SetActorSelectionState_Actor_PropertyAddress;

	private static int SetActorSelectionState_Actor_Offset;

	private static bool SetActorSelectionState_bShouldBeSelected_IsValid;

	private static FFieldAddress SetActorSelectionState_bShouldBeSelected_PropertyAddress;

	private static int SetActorSelectionState_bShouldBeSelected_Offset;

	private static bool SelectNothing_IsValid;

	private static IntPtr SelectNothing_FunctionAddress;

	private static int SelectNothing_ParamsSize;

	private static bool OnWorldCleanup_IsValid;

	private IntPtr OnWorldCleanup_InstanceFunctionAddress;

	private static IntPtr OnWorldCleanup_FunctionAddress;

	private static int OnWorldCleanup_ParamsSize;

	private static bool OnWorldCleanup_world_IsValid;

	private static FFieldAddress OnWorldCleanup_world_PropertyAddress;

	private static int OnWorldCleanup_world_Offset;

	private static bool OnWorldCleanup_SessionEnded_IsValid;

	private static FFieldAddress OnWorldCleanup_SessionEnded_PropertyAddress;

	private static int OnWorldCleanup_SessionEnded_Offset;

	private static bool OnWorldCleanup_CleanupResources_IsValid;

	private static FFieldAddress OnWorldCleanup_CleanupResources_PropertyAddress;

	private static int OnWorldCleanup_CleanupResources_Offset;

	private static bool GetSelectionSet_IsValid;

	private static IntPtr GetSelectionSet_FunctionAddress;

	private static int GetSelectionSet_ParamsSize;

	private static bool GetSelectionSet_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionSet_ReturnValue_PropertyAddress;

	private static int GetSelectionSet_ReturnValue_Offset;

	private static bool GetLevelViewportCameraInfo_IsValid;

	private static IntPtr GetLevelViewportCameraInfo_FunctionAddress;

	private static int GetLevelViewportCameraInfo_ParamsSize;

	private static bool GetLevelViewportCameraInfo_CameraLocation_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_CameraLocation_PropertyAddress;

	private static int GetLevelViewportCameraInfo_CameraLocation_Offset;

	private static bool GetLevelViewportCameraInfo_CameraRotation_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_CameraRotation_PropertyAddress;

	private static int GetLevelViewportCameraInfo_CameraRotation_Offset;

	private static bool GetLevelViewportCameraInfo_ReturnValue_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_ReturnValue_PropertyAddress;

	private static int GetLevelViewportCameraInfo_ReturnValue_Offset;

	private static bool GetActorReference_IsValid;

	private static IntPtr GetActorReference_FunctionAddress;

	private static int GetActorReference_ParamsSize;

	private static bool GetActorReference_PathToActor_IsValid;

	private static FFieldAddress GetActorReference_PathToActor_PropertyAddress;

	private static int GetActorReference_PathToActor_Offset;

	private static bool GetActorReference_ReturnValue_IsValid;

	private static FFieldAddress GetActorReference_ReturnValue_PropertyAddress;

	private static int GetActorReference_ReturnValue_Offset;

	private static bool ClearActorSelectionSet_IsValid;

	private static IntPtr ClearActorSelectionSet_FunctionAddress;

	private static int ClearActorSelectionSet_ParamsSize;

	[UProperty(Flags = (PropFlags)6755399441121797uL)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:HelpText")]
	protected string HelpText
	{
		get
		{
			CheckDestroyed();
			if (!HelpText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlacedEditorUtilityBase:HelpText");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, HelpText_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HelpText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlacedEditorUtilityBase:HelpText");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, HelpText_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:SetLevelViewportCameraInfo")]
	public unsafe void SetLevelViewportCameraInfo(FVector CameraLocation, FRotator CameraRotation)
	{
		CheckDestroyed();
		if (!SetLevelViewportCameraInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:SetLevelViewportCameraInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelViewportCameraInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelViewportCameraInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLevelViewportCameraInfo_CameraLocation_Offset), 0, SetLevelViewportCameraInfo_CameraLocation_PropertyAddress.Address, CameraLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetLevelViewportCameraInfo_CameraRotation_Offset), 0, SetLevelViewportCameraInfo_CameraRotation_PropertyAddress.Address, CameraRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLevelViewportCameraInfo_FunctionAddress, intPtr, SetLevelViewportCameraInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:SetActorSelectionState")]
	public unsafe void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
	{
		CheckDestroyed();
		if (!SetActorSelectionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:SetActorSelectionState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorSelectionState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorSelectionState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorSelectionState_Actor_Offset), 0, SetActorSelectionState_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorSelectionState_bShouldBeSelected_Offset), 0, SetActorSelectionState_bShouldBeSelected_PropertyAddress.Address, bShouldBeSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorSelectionState_FunctionAddress, intPtr, SetActorSelectionState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:SelectNothing")]
	public unsafe void SelectNothing()
	{
		CheckDestroyed();
		if (!SelectNothing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:SelectNothing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectNothing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectNothing_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SelectNothing_FunctionAddress, argsSize: SelectNothing_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:OnWorldCleanup")]
	public unsafe void OnWorldCleanup(UWorld world, bool SessionEnded, bool CleanupResources)
	{
		CheckDestroyed();
		if (!OnWorldCleanup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:OnWorldCleanup");
			return;
		}
		if (OnWorldCleanup_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWorldCleanup_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWorldCleanup");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldCleanup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldCleanup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldCleanup_world_Offset), 0, OnWorldCleanup_world_PropertyAddress.Address, world);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWorldCleanup_SessionEnded_Offset), 0, OnWorldCleanup_SessionEnded_PropertyAddress.Address, SessionEnded);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWorldCleanup_CleanupResources_Offset), 0, OnWorldCleanup_CleanupResources_PropertyAddress.Address, CleanupResources);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldCleanup_InstanceFunctionAddress, intPtr, OnWorldCleanup_ParamsSize);
	}

	protected unsafe virtual void OnWorldCleanup_Implementation(UWorld world, bool SessionEnded, bool CleanupResources)
	{
		CheckDestroyed();
		if (!OnWorldCleanup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:OnWorldCleanup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldCleanup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldCleanup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldCleanup_world_Offset), 0, OnWorldCleanup_world_PropertyAddress.Address, world);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWorldCleanup_SessionEnded_Offset), 0, OnWorldCleanup_SessionEnded_PropertyAddress.Address, SessionEnded);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWorldCleanup_CleanupResources_Offset), 0, OnWorldCleanup_CleanupResources_PropertyAddress.Address, CleanupResources);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldCleanup_FunctionAddress, intPtr, OnWorldCleanup_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:GetSelectionSet")]
	public unsafe List<AActor> GetSelectionSet()
	{
		CheckDestroyed();
		if (!GetSelectionSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:GetSelectionSet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectionSet_FunctionAddress, intPtr, GetSelectionSet_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetSelectionSet_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectionSet_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectionSet_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348259329u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:GetLevelViewportCameraInfo")]
	public unsafe bool GetLevelViewportCameraInfo(out FVector CameraLocation, out FRotator CameraRotation)
	{
		CheckDestroyed();
		if (!GetLevelViewportCameraInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:GetLevelViewportCameraInfo");
			CameraLocation = default(FVector);
			CameraRotation = default(FRotator);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelViewportCameraInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelViewportCameraInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevelViewportCameraInfo_FunctionAddress, intPtr, GetLevelViewportCameraInfo_ParamsSize);
		CameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_CameraLocation_Offset), 0, GetLevelViewportCameraInfo_CameraLocation_PropertyAddress.Address);
		CameraRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_CameraRotation_Offset), 0, GetLevelViewportCameraInfo_CameraRotation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_ReturnValue_Offset), 0, GetLevelViewportCameraInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:GetActorReference")]
	public unsafe AActor GetActorReference(string PathToActor)
	{
		CheckDestroyed();
		if (!GetActorReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:GetActorReference");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetActorReference_PathToActor_Offset), 0, GetActorReference_PathToActor_PropertyAddress.Address, PathToActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorReference_FunctionAddress, intPtr, GetActorReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetActorReference_PathToActor_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActorReference_ReturnValue_Offset), 0, GetActorReference_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUPlacedEditorUtilityBase:ClearActorSelectionSet")]
	public unsafe void ClearActorSelectionSet()
	{
		CheckDestroyed();
		if (!ClearActorSelectionSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlacedEditorUtilityBase:ClearActorSelectionSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearActorSelectionSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearActorSelectionSet_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearActorSelectionSet_FunctionAddress, argsSize: ClearActorSelectionSet_ParamsSize);
	}

	static ABGUPlacedEditorUtilityBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUPlacedEditorUtilityBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUPlacedEditorUtilityBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUPlacedEditorUtilityBase");
		HelpText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HelpText");
		HelpText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HelpText", Classes.FStrProperty);
		SetLevelViewportCameraInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLevelViewportCameraInfo");
		SetLevelViewportCameraInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelViewportCameraInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelViewportCameraInfo_CameraLocation_PropertyAddress, SetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		SetLevelViewportCameraInfo_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		SetLevelViewportCameraInfo_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelViewportCameraInfo_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelViewportCameraInfo_CameraRotation_PropertyAddress, SetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		SetLevelViewportCameraInfo_CameraRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		SetLevelViewportCameraInfo_CameraRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelViewportCameraInfo_FunctionAddress, "CameraRotation", Classes.FStructProperty);
		SetLevelViewportCameraInfo_IsValid = SetLevelViewportCameraInfo_FunctionAddress != IntPtr.Zero && SetLevelViewportCameraInfo_CameraLocation_IsValid && SetLevelViewportCameraInfo_CameraRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:SetLevelViewportCameraInfo", SetLevelViewportCameraInfo_IsValid);
		SetActorSelectionState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorSelectionState");
		SetActorSelectionState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorSelectionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorSelectionState_Actor_PropertyAddress, SetActorSelectionState_FunctionAddress, "Actor");
		SetActorSelectionState_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSelectionState_FunctionAddress, "Actor");
		SetActorSelectionState_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSelectionState_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorSelectionState_bShouldBeSelected_PropertyAddress, SetActorSelectionState_FunctionAddress, "bShouldBeSelected");
		SetActorSelectionState_bShouldBeSelected_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSelectionState_FunctionAddress, "bShouldBeSelected");
		SetActorSelectionState_bShouldBeSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSelectionState_FunctionAddress, "bShouldBeSelected", Classes.FBoolProperty);
		SetActorSelectionState_IsValid = SetActorSelectionState_FunctionAddress != IntPtr.Zero && SetActorSelectionState_Actor_IsValid && SetActorSelectionState_bShouldBeSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:SetActorSelectionState", SetActorSelectionState_IsValid);
		SelectNothing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectNothing");
		SelectNothing_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectNothing_FunctionAddress);
		SelectNothing_IsValid = SelectNothing_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:SelectNothing", SelectNothing_IsValid);
		OnWorldCleanup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWorldCleanup");
		OnWorldCleanup_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldCleanup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWorldCleanup_world_PropertyAddress, OnWorldCleanup_FunctionAddress, "world");
		OnWorldCleanup_world_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldCleanup_FunctionAddress, "world");
		OnWorldCleanup_world_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldCleanup_FunctionAddress, "world", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWorldCleanup_SessionEnded_PropertyAddress, OnWorldCleanup_FunctionAddress, "SessionEnded");
		OnWorldCleanup_SessionEnded_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldCleanup_FunctionAddress, "SessionEnded");
		OnWorldCleanup_SessionEnded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldCleanup_FunctionAddress, "SessionEnded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWorldCleanup_CleanupResources_PropertyAddress, OnWorldCleanup_FunctionAddress, "CleanupResources");
		OnWorldCleanup_CleanupResources_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldCleanup_FunctionAddress, "CleanupResources");
		OnWorldCleanup_CleanupResources_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldCleanup_FunctionAddress, "CleanupResources", Classes.FBoolProperty);
		OnWorldCleanup_IsValid = OnWorldCleanup_FunctionAddress != IntPtr.Zero && OnWorldCleanup_world_IsValid && OnWorldCleanup_SessionEnded_IsValid && OnWorldCleanup_CleanupResources_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:OnWorldCleanup", OnWorldCleanup_IsValid);
		GetSelectionSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectionSet");
		GetSelectionSet_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionSet_ReturnValue_PropertyAddress, GetSelectionSet_FunctionAddress, "ReturnValue");
		GetSelectionSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionSet_FunctionAddress, "ReturnValue");
		GetSelectionSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionSet_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectionSet_IsValid = GetSelectionSet_FunctionAddress != IntPtr.Zero && GetSelectionSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:GetSelectionSet", GetSelectionSet_IsValid);
		GetLevelViewportCameraInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLevelViewportCameraInfo");
		GetLevelViewportCameraInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelViewportCameraInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_CameraLocation_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		GetLevelViewportCameraInfo_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		GetLevelViewportCameraInfo_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_CameraRotation_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		GetLevelViewportCameraInfo_CameraRotation_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		GetLevelViewportCameraInfo_CameraRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "CameraRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_ReturnValue_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "ReturnValue");
		GetLevelViewportCameraInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "ReturnValue");
		GetLevelViewportCameraInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLevelViewportCameraInfo_IsValid = GetLevelViewportCameraInfo_FunctionAddress != IntPtr.Zero && GetLevelViewportCameraInfo_CameraLocation_IsValid && GetLevelViewportCameraInfo_CameraRotation_IsValid && GetLevelViewportCameraInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:GetLevelViewportCameraInfo", GetLevelViewportCameraInfo_IsValid);
		GetActorReference_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorReference");
		GetActorReference_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_PathToActor_PropertyAddress, GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "PathToActor", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_ReturnValue_PropertyAddress, GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorReference_IsValid = GetActorReference_FunctionAddress != IntPtr.Zero && GetActorReference_PathToActor_IsValid && GetActorReference_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:GetActorReference", GetActorReference_IsValid);
		ClearActorSelectionSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearActorSelectionSet");
		ClearActorSelectionSet_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearActorSelectionSet_FunctionAddress);
		ClearActorSelectionSet_IsValid = ClearActorSelectionSet_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlacedEditorUtilityBase:ClearActorSelectionSet", ClearActorSelectionSet_IsValid);
	}
}
