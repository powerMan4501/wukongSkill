using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Play AtkFX OnGround")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround")]
internal class BAN_GSPlayAtkFXOnGround : BAN_GSBase
{
	private static bool AtkFXOnGroundTypeList_IsValid;

	private static int AtkFXOnGroundTypeList_Offset;

	private static FFieldAddress AtkFXOnGroundTypeList_PropertyAddress;

	private TArrayReadWriteMarshaler<EAtkFXOnGroundType> AtkFXOnGroundTypeList_Marshaler;

	private static bool HitFXRadiusMin_IsValid;

	private static int HitFXRadiusMin_Offset;

	private static bool HitFXRadiusMax_IsValid;

	private static int HitFXRadiusMax_Offset;

	private static bool HitFXRadiusExpandTime_IsValid;

	private static int HitFXRadiusExpandTime_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool SlopeSamplingRadiuseRadius_IsValid;

	private static int SlopeSamplingRadiuseRadius_Offset;

	private static bool SurfaceSamplingRadius_IsValid;

	private static int SurfaceSamplingRadius_Offset;

	private static bool LineTraceHeight_IsValid;

	private static int LineTraceHeight_Offset;

	private static bool SkillEffectID_IsValid;

	private static int SkillEffectID_Offset;

	private static bool EnableCheckThroughWall_IsValid;

	private static int EnableCheckThroughWall_Offset;

