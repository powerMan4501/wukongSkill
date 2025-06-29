using System;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Try Find SceneItem")]
[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem")]
internal class BAN_GSTryFindSceneItem : BAN_GSBase
{
	private static bool SceneActorTags_IsValid;

	private static int SceneActorTags_Offset;

	private static FFieldAddress SceneActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SceneActorTags_Marshaler;

	private static bool MinDistance_IsValid;

	private static int MinDistance_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool FindSceneItemWay_IsValid;

	private static int FindSceneItemWay_Offset;

	private static FFieldAddress FindSceneItemWay_PropertyAddress;

	private static bool Angle_IsValid;

	private static int Angle_Offset;

	private static bool NeedRemoveCurrentCatch_IsValid;

	private static int NeedRemoveCurrentCatch_Offset;

	private static FFieldAddress NeedRemoveCurrentCatch_PropertyAddress;

	private static bool EnableDrawDebug_IsValid;

	private static int EnableDrawDebug_Offset;

	private static FFieldAddress EnableDrawDebug_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:SceneActorTags")]
	public TArrayReadWrite<FName> SceneActorTags
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:SceneActorTags");
				return null;
			}
			if (SceneActorTags_Marshaler == null)
			{
				SceneActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SceneActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SceneActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorTags_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:MinDistance")]
	public float MinDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:MinDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:MinDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:FindSceneItemWay")]
	public EFindSceneItemWay FindSceneItemWay
	{
		get
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:FindSceneItemWay");
				return EFindSceneItemWay.FindNearest;
			}
			return EnumMarshaler<EFindSceneItemWay>.FromNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:FindSceneItemWay");
			}
			else
			{
				EnumMarshaler<EFindSceneItemWay>.ToNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("【角度外】对比夹角")]
	[UMeta(MDProp.EditCondition, "FindSceneItemWay == FindSceneItemWay::ClosestOutsideTheAngle || FindSceneItemWay == FindSceneItemWay::FarthestOutsideTheAngle")]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:Angle")]
	public float Angle
	{
		get
		{
			CheckDestroyed();
			if (!Angle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:Angle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Angle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Angle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:Angle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Angle_Offset), value);
			}
		}
	}

	[DisplayName("重新查找前，清空当前已经缓存了的SceneItem")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:NeedRemoveCurrentCatch")]
	public bool NeedRemoveCurrentCatch
	{
		get
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:NeedRemoveCurrentCatch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:NeedRemoveCurrentCatch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("开启DebugDraw")]
	[Tooltip("可视化展示对位点信息")]
	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:EnableDrawDebug")]
	public bool EnableDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:EnableDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDrawDebug_Offset), 0, EnableDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTryFindSceneItem:EnableDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDrawDebug_Offset), 0, EnableDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTryFindSceneItem:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(bGUCharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + bGUCharacterCS?.GetName() + "</><action>=============================NotifyState版的TryFindSceneItem开始=============================</>");
			}
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TryCatchSceneItemByTag.Invoke(SceneActorTags.ToList(), FindSceneItemWay, NeedRemoveCurrentCatch, MinDistance, MaxDistance, NotifyParam.FromInstanceID, -1f, Angle, EnableDrawDebug);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(bGUCharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + bGUCharacterCS?.GetName() + "</><action>=============================NotifyState版的TryFindSceneItem结束=============================</>");
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTryFindSceneItem:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTryFindSceneItem bAN_GSTryFindSceneItem = GCHelper.Find<b1.BAN_GSTryFindSceneItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSTryFindSceneItem.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTryFindSceneItem:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTryFindSceneItem bAN_GSTryFindSceneItem = GCHelper.Find<b1.BAN_GSTryFindSceneItem>(obj);
		bool value = bAN_GSTryFindSceneItem.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSTryFindSceneItem");
		NativeReflection.GetPropertyRef(ref SceneActorTags_PropertyAddress, intPtr, "SceneActorTags");
		SceneActorTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneActorTags");
		SceneActorTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneActorTags", Classes.FArrayProperty);
		MinDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinDistance");
		MinDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinDistance", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FindSceneItemWay_PropertyAddress, intPtr, "FindSceneItemWay");
		FindSceneItemWay_Offset = NativeReflection.GetPropertyOffset(intPtr, "FindSceneItemWay");
		FindSceneItemWay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FindSceneItemWay", Classes.FEnumProperty);
		Angle_Offset = NativeReflection.GetPropertyOffset(intPtr, "Angle");
		Angle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Angle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NeedRemoveCurrentCatch_PropertyAddress, intPtr, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedRemoveCurrentCatch", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDrawDebug_PropertyAddress, intPtr, "EnableDrawDebug");
		EnableDrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDrawDebug");
		EnableDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDrawDebug", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTryFindSceneItem:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTryFindSceneItem:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSTryFindSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSTryFindSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSTryFindSceneItem));
	}
}
