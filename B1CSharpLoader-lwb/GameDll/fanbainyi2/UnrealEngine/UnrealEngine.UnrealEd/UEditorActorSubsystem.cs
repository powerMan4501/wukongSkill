using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/UnrealEd.EditorActorSubsystem", "UnrealEd", UnrealModuleType.Engine)]
public class UEditorActorSubsystem : UEditorSubsystem
{
	private static bool OnEditCutActorsBegin_IsValid;

	private static int OnEditCutActorsBegin_Offset;

	private FOnEditCutActorsBegin OnEditCutActorsBegin_DelegateCached;

	private static bool OnEditCutActorsEnd_IsValid;

	private static int OnEditCutActorsEnd_Offset;

	private FOnEditCutActorsEnd OnEditCutActorsEnd_DelegateCached;

	private static bool OnEditCopyActorsBegin_IsValid;

	private static int OnEditCopyActorsBegin_Offset;

	private FOnEditCopyActorsBegin OnEditCopyActorsBegin_DelegateCached;

	private static bool OnEditCopyActorsEnd_IsValid;

	private static int OnEditCopyActorsEnd_Offset;

	private FOnEditCopyActorsEnd OnEditCopyActorsEnd_DelegateCached;

	private static bool OnEditPasteActorsBegin_IsValid;

	private static int OnEditPasteActorsBegin_Offset;

	private FOnEditPasteActorsBegin OnEditPasteActorsBegin_DelegateCached;

	private static bool OnEditPasteActorsEnd_IsValid;

	private static int OnEditPasteActorsEnd_Offset;

	private FOnEditPasteActorsEnd OnEditPasteActorsEnd_DelegateCached;

	private static bool OnDuplicateActorsBegin_IsValid;

	private static int OnDuplicateActorsBegin_Offset;

	private FOnEditCutActorsBegin OnDuplicateActorsBegin_DelegateCached;

	private static bool OnDuplicateActorsEnd_IsValid;

	private static int OnDuplicateActorsEnd_Offset;

	private FOnDuplicateActorsEnd OnDuplicateActorsEnd_DelegateCached;

	private static bool OnDeleteActorsBegin_IsValid;

	private static int OnDeleteActorsBegin_Offset;

	private FOnDeleteActorsBegin OnDeleteActorsBegin_DelegateCached;

	private static bool OnDeleteActorsEnd_IsValid;

	private static int OnDeleteActorsEnd_Offset;

	private FOnDeleteActorsEnd OnDeleteActorsEnd_DelegateCached;

	private static bool SpawnActorFromObject_IsValid;

	private static IntPtr SpawnActorFromObject_FunctionAddress;

	private static int SpawnActorFromObject_ParamsSize;

	private static bool SpawnActorFromObject_ObjectToUse_IsValid;

	private static FFieldAddress SpawnActorFromObject_ObjectToUse_PropertyAddress;

	private static int SpawnActorFromObject_ObjectToUse_Offset;

	private static bool SpawnActorFromObject_Location_IsValid;

	private static FFieldAddress SpawnActorFromObject_Location_PropertyAddress;

	private static int SpawnActorFromObject_Location_Offset;

	private static bool SpawnActorFromObject_Rotation_IsValid;

	private static FFieldAddress SpawnActorFromObject_Rotation_PropertyAddress;

	private static int SpawnActorFromObject_Rotation_Offset;

	private static bool SpawnActorFromObject_bTransient_IsValid;

	private static FFieldAddress SpawnActorFromObject_bTransient_PropertyAddress;

	private static int SpawnActorFromObject_bTransient_Offset;

	private static bool SpawnActorFromObject_ReturnValue_IsValid;

	private static FFieldAddress SpawnActorFromObject_ReturnValue_PropertyAddress;

	private static int SpawnActorFromObject_ReturnValue_Offset;

	private static bool SpawnActorFromClass_IsValid;

	private static IntPtr SpawnActorFromClass_FunctionAddress;

	private static int SpawnActorFromClass_ParamsSize;

	private static bool SpawnActorFromClass_ActorClass_IsValid;

	private static FFieldAddress SpawnActorFromClass_ActorClass_PropertyAddress;

	private static int SpawnActorFromClass_ActorClass_Offset;

	private static bool SpawnActorFromClass_Location_IsValid;

	private static FFieldAddress SpawnActorFromClass_Location_PropertyAddress;

	private static int SpawnActorFromClass_Location_Offset;

	private static bool SpawnActorFromClass_Rotation_IsValid;

	private static FFieldAddress SpawnActorFromClass_Rotation_PropertyAddress;

	private static int SpawnActorFromClass_Rotation_Offset;

	private static bool SpawnActorFromClass_bTransient_IsValid;

	private static FFieldAddress SpawnActorFromClass_bTransient_PropertyAddress;

	private static int SpawnActorFromClass_bTransient_Offset;

	private static bool SpawnActorFromClass_ReturnValue_IsValid;

	private static FFieldAddress SpawnActorFromClass_ReturnValue_PropertyAddress;

	private static int SpawnActorFromClass_ReturnValue_Offset;

	private static bool SetSelectedLevelActors_IsValid;

	private static IntPtr SetSelectedLevelActors_FunctionAddress;

	private static int SetSelectedLevelActors_ParamsSize;

	private static bool SetSelectedLevelActors_ActorsToSelect_IsValid;

	private static FFieldAddress SetSelectedLevelActors_ActorsToSelect_PropertyAddress;

	private static int SetSelectedLevelActors_ActorsToSelect_Offset;

	private static bool SetComponentTransform_IsValid;

	private static IntPtr SetComponentTransform_FunctionAddress;

	private static int SetComponentTransform_ParamsSize;

	private static bool SetComponentTransform_InSceneComponent_IsValid;

	private static FFieldAddress SetComponentTransform_InSceneComponent_PropertyAddress;

	private static int SetComponentTransform_InSceneComponent_Offset;

	private static bool SetComponentTransform_InWorldTransform_IsValid;

	private static FFieldAddress SetComponentTransform_InWorldTransform_PropertyAddress;

	private static int SetComponentTransform_InWorldTransform_Offset;

	private static bool SetComponentTransform_ReturnValue_IsValid;

	private static FFieldAddress SetComponentTransform_ReturnValue_PropertyAddress;

	private static int SetComponentTransform_ReturnValue_Offset;

	private static bool SetActorTransform_IsValid;

