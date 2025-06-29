using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Set Curve Value To Mesh")]
[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh")]
internal class BANS_GSSetCurveValueToMesh : BANS_GSBase
{
	public enum EWarningType_SetCurve
	{
		UseCurve_ButNoCurve = 1,
		NeedRecovery_ButOTNotEqual,
		NoNeedRecovery_ButOTNotEqual,
		NotFoundParam,
		HasEmptyMaterial,
		CantFindSKMesh,
		ConflictWithDBC
	}

	private static bool TemporaryClose_IsValid;

	private static int TemporaryClose_Offset;

	private static FFieldAddress TemporaryClose_PropertyAddress;

	private static bool FloatCurveParamList_IsValid;

	private static int FloatCurveParamList_Offset;

	private static FFieldAddress FloatCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSFloatCurveToParam> FloatCurveParamList_Marshaler;

	private static bool LinearColorCurveParamList_IsValid;

	private static int LinearColorCurveParamList_Offset;

	private static FFieldAddress LinearColorCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSLinearColorCurveToParam> LinearColorCurveParamList_Marshaler;

	private static bool NotApplyToChrMesh_IsValid;

	private static int NotApplyToChrMesh_Offset;

	private static FFieldAddress NotApplyToChrMesh_PropertyAddress;

	private static bool MatIndexList_IsValid;

	private static int MatIndexList_Offset;

	private static FFieldAddress MatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> MatIndexList_Marshaler;

	private static bool BothWeapons_IsValid;

	private static int BothWeapons_Offset;

	private static FFieldAddress BothWeapons_PropertyAddress;

	private static bool WeaponIndexList_IsValid;

	private static int WeaponIndexList_Offset;

	private static FFieldAddress WeaponIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponIndexList_Marshaler;

	private static bool WeaponMatIndexList_IsValid;

	private static int WeaponMatIndexList_Offset;

	private static FFieldAddress WeaponMatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponMatIndexList_Marshaler;

	private static bool BothChildSkeltalMeshes_IsValid;

	private static int BothChildSkeltalMeshes_Offset;

	private static FFieldAddress BothChildSkeltalMeshes_PropertyAddress;

	private static bool ChildSKMeshTagList_IsValid;

	private static int ChildSKMeshTagList_Offset;

	private static FFieldAddress ChildSKMeshTagList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> ChildSKMeshTagList_Marshaler;

	private static bool ChildSKMatIndexList_IsValid;

	private static int ChildSKMatIndexList_Offset;

	private static FFieldAddress ChildSKMatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ChildSKMatIndexList_Marshaler;

	private static bool BothChildActor_IsValid;

	private static int BothChildActor_Offset;

	private static FFieldAddress BothChildActor_PropertyAddress;

	private static bool ChildActorMeshMatIndexList_IsValid;

	private static int ChildActorMeshMatIndexList_Offset;

	private static FFieldAddress ChildActorMeshMatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ChildActorMeshMatIndexList_Marshaler;

	private static bool NeedRecovery_IsValid;

	private static int NeedRecovery_Offset;

	private static FFieldAddress NeedRecovery_PropertyAddress;

	private static bool bFitRealTime_IsValid;

	private static int bFitRealTime_Offset;

	private static FFieldAddress bFitRealTime_PropertyAddress;

	private static bool FilterByRule_IsValid;

	private static IntPtr FilterByRule_FunctionAddress;

	private static int FilterByRule_ParamsSize;

	private static bool FilterByRule_LogArr_IsValid;

	private static int FilterByRule_LogArr_Offset;

	private static FFieldAddress FilterByRule_LogArr_PropertyAddress;

	private static bool FilterByRule_SKMesh_IsValid;

	private static int FilterByRule_SKMesh_Offset;

	private static bool FilterByRule_WhiteParamNameList_IsValid;

	private static int FilterByRule_WhiteParamNameList_Offset;

	private static FFieldAddress FilterByRule_WhiteParamNameList_PropertyAddress;

	private static bool FilterByRule_TotallyBelongToDBC_IsValid;

	private static int FilterByRule_TotallyBelongToDBC_Offset;

	private static FFieldAddress FilterByRule_TotallyBelongToDBC_PropertyAddress;

	private static bool FilterByRule_ReturnValue_IsValid;

	private static int FilterByRule_ReturnValue_Offset;

	private static FFieldAddress FilterByRule_ReturnValue_PropertyAddress;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

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
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:TemporaryClose")]
	public bool TemporaryClose
	{
		get
		{
			CheckDestroyed();
			if (!TemporaryClose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:TemporaryClose");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TemporaryClose_Offset), 0, TemporaryClose_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TemporaryClose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:TemporaryClose");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TemporaryClose_Offset), 0, TemporaryClose_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:FloatCurveParamList")]
	public TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:FloatCurveParamList");
				return null;
			}
			if (FloatCurveParamList_Marshaler == null)
			{
				FloatCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSFloatCurveToParam>(1, FloatCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.FromNative, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.ToNative);
			}
			return FloatCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, FloatCurveParamList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:LinearColorCurveParamList")]
	public TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!LinearColorCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:LinearColorCurveParamList");
				return null;
			}
			if (LinearColorCurveParamList_Marshaler == null)
			{
				LinearColorCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSLinearColorCurveToParam>(1, LinearColorCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSLinearColorCurveToParam, FGSLinearColorCurveToParam>.FromNative, CachedMarshalingDelegates<FGSLinearColorCurveToParam, FGSLinearColorCurveToParam>.ToNative);
			}
			return LinearColorCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, LinearColorCurveParamList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("不应用到角色Mesh")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:NotApplyToChrMesh")]
	public bool NotApplyToChrMesh
	{
		get
		{
			CheckDestroyed();
			if (!NotApplyToChrMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:NotApplyToChrMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotApplyToChrMesh_Offset), 0, NotApplyToChrMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotApplyToChrMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:NotApplyToChrMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotApplyToChrMesh_Offset), 0, NotApplyToChrMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("不填则默认应用到所有材质上")]
	[UMeta(MDProp.EditCondition, "!NotApplyToChrMesh")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:MatIndexList")]
	public TArrayReadWrite<int> MatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!MatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:MatIndexList");
				return null;
			}
			if (MatIndexList_Marshaler == null)
			{
				MatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, MatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return MatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, MatIndexList_Offset));
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothWeapons")]
	public bool BothWeapons
	{
		get
		{
			CheckDestroyed();
			if (!BothWeapons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothWeapons");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothWeapons_Offset), 0, BothWeapons_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothWeapons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothWeapons");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothWeapons_Offset), 0, BothWeapons_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("不填则默认取所有武器")]
	[UMeta(MDProp.EditCondition, "BothWeapons")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:WeaponIndexList")]
	public TArrayReadWrite<int> WeaponIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:WeaponIndexList");
				return null;
			}
			if (WeaponIndexList_Marshaler == null)
			{
				WeaponIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndexList_Offset));
		}
	}

	[Category("Anim Notify")]
	[UMeta(MDProp.EditCondition, "BothWeapons")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("不填则默认应用到武器所有材质上")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:WeaponMatIndexList")]
	public TArrayReadWrite<int> WeaponMatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponMatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:WeaponMatIndexList");
				return null;
			}
			if (WeaponMatIndexList_Marshaler == null)
			{
				WeaponMatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponMatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponMatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponMatIndexList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothChildSkeltalMeshes")]
	public bool BothChildSkeltalMeshes
	{
		get
		{
			CheckDestroyed();
			if (!BothChildSkeltalMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothChildSkeltalMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothChildSkeltalMeshes_Offset), 0, BothChildSkeltalMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothChildSkeltalMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothChildSkeltalMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothChildSkeltalMeshes_Offset), 0, BothChildSkeltalMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "BothChildSkeltalMeshes")]
	[Tooltip("不填则默认取所有子SKMesh")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:ChildSKMeshTagList")]
	public TArrayReadWrite<FName> ChildSKMeshTagList
	{
		get
		{
			CheckDestroyed();
			if (!ChildSKMeshTagList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:ChildSKMeshTagList");
				return null;
			}
			if (ChildSKMeshTagList_Marshaler == null)
			{
				ChildSKMeshTagList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, ChildSKMeshTagList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ChildSKMeshTagList_Marshaler.FromNative(IntPtr.Add(base.Address, ChildSKMeshTagList_Offset));
		}
	}

	[Tooltip("不填则默认应用到子SKMesh所有材质上")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "BothChildSkeltalMeshes")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:ChildSKMatIndexList")]
	public TArrayReadWrite<int> ChildSKMatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!ChildSKMatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:ChildSKMatIndexList");
				return null;
			}
			if (ChildSKMatIndexList_Marshaler == null)
			{
				ChildSKMatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ChildSKMatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ChildSKMatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, ChildSKMatIndexList_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothChildActor")]
	public bool BothChildActor
	{
		get
		{
			CheckDestroyed();
			if (!BothChildActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothChildActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothChildActor_Offset), 0, BothChildActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothChildActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:BothChildActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothChildActor_Offset), 0, BothChildActor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "BothChildActor")]
	[Tooltip("不填则默认应用到子Actor的所有MeshComp的所有材质上")]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:ChildActorMeshMatIndexList")]
	public TArrayReadWrite<int> ChildActorMeshMatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!ChildActorMeshMatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:ChildActorMeshMatIndexList");
				return null;
			}
			if (ChildActorMeshMatIndexList_Marshaler == null)
			{
				ChildActorMeshMatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ChildActorMeshMatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ChildActorMeshMatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, ChildActorMeshMatIndexList_Offset));
		}
	}

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("true:End恢复到0状态，false:End去到1的状态")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:NeedRecovery")]
	public bool NeedRecovery
	{
		get
		{
			CheckDestroyed();
			if (!NeedRecovery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:NeedRecovery");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRecovery_Offset), 0, NeedRecovery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRecovery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:NeedRecovery");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRecovery_Offset), 0, NeedRecovery_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("true:曲线时间为真实时间，false:曲线时间为0~1，由程序自适应TotalTime到0~1")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:bFitRealTime")]
	public bool bFitRealTime
	{
		get
		{
			CheckDestroyed();
			if (!bFitRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:bFitRealTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFitRealTime_Offset), 0, bFitRealTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFitRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:bFitRealTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFitRealTime_Offset), 0, bFitRealTime_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		bFitRealTime = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.SetCurveValueToMesh;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (TemporaryClose)
		{
			return;
		}
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BeginForSetCurveValueToMesh.Invoke((int)GetUniqueID(), FloatCurveParamList, LinearColorCurveParamList, NotApplyToChrMesh, MatIndexList, BothWeapons, WeaponIndexList, WeaponMatIndexList, BothChildSkeltalMeshes, ChildSKMeshTagList, ChildSKMatIndexList, BothChildActor, ChildActorMeshMatIndexList, TotalDuration, bFitRealTime);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (TemporaryClose)
		{
			return;
		}
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OverForSetCurveValueToMesh.Invoke((int)GetUniqueID(), NeedRecovery);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:FilterByRule")]
	public bool FilterByRule(out List<string> LogArr, USkeletalMesh SKMesh, List<FName> WhiteParamNameList, out bool TotallyBelongToDBC)
	{
		TotallyBelongToDBC = true;
		LogArr = new List<string>();
		return LogArr.Count > 0;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:FilterByRule")]
	private static void FilterByRule__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCurveValueToMesh bANS_GSSetCurveValueToMesh = GCHelper.Find<b1.BANS_GSSetCurveValueToMesh>(obj);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, FilterByRule_LogArr_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> LogArr = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, FilterByRule_LogArr_Offset));
		USkeletalMesh sKMesh = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(buffer, FilterByRule_SKMesh_Offset));
		List<FName> whiteParamNameList = new TArrayCopyMarshaler<FName>(1, FilterByRule_WhiteParamNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(buffer, FilterByRule_WhiteParamNameList_Offset));
		bool TotallyBelongToDBC;
		bool value = bANS_GSSetCurveValueToMesh.FilterByRule(out LogArr, sKMesh, whiteParamNameList, out TotallyBelongToDBC);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FilterByRule_ReturnValue_Offset), 0, FilterByRule_ReturnValue_PropertyAddress.Address, value);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, FilterByRule_LogArr_Offset), LogArr);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FilterByRule_TotallyBelongToDBC_Offset), 0, FilterByRule_TotallyBelongToDBC_PropertyAddress.Address, TotallyBelongToDBC);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCurveValueToMesh bANS_GSSetCurveValueToMesh = GCHelper.Find<b1.BANS_GSSetCurveValueToMesh>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSSetCurveValueToMesh.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCurveValueToMesh bANS_GSSetCurveValueToMesh = GCHelper.Find<b1.BANS_GSSetCurveValueToMesh>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSetCurveValueToMesh.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCurveValueToMesh bANS_GSSetCurveValueToMesh = GCHelper.Find<b1.BANS_GSSetCurveValueToMesh>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetCurveValueToMesh.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetCurveValueToMesh");
		NativeReflection.GetPropertyRef(ref TemporaryClose_PropertyAddress, intPtr, "TemporaryClose");
		TemporaryClose_Offset = NativeReflection.GetPropertyOffset(intPtr, "TemporaryClose");
		TemporaryClose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TemporaryClose", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref FloatCurveParamList_PropertyAddress, intPtr, "FloatCurveParamList");
		FloatCurveParamList_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatCurveParamList");
		FloatCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatCurveParamList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LinearColorCurveParamList_PropertyAddress, intPtr, "LinearColorCurveParamList");
		LinearColorCurveParamList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LinearColorCurveParamList");
		LinearColorCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LinearColorCurveParamList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NotApplyToChrMesh_PropertyAddress, intPtr, "NotApplyToChrMesh");
		NotApplyToChrMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotApplyToChrMesh");
		NotApplyToChrMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotApplyToChrMesh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MatIndexList_PropertyAddress, intPtr, "MatIndexList");
		MatIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatIndexList");
		MatIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothWeapons_PropertyAddress, intPtr, "BothWeapons");
		BothWeapons_Offset = NativeReflection.GetPropertyOffset(intPtr, "BothWeapons");
		BothWeapons_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BothWeapons", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref WeaponIndexList_PropertyAddress, intPtr, "WeaponIndexList");
		WeaponIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndexList");
		WeaponIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref WeaponMatIndexList_PropertyAddress, intPtr, "WeaponMatIndexList");
		WeaponMatIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponMatIndexList");
		WeaponMatIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponMatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothChildSkeltalMeshes_PropertyAddress, intPtr, "BothChildSkeltalMeshes");
		BothChildSkeltalMeshes_Offset = NativeReflection.GetPropertyOffset(intPtr, "BothChildSkeltalMeshes");
		BothChildSkeltalMeshes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BothChildSkeltalMeshes", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ChildSKMeshTagList_PropertyAddress, intPtr, "ChildSKMeshTagList");
		ChildSKMeshTagList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChildSKMeshTagList");
		ChildSKMeshTagList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChildSKMeshTagList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ChildSKMatIndexList_PropertyAddress, intPtr, "ChildSKMatIndexList");
		ChildSKMatIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChildSKMatIndexList");
		ChildSKMatIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChildSKMatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothChildActor_PropertyAddress, intPtr, "BothChildActor");
		BothChildActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "BothChildActor");
		BothChildActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BothChildActor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ChildActorMeshMatIndexList_PropertyAddress, intPtr, "ChildActorMeshMatIndexList");
		ChildActorMeshMatIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChildActorMeshMatIndexList");
		ChildActorMeshMatIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChildActorMeshMatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NeedRecovery_PropertyAddress, intPtr, "NeedRecovery");
		NeedRecovery_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedRecovery");
		NeedRecovery_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedRecovery", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFitRealTime_PropertyAddress, intPtr, "bFitRealTime");
		bFitRealTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFitRealTime");
		bFitRealTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFitRealTime", Classes.FBoolProperty);
		FilterByRule_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FilterByRule");
		FilterByRule_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterByRule_FunctionAddress);
		NativeReflection.GetPropertyRef(ref FilterByRule_LogArr_PropertyAddress, FilterByRule_FunctionAddress, "LogArr");
		FilterByRule_LogArr_Offset = NativeReflection.GetPropertyOffset(FilterByRule_FunctionAddress, "LogArr");
		FilterByRule_LogArr_IsValid = NativeReflection.ValidatePropertyClass(FilterByRule_FunctionAddress, "LogArr", Classes.FArrayProperty);
		FilterByRule_SKMesh_Offset = NativeReflection.GetPropertyOffset(FilterByRule_FunctionAddress, "SKMesh");
		FilterByRule_SKMesh_IsValid = NativeReflection.ValidatePropertyClass(FilterByRule_FunctionAddress, "SKMesh", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FilterByRule_WhiteParamNameList_PropertyAddress, FilterByRule_FunctionAddress, "WhiteParamNameList");
		FilterByRule_WhiteParamNameList_Offset = NativeReflection.GetPropertyOffset(FilterByRule_FunctionAddress, "WhiteParamNameList");
		FilterByRule_WhiteParamNameList_IsValid = NativeReflection.ValidatePropertyClass(FilterByRule_FunctionAddress, "WhiteParamNameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FilterByRule_TotallyBelongToDBC_PropertyAddress, FilterByRule_FunctionAddress, "TotallyBelongToDBC");
		FilterByRule_TotallyBelongToDBC_Offset = NativeReflection.GetPropertyOffset(FilterByRule_FunctionAddress, "TotallyBelongToDBC");
		FilterByRule_TotallyBelongToDBC_IsValid = NativeReflection.ValidatePropertyClass(FilterByRule_FunctionAddress, "TotallyBelongToDBC", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref FilterByRule_ReturnValue_PropertyAddress, FilterByRule_FunctionAddress, "ReturnValue");
		FilterByRule_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FilterByRule_FunctionAddress, "ReturnValue");
		FilterByRule_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FilterByRule_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FilterByRule_IsValid = FilterByRule_FunctionAddress != IntPtr.Zero && FilterByRule_LogArr_IsValid && FilterByRule_SKMesh_IsValid && FilterByRule_WhiteParamNameList_IsValid && FilterByRule_TotallyBelongToDBC_IsValid && FilterByRule_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:FilterByRule", FilterByRule_IsValid);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCurveValueToMesh:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetCurveValueToMesh()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetCurveValueToMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetCurveValueToMesh));
	}
}
