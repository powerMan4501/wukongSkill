using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("播放分镜")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut")]
internal class BED_MovieNode_Cut : BED_MovieNode
{
	private static bool CutSequence_IsValid;

	private static int CutSequence_Offset;

	private static bool bUseCinematicCamera_IsValid;

	private static int bUseCinematicCamera_Offset;

	private static FFieldAddress bUseCinematicCamera_PropertyAddress;

	private static bool bUseRail_IsValid;

	private static int bUseRail_Offset;

	private static FFieldAddress bUseRail_PropertyAddress;

	private static bool bUseCrane_IsValid;

	private static int bUseCrane_Offset;

	private static FFieldAddress bUseCrane_PropertyAddress;

	private static bool CameraTag_IsValid;

	private static int CameraTag_Offset;

	private static bool RailTag_IsValid;

	private static int RailTag_Offset;

	private static bool CraneTag_IsValid;

	private static int CraneTag_Offset;

	private static bool InCameraBlendTime_IsValid;

	private static int InCameraBlendTime_Offset;

	private static bool InCameraBlendFunction_IsValid;

	private static int InCameraBlendFunction_Offset;

	private static FFieldAddress InCameraBlendFunction_PropertyAddress;

	private static bool InCameraBlendFactor_IsValid;

	private static int InCameraBlendFactor_Offset;

	private static bool bLoopPlay_IsValid;

	private static int bLoopPlay_Offset;

	private static FFieldAddress bLoopPlay_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:CutSequence")]
	public TSoftObject<ULevelSequence> CutSequence
	{
		get
		{
			CheckDestroyed();
			if (!CutSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:CutSequence");
				return default(TSoftObject<ULevelSequence>);
			}
			return TSoftObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(base.Address, CutSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CutSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:CutSequence");
			}
			else
			{
				TSoftObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(base.Address, CutSequence_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("使用电影级摄像机")]
	[UProperty]
	[Category("Movie")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:bUseCinematicCamera")]
	public bool bUseCinematicCamera
	{
		get
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bUseCinematicCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCinematicCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bUseCinematicCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用滑轨")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:bUseRail")]
	public bool bUseRail
	{
		get
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bUseRail");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bUseRail");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用起重机")]
	[UProperty]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:bUseCrane")]
	public bool bUseCrane
	{
		get
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bUseCrane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bUseCrane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("摄像机标记")]
	[Category("Movie")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:CameraTag")]
	public FName CameraTag
	{
		get
		{
			CheckDestroyed();
			if (!CameraTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:CameraTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CameraTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:CameraTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CameraTag_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("滑轨标记")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:RailTag")]
	public FName RailTag
	{
		get
		{
			CheckDestroyed();
			if (!RailTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:RailTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RailTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RailTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:RailTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RailTag_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("起重机标记")]
	[Category("Movie")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:CraneTag")]
	public FName CraneTag
	{
		get
		{
			CheckDestroyed();
			if (!CraneTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:CraneTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CraneTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CraneTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:CraneTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CraneTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend In时间")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendTime")]
	public float InCameraBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraBlendTime_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend In函数")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendFunction")]
	public EViewTargetBlendFunction InCameraBlendFunction
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, InCameraBlendFunction_Offset), 0, InCameraBlendFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendFunction");
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
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendFactor")]
	public float InCameraBlendFactor
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraBlendFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:InCameraBlendFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraBlendFactor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("是否循环播放")]
	[Category("Movie")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:bLoopPlay")]
	public bool bLoopPlay
	{
		get
		{
			CheckDestroyed();
			if (!bLoopPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bLoopPlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopPlay_Offset), 0, bLoopPlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Cut:bLoopPlay");
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
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		InCameraBlendTime = 2f;
		InCameraBlendFunction = EViewTargetBlendFunction.VTBlend_EaseInOut;
		InCameraBlendFactor = 1.5f;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.Cut;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_Cut:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (CutSequence.IsNull)
		{
			return "";
		}
		return CutSequence.AssetPathName;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_Cut
		{
			CutSequencePath = (CutSequence.IsNull ? "" : CutSequence.AssetPathName),
			CameraTag = CameraTag.PlainName,
			RailTag = RailTag.PlainName,
			CraneTag = CraneTag.PlainName,
			IsUseCinematicCamera = bUseCinematicCamera,
			IsUseRail = bUseRail,
			IsUseCrane = bUseCrane,
			CameraBlendTime = InCameraBlendTime,
			CameraBlendFunc = (int)InCameraBlendFunction,
			CameraBlendExp = InCameraBlendFactor,
			IsLoopPlay = bLoopPlay
		}.ToByteArray();
	}

	public override bool GetPreloadAssets(ref List<FSoftObjectPath> PreloadAssets)
	{
		if (PreloadAssets == null)
		{
			return false;
		}
		if (!CutSequence.IsNull)
		{
			FSoftObjectPath item = default(FSoftObjectPath);
			item.SetPath(CutSequence.AssetPathName);
			PreloadAssets.Add(item);
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_Cut:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_Cut bED_MovieNode_Cut = GCHelper.Find<b1.BED_MovieNode_Cut>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_Cut.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_Cut");
		CutSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "CutSequence");
		CutSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CutSequence", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref bUseCinematicCamera_PropertyAddress, intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCinematicCamera", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRail_PropertyAddress, intPtr, "bUseRail");
		bUseRail_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseRail");
		bUseRail_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseRail", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseCrane_PropertyAddress, intPtr, "bUseCrane");
		bUseCrane_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCrane");
		bUseCrane_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCrane", Classes.FBoolProperty);
		CameraTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraTag");
		CameraTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraTag", Classes.FNameProperty);
		RailTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "RailTag");
		RailTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RailTag", Classes.FNameProperty);
		CraneTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CraneTag");
		CraneTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CraneTag", Classes.FNameProperty);
		InCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendTime");
		InCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref InCameraBlendFunction_PropertyAddress, intPtr, "InCameraBlendFunction");
		InCameraBlendFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFunction");
		InCameraBlendFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFunction", Classes.FEnumProperty);
		InCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFactor");
		InCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFactor", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bLoopPlay_PropertyAddress, intPtr, "bLoopPlay");
		bLoopPlay_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoopPlay");
		bLoopPlay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoopPlay", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_Cut:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_Cut()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_Cut)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_Cut));
	}
}