	private static IntPtr SetActorTransform_FunctionAddress;

	private static int SetActorTransform_ParamsSize;

	private static bool SetActorTransform_InActor_IsValid;

	private static FFieldAddress SetActorTransform_InActor_PropertyAddress;

	private static int SetActorTransform_InActor_Offset;

	private static bool SetActorTransform_InWorldTransform_IsValid;

	private static FFieldAddress SetActorTransform_InWorldTransform_PropertyAddress;

	private static int SetActorTransform_InWorldTransform_Offset;

	private static bool SetActorTransform_ReturnValue_IsValid;

	private static FFieldAddress SetActorTransform_ReturnValue_PropertyAddress;

	private static int SetActorTransform_ReturnValue_Offset;

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

	private static bool SelectAllChildren_IsValid;

	private static IntPtr SelectAllChildren_FunctionAddress;

	private static int SelectAllChildren_ParamsSize;

	private static bool SelectAllChildren_bRecurseChildren_IsValid;

	private static FFieldAddress SelectAllChildren_bRecurseChildren_PropertyAddress;

	private static int SelectAllChildren_bRecurseChildren_Offset;

	private static bool SelectAll_IsValid;

	private static IntPtr SelectAll_FunctionAddress;

	private static int SelectAll_ParamsSize;

	private static bool SelectAll_InWorld_IsValid;

	private static FFieldAddress SelectAll_InWorld_PropertyAddress;

	private static int SelectAll_InWorld_Offset;

	private static bool InvertSelection_IsValid;

	private static IntPtr InvertSelection_FunctionAddress;

	private static int InvertSelection_ParamsSize;

	private static bool InvertSelection_InWorld_IsValid;

	private static FFieldAddress InvertSelection_InWorld_PropertyAddress;

	private static int InvertSelection_InWorld_Offset;

	private static bool GetSelectedLevelActors_IsValid;

	private static IntPtr GetSelectedLevelActors_FunctionAddress;

	private static int GetSelectedLevelActors_ParamsSize;

	private static bool GetSelectedLevelActors_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedLevelActors_ReturnValue_PropertyAddress;

	private static int GetSelectedLevelActors_ReturnValue_Offset;

	private static bool GetAllLevelActorsComponents_IsValid;

	private static IntPtr GetAllLevelActorsComponents_FunctionAddress;

	private static int GetAllLevelActorsComponents_ParamsSize;

	private static bool GetAllLevelActorsComponents_ReturnValue_IsValid;

	private static FFieldAddress GetAllLevelActorsComponents_ReturnValue_PropertyAddress;

	private static int GetAllLevelActorsComponents_ReturnValue_Offset;

	private static bool GetAllLevelActors_IsValid;

	private static IntPtr GetAllLevelActors_FunctionAddress;

	private static int GetAllLevelActors_ParamsSize;

	private static bool GetAllLevelActors_ReturnValue_IsValid;

	private static FFieldAddress GetAllLevelActors_ReturnValue_PropertyAddress;

	private static int GetAllLevelActors_ReturnValue_Offset;

	private static bool GetActorReference_IsValid;

	private static IntPtr GetActorReference_FunctionAddress;

	private static int GetActorReference_ParamsSize;

	private static bool GetActorReference_PathToActor_IsValid;

	private static FFieldAddress GetActorReference_PathToActor_PropertyAddress;

	private static int GetActorReference_PathToActor_Offset;

	private static bool GetActorReference_ReturnValue_IsValid;

	private static FFieldAddress GetActorReference_ReturnValue_PropertyAddress;

	private static int GetActorReference_ReturnValue_Offset;

	private static bool DuplicateSelectedActors_IsValid;

	private static IntPtr DuplicateSelectedActors_FunctionAddress;

	private static int DuplicateSelectedActors_ParamsSize;

	private static bool DuplicateSelectedActors_InWorld_IsValid;

	private static FFieldAddress DuplicateSelectedActors_InWorld_PropertyAddress;

	private static int DuplicateSelectedActors_InWorld_Offset;

	private static bool DuplicateActors_IsValid;

	private static IntPtr DuplicateActors_FunctionAddress;

	private static int DuplicateActors_ParamsSize;

	private static bool DuplicateActors_ActorsToDuplicate_IsValid;

	private static FFieldAddress DuplicateActors_ActorsToDuplicate_PropertyAddress;

	private static int DuplicateActors_ActorsToDuplicate_Offset;

	private static bool DuplicateActors_ToWorld_IsValid;

	private static FFieldAddress DuplicateActors_ToWorld_PropertyAddress;

	private static int DuplicateActors_ToWorld_Offset;

	private static bool DuplicateActors_Offset_IsValid;

	private static FFieldAddress DuplicateActors_Offset_PropertyAddress;

	private static int DuplicateActors_Offset_Offset;

	private static bool DuplicateActors_ReturnValue_IsValid;

	private static FFieldAddress DuplicateActors_ReturnValue_PropertyAddress;

	private static int DuplicateActors_ReturnValue_Offset;

	private static bool DuplicateActor_IsValid;

	private static IntPtr DuplicateActor_FunctionAddress;

	private static int DuplicateActor_ParamsSize;

	private static bool DuplicateActor_ActorToDuplicate_IsValid;

	private static FFieldAddress DuplicateActor_ActorToDuplicate_PropertyAddress;

	private static int DuplicateActor_ActorToDuplicate_Offset;

	private static bool DuplicateActor_ToWorld_IsValid;

	private static FFieldAddress DuplicateActor_ToWorld_PropertyAddress;

	private static int DuplicateActor_ToWorld_Offset;

	private static bool DuplicateActor_Offset_IsValid;

	private static FFieldAddress DuplicateActor_Offset_PropertyAddress;

	private static int DuplicateActor_Offset_Offset;

	private static bool DuplicateActor_ReturnValue_IsValid;

	private static FFieldAddress DuplicateActor_ReturnValue_PropertyAddress;

	private static int DuplicateActor_ReturnValue_Offset;

	private static bool DestroyActors_IsValid;

	private static IntPtr DestroyActors_FunctionAddress;

	private static int DestroyActors_ParamsSize;

	private static bool DestroyActors_ActorsToDestroy_IsValid;

	private static FFieldAddress DestroyActors_ActorsToDestroy_PropertyAddress;

	private static int DestroyActors_ActorsToDestroy_Offset;

	private static bool DestroyActors_ReturnValue_IsValid;