	private static FFieldAddress EnableCheckThroughWall_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[DisplayName("打中路面表现类型列表")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:AtkFXOnGroundTypeList")]
	public TArrayReadWrite<EAtkFXOnGroundType> AtkFXOnGroundTypeList
	{
		get
		{
			CheckDestroyed();
			if (!AtkFXOnGroundTypeList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:AtkFXOnGroundTypeList");
				return null;
			}
			if (AtkFXOnGroundTypeList_Marshaler == null)
			{
				AtkFXOnGroundTypeList_Marshaler = new TArrayReadWriteMarshaler<EAtkFXOnGroundType>(1, AtkFXOnGroundTypeList_PropertyAddress, CachedMarshalingDelegates<EAtkFXOnGroundType, EnumMarshaler<EAtkFXOnGroundType>>.FromNative, CachedMarshalingDelegates<EAtkFXOnGroundType, EnumMarshaler<EAtkFXOnGroundType>>.ToNative);
			}
			return AtkFXOnGroundTypeList_Marshaler.FromNative(IntPtr.Add(base.Address, AtkFXOnGroundTypeList_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("单位:cm")]
	[EditAnywhere]
	[Category("Anim Notify")]
	[DisplayName("打击范围表现半径最小值")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusMin")]
	public float HitFXRadiusMin
	{
		get
		{
			CheckDestroyed();
			if (!HitFXRadiusMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitFXRadiusMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitFXRadiusMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitFXRadiusMin_Offset), value);
			}
		}
	}

	[Tooltip("单位:cm")]
	[DisplayName("打击范围表现半径最大值")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusMax")]
	public float HitFXRadiusMax
	{
		get
		{
			CheckDestroyed();
			if (!HitFXRadiusMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitFXRadiusMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitFXRadiusMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitFXRadiusMax_Offset), value);
			}
		}
	}

	[DisplayName("打击范围表现半径扩展时间")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("单位:秒")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusExpandTime")]
	public float HitFXRadiusExpandTime
	{
		get
		{
			CheckDestroyed();
			if (!HitFXRadiusExpandTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusExpandTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitFXRadiusExpandTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitFXRadiusExpandTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:HitFXRadiusExpandTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitFXRadiusExpandTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[Tooltip("斜面旋转采样半径")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SlopeSamplingRadiuseRadius")]
	public float SlopeSamplingRadiuseRadius
	{
		get
		{
			CheckDestroyed();
			if (!SlopeSamplingRadiuseRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SlopeSamplingRadiuseRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlopeSamplingRadiuseRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlopeSamplingRadiuseRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SlopeSamplingRadiuseRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlopeSamplingRadiuseRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("地面类型采样半径")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SurfaceSamplingRadius")]
	public float SurfaceSamplingRadius
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceSamplingRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SurfaceSamplingRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SurfaceSamplingRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceSamplingRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SurfaceSamplingRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SurfaceSamplingRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:LineTraceHeight")]
	public float LineTraceHeight
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:LineTraceHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineTraceHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:LineTraceHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineTraceHeight_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("此处SkillEffectID只作为表现表的索引使用")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SkillEffectID")]
	public int SkillEffectID
	{
		get
		{
			CheckDestroyed();
			if (!SkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SkillEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:SkillEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillEffectID_Offset), value);
			}
		}
	}

	[DisplayName("开启穿墙检测")]
	[BlueprintReadWrite]
	[Tooltip("若开启：会从ActorLocation打射线到砸地点，若查询到遮挡，则不会触发事件")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:EnableCheckThroughWall")]
	public bool EnableCheckThroughWall
	{
		get
		{
			CheckDestroyed();
			if (!EnableCheckThroughWall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:EnableCheckThroughWall");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCheckThroughWall_Offset), 0, EnableCheckThroughWall_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCheckThroughWall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:EnableCheckThroughWall");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCheckThroughWall_Offset), 0, EnableCheckThroughWall_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		HitFXRadiusMin = 100f;
		HitFXRadiusMax = 100f;
		HitFXRadiusExpandTime = 0f;
		AtkFXOnGroundTypeList.Add(EAtkFXOnGroundType.UseDBC);
		AtkFXOnGroundTypeList.Add(EAtkFXOnGroundType.UseMatPainter);
		EnableCheckThroughWall = false;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (!(NotifyParam.owner == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			FVector location = GetSocketWorldTransform(meshComp, SocketName).GetLocation();
			BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_OnHitGroundPerform.Invoke(NotifyParam.owner.World, AtkFXOnGroundTypeList.ToList(), location, LineTraceHeight, SlopeSamplingRadiuseRadius, SkillEffectID, SurfaceSamplingRadius, EnableCheckThroughWall, HitFXRadiusMin, HitFXRadiusMax, HitFXRadiusExpandTime);
		}
	}

	private FTransform GetSocketWorldTransform(USkeletalMeshComponent MeshComp, FName SocketName)
	{
		FTransform result = default(FTransform);
		result.SetTranslation(MeshComp.GetSocketLocation(SocketName));
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayAtkFXOnGround bAN_GSPlayAtkFXOnGround = GCHelper.Find<b1.BAN_GSPlayAtkFXOnGround>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayAtkFXOnGround.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround");
		NativeReflection.GetPropertyRef(ref AtkFXOnGroundTypeList_PropertyAddress, intPtr, "AtkFXOnGroundTypeList");
		AtkFXOnGroundTypeList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AtkFXOnGroundTypeList");
		AtkFXOnGroundTypeList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AtkFXOnGroundTypeList", Classes.FArrayProperty);
		HitFXRadiusMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitFXRadiusMin");
		HitFXRadiusMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitFXRadiusMin", Classes.FFloatProperty);
		HitFXRadiusMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitFXRadiusMax");
		HitFXRadiusMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitFXRadiusMax", Classes.FFloatProperty);
		HitFXRadiusExpandTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitFXRadiusExpandTime");
		HitFXRadiusExpandTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitFXRadiusExpandTime", Classes.FFloatProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		SlopeSamplingRadiuseRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlopeSamplingRadiuseRadius");
		SlopeSamplingRadiuseRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlopeSamplingRadiuseRadius", Classes.FFloatProperty);
		SurfaceSamplingRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurfaceSamplingRadius");
		SurfaceSamplingRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurfaceSamplingRadius", Classes.FFloatProperty);
		LineTraceHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceHeight");
		LineTraceHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceHeight", Classes.FFloatProperty);
		SkillEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectID");
		SkillEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EnableCheckThroughWall_PropertyAddress, intPtr, "EnableCheckThroughWall");
		EnableCheckThroughWall_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableCheckThroughWall");
		EnableCheckThroughWall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableCheckThroughWall", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayAtkFXOnGround:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSPlayAtkFXOnGround()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSPlayAtkFXOnGround)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSPlayAtkFXOnGround));
	}
}
