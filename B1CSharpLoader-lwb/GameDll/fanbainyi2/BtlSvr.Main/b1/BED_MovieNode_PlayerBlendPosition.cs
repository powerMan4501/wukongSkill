using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("主角：初始位置对位")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition")]
internal class BED_MovieNode_PlayerBlendPosition : BED_MovieNode
{
	private static bool AlternativeTransforms_IsValid;

	private static int AlternativeTransforms_Offset;

	private static FFieldAddress AlternativeTransforms_PropertyAddress;

	private TArrayReadWriteMarshaler<FTransform> AlternativeTransforms_Marshaler;

	private static bool BlendMaxTime_IsValid;

	private static int BlendMaxTime_Offset;

	private static bool BlendPositionAcceptRadius_IsValid;

	private static int BlendPositionAcceptRadius_Offset;

	private static bool MoveSpeedType_IsValid;

	private static int MoveSpeedType_Offset;

	private static FFieldAddress MoveSpeedType_PropertyAddress;

	private static bool BlendPositionInterpTime_IsValid;

	private static int BlendPositionInterpTime_Offset;

	private static bool TeleportDistance_IsValid;

	private static int TeleportDistance_Offset;

	[UProperty]
	[DisplayName("可选对位点")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:AlternativeTransforms")]
	public TArrayReadWrite<FTransform> AlternativeTransforms
	{
		get
		{
			CheckDestroyed();
			if (!AlternativeTransforms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:AlternativeTransforms");
				return null;
			}
			if (AlternativeTransforms_Marshaler == null)
			{
				AlternativeTransforms_Marshaler = new TArrayReadWriteMarshaler<FTransform>(1, AlternativeTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative);
			}
			return AlternativeTransforms_Marshaler.FromNative(IntPtr.Add(base.Address, AlternativeTransforms_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("最大对位时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendMaxTime")]
	public float BlendMaxTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendMaxTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendMaxTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendMaxTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendMaxTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendMaxTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendMaxTime_Offset), value);
			}
		}
	}

	[DisplayName("可接受的对位结果范围")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendPositionAcceptRadius")]
	public float BlendPositionAcceptRadius
	{
		get
		{
			CheckDestroyed();
			if (!BlendPositionAcceptRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendPositionAcceptRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendPositionAcceptRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendPositionAcceptRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendPositionAcceptRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendPositionAcceptRadius_Offset), value);
			}
		}
	}

	[DisplayName("对位移动速度档位")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:MoveSpeedType")]
	public EAIMoveSpeedType MoveSpeedType
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:MoveSpeedType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, MoveSpeedType_Offset), 0, MoveSpeedType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:MoveSpeedType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, MoveSpeedType_Offset), 0, MoveSpeedType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Movie")]
	[DisplayName("对位插值移动时间")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendPositionInterpTime")]
	public float BlendPositionInterpTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendPositionInterpTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendPositionInterpTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendPositionInterpTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendPositionInterpTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:BlendPositionInterpTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendPositionInterpTime_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("瞬移距离阈值")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:TeleportDistance")]
	public float TeleportDistance
	{
		get
		{
			CheckDestroyed();
			if (!TeleportDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:TeleportDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TeleportDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition:TeleportDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TeleportDistance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PlayerBlendPosition;
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_PlayerBlendPosition movieCustom_PlayerBlendPosition = new MovieCustom_PlayerBlendPosition();
		foreach (FTransform alternativeTransform in AlternativeTransforms)
		{
			RepeatedField<CalliopeCustom_Transform> alternativeTransforms = movieCustom_PlayerBlendPosition.AlternativeTransforms;
			CalliopeCustom_Transform calliopeCustom_Transform = new CalliopeCustom_Transform();
			FVector translation = alternativeTransform.Translation;
			calliopeCustom_Transform.TransformX = translation.X;
			translation = alternativeTransform.Translation;
			calliopeCustom_Transform.TransformY = translation.Y;
			translation = alternativeTransform.Translation;
			calliopeCustom_Transform.TransformZ = translation.Z;
			calliopeCustom_Transform.TransformPitch = alternativeTransform.Rotator().Pitch;
			calliopeCustom_Transform.TransformYaw = alternativeTransform.Rotator().Yaw;
			calliopeCustom_Transform.TransformRoll = alternativeTransform.Rotator().Roll;
			translation = alternativeTransform.Scale3D;
			calliopeCustom_Transform.TransformSx = translation.X;
			translation = alternativeTransform.Scale3D;
			calliopeCustom_Transform.TransformSy = translation.Y;
			translation = alternativeTransform.Scale3D;
			calliopeCustom_Transform.TransformSz = translation.Z;
			alternativeTransforms.Add(calliopeCustom_Transform);
		}
		movieCustom_PlayerBlendPosition.BlendMaxTime = BlendMaxTime;
		movieCustom_PlayerBlendPosition.BlendPositionAcceptRadius = BlendPositionAcceptRadius;
		movieCustom_PlayerBlendPosition.MoveSpeedType = (int)MoveSpeedType;
		movieCustom_PlayerBlendPosition.BlendPositionInterpTime = BlendPositionInterpTime;
		movieCustom_PlayerBlendPosition.TeleportDistance = TeleportDistance;
		return movieCustom_PlayerBlendPosition.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PlayerBlendPosition");
		NativeReflection.GetPropertyRef(ref AlternativeTransforms_PropertyAddress, unrealStruct, "AlternativeTransforms");
		AlternativeTransforms_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AlternativeTransforms");
		AlternativeTransforms_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AlternativeTransforms", Classes.FArrayProperty);
		BlendMaxTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendMaxTime");
		BlendMaxTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendMaxTime", Classes.FFloatProperty);
		BlendPositionAcceptRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendPositionAcceptRadius");
		BlendPositionAcceptRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendPositionAcceptRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveSpeedType_PropertyAddress, unrealStruct, "MoveSpeedType");
		MoveSpeedType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSpeedType");
		MoveSpeedType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSpeedType", Classes.FEnumProperty);
		BlendPositionInterpTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendPositionInterpTime");
		BlendPositionInterpTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendPositionInterpTime", Classes.FFloatProperty);
		TeleportDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TeleportDistance");
		TeleportDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TeleportDistance", Classes.FFloatProperty);
	}

	static BED_MovieNode_PlayerBlendPosition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PlayerBlendPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PlayerBlendPosition));
	}
}