	private static FFieldAddress DestroyActors_ReturnValue_PropertyAddress;

	private static int DestroyActors_ReturnValue_Offset;

	private static bool DestroyActor_IsValid;

	private static IntPtr DestroyActor_FunctionAddress;

	private static int DestroyActor_ParamsSize;

	private static bool DestroyActor_ActorToDestroy_IsValid;

	private static FFieldAddress DestroyActor_ActorToDestroy_PropertyAddress;

	private static int DestroyActor_ActorToDestroy_Offset;

	private static bool DestroyActor_ReturnValue_IsValid;

	private static FFieldAddress DestroyActor_ReturnValue_PropertyAddress;

	private static int DestroyActor_ReturnValue_Offset;

	private static bool DeleteSelectedActors_IsValid;

	private static IntPtr DeleteSelectedActors_FunctionAddress;

	private static int DeleteSelectedActors_ParamsSize;

	private static bool DeleteSelectedActors_InWorld_IsValid;

	private static FFieldAddress DeleteSelectedActors_InWorld_PropertyAddress;

	private static int DeleteSelectedActors_InWorld_Offset;

	private static bool ConvertActors_IsValid;

	private static IntPtr ConvertActors_FunctionAddress;

	private static int ConvertActors_ParamsSize;

	private static bool ConvertActors_Actors_IsValid;

	private static FFieldAddress ConvertActors_Actors_PropertyAddress;

	private static int ConvertActors_Actors_Offset;

	private static bool ConvertActors_ActorClass_IsValid;

	private static FFieldAddress ConvertActors_ActorClass_PropertyAddress;

	private static int ConvertActors_ActorClass_Offset;

	private static bool ConvertActors_StaticMeshPackagePath_IsValid;

	private static FFieldAddress ConvertActors_StaticMeshPackagePath_PropertyAddress;

	private static int ConvertActors_StaticMeshPackagePath_Offset;

	private static bool ConvertActors_ReturnValue_IsValid;

	private static FFieldAddress ConvertActors_ReturnValue_PropertyAddress;

	private static int ConvertActors_ReturnValue_Offset;

	private static bool ClearActorSelectionSet_IsValid;

	private static IntPtr ClearActorSelectionSet_FunctionAddress;

