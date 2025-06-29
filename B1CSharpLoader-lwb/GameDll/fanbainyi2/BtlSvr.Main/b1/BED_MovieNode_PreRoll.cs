using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("播放前摇")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll")]
internal class BED_MovieNode_PreRoll : b1.BED_MovieNode_Event
{
	private static bool PreRollSequence_IsValid;

	private static int PreRollSequence_Offset;

	private static bool bUseCinematicCamera_IsValid;

	private static int bUseCinematicCamera_Offset;

	private static FFieldAddress bUseCinematicCamera_PropertyAddress;

	private static bool CameraTag_IsValid;

	private static int CameraTag_Offset;

	private static bool InCameraBlendTime_IsValid;

	private static int InCameraBlendTime_Offset;

	private static bool InCameraBlendFunction_IsValid;

	private static int InCameraBlendFunction_Offset;

	private static FFieldAddress InCameraBlendFunction_PropertyAddress;

	private static bool InCameraBlendFactor_IsValid;

	private static int InCameraBlendFactor_Offset;

	private static bool bStopSequenceWhenFinish_IsValid;

	private static int bStopSequenceWhenFinish_Offset;

	private static FFieldAddress bStopSequenceWhenFinish_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:PreRollSequence")]
	public TSoftObject<ULevelSequence> PreRollSequence
	{
		get
		{
			CheckDestroyed();
			if (!PreRollSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:PreRollSequence");
				return default(TSoftObject<ULevelSequence>);
			}
			return TSoftObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(base.Address, PreRollSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreRollSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:PreRollSequence");
			}
			else
			{
				TSoftObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(base.Address, PreRollSequence_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[UProperty]
	[DisplayName("使用电影级摄像机")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:bUseCinematicCamera")]
	public bool bUseCinematicCamera
	{
		get
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:bUseCinematicCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:bUseCinematicCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Movie")]
	[DisplayName("摄像机标记")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:CameraTag")]
	public FName CameraTag
	{
		get
		{
			CheckDestroyed();
			if (!CameraTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:CameraTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CameraTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:CameraTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CameraTag_Offset), value);
			}
		}
	}

	[DisplayName("Blend In时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendTime")]
	public float InCameraBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraBlendTime_Offset), value);
			}
		}
	}

	[DisplayName("Blend In函数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Movie")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendFunction")]
	public EViewTargetBlendFunction InCameraBlendFunction
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, InCameraBlendFunction_Offset), 0, InCameraBlendFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendFunction");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, InCameraBlendFunction_Offset), 0, InCameraBlendFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend In加速系数")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendFactor")]
	public float InCameraBlendFactor
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraBlendFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:InCameraBlendFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraBlendFactor_Offset), value);
			}
		}
	}

	[DisplayName("A到B对位结束后，是否主动结束seq")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Movie")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:bStopSequenceWhenFinish")]
	public bool bStopSequenceWhenFinish
	{
		get
		{
			CheckDestroyed();
			if (!bStopSequenceWhenFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:bStopSequenceWhenFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopSequenceWhenFinish_Offset), 0, bStopSequenceWhenFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopSequenceWhenFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PreRoll:bStopSequenceWhenFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopSequenceWhenFinish_Offset), 0, bStopSequenceWhenFinish_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Phase");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		InCameraBlendTime = 2f;
		InCameraBlendFunction = EViewTargetBlendFunction.VTBlend_EaseInOut;
		InCameraBlendFactor = 1.5f;
		bStopSequenceWhenFinish = true;
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PreRoll;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PreRoll:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (PreRollSequence.IsNull)
		{
			return "";
		}
		return PreRollSequence.AssetPathName;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PreRoll
		{
			PreRollSequencePath = (PreRollSequence.IsNull ? "" : PreRollSequence.AssetPathName),
			CameraTag = CameraTag.PlainName,
			IsUseCinematicCamera = bUseCinematicCamera,
			CameraBlendTime = InCameraBlendTime,
			CameraBlendFunc = (int)InCameraBlendFunction,
			CameraBlendExp = InCameraBlendFactor,
			IsStopPreRollWhenFinish = bStopSequenceWhenFinish
		}.ToByteArray();
	}

	public override bool GetPreloadAssets(ref List<FSoftObjectPath> PreloadAssets)
	{
		if (PreloadAssets == null)
		{
			return false;
		}
		if (!PreRollSequence.IsNull)
		{
			FSoftObjectPath item = default(FSoftObjectPath);
			item.SetPath(PreRollSequence.AssetPathName);
			PreloadAssets.Add(item);
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PreRoll:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PreRoll bED_MovieNode_PreRoll = GCHelper.Find<b1.BED_MovieNode_PreRoll>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PreRoll.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PreRoll");
		PreRollSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreRollSequence");
		PreRollSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreRollSequence", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref bUseCinematicCamera_PropertyAddress, intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCinematicCamera", Classes.FBoolProperty);
		CameraTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraTag");
		CameraTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraTag", Classes.FNameProperty);
		InCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendTime");
		InCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref InCameraBlendFunction_PropertyAddress, intPtr, "InCameraBlendFunction");
		InCameraBlendFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFunction");
		InCameraBlendFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFunction", Classes.FEnumProperty);
		InCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFactor");
		InCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFactor", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bStopSequenceWhenFinish_PropertyAddress, intPtr, "bStopSequenceWhenFinish");
		bStopSequenceWhenFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStopSequenceWhenFinish");
		bStopSequenceWhenFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStopSequenceWhenFinish", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PreRoll:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PreRoll()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PreRoll)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PreRoll));
	}
}
