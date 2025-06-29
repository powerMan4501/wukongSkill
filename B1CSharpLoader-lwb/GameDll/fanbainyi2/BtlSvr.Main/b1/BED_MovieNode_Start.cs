using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("开始播放")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_Start")]
internal class BED_MovieNode_Start : b1.BED_MovieNode_Event
{
	private static bool StartSequences_IsValid;

	private static int StartSequences_Offset;

	private static FFieldAddress StartSequences_PropertyAddress;

	private TArrayReadWriteMarshaler<FLevelSequenceConfig> StartSequences_Marshaler;

	private static bool StartTimeSeconds_IsValid;

	private static int StartTimeSeconds_Offset;

	private static bool bUseCinematicCamera_IsValid;

	private static int bUseCinematicCamera_Offset;

	private static FFieldAddress bUseCinematicCamera_PropertyAddress;

	private static bool bUseRail_IsValid;

	private static int bUseRail_Offset;

	private static FFieldAddress bUseRail_PropertyAddress;

	private static bool bUseCrane_IsValid;

	private static int bUseCrane_Offset;

	private static FFieldAddress bUseCrane_PropertyAddress;

	private static bool CameraBlendInTime_IsValid;

	private static int CameraBlendInTime_Offset;

	private static bool CameraBlendInFunction_IsValid;

	private static int CameraBlendInFunction_Offset;

	private static FFieldAddress CameraBlendInFunction_PropertyAddress;

	private static bool CameraBlendInFuncExp_IsValid;

	private static int CameraBlendInFuncExp_Offset;

	private static bool bLoopPlay_IsValid;

	private static int bLoopPlay_Offset;