	private static int ClearActorSelectionSet_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnEditCutActorsBegin")]
	public FOnEditCutActorsBegin OnEditCutActorsBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnEditCutActorsBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnEditCutActorsBegin");
				return new FOnEditCutActorsBegin();
			}
			if (OnEditCutActorsBegin_DelegateCached == null)
			{
				OnEditCutActorsBegin_DelegateCached = new FOnEditCutActorsBegin();
				OnEditCutActorsBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEditCutActorsBegin_Offset));
			}
			return OnEditCutActorsBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnEditCutActorsEnd")]
	public FOnEditCutActorsEnd OnEditCutActorsEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnEditCutActorsEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnEditCutActorsEnd");
				return new FOnEditCutActorsEnd();
			}
			if (OnEditCutActorsEnd_DelegateCached == null)
			{
				OnEditCutActorsEnd_DelegateCached = new FOnEditCutActorsEnd();
				OnEditCutActorsEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEditCutActorsEnd_Offset));
			}
			return OnEditCutActorsEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnEditCopyActorsBegin")]
	public FOnEditCopyActorsBegin OnEditCopyActorsBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnEditCopyActorsBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnEditCopyActorsBegin");
				return new FOnEditCopyActorsBegin();
			}
			if (OnEditCopyActorsBegin_DelegateCached == null)
			{
				OnEditCopyActorsBegin_DelegateCached = new FOnEditCopyActorsBegin();
				OnEditCopyActorsBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEditCopyActorsBegin_Offset));
			}
			return OnEditCopyActorsBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnEditCopyActorsEnd")]
	public FOnEditCopyActorsEnd OnEditCopyActorsEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnEditCopyActorsEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnEditCopyActorsEnd");
				return new FOnEditCopyActorsEnd();
			}
			if (OnEditCopyActorsEnd_DelegateCached == null)
			{
				OnEditCopyActorsEnd_DelegateCached = new FOnEditCopyActorsEnd();
				OnEditCopyActorsEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEditCopyActorsEnd_Offset));
			}
			return OnEditCopyActorsEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnEditPasteActorsBegin")]
	public FOnEditPasteActorsBegin OnEditPasteActorsBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnEditPasteActorsBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnEditPasteActorsBegin");
				return new FOnEditPasteActorsBegin();
			}
			if (OnEditPasteActorsBegin_DelegateCached == null)
			{
				OnEditPasteActorsBegin_DelegateCached = new FOnEditPasteActorsBegin();
				OnEditPasteActorsBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEditPasteActorsBegin_Offset));
			}
			return OnEditPasteActorsBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnEditPasteActorsEnd")]
	public FOnEditPasteActorsEnd OnEditPasteActorsEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnEditPasteActorsEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnEditPasteActorsEnd");
				return new FOnEditPasteActorsEnd();
			}
			if (OnEditPasteActorsEnd_DelegateCached == null)
			{
				OnEditPasteActorsEnd_DelegateCached = new FOnEditPasteActorsEnd();
				OnEditPasteActorsEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEditPasteActorsEnd_Offset));
			}
			return OnEditPasteActorsEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnDuplicateActorsBegin")]
	public FOnEditCutActorsBegin OnDuplicateActorsBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnDuplicateActorsBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnDuplicateActorsBegin");
				return new FOnEditCutActorsBegin();
			}
			if (OnDuplicateActorsBegin_DelegateCached == null)
			{
				OnDuplicateActorsBegin_DelegateCached = new FOnEditCutActorsBegin();
				OnDuplicateActorsBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDuplicateActorsBegin_Offset));
			}
			return OnDuplicateActorsBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnDuplicateActorsEnd")]
	public FOnDuplicateActorsEnd OnDuplicateActorsEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnDuplicateActorsEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnDuplicateActorsEnd");
				return new FOnDuplicateActorsEnd();
			}
			if (OnDuplicateActorsEnd_DelegateCached == null)
			{
				OnDuplicateActorsEnd_DelegateCached = new FOnDuplicateActorsEnd();
				OnDuplicateActorsEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDuplicateActorsEnd_Offset));
			}
			return OnDuplicateActorsEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnDeleteActorsBegin")]
	public FOnDeleteActorsBegin OnDeleteActorsBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnDeleteActorsBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnDeleteActorsBegin");
				return new FOnDeleteActorsBegin();
			}
			if (OnDeleteActorsBegin_DelegateCached == null)
			{
				OnDeleteActorsBegin_DelegateCached = new FOnDeleteActorsBegin();
				OnDeleteActorsBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDeleteActorsBegin_Offset));
			}
			return OnDeleteActorsBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:OnDeleteActorsEnd")]
	public FOnDeleteActorsEnd OnDeleteActorsEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnDeleteActorsEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.EditorActorSubsystem:OnDeleteActorsEnd");
				return new FOnDeleteActorsEnd();
			}
			if (OnDeleteActorsEnd_DelegateCached == null)
			{
				OnDeleteActorsEnd_DelegateCached = new FOnDeleteActorsEnd();
				OnDeleteActorsEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDeleteActorsEnd_Offset));
			}
			return OnDeleteActorsEnd_DelegateCached;
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SpawnActorFromObject")]
	public unsafe AActor SpawnActorFromObject(UObject ObjectToUse, FVector Location, FRotator Rotation, bool bTransient = false)
	{
		CheckDestroyed();
		if (!SpawnActorFromObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SpawnActorFromObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnActorFromObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnActorFromObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_ObjectToUse_Offset), 0, SpawnActorFromObject_ObjectToUse_PropertyAddress.Address, ObjectToUse);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_Location_Offset), 0, SpawnActorFromObject_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_Rotation_Offset), 0, SpawnActorFromObject_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_bTransient_Offset), 0, SpawnActorFromObject_bTransient_PropertyAddress.Address, bTransient);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnActorFromObject_FunctionAddress, intPtr, SpawnActorFromObject_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnActorFromObject_ReturnValue_Offset), 0, SpawnActorFromObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SpawnActorFromClass")]
	public unsafe AActor SpawnActorFromClass(TSubclassOf<AActor> ActorClass, FVector Location, FRotator Rotation, bool bTransient = false)
	{
		CheckDestroyed();
		if (!SpawnActorFromClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SpawnActorFromClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnActorFromClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnActorFromClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_ActorClass_Offset), 0, SpawnActorFromClass_ActorClass_PropertyAddress.Address, ActorClass);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_Location_Offset), 0, SpawnActorFromClass_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_Rotation_Offset), 0, SpawnActorFromClass_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_bTransient_Offset), 0, SpawnActorFromClass_bTransient_PropertyAddress.Address, bTransient);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnActorFromClass_FunctionAddress, intPtr, SpawnActorFromClass_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnActorFromClass_ReturnValue_Offset), 0, SpawnActorFromClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SetSelectedLevelActors")]
	public unsafe void SetSelectedLevelActors(List<AActor> ActorsToSelect)
	{
		CheckDestroyed();
		if (!SetSelectedLevelActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SetSelectedLevelActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedLevelActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedLevelActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, SetSelectedLevelActors_ActorsToSelect_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSelectedLevelActors_ActorsToSelect_Offset), ActorsToSelect);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedLevelActors_FunctionAddress, intPtr, SetSelectedLevelActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSelectedLevelActors_ActorsToSelect_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SetComponentTransform")]
	public unsafe bool SetComponentTransform(USceneComponent InSceneComponent, FTransform InWorldTransform)
	{
		CheckDestroyed();
		if (!SetComponentTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SetComponentTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComponentTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComponentTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetComponentTransform_InSceneComponent_Offset), 0, SetComponentTransform_InSceneComponent_PropertyAddress.Address, InSceneComponent);
		NativeReflection.InitializeValue_InContainer(SetComponentTransform_InWorldTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetComponentTransform_InWorldTransform_Offset), 0, SetComponentTransform_InWorldTransform_PropertyAddress.Address, InWorldTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetComponentTransform_FunctionAddress, intPtr, SetComponentTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetComponentTransform_ReturnValue_Offset), 0, SetComponentTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SetActorTransform")]
	public unsafe bool SetActorTransform(AActor InActor, FTransform InWorldTransform)
	{
		CheckDestroyed();
		if (!SetActorTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SetActorTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorTransform_InActor_Offset), 0, SetActorTransform_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InitializeValue_InContainer(SetActorTransform_InWorldTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetActorTransform_InWorldTransform_Offset), 0, SetActorTransform_InWorldTransform_PropertyAddress.Address, InWorldTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorTransform_FunctionAddress, intPtr, SetActorTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorTransform_ReturnValue_Offset), 0, SetActorTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SetActorSelectionState")]
	public unsafe void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
	{
		CheckDestroyed();
		if (!SetActorSelectionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SetActorSelectionState");
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
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SelectNothing")]
	public unsafe void SelectNothing()
	{
		CheckDestroyed();
		if (!SelectNothing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SelectNothing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectNothing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectNothing_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SelectNothing_FunctionAddress, argsSize: SelectNothing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SelectAllChildren")]
	public unsafe void SelectAllChildren(bool bRecurseChildren)
	{
		CheckDestroyed();
		if (!SelectAllChildren_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SelectAllChildren");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectAllChildren_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectAllChildren_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectAllChildren_bRecurseChildren_Offset), 0, SelectAllChildren_bRecurseChildren_PropertyAddress.Address, bRecurseChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectAllChildren_FunctionAddress, intPtr, SelectAllChildren_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:SelectAll")]
	public unsafe void SelectAll(UWorld InWorld)
	{
		CheckDestroyed();
		if (!SelectAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:SelectAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectAll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, SelectAll_InWorld_Offset), 0, SelectAll_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectAll_FunctionAddress, intPtr, SelectAll_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:InvertSelection")]
	public unsafe void InvertSelection(UWorld InWorld)
	{
		CheckDestroyed();
		if (!InvertSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:InvertSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvertSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvertSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, InvertSelection_InWorld_Offset), 0, InvertSelection_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, InvertSelection_FunctionAddress, intPtr, InvertSelection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:GetSelectedLevelActors")]
	public unsafe List<AActor> GetSelectedLevelActors()
	{
		CheckDestroyed();
		if (!GetSelectedLevelActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:GetSelectedLevelActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedLevelActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedLevelActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedLevelActors_FunctionAddress, intPtr, GetSelectedLevelActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetSelectedLevelActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedLevelActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedLevelActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:GetAllLevelActorsComponents")]
	public unsafe List<UActorComponent> GetAllLevelActorsComponents()
	{
		CheckDestroyed();
		if (!GetAllLevelActorsComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:GetAllLevelActorsComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllLevelActorsComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllLevelActorsComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllLevelActorsComponents_FunctionAddress, intPtr, GetAllLevelActorsComponents_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetAllLevelActorsComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllLevelActorsComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllLevelActorsComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:GetAllLevelActors")]
	public unsafe List<AActor> GetAllLevelActors()
	{
		CheckDestroyed();
		if (!GetAllLevelActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:GetAllLevelActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllLevelActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllLevelActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllLevelActors_FunctionAddress, intPtr, GetAllLevelActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllLevelActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllLevelActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllLevelActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:GetActorReference")]
	public unsafe AActor GetActorReference(string PathToActor)
	{
		CheckDestroyed();
		if (!GetActorReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:GetActorReference");
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
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:DuplicateSelectedActors")]
	public unsafe void DuplicateSelectedActors(UWorld InWorld)
	{
		CheckDestroyed();
		if (!DuplicateSelectedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:DuplicateSelectedActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateSelectedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateSelectedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DuplicateSelectedActors_InWorld_Offset), 0, DuplicateSelectedActors_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateSelectedActors_FunctionAddress, intPtr, DuplicateSelectedActors_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:DuplicateActors")]
	public unsafe List<AActor> DuplicateActors(List<AActor> ActorsToDuplicate, UWorld ToWorld, FVector Offset)
	{
		CheckDestroyed();
		if (!DuplicateActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:DuplicateActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, DuplicateActors_ActorsToDuplicate_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, DuplicateActors_ActorsToDuplicate_Offset), ActorsToDuplicate);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DuplicateActors_ToWorld_Offset), 0, DuplicateActors_ToWorld_PropertyAddress.Address, ToWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DuplicateActors_Offset_Offset), 0, DuplicateActors_Offset_PropertyAddress.Address, Offset);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateActors_FunctionAddress, intPtr, DuplicateActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateActors_ActorsToDuplicate_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, DuplicateActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, DuplicateActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(DuplicateActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:DuplicateActor")]
	public unsafe AActor DuplicateActor(AActor ActorToDuplicate, UWorld ToWorld, FVector Offset)
	{
		CheckDestroyed();
		if (!DuplicateActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:DuplicateActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DuplicateActor_ActorToDuplicate_Offset), 0, DuplicateActor_ActorToDuplicate_PropertyAddress.Address, ActorToDuplicate);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DuplicateActor_ToWorld_Offset), 0, DuplicateActor_ToWorld_PropertyAddress.Address, ToWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DuplicateActor_Offset_Offset), 0, DuplicateActor_Offset_PropertyAddress.Address, Offset);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateActor_FunctionAddress, intPtr, DuplicateActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, DuplicateActor_ReturnValue_Offset), 0, DuplicateActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:DestroyActors")]
	public unsafe bool DestroyActors(List<AActor> ActorsToDestroy)
	{
		CheckDestroyed();
		if (!DestroyActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:DestroyActors");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, DestroyActors_ActorsToDestroy_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, DestroyActors_ActorsToDestroy_Offset), ActorsToDestroy);
		NativeReflection.InvokeFunctionOptimized(base.Address, DestroyActors_FunctionAddress, intPtr, DestroyActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DestroyActors_ActorsToDestroy_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DestroyActors_ReturnValue_Offset), 0, DestroyActors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:DestroyActor")]
	public unsafe bool DestroyActor(AActor ActorToDestroy)
	{
		CheckDestroyed();
		if (!DestroyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:DestroyActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DestroyActor_ActorToDestroy_Offset), 0, DestroyActor_ActorToDestroy_PropertyAddress.Address, ActorToDestroy);
		NativeReflection.InvokeFunctionOptimized(base.Address, DestroyActor_FunctionAddress, intPtr, DestroyActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DestroyActor_ReturnValue_Offset), 0, DestroyActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:DeleteSelectedActors")]
	public unsafe void DeleteSelectedActors(UWorld InWorld)
	{
		CheckDestroyed();
		if (!DeleteSelectedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:DeleteSelectedActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteSelectedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteSelectedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DeleteSelectedActors_InWorld_Offset), 0, DeleteSelectedActors_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteSelectedActors_FunctionAddress, intPtr, DeleteSelectedActors_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:ConvertActors")]
	public unsafe List<AActor> ConvertActors(List<AActor> Actors, TSubclassOf<AActor> ActorClass, string StaticMeshPackagePath)
	{
		CheckDestroyed();
		if (!ConvertActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:ConvertActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ConvertActors_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertActors_Actors_Offset), Actors);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ConvertActors_ActorClass_Offset), 0, ConvertActors_ActorClass_PropertyAddress.Address, ActorClass);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertActors_StaticMeshPackagePath_Offset), 0, ConvertActors_StaticMeshPackagePath_PropertyAddress.Address, StaticMeshPackagePath);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConvertActors_FunctionAddress, intPtr, ConvertActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertActors_Actors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ConvertActors_StaticMeshPackagePath_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, ConvertActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.EditorActorSubsystem:ClearActorSelectionSet")]
	public unsafe void ClearActorSelectionSet()
	{
		CheckDestroyed();
		if (!ClearActorSelectionSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.EditorActorSubsystem:ClearActorSelectionSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearActorSelectionSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearActorSelectionSet_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearActorSelectionSet_FunctionAddress, argsSize: ClearActorSelectionSet_ParamsSize);
	}

	static UEditorActorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorActorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorActorSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealEd.EditorActorSubsystem");
		OnEditCutActorsBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEditCutActorsBegin");
		OnEditCutActorsBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEditCutActorsBegin", Classes.FMulticastDelegateProperty);
		OnEditCutActorsEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEditCutActorsEnd");
		OnEditCutActorsEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEditCutActorsEnd", Classes.FMulticastDelegateProperty);
		OnEditCopyActorsBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEditCopyActorsBegin");
		OnEditCopyActorsBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEditCopyActorsBegin", Classes.FMulticastDelegateProperty);
		OnEditCopyActorsEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEditCopyActorsEnd");
		OnEditCopyActorsEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEditCopyActorsEnd", Classes.FMulticastDelegateProperty);
		OnEditPasteActorsBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEditPasteActorsBegin");
		OnEditPasteActorsBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEditPasteActorsBegin", Classes.FMulticastDelegateProperty);
		OnEditPasteActorsEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEditPasteActorsEnd");
		OnEditPasteActorsEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEditPasteActorsEnd", Classes.FMulticastDelegateProperty);
		OnDuplicateActorsBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDuplicateActorsBegin");
		OnDuplicateActorsBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDuplicateActorsBegin", Classes.FMulticastDelegateProperty);
		OnDuplicateActorsEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDuplicateActorsEnd");
		OnDuplicateActorsEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDuplicateActorsEnd", Classes.FMulticastDelegateProperty);
		OnDeleteActorsBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDeleteActorsBegin");
		OnDeleteActorsBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDeleteActorsBegin", Classes.FMulticastDelegateProperty);
		OnDeleteActorsEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDeleteActorsEnd");
		OnDeleteActorsEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDeleteActorsEnd", Classes.FMulticastDelegateProperty);
		SpawnActorFromObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnActorFromObject");
		SpawnActorFromObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActorFromObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_ObjectToUse_PropertyAddress, SpawnActorFromObject_FunctionAddress, "ObjectToUse");
		SpawnActorFromObject_ObjectToUse_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "ObjectToUse");
		SpawnActorFromObject_ObjectToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "ObjectToUse", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_Location_PropertyAddress, SpawnActorFromObject_FunctionAddress, "Location");
		SpawnActorFromObject_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "Location");
		SpawnActorFromObject_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_Rotation_PropertyAddress, SpawnActorFromObject_FunctionAddress, "Rotation");
		SpawnActorFromObject_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "Rotation");
		SpawnActorFromObject_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_bTransient_PropertyAddress, SpawnActorFromObject_FunctionAddress, "bTransient");
		SpawnActorFromObject_bTransient_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "bTransient");
		SpawnActorFromObject_bTransient_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "bTransient", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_ReturnValue_PropertyAddress, SpawnActorFromObject_FunctionAddress, "ReturnValue");
		SpawnActorFromObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "ReturnValue");
		SpawnActorFromObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActorFromObject_IsValid = SpawnActorFromObject_FunctionAddress != IntPtr.Zero && SpawnActorFromObject_ObjectToUse_IsValid && SpawnActorFromObject_Location_IsValid && SpawnActorFromObject_Rotation_IsValid && SpawnActorFromObject_bTransient_IsValid && SpawnActorFromObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SpawnActorFromObject", SpawnActorFromObject_IsValid);
		SpawnActorFromClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnActorFromClass");
		SpawnActorFromClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActorFromClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_ActorClass_PropertyAddress, SpawnActorFromClass_FunctionAddress, "ActorClass");
		SpawnActorFromClass_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "ActorClass");
		SpawnActorFromClass_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_Location_PropertyAddress, SpawnActorFromClass_FunctionAddress, "Location");
		SpawnActorFromClass_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "Location");
		SpawnActorFromClass_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_Rotation_PropertyAddress, SpawnActorFromClass_FunctionAddress, "Rotation");
		SpawnActorFromClass_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "Rotation");
		SpawnActorFromClass_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_bTransient_PropertyAddress, SpawnActorFromClass_FunctionAddress, "bTransient");
		SpawnActorFromClass_bTransient_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "bTransient");
		SpawnActorFromClass_bTransient_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "bTransient", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_ReturnValue_PropertyAddress, SpawnActorFromClass_FunctionAddress, "ReturnValue");
		SpawnActorFromClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "ReturnValue");
		SpawnActorFromClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActorFromClass_IsValid = SpawnActorFromClass_FunctionAddress != IntPtr.Zero && SpawnActorFromClass_ActorClass_IsValid && SpawnActorFromClass_Location_IsValid && SpawnActorFromClass_Rotation_IsValid && SpawnActorFromClass_bTransient_IsValid && SpawnActorFromClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SpawnActorFromClass", SpawnActorFromClass_IsValid);
		SetSelectedLevelActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedLevelActors");
		SetSelectedLevelActors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedLevelActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedLevelActors_ActorsToSelect_PropertyAddress, SetSelectedLevelActors_FunctionAddress, "ActorsToSelect");
		SetSelectedLevelActors_ActorsToSelect_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedLevelActors_FunctionAddress, "ActorsToSelect");
		SetSelectedLevelActors_ActorsToSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedLevelActors_FunctionAddress, "ActorsToSelect", Classes.FArrayProperty);
		SetSelectedLevelActors_IsValid = SetSelectedLevelActors_FunctionAddress != IntPtr.Zero && SetSelectedLevelActors_ActorsToSelect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SetSelectedLevelActors", SetSelectedLevelActors_IsValid);
		SetComponentTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetComponentTransform");
		SetComponentTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComponentTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComponentTransform_InSceneComponent_PropertyAddress, SetComponentTransform_FunctionAddress, "InSceneComponent");
		SetComponentTransform_InSceneComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentTransform_FunctionAddress, "InSceneComponent");
		SetComponentTransform_InSceneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentTransform_FunctionAddress, "InSceneComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComponentTransform_InWorldTransform_PropertyAddress, SetComponentTransform_FunctionAddress, "InWorldTransform");
		SetComponentTransform_InWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentTransform_FunctionAddress, "InWorldTransform");
		SetComponentTransform_InWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentTransform_FunctionAddress, "InWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComponentTransform_ReturnValue_PropertyAddress, SetComponentTransform_FunctionAddress, "ReturnValue");
		SetComponentTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentTransform_FunctionAddress, "ReturnValue");
		SetComponentTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetComponentTransform_IsValid = SetComponentTransform_FunctionAddress != IntPtr.Zero && SetComponentTransform_InSceneComponent_IsValid && SetComponentTransform_InWorldTransform_IsValid && SetComponentTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SetComponentTransform", SetComponentTransform_IsValid);
		SetActorTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorTransform");
		SetActorTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_InActor_PropertyAddress, SetActorTransform_FunctionAddress, "InActor");
		SetActorTransform_InActor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "InActor");
		SetActorTransform_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_InWorldTransform_PropertyAddress, SetActorTransform_FunctionAddress, "InWorldTransform");
		SetActorTransform_InWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "InWorldTransform");
		SetActorTransform_InWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "InWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_ReturnValue_PropertyAddress, SetActorTransform_FunctionAddress, "ReturnValue");
		SetActorTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "ReturnValue");
		SetActorTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorTransform_IsValid = SetActorTransform_FunctionAddress != IntPtr.Zero && SetActorTransform_InActor_IsValid && SetActorTransform_InWorldTransform_IsValid && SetActorTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SetActorTransform", SetActorTransform_IsValid);
		SetActorSelectionState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorSelectionState");
		SetActorSelectionState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorSelectionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorSelectionState_Actor_PropertyAddress, SetActorSelectionState_FunctionAddress, "Actor");
		SetActorSelectionState_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSelectionState_FunctionAddress, "Actor");
		SetActorSelectionState_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSelectionState_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorSelectionState_bShouldBeSelected_PropertyAddress, SetActorSelectionState_FunctionAddress, "bShouldBeSelected");
		SetActorSelectionState_bShouldBeSelected_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSelectionState_FunctionAddress, "bShouldBeSelected");
		SetActorSelectionState_bShouldBeSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSelectionState_FunctionAddress, "bShouldBeSelected", Classes.FBoolProperty);
		SetActorSelectionState_IsValid = SetActorSelectionState_FunctionAddress != IntPtr.Zero && SetActorSelectionState_Actor_IsValid && SetActorSelectionState_bShouldBeSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SetActorSelectionState", SetActorSelectionState_IsValid);
		SelectNothing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectNothing");
		SelectNothing_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectNothing_FunctionAddress);
		SelectNothing_IsValid = SelectNothing_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SelectNothing", SelectNothing_IsValid);
		SelectAllChildren_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectAllChildren");
		SelectAllChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectAllChildren_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectAllChildren_bRecurseChildren_PropertyAddress, SelectAllChildren_FunctionAddress, "bRecurseChildren");
		SelectAllChildren_bRecurseChildren_Offset = NativeReflectionCached.GetPropertyOffset(SelectAllChildren_FunctionAddress, "bRecurseChildren");
		SelectAllChildren_bRecurseChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectAllChildren_FunctionAddress, "bRecurseChildren", Classes.FBoolProperty);
		SelectAllChildren_IsValid = SelectAllChildren_FunctionAddress != IntPtr.Zero && SelectAllChildren_bRecurseChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SelectAllChildren", SelectAllChildren_IsValid);
		SelectAll_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectAll");
		SelectAll_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectAll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectAll_InWorld_PropertyAddress, SelectAll_FunctionAddress, "InWorld");
		SelectAll_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(SelectAll_FunctionAddress, "InWorld");
		SelectAll_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectAll_FunctionAddress, "InWorld", Classes.FObjectProperty);
		SelectAll_IsValid = SelectAll_FunctionAddress != IntPtr.Zero && SelectAll_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:SelectAll", SelectAll_IsValid);
		InvertSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InvertSelection");
		InvertSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(InvertSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InvertSelection_InWorld_PropertyAddress, InvertSelection_FunctionAddress, "InWorld");
		InvertSelection_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(InvertSelection_FunctionAddress, "InWorld");
		InvertSelection_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(InvertSelection_FunctionAddress, "InWorld", Classes.FObjectProperty);
		InvertSelection_IsValid = InvertSelection_FunctionAddress != IntPtr.Zero && InvertSelection_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:InvertSelection", InvertSelection_IsValid);
		GetSelectedLevelActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedLevelActors");
		GetSelectedLevelActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedLevelActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedLevelActors_ReturnValue_PropertyAddress, GetSelectedLevelActors_FunctionAddress, "ReturnValue");
		GetSelectedLevelActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedLevelActors_FunctionAddress, "ReturnValue");
		GetSelectedLevelActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedLevelActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedLevelActors_IsValid = GetSelectedLevelActors_FunctionAddress != IntPtr.Zero && GetSelectedLevelActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:GetSelectedLevelActors", GetSelectedLevelActors_IsValid);
		GetAllLevelActorsComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllLevelActorsComponents");
		GetAllLevelActorsComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllLevelActorsComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelActorsComponents_ReturnValue_PropertyAddress, GetAllLevelActorsComponents_FunctionAddress, "ReturnValue");
		GetAllLevelActorsComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelActorsComponents_FunctionAddress, "ReturnValue");
		GetAllLevelActorsComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelActorsComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllLevelActorsComponents_IsValid = GetAllLevelActorsComponents_FunctionAddress != IntPtr.Zero && GetAllLevelActorsComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:GetAllLevelActorsComponents", GetAllLevelActorsComponents_IsValid);
		GetAllLevelActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllLevelActors");
		GetAllLevelActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllLevelActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelActors_ReturnValue_PropertyAddress, GetAllLevelActors_FunctionAddress, "ReturnValue");
		GetAllLevelActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelActors_FunctionAddress, "ReturnValue");
		GetAllLevelActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllLevelActors_IsValid = GetAllLevelActors_FunctionAddress != IntPtr.Zero && GetAllLevelActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:GetAllLevelActors", GetAllLevelActors_IsValid);
		GetActorReference_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorReference");
		GetActorReference_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_PathToActor_PropertyAddress, GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "PathToActor", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_ReturnValue_PropertyAddress, GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorReference_IsValid = GetActorReference_FunctionAddress != IntPtr.Zero && GetActorReference_PathToActor_IsValid && GetActorReference_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:GetActorReference", GetActorReference_IsValid);
		DuplicateSelectedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DuplicateSelectedActors");
		DuplicateSelectedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateSelectedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSelectedActors_InWorld_PropertyAddress, DuplicateSelectedActors_FunctionAddress, "InWorld");
		DuplicateSelectedActors_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSelectedActors_FunctionAddress, "InWorld");
		DuplicateSelectedActors_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSelectedActors_FunctionAddress, "InWorld", Classes.FObjectProperty);
		DuplicateSelectedActors_IsValid = DuplicateSelectedActors_FunctionAddress != IntPtr.Zero && DuplicateSelectedActors_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:DuplicateSelectedActors", DuplicateSelectedActors_IsValid);
		DuplicateActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DuplicateActors");
		DuplicateActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActors_ActorsToDuplicate_PropertyAddress, DuplicateActors_FunctionAddress, "ActorsToDuplicate");
		DuplicateActors_ActorsToDuplicate_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActors_FunctionAddress, "ActorsToDuplicate");
		DuplicateActors_ActorsToDuplicate_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActors_FunctionAddress, "ActorsToDuplicate", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActors_ToWorld_PropertyAddress, DuplicateActors_FunctionAddress, "ToWorld");
		DuplicateActors_ToWorld_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActors_FunctionAddress, "ToWorld");
		DuplicateActors_ToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActors_FunctionAddress, "ToWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActors_Offset_PropertyAddress, DuplicateActors_FunctionAddress, "Offset");
		DuplicateActors_Offset_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActors_FunctionAddress, "Offset");
		DuplicateActors_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActors_FunctionAddress, "Offset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActors_ReturnValue_PropertyAddress, DuplicateActors_FunctionAddress, "ReturnValue");
		DuplicateActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActors_FunctionAddress, "ReturnValue");
		DuplicateActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		DuplicateActors_IsValid = DuplicateActors_FunctionAddress != IntPtr.Zero && DuplicateActors_ActorsToDuplicate_IsValid && DuplicateActors_ToWorld_IsValid && DuplicateActors_Offset_IsValid && DuplicateActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:DuplicateActors", DuplicateActors_IsValid);
		DuplicateActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DuplicateActor");
		DuplicateActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_ActorToDuplicate_PropertyAddress, DuplicateActor_FunctionAddress, "ActorToDuplicate");
		DuplicateActor_ActorToDuplicate_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "ActorToDuplicate");
		DuplicateActor_ActorToDuplicate_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "ActorToDuplicate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_ToWorld_PropertyAddress, DuplicateActor_FunctionAddress, "ToWorld");
		DuplicateActor_ToWorld_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "ToWorld");
		DuplicateActor_ToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "ToWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_Offset_PropertyAddress, DuplicateActor_FunctionAddress, "Offset");
		DuplicateActor_Offset_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "Offset");
		DuplicateActor_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "Offset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_ReturnValue_PropertyAddress, DuplicateActor_FunctionAddress, "ReturnValue");
		DuplicateActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "ReturnValue");
		DuplicateActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateActor_IsValid = DuplicateActor_FunctionAddress != IntPtr.Zero && DuplicateActor_ActorToDuplicate_IsValid && DuplicateActor_ToWorld_IsValid && DuplicateActor_Offset_IsValid && DuplicateActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:DuplicateActor", DuplicateActor_IsValid);
		DestroyActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroyActors");
		DestroyActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyActors_ActorsToDestroy_PropertyAddress, DestroyActors_FunctionAddress, "ActorsToDestroy");
		DestroyActors_ActorsToDestroy_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActors_FunctionAddress, "ActorsToDestroy");
		DestroyActors_ActorsToDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActors_FunctionAddress, "ActorsToDestroy", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DestroyActors_ReturnValue_PropertyAddress, DestroyActors_FunctionAddress, "ReturnValue");
		DestroyActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActors_FunctionAddress, "ReturnValue");
		DestroyActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DestroyActors_IsValid = DestroyActors_FunctionAddress != IntPtr.Zero && DestroyActors_ActorsToDestroy_IsValid && DestroyActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:DestroyActors", DestroyActors_IsValid);
		DestroyActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroyActor");
		DestroyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyActor_ActorToDestroy_PropertyAddress, DestroyActor_FunctionAddress, "ActorToDestroy");
		DestroyActor_ActorToDestroy_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActor_FunctionAddress, "ActorToDestroy");
		DestroyActor_ActorToDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActor_FunctionAddress, "ActorToDestroy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DestroyActor_ReturnValue_PropertyAddress, DestroyActor_FunctionAddress, "ReturnValue");
		DestroyActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActor_FunctionAddress, "ReturnValue");
		DestroyActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DestroyActor_IsValid = DestroyActor_FunctionAddress != IntPtr.Zero && DestroyActor_ActorToDestroy_IsValid && DestroyActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:DestroyActor", DestroyActor_IsValid);
		DeleteSelectedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeleteSelectedActors");
		DeleteSelectedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteSelectedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteSelectedActors_InWorld_PropertyAddress, DeleteSelectedActors_FunctionAddress, "InWorld");
		DeleteSelectedActors_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DeleteSelectedActors_FunctionAddress, "InWorld");
		DeleteSelectedActors_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteSelectedActors_FunctionAddress, "InWorld", Classes.FObjectProperty);
		DeleteSelectedActors_IsValid = DeleteSelectedActors_FunctionAddress != IntPtr.Zero && DeleteSelectedActors_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:DeleteSelectedActors", DeleteSelectedActors_IsValid);
		ConvertActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConvertActors");
		ConvertActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertActors_Actors_PropertyAddress, ConvertActors_FunctionAddress, "Actors");
		ConvertActors_Actors_Offset = NativeReflectionCached.GetPropertyOffset(ConvertActors_FunctionAddress, "Actors");
		ConvertActors_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertActors_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertActors_ActorClass_PropertyAddress, ConvertActors_FunctionAddress, "ActorClass");
		ConvertActors_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(ConvertActors_FunctionAddress, "ActorClass");
		ConvertActors_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertActors_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertActors_StaticMeshPackagePath_PropertyAddress, ConvertActors_FunctionAddress, "StaticMeshPackagePath");
		ConvertActors_StaticMeshPackagePath_Offset = NativeReflectionCached.GetPropertyOffset(ConvertActors_FunctionAddress, "StaticMeshPackagePath");
		ConvertActors_StaticMeshPackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertActors_FunctionAddress, "StaticMeshPackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertActors_ReturnValue_PropertyAddress, ConvertActors_FunctionAddress, "ReturnValue");
		ConvertActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertActors_FunctionAddress, "ReturnValue");
		ConvertActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ConvertActors_IsValid = ConvertActors_FunctionAddress != IntPtr.Zero && ConvertActors_Actors_IsValid && ConvertActors_ActorClass_IsValid && ConvertActors_StaticMeshPackagePath_IsValid && ConvertActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:ConvertActors", ConvertActors_IsValid);
		ClearActorSelectionSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearActorSelectionSet");
		ClearActorSelectionSet_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearActorSelectionSet_FunctionAddress);
		ClearActorSelectionSet_IsValid = ClearActorSelectionSet_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.EditorActorSubsystem:ClearActorSelectionSet", ClearActorSelectionSet_IsValid);
	}
}
