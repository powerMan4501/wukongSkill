using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Move To SceneItem")]
[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem")]
internal class BANS_GSMoveToSceneItem : BANS_GSBase
{
	private static bool NoteString1_IsValid;

	private static int NoteString1_Offset;

	private static bool IsTeleport_IsValid;

	private static int IsTeleport_Offset;

	private static FFieldAddress IsTeleport_PropertyAddress;

	private static bool CalibrationTrans_IsValid;

	private static int CalibrationTrans_Offset;

	private static FFieldAddress CalibrationTrans_PropertyAddress;

	private static bool bResetSceneItemOnFinish_IsValid;

	private static int bResetSceneItemOnFinish_Offset;

	private static FFieldAddress bResetSceneItemOnFinish_PropertyAddress;

	private static bool ScaleXAxisOnly_IsValid;

	private static int ScaleXAxisOnly_Offset;

	private static FFieldAddress ScaleXAxisOnly_PropertyAddress;

	private static bool EnableDebugMode_IsValid;

	private static int EnableDebugMode_Offset;

	private static FFieldAddress EnableDebugMode_PropertyAddress;

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

	[BlueprintReadOnly]
	[DisplayName("本质上是RootMotion缩放，所以需要动画本身带RootMotion，不是真的Move")]
	[UProperty]
	[Category("Note")]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:NoteString1")]
	public byte NoteString1
	{
		get
		{
			CheckDestroyed();
			if (!NoteString1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:NoteString1");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, NoteString1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoteString1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:NoteString1");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, NoteString1_Offset), value);
			}
		}
	}

	[DisplayName("是否直接传送")]
	[Tooltip("NotifyBegin的时候不触发，NotifyEnd时候触发")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:IsTeleport")]
	public bool IsTeleport
	{
		get
		{
			CheckDestroyed();
			if (!IsTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:IsTeleport");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTeleport_Offset), 0, IsTeleport_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:IsTeleport");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTeleport_Offset), 0, IsTeleport_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("移动完成后，是否强制矫正位置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:CalibrationTrans")]
	public bool CalibrationTrans
	{
		get
		{
			CheckDestroyed();
			if (!CalibrationTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:CalibrationTrans");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CalibrationTrans_Offset), 0, CalibrationTrans_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CalibrationTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:CalibrationTrans");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CalibrationTrans_Offset), 0, CalibrationTrans_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移动完成后，是否清空SceneItem缓存")]
	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:bResetSceneItemOnFinish")]
	public bool bResetSceneItemOnFinish
	{
		get
		{
			CheckDestroyed();
			if (!bResetSceneItemOnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:bResetSceneItemOnFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bResetSceneItemOnFinish_Offset), 0, bResetSceneItemOnFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bResetSceneItemOnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:bResetSceneItemOnFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bResetSceneItemOnFinish_Offset), 0, bResetSceneItemOnFinish_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("只缩放X轴")]
	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:ScaleXAxisOnly")]
	public bool ScaleXAxisOnly
	{
		get
		{
			CheckDestroyed();
			if (!ScaleXAxisOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:ScaleXAxisOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ScaleXAxisOnly_Offset), 0, ScaleXAxisOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleXAxisOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:ScaleXAxisOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ScaleXAxisOnly_Offset), 0, ScaleXAxisOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("启用DebugMode")]
	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:EnableDebugMode")]
	public bool EnableDebugMode
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebugMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:EnableDebugMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebugMode_Offset), 0, EnableDebugMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebugMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMoveToSceneItem:EnableDebugMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebugMode_Offset), 0, EnableDebugMode_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		IsTeleport = true;
		CalibrationTrans = true;
		ScaleXAxisOnly = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
			if (bGUCharacterCS != null && !IsTeleport)
			{
				MoveLogic(bGUCharacterCS, NotifyParam.NotifyBeginTime, NotifyParam.NotifyEndTime);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMoveToSceneItem:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (bResetSceneItemOnFinish)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_RemoveCatchedSceneItemAndReset.Invoke();
			}
			if (IsTeleport || CalibrationTrans)
			{
				TeleportLogic(bGUCharacterCS);
			}
		}
	}

	private void MoveLogic(BGUCharacterCS CharacterCS, float LeftTime, float RightTime)
	{
		BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(CharacterCS);
		if (readOnlyData != null && readOnlyData.SceneItemCatch != null && BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(readOnlyData.SceneItemCatch) != null)
		{
			float totalDuration = RightTime - LeftTime;
			BUS_EventCollectionCS.Get(CharacterCS).Evt_SetAMScaleRateByPosMultiCast.Invoke(EAMScaleType.ScaleForSceneItem, EAMScaleRateAxis.AxisX, 0f, 0f, 0, AttackRangeLimit: false, EnableDebugMode, totalDuration, LeftTime, RightTime);
		}
	}

	private void TeleportLogic(BGUCharacterCS CharacterCS)
	{
		BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(CharacterCS);
		if (readOnlyData != null && readOnlyData.SceneItemCatch != null && BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(readOnlyData.SceneItemCatch) != null)
		{
			FTransform p = BGUFuncLibActorTransformCS.BGUGetActorTransform(readOnlyData.SceneItemCatch);
			BUS_EventCollectionCS.Get(CharacterCS).Evt_TeleportMoveByTrans.Invoke(p);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMoveToSceneItem:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMoveToSceneItem bANS_GSMoveToSceneItem = GCHelper.Find<b1.BANS_GSMoveToSceneItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSMoveToSceneItem.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMoveToSceneItem:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMoveToSceneItem bANS_GSMoveToSceneItem = GCHelper.Find<b1.BANS_GSMoveToSceneItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSMoveToSceneItem.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSMoveToSceneItem");
		NoteString1_Offset = NativeReflection.GetPropertyOffset(intPtr, "NoteString1");
		NoteString1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NoteString1", Classes.FByteProperty);
		NativeReflection.GetPropertyRef(ref IsTeleport_PropertyAddress, intPtr, "IsTeleport");
		IsTeleport_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsTeleport");
		IsTeleport_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsTeleport", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CalibrationTrans_PropertyAddress, intPtr, "CalibrationTrans");
		CalibrationTrans_Offset = NativeReflection.GetPropertyOffset(intPtr, "CalibrationTrans");
		CalibrationTrans_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CalibrationTrans", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bResetSceneItemOnFinish_PropertyAddress, intPtr, "bResetSceneItemOnFinish");
		bResetSceneItemOnFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bResetSceneItemOnFinish");
		bResetSceneItemOnFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bResetSceneItemOnFinish", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ScaleXAxisOnly_PropertyAddress, intPtr, "ScaleXAxisOnly");
		ScaleXAxisOnly_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleXAxisOnly");
		ScaleXAxisOnly_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleXAxisOnly", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDebugMode_PropertyAddress, intPtr, "EnableDebugMode");
		EnableDebugMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebugMode");
		EnableDebugMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebugMode", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMoveToSceneItem:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMoveToSceneItem:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSMoveToSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSMoveToSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSMoveToSceneItem));
	}
}
