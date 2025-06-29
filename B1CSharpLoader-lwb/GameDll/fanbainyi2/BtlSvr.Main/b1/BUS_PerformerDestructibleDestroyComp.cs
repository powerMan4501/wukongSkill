using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp")]
public class BUS_PerformerDestructibleDestroyComp : UBaseActorCompTickable
{
	private static List<ECollisionChannel> Filter;

	private List<UShapeComponent> HitShapes = new List<UShapeComponent>();

	private List<FVector> HitShapePos = new List<FVector>();

	private List<FGSSweepCheckShapeInfo> HitShapeInfo = new List<FGSSweepCheckShapeInfo>();

	private List<AActor> IgnoreActors;

	private List<FUStGSHitResult> HitResultList;

	private static bool bIsEnabled_IsValid;

	private static int bIsEnabled_Offset;

	private static FFieldAddress bIsEnabled_PropertyAddress;

	private static bool HitStrengthLevel_IsValid;

	private static int HitStrengthLevel_Offset;

	private static FFieldAddress HitStrengthLevel_PropertyAddress;

	private static bool HitShapeTag_IsValid;

	private static int HitShapeTag_Offset;

	private static bool IsNeedDrawDebug_IsValid;

	private static int IsNeedDrawDebug_Offset;

	private static FFieldAddress IsNeedDrawDebug_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool SetEnableDestroyDestructible_IsValid;

	private static IntPtr SetEnableDestroyDestructible_FunctionAddress;

	private static int SetEnableDestroyDestructible_ParamsSize;

	private static bool SetEnableDestroyDestructible_IsEnabled_IsValid;

	private static int SetEnableDestroyDestructible_IsEnabled_Offset;