	private static FFieldAddress bLoopPlay_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:StartSequences")]
	public TArrayReadWrite<FLevelSequenceConfig> StartSequences
	{
		get
		{
			CheckDestroyed();
			if (!StartSequences_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:StartSequences");
				return null;
			}
			if (StartSequences_Marshaler == null)
			{
				StartSequences_Marshaler = new TArrayReadWriteMarshaler<FLevelSequenceConfig>(1, StartSequences_PropertyAddress, CachedMarshalingDelegates<FLevelSequenceConfig, FLevelSequenceConfig>.FromNative, CachedMarshalingDelegates<FLevelSequenceConfig, FLevelSequenceConfig>.ToNative);
			}
			return StartSequences_Marshaler.FromNative(IntPtr.Add(base.Address, StartSequences_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:StartTimeSeconds")]
	public float StartTimeSeconds
	{
		get
		{
			CheckDestroyed();
			if (!StartTimeSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:StartTimeSeconds");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartTimeSeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartTimeSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:StartTimeSeconds");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartTimeSeconds_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用电影摄像机")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:bUseCinematicCamera")]
	public bool bUseCinematicCamera
	{
		get
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bUseCinematicCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bUseCinematicCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("使用滑轨")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:bUseRail")]
	public bool bUseRail
	{
		get
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bUseRail");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bUseRail");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("使用起重机")]
	[Category("Movie")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:bUseCrane")]
	public bool bUseCrane
	{
		get
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bUseCrane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bUseCrane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("淡入时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInTime")]
	public float CameraBlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendInTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Movie")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("淡入函数")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInFunction")]
	public EViewTargetBlendFunction CameraBlendInFunction
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, CameraBlendInFunction_Offset), 0, CameraBlendInFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInFunction");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, CameraBlendInFunction_Offset), 0, CameraBlendInFunction_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Movie")]
	[DisplayName("淡入系数")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInFuncExp")]
	public float CameraBlendInFuncExp
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInFuncExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendInFuncExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:CameraBlendInFuncExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendInFuncExp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否循环播放")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:bLoopPlay")]
	public bool bLoopPlay
	{
		get
		{
			CheckDestroyed();
			if (!bLoopPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bLoopPlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopPlay_Offset), 0, bLoopPlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Start:bLoopPlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoopPlay_Offset), 0, bLoopPlay_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		CameraBlendInTime = 2f;
		CameraBlendInFunction = EViewTargetBlendFunction.VTBlend_EaseInOut;
		CameraBlendInFuncExp = 1.5f;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.Start;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_Start:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"起始Sequence:从第{StartTimeSeconds}秒开始播放");
		foreach (FLevelSequenceConfig startSequence in StartSequences)
		{
			TSoftObject<ULevelSequence> sequence = startSequence.Sequence;
			stringBuilder.Append("\n" + sequence.AssetPathName.Split('.').Last());
		}
		stringBuilder.AppendLine(bLoopPlay ? "循环播放" : "");
		stringBuilder.Append($"Camera: BlendInTime: {CameraBlendInTime}  Exp: {CameraBlendInFuncExp}");
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_Start movieCustom_Start = new MovieCustom_Start();
		foreach (FLevelSequenceConfig startSequence in StartSequences)
		{
			RepeatedField<CalliopeCustom_LevelSequenceConfig> startSequences = movieCustom_Start.StartSequences;
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
		movieCustom_Start.IsUseCinematicCamera = bUseCinematicCamera;
		movieCustom_Start.IsUseRail = bUseRail;
		movieCustom_Start.IsUseCrane = bUseCrane;
		movieCustom_Start.StartTimeSeconds = StartTimeSeconds;
		movieCustom_Start.CameraBlendInTime = CameraBlendInTime;
		movieCustom_Start.CameraBlendInFunc = (byte)CameraBlendInFunction;
		movieCustom_Start.CameraBlendInExp = CameraBlendInFuncExp;
		movieCustom_Start.IsLoopPlay = bLoopPlay;
		return movieCustom_Start.ToByteArray();
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		if (StartSequences.Count == 0)
		{
			OutErrorMessage = "播放开始节点配置错误，至少配置一个Sequence！";
			return false;
		}
		foreach (FLevelSequenceConfig startSequence in StartSequences)
		{
			if (startSequence.Sequence.IsNull)
			{
				OutErrorMessage = "播放开始节点配置错误，Sequence不能为空！";
				return false;
			}
		}
		return base.CorrectnessCheck(out OutErrorMessage);
	}

	public override bool GetPreloadAssets(ref List<FSoftObjectPath> PreloadAssets)
	{
		if (PreloadAssets == null)
		{
			return false;
		}
		foreach (FLevelSequenceConfig startSequence in StartSequences)
		{
			TSoftObject<ULevelSequence> sequence = startSequence.Sequence;
			if (!sequence.IsNull)
			{
				FSoftObjectPath item = default(FSoftObjectPath);
				sequence = startSequence.Sequence;
				item.SetPath(sequence.AssetPathName);
				PreloadAssets.Add(item);
			}
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_Start:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_Start bED_MovieNode_Start = GCHelper.Find<b1.BED_MovieNode_Start>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_Start.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_Start");
		NativeReflection.GetPropertyRef(ref StartSequences_PropertyAddress, intPtr, "StartSequences");
		StartSequences_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartSequences");
		StartSequences_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartSequences", Classes.FArrayProperty);
		StartTimeSeconds_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartTimeSeconds");
		StartTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartTimeSeconds", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bUseCinematicCamera_PropertyAddress, intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCinematicCamera", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRail_PropertyAddress, intPtr, "bUseRail");
		bUseRail_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseRail");
		bUseRail_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseRail", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseCrane_PropertyAddress, intPtr, "bUseCrane");
		bUseCrane_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCrane");
		bUseCrane_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCrane", Classes.FBoolProperty);
		CameraBlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendInTime");
		CameraBlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendInTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CameraBlendInFunction_PropertyAddress, intPtr, "CameraBlendInFunction");
		CameraBlendInFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendInFunction");
		CameraBlendInFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendInFunction", Classes.FEnumProperty);
		CameraBlendInFuncExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendInFuncExp");
		CameraBlendInFuncExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendInFuncExp", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bLoopPlay_PropertyAddress, intPtr, "bLoopPlay");
		bLoopPlay_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoopPlay");
		bLoopPlay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoopPlay", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_Start:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_Start));
	}
}
