using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS DashHitWall Check")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck")]
internal class BANS_GSDashHitWallCheck : BANS_GSBase
{
	private static bool CheckShapeList_IsValid;

	private static int CheckShapeList_Offset;

	private static FFieldAddress CheckShapeList_PropertyAddress;

	private TArrayReadWriteMarshaler<FUStCheckShape> CheckShapeList_Marshaler;

	private static bool ObjectTypeList_IsValid;

	private static int ObjectTypeList_Offset;

	private static FFieldAddress ObjectTypeList_PropertyAddress;

	private TArrayReadWriteMarshaler<EObjectTypeQuery> ObjectTypeList_Marshaler;

	private static bool ValidTag_IsValid;

	private static int ValidTag_Offset;

	private static bool HitWallStiffAM_IsValid;

	private static int HitWallStiffAM_Offset;

	private static bool IsRenderDebugShape_IsValid;

	private static int IsRenderDebugShape_Offset;

	private static FFieldAddress IsRenderDebugShape_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:CheckShapeList")]
	public TArrayReadWrite<FUStCheckShape> CheckShapeList
	{
		get
		{
			CheckDestroyed();
			if (!CheckShapeList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:CheckShapeList");
				return null;
			}
			if (CheckShapeList_Marshaler == null)
			{
				CheckShapeList_Marshaler = new TArrayReadWriteMarshaler<FUStCheckShape>(1, CheckShapeList_PropertyAddress, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.FromNative, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.ToNative);
			}
			return CheckShapeList_Marshaler.FromNative(IntPtr.Add(base.Address, CheckShapeList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:ObjectTypeList")]
	public TArrayReadWrite<EObjectTypeQuery> ObjectTypeList
	{
		get
		{
			CheckDestroyed();
			if (!ObjectTypeList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:ObjectTypeList");
				return null;
			}
			if (ObjectTypeList_Marshaler == null)
			{
				ObjectTypeList_Marshaler = new TArrayReadWriteMarshaler<EObjectTypeQuery>(1, ObjectTypeList_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative);
			}
			return ObjectTypeList_Marshaler.FromNative(IntPtr.Add(base.Address, ObjectTypeList_Offset));
		}
	}

	[Tooltip("仅在命中带特定Tag的Actor时生效，不填则略过筛选Tag这一步")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:ValidTag")]
	public string ValidTag
	{
		get
		{
			CheckDestroyed();
			if (!ValidTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:ValidTag");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ValidTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValidTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:ValidTag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ValidTag_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:HitWallStiffAM")]
	public UAnimMontage HitWallStiffAM
	{
		get
		{
			CheckDestroyed();
			if (!HitWallStiffAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:HitWallStiffAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, HitWallStiffAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitWallStiffAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:HitWallStiffAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, HitWallStiffAM_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:IsRenderDebugShape")]
	public bool IsRenderDebugShape
	{
		get
		{
			CheckDestroyed();
			if (!IsRenderDebugShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:IsRenderDebugShape");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRenderDebugShape_Offset), 0, IsRenderDebugShape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRenderDebugShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDashHitWallCheck:IsRenderDebugShape");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRenderDebugShape_Offset), 0, IsRenderDebugShape_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_DashWallCheckBegin.Invoke((int)GetUniqueID(), CheckShapeList, ObjectTypeList, HitWallStiffAM, ValidTag);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		UWorld world = NotifyParam.owner.World;
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(world) && IsRenderDebugShape)
		{
			DebugRender(world, NotifyParam.MeshComp);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_DashWallCheckEnd.Invoke((int)GetUniqueID());
		}
	}

	private void DebugRender(UWorld World, USkeletalMeshComponent MeshComp)
	{
		foreach (FUStCheckShape checkShape in CheckShapeList)
		{
			FVector socketLocation = MeshComp.GetSocketLocation(checkShape.SocketName);
			USystemLibrary.DrawDebugSphere(World, socketLocation, checkShape.Radius, 50, FLinearColor.Blue, 0.05f, 5f);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDashHitWallCheck bANS_GSDashHitWallCheck = GCHelper.Find<b1.BANS_GSDashHitWallCheck>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSDashHitWallCheck.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDashHitWallCheck bANS_GSDashHitWallCheck = GCHelper.Find<b1.BANS_GSDashHitWallCheck>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSDashHitWallCheck.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDashHitWallCheck bANS_GSDashHitWallCheck = GCHelper.Find<b1.BANS_GSDashHitWallCheck>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSDashHitWallCheck.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSDashHitWallCheck");
		NativeReflection.GetPropertyRef(ref CheckShapeList_PropertyAddress, intPtr, "CheckShapeList");
		CheckShapeList_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckShapeList");
		CheckShapeList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckShapeList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObjectTypeList_PropertyAddress, intPtr, "ObjectTypeList");
		ObjectTypeList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObjectTypeList");
		ObjectTypeList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObjectTypeList", Classes.FArrayProperty);
		ValidTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ValidTag");
		ValidTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ValidTag", Classes.FStrProperty);
		HitWallStiffAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitWallStiffAM");
		HitWallStiffAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitWallStiffAM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsRenderDebugShape_PropertyAddress, intPtr, "IsRenderDebugShape");
		IsRenderDebugShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRenderDebugShape");
		IsRenderDebugShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRenderDebugShape", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDashHitWallCheck:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSDashHitWallCheck()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSDashHitWallCheck)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSDashHitWallCheck));
	}
}
