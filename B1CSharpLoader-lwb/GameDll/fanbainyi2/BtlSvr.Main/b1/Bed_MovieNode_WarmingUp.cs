using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("播放预热")]
[UClass]
[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp")]
internal class Bed_MovieNode_WarmingUp : BED_MovieNode
{
	private static bool StartSequences_IsValid;

	private static int StartSequences_Offset;

	private static FFieldAddress StartSequences_PropertyAddress;

	private TArrayReadWriteMarshaler<FLevelSequenceConfig> StartSequences_Marshaler;

	private static bool bUseMarkFrameLoop_IsValid;

	private static int bUseMarkFrameLoop_Offset;

	private static FFieldAddress bUseMarkFrameLoop_PropertyAddress;

	private static bool bUseCinematicCamera_IsValid;

	private static int bUseCinematicCamera_Offset;

	private static FFieldAddress bUseCinematicCamera_PropertyAddress;

	private static bool CameraBlendInTime_IsValid;

	private static int CameraBlendInTime_Offset;

	private static bool CameraBlendInFunction_IsValid;

	private static int CameraBlendInFunction_Offset;

	private static FFieldAddress CameraBlendInFunction_PropertyAddress;

	private static bool CameraBlendInFuncExp_IsValid;

	private static int CameraBlendInFuncExp_Offset;

	private static bool StreamingLevelNameList_IsValid;

	private static int StreamingLevelNameList_Offset;

	private static FFieldAddress StreamingLevelNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> StreamingLevelNameList_Marshaler;

	private static bool Performers_IsValid;

	private static int Performers_Offset;

	private static bool AssociationUnitInfoConfigId_IsValid;

	private static int AssociationUnitInfoConfigId_Offset;

	private static bool AssociationUnitSpawnInfoSpawnType_IsValid;

	private static int AssociationUnitSpawnInfoSpawnType_Offset;

	private static FFieldAddress AssociationUnitSpawnInfoSpawnType_PropertyAddress;

	private static bool bUseAsyncLoad_IsValid;

	private static int bUseAsyncLoad_Offset;

	private static FFieldAddress bUseAsyncLoad_PropertyAddress;

	[Category("Movie")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:StartSequences")]
	public TArrayReadWrite<FLevelSequenceConfig> StartSequences
	{
		get
		{
			CheckDestroyed();
			if (!StartSequences_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:StartSequences");
				return null;
			}
			if (StartSequences_Marshaler == null)
			{
				StartSequences_Marshaler = new TArrayReadWriteMarshaler<FLevelSequenceConfig>(1, StartSequences_PropertyAddress, CachedMarshalingDelegates<FLevelSequenceConfig, FLevelSequenceConfig>.FromNative, CachedMarshalingDelegates<FLevelSequenceConfig, FLevelSequenceConfig>.ToNative);
			}
			return StartSequences_Marshaler.FromNative(IntPtr.Add(base.Address, StartSequences_Offset));
		}
	}

	[EditAnywhere]
	[Tooltip("LoopStart - LoopEnd")]
	[BlueprintReadWrite]
	[Category("Movie")]
	[UProperty]
	[DisplayName("使用循环标记自动循环中间段")]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseMarkFrameLoop")]
	public bool bUseMarkFrameLoop
	{
		get
		{
			CheckDestroyed();
			if (!bUseMarkFrameLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseMarkFrameLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseMarkFrameLoop_Offset), 0, bUseMarkFrameLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseMarkFrameLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseMarkFrameLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseMarkFrameLoop_Offset), 0, bUseMarkFrameLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("使用电影摄像机")]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseCinematicCamera")]
	public bool bUseCinematicCamera
	{
		get
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseCinematicCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseCinematicCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("淡入时间")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInTime")]
	public float CameraBlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendInTime_Offset), value);
			}
		}
	}

	[DisplayName("淡入函数")]
	[UProperty]
	[EditAnywhere]
	[Category("Movie")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInFunction")]
	public EViewTargetBlendFunction CameraBlendInFunction
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, CameraBlendInFunction_Offset), 0, CameraBlendInFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInFunction");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, CameraBlendInFunction_Offset), 0, CameraBlendInFunction_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("淡入系数")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInFuncExp")]
	public float CameraBlendInFuncExp
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInFuncExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendInFuncExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:CameraBlendInFuncExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendInFuncExp_Offset), value);
			}
		}
	}

	[DisplayName("需要等待加载的地图列表")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:StreamingLevelNameList")]
	public TArrayReadWrite<FName> StreamingLevelNameList
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:StreamingLevelNameList");
				return null;
			}
			if (StreamingLevelNameList_Marshaler == null)
			{
				StreamingLevelNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, StreamingLevelNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return StreamingLevelNameList_Marshaler.FromNative(IntPtr.Add(base.Address, StreamingLevelNameList_Offset));
		}
	}

	[Category("Movie")]
	[DisplayName("需要等待加载的演员列表")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:Performers")]
	public FGameplayTagContainer Performers
	{
		get
		{
			CheckDestroyed();
			if (!Performers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:Performers");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, Performers_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:Performers");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, Performers_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("协战单位配置ID")]
	[EditAnywhere]
	[Category("Movie|Association")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:AssociationUnitInfoConfigId")]
	public int AssociationUnitInfoConfigId
	{
		get
		{
			CheckDestroyed();
			if (!AssociationUnitInfoConfigId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:AssociationUnitInfoConfigId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AssociationUnitInfoConfigId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AssociationUnitInfoConfigId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:AssociationUnitInfoConfigId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AssociationUnitInfoConfigId_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("协战单位刷新类型")]
	[Category("Movie|Association")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:AssociationUnitSpawnInfoSpawnType")]
	public EAssociationUnitSpawnType AssociationUnitSpawnInfoSpawnType
	{
		get
		{
			CheckDestroyed();
			if (!AssociationUnitSpawnInfoSpawnType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:AssociationUnitSpawnInfoSpawnType");
				return EAssociationUnitSpawnType.BySceneItem;
			}
			return EnumMarshaler<EAssociationUnitSpawnType>.FromNative(IntPtr.Add(base.Address, AssociationUnitSpawnInfoSpawnType_Offset), 0, AssociationUnitSpawnInfoSpawnType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AssociationUnitSpawnInfoSpawnType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:AssociationUnitSpawnInfoSpawnType");
			}
			else
			{
				EnumMarshaler<EAssociationUnitSpawnType>.ToNative(IntPtr.Add(base.Address, AssociationUnitSpawnInfoSpawnType_Offset), 0, AssociationUnitSpawnInfoSpawnType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("是否异步加载资源")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseAsyncLoad")]
	public bool bUseAsyncLoad
	{
		get
		{
			CheckDestroyed();
			if (!bUseAsyncLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseAsyncLoad");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseAsyncLoad_Offset), 0, bUseAsyncLoad_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseAsyncLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bed_MovieNode_WarmingUp:bUseAsyncLoad");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseAsyncLoad_Offset), 0, bUseAsyncLoad_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		bUseMarkFrameLoop = true;
		CameraBlendInFunction = EViewTargetBlendFunction.VTBlend_EaseInOut;
		CameraBlendInFuncExp = 1.5f;
		CameraBlendInTime = 1f;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.WarmingUp;
	}

	public override uint GetCustomDataVersion()
	{
		return 1u;
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_WarmingUpV1 movieCustom_WarmingUpV = new MovieCustom_WarmingUpV1();
		foreach (FLevelSequenceConfig startSequence in StartSequences)
		{
			RepeatedField<CalliopeCustom_LevelSequenceConfig> startSequences = movieCustom_WarmingUpV.StartSequences;
			CalliopeCustom_LevelSequenceConfig calliopeCustom_LevelSequenceConfig = new CalliopeCustom_LevelSequenceConfig();
			TSoftObject<ULevelSequence> sequence = startSequence.Sequence;
			calliopeCustom_LevelSequenceConfig.SequencePath = sequence.AssetPathName;
			CalliopeCustom_Transform obj = new CalliopeCustom_Transform
			{
				TransformX = startSequence.CameraStartTransform.Translation.X,
				TransformY = startSequence.CameraStartTransform.Translation.Y,
				TransformZ = startSequence.CameraStartTransform.Translation.Z
			};
			FTransform cameraStartTransform = startSequence.CameraStartTransform;
			obj.TransformPitch = cameraStartTransform.Rotator().Pitch;
			cameraStartTransform = startSequence.CameraStartTransform;
			obj.TransformYaw = cameraStartTransform.Rotator().Yaw;
			cameraStartTransform = startSequence.CameraStartTransform;
			obj.TransformRoll = cameraStartTransform.Rotator().Roll;
			obj.TransformSx = startSequence.CameraStartTransform.Scale3D.X;
			obj.TransformSy = startSequence.CameraStartTransform.Scale3D.Y;
			obj.TransformSz = startSequence.CameraStartTransform.Scale3D.Z;
			calliopeCustom_LevelSequenceConfig.CameraStartTransform = obj;
			FName cameraTag = startSequence.CameraTag;
			calliopeCustom_LevelSequenceConfig.CameraTag = cameraTag.ToString();
			cameraTag = startSequence.RailTag;
			calliopeCustom_LevelSequenceConfig.RailTag = cameraTag.ToString();
			cameraTag = startSequence.CraneTag;
			calliopeCustom_LevelSequenceConfig.CraneTag = cameraTag.ToString();
			startSequences.Add(calliopeCustom_LevelSequenceConfig);
		}
		movieCustom_WarmingUpV.IsUseCinematicCamera = bUseCinematicCamera;
		movieCustom_WarmingUpV.IsUseMarkFrameLoop = bUseMarkFrameLoop;
		movieCustom_WarmingUpV.CameraBlendInTime = CameraBlendInTime;
		movieCustom_WarmingUpV.CameraBlendInFunc = (byte)CameraBlendInFunction;
		movieCustom_WarmingUpV.CameraBlendInExp = CameraBlendInFuncExp;
		movieCustom_WarmingUpV.IsUseBlockLoad = !bUseAsyncLoad;
		foreach (FName streamingLevelName in StreamingLevelNameList)
		{
			movieCustom_WarmingUpV.StreamingLevelNameList.Add(streamingLevelName.ToString());
		}
		foreach (FGameplayTag gameplayTag in Performers.GameplayTags)
		{
			RepeatedField<string> performers = movieCustom_WarmingUpV.Performers;
			FName cameraTag = gameplayTag.TagName;
			performers.Add(cameraTag.ToString());
		}
		movieCustom_WarmingUpV.AssociationConfigId = AssociationUnitInfoConfigId;
		movieCustom_WarmingUpV.AssociationSpawnType = (int)AssociationUnitSpawnInfoSpawnType;
		return movieCustom_WarmingUpV.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.Bed_MovieNode_WarmingUp");
		NativeReflection.GetPropertyRef(ref StartSequences_PropertyAddress, unrealStruct, "StartSequences");
		StartSequences_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartSequences");
		StartSequences_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartSequences", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bUseMarkFrameLoop_PropertyAddress, unrealStruct, "bUseMarkFrameLoop");
		bUseMarkFrameLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseMarkFrameLoop");
		bUseMarkFrameLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseMarkFrameLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseCinematicCamera_PropertyAddress, unrealStruct, "bUseCinematicCamera");
		bUseCinematicCamera_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseCinematicCamera");
		bUseCinematicCamera_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseCinematicCamera", Classes.FBoolProperty);
		CameraBlendInTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendInTime");
		CameraBlendInTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendInTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CameraBlendInFunction_PropertyAddress, unrealStruct, "CameraBlendInFunction");
		CameraBlendInFunction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendInFunction");
		CameraBlendInFunction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendInFunction", Classes.FEnumProperty);
		CameraBlendInFuncExp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendInFuncExp");
		CameraBlendInFuncExp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendInFuncExp", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref StreamingLevelNameList_PropertyAddress, unrealStruct, "StreamingLevelNameList");
		StreamingLevelNameList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StreamingLevelNameList");
		StreamingLevelNameList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StreamingLevelNameList", Classes.FArrayProperty);
		Performers_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Performers");
		Performers_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Performers", Classes.FStructProperty);
		AssociationUnitInfoConfigId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AssociationUnitInfoConfigId");
		AssociationUnitInfoConfigId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AssociationUnitInfoConfigId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AssociationUnitSpawnInfoSpawnType_PropertyAddress, unrealStruct, "AssociationUnitSpawnInfoSpawnType");
		AssociationUnitSpawnInfoSpawnType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AssociationUnitSpawnInfoSpawnType");
		AssociationUnitSpawnInfoSpawnType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AssociationUnitSpawnInfoSpawnType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bUseAsyncLoad_PropertyAddress, unrealStruct, "bUseAsyncLoad");
		bUseAsyncLoad_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseAsyncLoad");
		bUseAsyncLoad_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseAsyncLoad", Classes.FBoolProperty);
	}

	static Bed_MovieNode_WarmingUp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Bed_MovieNode_WarmingUp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Bed_MovieNode_WarmingUp));
	}
}
