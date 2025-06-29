using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor")]
public class BGU_EQSPointRecorderActor : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool LocalMode_IsValid;

	private static int LocalMode_Offset;

	private static FFieldAddress LocalMode_PropertyAddress;

	private static bool RelativeTarget_IsValid;

	private static int RelativeTarget_Offset;

	private static bool GeneratePointsEQSTemplate_IsValid;

	private static int GeneratePointsEQSTemplate_Offset;

	private static bool QueryConfig_IsValid;

	private static int QueryConfig_Offset;

	private static FFieldAddress QueryConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSEnvNamedValue> QueryConfig_Marshaler;

	private static bool PreviewActor_IsValid;

	private static int PreviewActor_Offset;

	private static bool CustomAddingActors_IsValid;

	private static int CustomAddingActors_Offset;

	private static FFieldAddress CustomAddingActors_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> CustomAddingActors_Marshaler;

	private static bool EQSPoints_IsValid;

	private static int EQSPoints_Offset;

	private static FFieldAddress EQSPoints_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> EQSPoints_Marshaler;

	private static bool CustomPoints_IsValid;

	private static int CustomPoints_Offset;

	private static FFieldAddress CustomPoints_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> CustomPoints_Marshaler;

	private static bool GeneratedEQSActors_IsValid;

	private static int GeneratedEQSActors_Offset;

	private static FFieldAddress GeneratedEQSActors_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> GeneratedEQSActors_Marshaler;

	private static bool bRunQueryWhenMove_IsValid;

	private static int bRunQueryWhenMove_Offset;

	private static FFieldAddress bRunQueryWhenMove_PropertyAddress;

	private static bool bOnlyUpdateWhenMoveFinish_IsValid;

	private static int bOnlyUpdateWhenMoveFinish_Offset;

	private static FFieldAddress bOnlyUpdateWhenMoveFinish_PropertyAddress;

	private static bool bEnableDebug_IsValid;

	private static int bEnableDebug_Offset;

	private static FFieldAddress bEnableDebug_PropertyAddress;

	private static bool ClearRecord_IsValid;

	private static IntPtr ClearRecord_FunctionAddress;

	private static int ClearRecord_ParamsSize;

	private static bool RunEQSQuery_IsValid;

	private static IntPtr RunEQSQuery_FunctionAddress;

	private static int RunEQSQuery_ParamsSize;

	private static bool RecordEQSPoints_IsValid;

	private static IntPtr RecordEQSPoints_FunctionAddress;

	private static int RecordEQSPoints_ParamsSize;

	private static bool ClearSpawnPoints_IsValid;

	private static IntPtr ClearSpawnPoints_FunctionAddress;

	private static int ClearSpawnPoints_ParamsSize;

	private static bool ClearCustomPoints_IsValid;

	private static IntPtr ClearCustomPoints_FunctionAddress;

	private static int ClearCustomPoints_ParamsSize;

	private static bool RecordCustomPoints_IsValid;

	private static IntPtr RecordCustomPoints_FunctionAddress;

	private static int RecordCustomPoints_ParamsSize;

	private static bool PreviewCustomPoints_IsValid;

	private static IntPtr PreviewCustomPoints_FunctionAddress;

	private static int PreviewCustomPoints_ParamsSize;

	private static bool ClearGenerateEQSActors_IsValid;

	private static IntPtr ClearGenerateEQSActors_FunctionAddress;

	private static int ClearGenerateEQSActors_ParamsSize;

	private static bool PreviewRecordSpawnPoints_IsValid;

	private static IntPtr PreviewRecordSpawnPoints_FunctionAddress;

	private static int PreviewRecordSpawnPoints_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool OnPostEditMove_IsValid;

	private static IntPtr OnPostEditMove_FunctionAddress;

	private static int OnPostEditMove_ParamsSize;

	private static bool OnPostEditMove_bFinish_IsValid;

	private static int OnPostEditMove_bFinish_Offset;

	private static FFieldAddress OnPostEditMove_bFinish_PropertyAddress;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("EQSPointRecorder | LocalMode")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:LocalMode")]
	public bool LocalMode
	{
		get
		{
			CheckDestroyed();
			if (!LocalMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:LocalMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LocalMode_Offset), 0, LocalMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocalMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:LocalMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LocalMode_Offset), 0, LocalMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("EQSPointRecorder | LocalMode")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:RelativeTarget")]
	public AActor RelativeTarget
	{
		get
		{
			CheckDestroyed();
			if (!RelativeTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:RelativeTarget");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, RelativeTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:RelativeTarget");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, RelativeTarget_Offset), value);
			}
		}
	}

	[Category("EQSPointRecorder | EQS")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:GeneratePointsEQSTemplate")]
	public UEnvQuery GeneratePointsEQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!GeneratePointsEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:GeneratePointsEQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, GeneratePointsEQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeneratePointsEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:GeneratePointsEQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, GeneratePointsEQSTemplate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("EQSPointRecorder | EQS")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:QueryConfig")]
	public TArrayReadWrite<FGSEnvNamedValue> QueryConfig
	{
		get
		{
			CheckDestroyed();
			if (!QueryConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:QueryConfig");
				return null;
			}
			if (QueryConfig_Marshaler == null)
			{
				QueryConfig_Marshaler = new TArrayReadWriteMarshaler<FGSEnvNamedValue>(1, QueryConfig_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative);
			}
			return QueryConfig_Marshaler.FromNative(IntPtr.Add(base.Address, QueryConfig_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[UProperty]
	[Category("EQSPointRecorder")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewActor")]
	public TSubclassOf<AActor> PreviewActor
	{
		get
		{
			CheckDestroyed();
			if (!PreviewActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewActor");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, PreviewActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviewActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewActor");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, PreviewActor_Offset), value);
			}
		}
	}

	[Category("EQSPointRecorder | Custom")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:CustomAddingActors")]
	public TArrayReadWrite<TSoftObject<AActor>> CustomAddingActors
	{
		get
		{
			CheckDestroyed();
			if (!CustomAddingActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:CustomAddingActors");
				return null;
			}
			if (CustomAddingActors_Marshaler == null)
			{
				CustomAddingActors_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, CustomAddingActors_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return CustomAddingActors_Marshaler.FromNative(IntPtr.Add(base.Address, CustomAddingActors_Offset));
		}
	}

	[Category("EQSPointRecorder | EQS")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:EQSPoints")]
	public TArrayReadWrite<FVector> EQSPoints
	{
		get
		{
			CheckDestroyed();
			if (!EQSPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:EQSPoints");
				return null;
			}
			if (EQSPoints_Marshaler == null)
			{
				EQSPoints_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, EQSPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return EQSPoints_Marshaler.FromNative(IntPtr.Add(base.Address, EQSPoints_Offset));
		}
	}

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("EQSPointRecorder | Custom")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:CustomPoints")]
	public TArrayReadWrite<FVector> CustomPoints
	{
		get
		{
			CheckDestroyed();
			if (!CustomPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:CustomPoints");
				return null;
			}
			if (CustomPoints_Marshaler == null)
			{
				CustomPoints_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, CustomPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return CustomPoints_Marshaler.FromNative(IntPtr.Add(base.Address, CustomPoints_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[Category("EQSPointRecorder | EQS")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:GeneratedEQSActors")]
	public TArrayReadWrite<TSoftObject<AActor>> GeneratedEQSActors
	{
		get
		{
			CheckDestroyed();
			if (!GeneratedEQSActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:GeneratedEQSActors");
				return null;
			}
			if (GeneratedEQSActors_Marshaler == null)
			{
				GeneratedEQSActors_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, GeneratedEQSActors_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return GeneratedEQSActors_Marshaler.FromNative(IntPtr.Add(base.Address, GeneratedEQSActors_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("EQSPointRecorder | EQS")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:bRunQueryWhenMove")]
	public bool bRunQueryWhenMove
	{
		get
		{
			CheckDestroyed();
			if (!bRunQueryWhenMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:bRunQueryWhenMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunQueryWhenMove_Offset), 0, bRunQueryWhenMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunQueryWhenMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:bRunQueryWhenMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunQueryWhenMove_Offset), 0, bRunQueryWhenMove_PropertyAddress.Address, value);
			}
		}
	}

	[Category("EQSPointRecorder | EQS")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:bOnlyUpdateWhenMoveFinish")]
	public bool bOnlyUpdateWhenMoveFinish
	{
		get
		{
			CheckDestroyed();
			if (!bOnlyUpdateWhenMoveFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:bOnlyUpdateWhenMoveFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bOnlyUpdateWhenMoveFinish_Offset), 0, bOnlyUpdateWhenMoveFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bOnlyUpdateWhenMoveFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:bOnlyUpdateWhenMoveFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bOnlyUpdateWhenMoveFinish_Offset), 0, bOnlyUpdateWhenMoveFinish_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("EQSPointRecorder")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:bEnableDebug")]
	public bool bEnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:bEnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_EQSPointRecorderActor:bEnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[Category("EQSPointRecorder")]
	[DisplayName("预览已记录的所有点")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewRecordSpawnPoints")]
	public void PreviewRecordSpawnPoints()
	{
		GeneratePreviewMesh(EQSPoints.ToList(), out var PreviewActors);
		foreach (TSoftObject<AActor> item in PreviewActors)
		{
			GeneratedEQSActors.Add(item);
		}
		GeneratePreviewMesh(CustomPoints.ToList(), out PreviewActors);
		foreach (TSoftObject<AActor> item2 in PreviewActors)
		{
			CustomAddingActors.Add(item2);
		}
	}

	[UFunction]
	[DisplayName("删除所有预览点")]
	[BlueprintCallable]
	[Category("EQSPointRecorder")]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearSpawnPoints")]
	public void ClearSpawnPoints()
	{
		ClearGenerateEQSActors();
		ClearCustomPoints();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("EQSPointRecorder")]
	[UMeta(MDFunc.CallInEditor)]
	[DisplayName("清除所有记录点")]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearRecord")]
	public void ClearRecord()
	{
		EQSPoints.Clear();
		CustomPoints.Clear();
	}

	[UMeta(MDFunc.CallInEditor)]
	[DisplayName("根据EQS生成点")]
	[Category("EQSPointRecorder | EQS")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:RunEQSQuery")]
	public void RunEQSQuery()
	{
		UBGUEQSObject uBGUEQSObject = UObject.NewObject<UBGUEQSObject>(this);
		if (GeneratedEQSActors.Count > 0)
		{
			ClearGenerateEQSActors();
		}
		List<FVector> Locations;
		List<float> Scores;
		if (QueryConfig.Count > 0)
		{
			uBGUEQSObject.EQSObjRunInstantWithCustomParams(GeneratePointsEQSTemplate, this, QueryConfig.ToList(), out Locations, out Scores);
		}
		else
		{
			uBGUEQSObject.EQSObjRunInstant(GeneratePointsEQSTemplate, this, out Locations, out Scores);
		}
		if (InLocalMode())
		{
			FTransform actorTransform = RelativeTarget.GetActorTransform();
			actorTransform.Scale3D = FVector.OneVector;
			for (int i = 0; i < Locations.Count; i++)
			{
				Locations[i] = actorTransform.InverseTransformLocation(Locations[i]);
			}
		}
		GeneratePreviewMesh(Locations, out var PreviewActors);
		foreach (TSoftObject<AActor> item in PreviewActors)
		{
			GeneratedEQSActors.Add(item);
		}
	}

	[UMeta(MDFunc.CallInEditor)]
	[DisplayName("删除EQS预览点")]
	[Category("EQSPointRecorder | EQS")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearGenerateEQSActors")]
	public void ClearGenerateEQSActors()
	{
		foreach (TSoftObject<AActor> generatedEQSActor in GeneratedEQSActors)
		{
			if (generatedEQSActor.IsValid)
			{
				generatedEQSActor.Value.DetachFromActor();
				BGU_UnrealWorldUtil.DestroyActor(generatedEQSActor.Value);
			}
		}
		GeneratedEQSActors.Clear();
	}

	[DisplayName("EQS生成的点位置加入记录中")]
	[Category("EQSPointRecorder | EQS")]
	[BlueprintCallable]
	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:RecordEQSPoints")]
	public void RecordEQSPoints()
	{
		if (GeneratedEQSActors.Count == 0)
		{
			return;
		}
		EQSPoints.Clear();
		foreach (TSoftObject<AActor> generatedEQSActor in GeneratedEQSActors)
		{
			if (generatedEQSActor.IsValid)
			{
				if (!InLocalMode())
				{
					EQSPoints.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(generatedEQSActor.Value));
					continue;
				}
				FTransform actorTransform = RelativeTarget.GetActorTransform();
				actorTransform.Scale3D = FVector.OneVector;
				EQSPoints.Add(actorTransform.InverseTransformLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(generatedEQSActor.Value)));
			}
		}
		bRunQueryWhenMove = false;
	}

	[DisplayName("自定义Actor的位置加入记录")]
	[UMeta(MDFunc.CallInEditor)]
	[Category("EQSPointRecorder | Custom")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:RecordCustomPoints")]
	public void RecordCustomPoints()
	{
		if (CustomAddingActors.Count == 0)
		{
			return;
		}
		CustomPoints.Clear();
		foreach (TSoftObject<AActor> customAddingActor in CustomAddingActors)
		{
			if (customAddingActor.IsValid)
			{
				if (!InLocalMode())
				{
					CustomPoints.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(customAddingActor.Value));
					continue;
				}
				FTransform actorTransform = RelativeTarget.GetActorTransform();
				actorTransform.Scale3D = FVector.OneVector;
				CustomPoints.Add(actorTransform.InverseTransformLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(customAddingActor.Value)));
			}
		}
	}

	[BlueprintCallable]
	[Category("EQSPointRecorder | Custom")]
	[UMeta(MDFunc.CallInEditor)]
	[DisplayName("删除自定义Actor")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearCustomPoints")]
	public void ClearCustomPoints()
	{
		foreach (TSoftObject<AActor> customAddingActor in CustomAddingActors)
		{
			if (customAddingActor.IsValid)
			{
				customAddingActor.Value.DetachFromActor();
				BGU_UnrealWorldUtil.DestroyActor(customAddingActor.Value);
			}
		}
		CustomAddingActors.Clear();
	}

	[BlueprintCallable]
	[Category("EQSPointRecorder | Custom")]
	[DisplayName("生成自定义位置预览点")]
	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewCustomPoints")]
	public void PreviewCustomPoints()
	{
		GeneratePreviewMesh(CustomPoints.ToList(), out var PreviewActors);
		foreach (TSoftObject<AActor> item in PreviewActors)
		{
			CustomAddingActors.Add(item);
		}
	}

	private void GeneratePreviewMesh(List<FVector> Locations, out List<TSoftObject<AActor>> PreviewActors)
	{
		PreviewActors = new List<TSoftObject<AActor>>();
		if (InLocalMode())
		{
			FTransform actorTransform = RelativeTarget.GetActorTransform();
			actorTransform.Scale3D = FVector.OneVector;
			{
				foreach (FVector Location in Locations)
				{
					AActor aActor = UGSFuncLibForEditor.GEditor_SpawnActorAbsolute(Transform: new FTransform(FRotator.ZeroRotator, actorTransform.TransformLocation(Location)), EditotWorld: UGSFuncLibForEditor.GetEditorWorld(), Class: PreviewActor.Value);
					aActor.SetActorEnableCollision(bNewActorEnableCollision: false);
					aActor.RootComponent.SetAbsolute();
					aActor.AttachToActor(RelativeTarget, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
					PreviewActors.Add(new TSoftObject<AActor>(aActor));
				}
				return;
			}
		}
		foreach (FVector Location2 in Locations)
		{
			AActor aActor2 = UGSFuncLibForEditor.GEditor_SpawnActorAbsolute(Transform: new FTransform(FRotator.ZeroRotator, Location2), EditotWorld: UGSFuncLibForEditor.GetEditorWorld(), Class: PreviewActor.Value);
			aActor2.SetActorEnableCollision(bNewActorEnableCollision: false);
			aActor2.RootComponent.SetAbsolute(bNewAbsoluteLocation: true, bNewAbsoluteRotation: true, bNewAbsoluteScale: true);
			aActor2.AttachToActor(this, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			PreviewActors.Add(new TSoftObject<AActor>(aActor2));
		}
	}

	public bool InLocalMode()
	{
		if (LocalMode)
		{
			_ = RelativeTarget == null;
		}
		if (LocalMode)
		{
			return RelativeTarget != null;
		}
		return false;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
	}

	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		ClearGenerateEQSActors();
		base.BeginPlayCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:OnPostEditMove")]
	protected override void OnPostEditMove_Implementation(bool bFinish)
	{
		base.OnPostEditMove_Implementation(bFinish);
		if (bRunQueryWhenMove && (!bOnlyUpdateWhenMoveFinish || bFinish))
		{
			RunEQSQuery();
		}
	}

	[USharpPath("/Script/b1-Managed.BGU_EQSPointRecorderActor:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		ClearGenerateEQSActors();
	}

	protected override void CreateDataContainer(FObjectInitializer Initializer)
	{
		base.DataComp = Initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.EQSPointRecorderDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearRecord")]
	private static void ClearRecord__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.ClearRecord();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:RunEQSQuery")]
	private static void RunEQSQuery__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.RunEQSQuery();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:RecordEQSPoints")]
	private static void RecordEQSPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.RecordEQSPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearSpawnPoints")]
	private static void ClearSpawnPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.ClearSpawnPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearCustomPoints")]
	private static void ClearCustomPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.ClearCustomPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:RecordCustomPoints")]
	private static void RecordCustomPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.RecordCustomPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewCustomPoints")]
	private static void PreviewCustomPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.PreviewCustomPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearGenerateEQSActors")]
	private static void ClearGenerateEQSActors__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.ClearGenerateEQSActors();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewRecordSpawnPoints")]
	private static void PreviewRecordSpawnPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.PreviewRecordSpawnPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:OnPostEditMove")]
	private static void OnPostEditMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bool bFinish = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnPostEditMove_bFinish_Offset), 0, OnPostEditMove_bFinish_PropertyAddress.Address);
		bGU_EQSPointRecorderActor.OnPostEditMove_Implementation(bFinish);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_EQSPointRecorderActor:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = GCHelper.Find<BGU_EQSPointRecorderActor>(obj);
		bGU_EQSPointRecorderActor.ReceiveDestroyed_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_EQSPointRecorderActor");
		Root_Offset = NativeReflection.GetPropertyOffset(intPtr, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Root", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref LocalMode_PropertyAddress, intPtr, "LocalMode");
		LocalMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocalMode");
		LocalMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocalMode", Classes.FBoolProperty);
		RelativeTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelativeTarget");
		RelativeTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelativeTarget", Classes.FObjectProperty);
		GeneratePointsEQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeneratePointsEQSTemplate");
		GeneratePointsEQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeneratePointsEQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QueryConfig_PropertyAddress, intPtr, "QueryConfig");
		QueryConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryConfig");
		QueryConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryConfig", Classes.FArrayProperty);
		PreviewActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreviewActor");
		PreviewActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreviewActor", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref CustomAddingActors_PropertyAddress, intPtr, "CustomAddingActors");
		CustomAddingActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomAddingActors");
		CustomAddingActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomAddingActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EQSPoints_PropertyAddress, intPtr, "EQSPoints");
		EQSPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSPoints");
		EQSPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSPoints", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CustomPoints_PropertyAddress, intPtr, "CustomPoints");
		CustomPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomPoints");
		CustomPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomPoints", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GeneratedEQSActors_PropertyAddress, intPtr, "GeneratedEQSActors");
		GeneratedEQSActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeneratedEQSActors");
		GeneratedEQSActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeneratedEQSActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bRunQueryWhenMove_PropertyAddress, intPtr, "bRunQueryWhenMove");
		bRunQueryWhenMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunQueryWhenMove");
		bRunQueryWhenMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunQueryWhenMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bOnlyUpdateWhenMoveFinish_PropertyAddress, intPtr, "bOnlyUpdateWhenMoveFinish");
		bOnlyUpdateWhenMoveFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bOnlyUpdateWhenMoveFinish");
		bOnlyUpdateWhenMoveFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bOnlyUpdateWhenMoveFinish", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebug_PropertyAddress, intPtr, "bEnableDebug");
		bEnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableDebug");
		bEnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableDebug", Classes.FBoolProperty);
		ClearRecord_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearRecord");
		ClearRecord_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearRecord_FunctionAddress);
		ClearRecord_IsValid = ClearRecord_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearRecord", ClearRecord_IsValid);
		RunEQSQuery_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RunEQSQuery");
		RunEQSQuery_ParamsSize = NativeReflection.GetFunctionParamsSize(RunEQSQuery_FunctionAddress);
		RunEQSQuery_IsValid = RunEQSQuery_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:RunEQSQuery", RunEQSQuery_IsValid);
		RecordEQSPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecordEQSPoints");
		RecordEQSPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordEQSPoints_FunctionAddress);
		RecordEQSPoints_IsValid = RecordEQSPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:RecordEQSPoints", RecordEQSPoints_IsValid);
		ClearSpawnPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSpawnPoints");
		ClearSpawnPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSpawnPoints_FunctionAddress);
		ClearSpawnPoints_IsValid = ClearSpawnPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearSpawnPoints", ClearSpawnPoints_IsValid);
		ClearCustomPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearCustomPoints");
		ClearCustomPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearCustomPoints_FunctionAddress);
		ClearCustomPoints_IsValid = ClearCustomPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearCustomPoints", ClearCustomPoints_IsValid);
		RecordCustomPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecordCustomPoints");
		RecordCustomPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordCustomPoints_FunctionAddress);
		RecordCustomPoints_IsValid = RecordCustomPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:RecordCustomPoints", RecordCustomPoints_IsValid);
		PreviewCustomPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreviewCustomPoints");
		PreviewCustomPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(PreviewCustomPoints_FunctionAddress);
		PreviewCustomPoints_IsValid = PreviewCustomPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewCustomPoints", PreviewCustomPoints_IsValid);
		ClearGenerateEQSActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGenerateEQSActors");
		ClearGenerateEQSActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGenerateEQSActors_FunctionAddress);
		ClearGenerateEQSActors_IsValid = ClearGenerateEQSActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:ClearGenerateEQSActors", ClearGenerateEQSActors_IsValid);
		PreviewRecordSpawnPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreviewRecordSpawnPoints");
		PreviewRecordSpawnPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(PreviewRecordSpawnPoints_FunctionAddress);
		PreviewRecordSpawnPoints_IsValid = PreviewRecordSpawnPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:PreviewRecordSpawnPoints", PreviewRecordSpawnPoints_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:BeginPlayCS", BeginPlayCS_IsValid);
		OnPostEditMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostEditMove");
		OnPostEditMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostEditMove_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPostEditMove_bFinish_PropertyAddress, OnPostEditMove_FunctionAddress, "bFinish");
		OnPostEditMove_bFinish_Offset = NativeReflection.GetPropertyOffset(OnPostEditMove_FunctionAddress, "bFinish");
		OnPostEditMove_bFinish_IsValid = NativeReflection.ValidatePropertyClass(OnPostEditMove_FunctionAddress, "bFinish", Classes.FBoolProperty);
		OnPostEditMove_IsValid = OnPostEditMove_FunctionAddress != IntPtr.Zero && OnPostEditMove_bFinish_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:OnPostEditMove", OnPostEditMove_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_EQSPointRecorderActor:ReceiveDestroyed", ReceiveDestroyed_IsValid);
	}

	static BGU_EQSPointRecorderActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_EQSPointRecorderActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_EQSPointRecorderActor));
	}
}