	private static FFieldAddress SetEnableDestroyDestructible_IsEnabled_PropertyAddress;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[Category("演员破碎击碎配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("开启破碎打击")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:bIsEnabled")]
	public bool bIsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!bIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:bIsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsEnabled_Offset), 0, bIsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:bIsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsEnabled_Offset), 0, bIsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("破碎物打击力度")]
	[UProperty]
	[Category("演员破碎击碎配置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:HitStrengthLevel")]
	public EGSHitDestructibleStrengthLevel HitStrengthLevel
	{
		get
		{
			CheckDestroyed();
			if (!HitStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:HitStrengthLevel");
				return EGSHitDestructibleStrengthLevel.None;
			}
			return EnumMarshaler<EGSHitDestructibleStrengthLevel>.FromNative(IntPtr.Add(base.Address, HitStrengthLevel_Offset), 0, HitStrengthLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:HitStrengthLevel");
			}
			else
			{
				EnumMarshaler<EGSHitDestructibleStrengthLevel>.ToNative(IntPtr.Add(base.Address, HitStrengthLevel_Offset), 0, HitStrengthLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("演员破碎击碎配置")]
	[BlueprintReadWrite]
	[DisplayName("检测碰撞组件Tag")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:HitShapeTag")]
	public FName HitShapeTag
	{
		get
		{
			CheckDestroyed();
			if (!HitShapeTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:HitShapeTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, HitShapeTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitShapeTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:HitShapeTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, HitShapeTag_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("演员破碎击碎配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:IsNeedDrawDebug")]
	public bool IsNeedDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:IsNeedDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedDrawDebug_Offset), 0, IsNeedDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:IsNeedDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedDrawDebug_Offset), 0, IsNeedDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	private AActor Owner { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.IsEditorOnly = false;
	}

	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		Owner = GetOwner();
		foreach (UActorComponent item2 in Owner.GetComponentsByTag(UClass.GetClass<UShapeComponent>(), HitShapeTag))
		{
			UShapeComponent uShapeComponent = item2 as UShapeComponent;
			if (uShapeComponent != null)
			{
				HitShapes.Add(uShapeComponent);
				HitShapePos.Add(uShapeComponent.GetWorldLocation());
				FGSSweepCheckShapeInfo item = default(FGSSweepCheckShapeInfo);
				if (uShapeComponent is UBoxComponent uBoxComponent)
				{
					item.SweepCheckShapeType = EGSSweepCheckShapeType.BoxShape;
					item.ShapeParamVector = uBoxComponent.GetScaledBoxExtent();
				}
				else if (uShapeComponent is UCapsuleComponent uCapsuleComponent)
				{
					item.SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape;
					item.ShapeParamFloat = ((uCapsuleComponent.GetScaledCapsuleHalfHeight() > uCapsuleComponent.GetScaledCapsuleRadius()) ? uCapsuleComponent.GetScaledCapsuleHalfHeight() : uCapsuleComponent.GetScaledCapsuleRadius());
				}
				else if (uShapeComponent is USphereComponent uSphereComponent)
				{
					item.SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape;
					item.ShapeParamFloat = uSphereComponent.GetScaledSphereRadius();
				}
				HitShapeInfo.Add(item);
			}
		}
		IgnoreActors = new List<AActor> { Owner };
	}

	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		if (!bIsEnabled)
		{
			SetComponentTickEnabled(bEnabled: false);
			return;
		}
		for (int i = 0; i < HitShapes.Count; i++)
		{
			if (HitShapes[i] == null)
			{
				continue;
			}
			FVector fVector = HitShapes[i].GetWorldLocation() + Owner.GetActorForwardVector();
			UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannel(Owner, new FTransform(HitShapePos[i]), new FTransform(fVector), HitShapes[i].GetWorldRotation().Quaternion(), ECollisionChannel.ECC_GameTraceChannel2, HitShapeInfo[i], out HitResultList, IgnoreActors, null, Filter, IsNeedDrawDebug);
			if (HitResultList != null && HitResultList.Count > 0)
			{
				foreach (FUStGSHitResult hitResult in HitResultList)
				{
					if (hitResult.HitComponent == null)
					{
						continue;
					}
					AActor actor = hitResult.Actor;
					if (!(actor == null))
					{
						b1.IBUC_DestructibleData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(actor);
						if (readOnlyData != null && !readOnlyData.IsDestroyed && (int)readOnlyData.StrengthLevel < (int)HitStrengthLevel)
						{
							FVector impactPoint = hitResult.ImpactPoint;
							FVector normal = hitResult.Normal;
							BGUFunctionLibraryCS.BGUDestroyDestructible(actor, new FVector(impactPoint.X, impactPoint.Y, impactPoint.Z), -1.0 * new FVector(normal.X, normal.Y, normal.Z));
						}
					}
				}
			}
			HitShapePos[i] = fVector;
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:SetEnableDestroyDestructible")]
	public void SetEnableDestroyDestructible(bool IsEnabled)
	{
		bIsEnabled = IsEnabled;
		SetComponentTickEnabled(IsEnabled);
	}

	static BUS_PerformerDestructibleDestroyComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PerformerDestructibleDestroyComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PerformerDestructibleDestroyComp));
		Filter = new List<ECollisionChannel> { ECollisionChannel.ECC_WorldDynamic };
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_PerformerDestructibleDestroyComp bUS_PerformerDestructibleDestroyComp = GCHelper.Find<BUS_PerformerDestructibleDestroyComp>(obj);
		bUS_PerformerDestructibleDestroyComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:SetEnableDestroyDestructible")]
	private static void SetEnableDestroyDestructible__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_PerformerDestructibleDestroyComp bUS_PerformerDestructibleDestroyComp = GCHelper.Find<BUS_PerformerDestructibleDestroyComp>(obj);
		bool enableDestroyDestructible = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetEnableDestroyDestructible_IsEnabled_Offset), 0, SetEnableDestroyDestructible_IsEnabled_PropertyAddress.Address);
		bUS_PerformerDestructibleDestroyComp.SetEnableDestroyDestructible(enableDestroyDestructible);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_PerformerDestructibleDestroyComp bUS_PerformerDestructibleDestroyComp = GCHelper.Find<BUS_PerformerDestructibleDestroyComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bUS_PerformerDestructibleDestroyComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp");
		NativeReflection.GetPropertyRef(ref bIsEnabled_PropertyAddress, intPtr, "bIsEnabled");
		bIsEnabled_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsEnabled");
		bIsEnabled_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsEnabled", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HitStrengthLevel_PropertyAddress, intPtr, "HitStrengthLevel");
		HitStrengthLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitStrengthLevel");
		HitStrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitStrengthLevel", Classes.FEnumProperty);
		HitShapeTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitShapeTag");
		HitShapeTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitShapeTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref IsNeedDrawDebug_PropertyAddress, intPtr, "IsNeedDrawDebug");
		IsNeedDrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNeedDrawDebug");
		IsNeedDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNeedDrawDebug", Classes.FBoolProperty);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		SetEnableDestroyDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableDestroyDestructible");
		SetEnableDestroyDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableDestroyDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetEnableDestroyDestructible_IsEnabled_PropertyAddress, SetEnableDestroyDestructible_FunctionAddress, "IsEnabled");
		SetEnableDestroyDestructible_IsEnabled_Offset = NativeReflection.GetPropertyOffset(SetEnableDestroyDestructible_FunctionAddress, "IsEnabled");
		SetEnableDestroyDestructible_IsEnabled_IsValid = NativeReflection.ValidatePropertyClass(SetEnableDestroyDestructible_FunctionAddress, "IsEnabled", Classes.FBoolProperty);
		SetEnableDestroyDestructible_IsValid = SetEnableDestroyDestructible_FunctionAddress != IntPtr.Zero && SetEnableDestroyDestructible_IsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:SetEnableDestroyDestructible", SetEnableDestroyDestructible_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_PerformerDestructibleDestroyComp:TickComponentInCS", TickComponentInCS_IsValid);
	}
}
