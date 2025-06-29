using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Awake Partner")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner")]
internal class BAN_GSAwakePartner : BAN_GSBase
{
	private static bool PartnerFilter_IsValid;

	private static int PartnerFilter_Offset;

	private static bool ResIDList_IsValid;

	private static int ResIDList_Offset;

	private static FFieldAddress ResIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ResIDList_Marshaler;

	private static bool AwakeUnitInFight_IsValid;

	private static int AwakeUnitInFight_Offset;

	private static FFieldAddress AwakeUnitInFight_PropertyAddress;

	private static bool CircleRadius_IsValid;

	private static int CircleRadius_Offset;

	private static bool Height_Up_IsValid;

	private static int Height_Up_Offset;

	private static bool Height_Down_IsValid;

	private static int Height_Down_Offset;

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

	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:PartnerFilter")]
	public int PartnerFilter
	{
		get
		{
			CheckDestroyed();
			if (!PartnerFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:PartnerFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PartnerFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PartnerFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:PartnerFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PartnerFilter_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:ResIDList")]
	public TArrayReadWrite<int> ResIDList
	{
		get
		{
			CheckDestroyed();
			if (!ResIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:ResIDList");
				return null;
			}
			if (ResIDList_Marshaler == null)
			{
				ResIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ResIDList_Marshaler.FromNative(IntPtr.Add(base.Address, ResIDList_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:AwakeUnitInFight")]
	public bool AwakeUnitInFight
	{
		get
		{
			CheckDestroyed();
			if (!AwakeUnitInFight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:AwakeUnitInFight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AwakeUnitInFight_Offset), 0, AwakeUnitInFight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AwakeUnitInFight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:AwakeUnitInFight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AwakeUnitInFight_Offset), 0, AwakeUnitInFight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:CircleRadius")]
	public int CircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:CircleRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:CircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CircleRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:Height_Up")]
	public float Height_Up
	{
		get
		{
			CheckDestroyed();
			if (!Height_Up_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:Height_Up");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Height_Up_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_Up_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:Height_Up");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Height_Up_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:Height_Down")]
	public float Height_Down
	{
		get
		{
			CheckDestroyed();
			if (!Height_Down_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:Height_Down");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Height_Down_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_Down_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAwakePartner:Height_Down");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Height_Down_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAwakePartner:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor actor = NotifyParam.MeshComp?.GetOwner();
		AwakePartner(actor);
	}

	private void AwakePartner(AActor Actor)
	{
		if (PartnerFilter == 0)
		{
			return;
		}
		List<AActor> OutActors = new List<AActor>();
		List<int> list = new List<int>();
		list.Add(CircleRadius);
		UWorld world = Actor.World;
		FVector baseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(Actor);
		int partnerFilter = PartnerFilter;
		IList<int> Prams = list;
		BGUFuncLibSelectTargetsCS.BGUSelectTargetsInShape(world, out OutActors, Actor, baseLoc, ERangeType.Circle, 10, partnerFilter, 0, 0, in Prams);
		if (OutActors.Count == 0 || Actor as BGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = BGUFunctionLibraryCS.BGUGetTarget(Actor) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		for (int i = 0; i < OutActors.Count; i++)
		{
			if (UBGUFuncLibSelectTargets.BGUIsSelectTargetInFilterBP(Actor, OutActors[i], PartnerFilter) && FilterByHeight(Actor, OutActors[i]))
			{
				BGUCharacterCS bGUCharacterCS2 = OutActors[i] as BGUCharacterCS;
				if (bGUCharacterCS2 != null)
				{
					break;
				}
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS2);
				if (bUS_GSEventCollection == null || (ResIDList.Count > 0 && !ResIDList.Contains(bGUCharacterCS2.GetResID())) || (!AwakeUnitInFight && BGUFunctionLibraryCS.BGUGetTarget(OutActors[i]) != null))
				{
					break;
				}
				bUS_GSEventCollection.Evt_AICatchTarget.Invoke(bGUCharacterCS, ETargetSourceType.Target_AwakePartner);
			}
		}
	}

	private bool FilterByHeight(AActor Owner, AActor AwakeTarget)
	{
		if (Height_Up == 0f && Height_Down == 0f)
		{
			return true;
		}
		bool result = true;
		float z = BGUFuncLibActorTransformCS.BGUGetActorLocation(AwakeTarget).Z;
		float z2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner).Z;
		if (Height_Up != 0f && z > z2 && z - z2 > Math.Abs(Height_Up))
		{
			result = false;
		}
		if (Height_Down != 0f && z < z2 && z2 - z > Math.Abs(Height_Down))
		{
			result = false;
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAwakePartner:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAwakePartner bAN_GSAwakePartner = GCHelper.Find<b1.BAN_GSAwakePartner>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSAwakePartner.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAwakePartner:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAwakePartner bAN_GSAwakePartner = GCHelper.Find<b1.BAN_GSAwakePartner>(obj);
		bool value = bAN_GSAwakePartner.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSAwakePartner");
		PartnerFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "PartnerFilter");
		PartnerFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PartnerFilter", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ResIDList_PropertyAddress, intPtr, "ResIDList");
		ResIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResIDList");
		ResIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AwakeUnitInFight_PropertyAddress, intPtr, "AwakeUnitInFight");
		AwakeUnitInFight_Offset = NativeReflection.GetPropertyOffset(intPtr, "AwakeUnitInFight");
		AwakeUnitInFight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AwakeUnitInFight", Classes.FBoolProperty);
		CircleRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CircleRadius");
		CircleRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CircleRadius", Classes.FIntProperty);
		Height_Up_Offset = NativeReflection.GetPropertyOffset(intPtr, "Height_Up");
		Height_Up_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Height_Up", Classes.FFloatProperty);
		Height_Down_Offset = NativeReflection.GetPropertyOffset(intPtr, "Height_Down");
		Height_Down_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Height_Down", Classes.FFloatProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAwakePartner:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAwakePartner:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSAwakePartner()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSAwakePartner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSAwakePartner));
	}
}
