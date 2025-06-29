using System;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS AM Curve Move")]
[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove")]
internal class BANS_GSAMCurveMove : BANS_GSBase
{
	private static bool MoveCurveXAsix_IsValid;

	private static int MoveCurveXAsix_Offset;

	private static bool MoveCurveZAsix_IsValid;

	private static int MoveCurveZAsix_Offset;

	private static bool MoveCurveType_IsValid;

	private static int MoveCurveType_Offset;

	private static FFieldAddress MoveCurveType_PropertyAddress;

	private static bool bShouldClearVelocityOnEnd_IsValid;

	private static int bShouldClearVelocityOnEnd_Offset;

	private static FFieldAddress bShouldClearVelocityOnEnd_PropertyAddress;

	private static bool NotUseWhenHaveTarget_IsValid;

	private static int NotUseWhenHaveTarget_Offset;

	private static FFieldAddress NotUseWhenHaveTarget_PropertyAddress;

	private static bool UseBeHitDir_IsValid;

	private static int UseBeHitDir_Offset;

	private static FFieldAddress UseBeHitDir_PropertyAddress;

	private static bool UseAttractionDir_IsValid;

	private static int UseAttractionDir_Offset;

	private static FFieldAddress UseAttractionDir_PropertyAddress;

	private static bool UseForwarXDir_IsValid;

	private static int UseForwarXDir_Offset;

	private static FFieldAddress UseForwarXDir_PropertyAddress;

	private static bool UseTargetBaseDisScale_IsValid;

	private static int UseTargetBaseDisScale_Offset;

	private static FFieldAddress UseTargetBaseDisScale_PropertyAddress;

	private static bool TargetBaseDisScaleOffset_IsValid;

	private static int TargetBaseDisScaleOffset_Offset;

	private static bool bAutoResetMovementMode_IsValid;

	private static int bAutoResetMovementMode_Offset;

	private static FFieldAddress bAutoResetMovementMode_PropertyAddress;

	private static bool CliffFallCheckLength_IsValid;

	private static int CliffFallCheckLength_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveXAsix")]
	public UCurveFloat MoveCurveXAsix
	{
		get
		{
			CheckDestroyed();
			if (!MoveCurveXAsix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveXAsix");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, MoveCurveXAsix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveCurveXAsix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveXAsix");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, MoveCurveXAsix_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveZAsix")]
	public UCurveFloat MoveCurveZAsix
	{
		get
		{
			CheckDestroyed();
			if (!MoveCurveZAsix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveZAsix");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, MoveCurveZAsix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveCurveZAsix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveZAsix");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, MoveCurveZAsix_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveType")]
	public EBGUMoveCurveType MoveCurveType
	{
		get
		{
			CheckDestroyed();
			if (!MoveCurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveType");
				return EBGUMoveCurveType.None;
			}
			return EnumMarshaler<EBGUMoveCurveType>.FromNative(IntPtr.Add(base.Address, MoveCurveType_Offset), 0, MoveCurveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveCurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:MoveCurveType");
			}
			else
			{
				EnumMarshaler<EBGUMoveCurveType>.ToNative(IntPtr.Add(base.Address, MoveCurveType_Offset), 0, MoveCurveType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("是否在曲线播放完成后速度清零")]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:bShouldClearVelocityOnEnd")]
	public bool bShouldClearVelocityOnEnd
	{
		get
		{
			CheckDestroyed();
			if (!bShouldClearVelocityOnEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:bShouldClearVelocityOnEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShouldClearVelocityOnEnd_Offset), 0, bShouldClearVelocityOnEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShouldClearVelocityOnEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:bShouldClearVelocityOnEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShouldClearVelocityOnEnd_Offset), 0, bShouldClearVelocityOnEnd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("有目标时不使用曲线移动")]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:NotUseWhenHaveTarget")]
	public bool NotUseWhenHaveTarget
	{
		get
		{
			CheckDestroyed();
			if (!NotUseWhenHaveTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:NotUseWhenHaveTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotUseWhenHaveTarget_Offset), 0, NotUseWhenHaveTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotUseWhenHaveTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:NotUseWhenHaveTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotUseWhenHaveTarget_Offset), 0, NotUseWhenHaveTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:UseBeHitDir")]
	public bool UseBeHitDir
	{
		get
		{
			CheckDestroyed();
			if (!UseBeHitDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseBeHitDir");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseBeHitDir_Offset), 0, UseBeHitDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseBeHitDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseBeHitDir");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseBeHitDir_Offset), 0, UseBeHitDir_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!UseBeHitDir")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:UseAttractionDir")]
	public bool UseAttractionDir
	{
		get
		{
			CheckDestroyed();
			if (!UseAttractionDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseAttractionDir");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAttractionDir_Offset), 0, UseAttractionDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAttractionDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseAttractionDir");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAttractionDir_Offset), 0, UseAttractionDir_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!UseBeHitDir")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:UseForwarXDir")]
	public bool UseForwarXDir
	{
		get
		{
			CheckDestroyed();
			if (!UseForwarXDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseForwarXDir");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseForwarXDir_Offset), 0, UseForwarXDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseForwarXDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseForwarXDir");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseForwarXDir_Offset), 0, UseForwarXDir_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!UseBeHitDir")]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:UseTargetBaseDisScale")]
	public bool UseTargetBaseDisScale
	{
		get
		{
			CheckDestroyed();
			if (!UseTargetBaseDisScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseTargetBaseDisScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseTargetBaseDisScale_Offset), 0, UseTargetBaseDisScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseTargetBaseDisScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:UseTargetBaseDisScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseTargetBaseDisScale_Offset), 0, UseTargetBaseDisScale_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!UseBeHitDir && UseTargetBaseDisScale")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:TargetBaseDisScaleOffset")]
	public float TargetBaseDisScaleOffset
	{
		get
		{
			CheckDestroyed();
			if (!TargetBaseDisScaleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:TargetBaseDisScaleOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TargetBaseDisScaleOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBaseDisScaleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:TargetBaseDisScaleOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TargetBaseDisScaleOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("是否在Z轴位移曲线播放完成后自动切换回Walking MovementMode")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:bAutoResetMovementMode")]
	public bool bAutoResetMovementMode
	{
		get
		{
			CheckDestroyed();
			if (!bAutoResetMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:bAutoResetMovementMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoResetMovementMode_Offset), 0, bAutoResetMovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoResetMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:bAutoResetMovementMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoResetMovementMode_Offset), 0, bAutoResetMovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("填0则不进行预测，因为比较特殊，填了就会无视受击等级开启悬崖空气墙预测")]
	[DisplayName("悬崖击坠位移预判距离")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:CliffFallCheckLength")]
	public float CliffFallCheckLength
	{
		get
		{
			CheckDestroyed();
			if (!CliffFallCheckLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:CliffFallCheckLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CliffFallCheckLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CliffFallCheckLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAMCurveMove:CliffFallCheckLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CliffFallCheckLength_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.AMCurveMove;
		MoveCurveType = EBGUMoveCurveType.DistanceCurve;
		bShouldClearVelocityOnEnd = false;
		UseBeHitDir = false;
		UseForwarXDir = false;
		UseTargetBaseDisScale = false;
		NotUseWhenHaveTarget = false;
		TargetBaseDisScaleOffset = 0f;
		bAutoResetMovementMode = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			bool flag = true;
			if (NotUseWhenHaveTarget && BGUFunctionLibraryCS.BGUGetTargetInfo(bGUCharacterCS).LockTargetEntity != Entity.Null)
			{
				flag = false;
			}
			if (flag)
			{
				FVector curveMoveDirInfo = CalcMoveDirInfo(bGUCharacterCS);
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetCurveMoveBeHitInfo.Invoke(UseBeHitDir, UseAttractionDir);
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetCurveMoveScaleInfo.Invoke(UseTargetBaseDisScale, TargetBaseDisScaleOffset, UseAttractionDir);
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetCurveMoveInfo.Invoke(MoveCurveXAsix, MoveCurveZAsix, MoveCurveType, curveMoveDirInfo, TotalDuration, bAutoResetMovementMode, EnableCurveMove: true, bShouldClearVelocityOnEnd);
			}
		}
	}

	private FVector CalcMoveDirInfo(BGUCharacterCS BGUCharacter)
	{
		float num = 0f;
		float num2 = 0f;
		if (MoveCurveXAsix != null)
		{
			num = (UseForwarXDir ? 1 : (-1));
		}
		if (MoveCurveZAsix != null)
		{
			num2 = 1f;
		}
		return new FVector(num, 0.0, num2);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAMCurveMove:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_OnSetCurveMoveEnd.Invoke();
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAMCurveMove:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAMCurveMove bANS_GSAMCurveMove = GCHelper.Find<b1.BANS_GSAMCurveMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAMCurveMove.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAMCurveMove:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAMCurveMove bANS_GSAMCurveMove = GCHelper.Find<b1.BANS_GSAMCurveMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAMCurveMove.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAMCurveMove");
		MoveCurveXAsix_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveCurveXAsix");
		MoveCurveXAsix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveCurveXAsix", Classes.FObjectProperty);
		MoveCurveZAsix_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveCurveZAsix");
		MoveCurveZAsix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveCurveZAsix", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MoveCurveType_PropertyAddress, intPtr, "MoveCurveType");
		MoveCurveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveCurveType");
		MoveCurveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveCurveType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bShouldClearVelocityOnEnd_PropertyAddress, intPtr, "bShouldClearVelocityOnEnd");
		bShouldClearVelocityOnEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShouldClearVelocityOnEnd");
		bShouldClearVelocityOnEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShouldClearVelocityOnEnd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NotUseWhenHaveTarget_PropertyAddress, intPtr, "NotUseWhenHaveTarget");
		NotUseWhenHaveTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotUseWhenHaveTarget");
		NotUseWhenHaveTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotUseWhenHaveTarget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseBeHitDir_PropertyAddress, intPtr, "UseBeHitDir");
		UseBeHitDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseBeHitDir");
		UseBeHitDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseBeHitDir", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseAttractionDir_PropertyAddress, intPtr, "UseAttractionDir");
		UseAttractionDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseAttractionDir");
		UseAttractionDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseAttractionDir", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseForwarXDir_PropertyAddress, intPtr, "UseForwarXDir");
		UseForwarXDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseForwarXDir");
		UseForwarXDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseForwarXDir", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseTargetBaseDisScale_PropertyAddress, intPtr, "UseTargetBaseDisScale");
		UseTargetBaseDisScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseTargetBaseDisScale");
		UseTargetBaseDisScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseTargetBaseDisScale", Classes.FBoolProperty);
		TargetBaseDisScaleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetBaseDisScaleOffset");
		TargetBaseDisScaleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetBaseDisScaleOffset", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bAutoResetMovementMode_PropertyAddress, intPtr, "bAutoResetMovementMode");
		bAutoResetMovementMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAutoResetMovementMode");
		bAutoResetMovementMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAutoResetMovementMode", Classes.FBoolProperty);
		CliffFallCheckLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "CliffFallCheckLength");
		CliffFallCheckLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CliffFallCheckLength", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAMCurveMove:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAMCurveMove:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAMCurveMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAMCurveMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAMCurveMove));
	}
}
