using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUAiWeakInteractionActorBase")]
public class BGUAiWeakInteractionActorBase : BGUActorBaseCS
{
	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	private static bool AiWeakInteractComp_IsValid;

	private static int AiWeakInteractComp_Offset;

	private static bool InteractRangeDebugComp_IsValid;

	private static int InteractRangeDebugComp_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUAiWeakInteractionActorBase:DefaultRootComp")]
	private USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAiWeakInteractionActorBase:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAiWeakInteractionActorBase:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAiWeakInteractionActorBase:AiWeakInteractComp")]
	public BUS_AiWeakInteractComp AiWeakInteractComp
	{
		get
		{
			CheckDestroyed();
			if (!AiWeakInteractComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAiWeakInteractionActorBase:AiWeakInteractComp");
				return null;
			}
			return UObjectMarshaler<BUS_AiWeakInteractComp>.FromNative(IntPtr.Add(base.Address, AiWeakInteractComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AiWeakInteractComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAiWeakInteractionActorBase:AiWeakInteractComp");
			}
			else
			{
				UObjectMarshaler<BUS_AiWeakInteractComp>.ToNative(IntPtr.Add(base.Address, AiWeakInteractComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAiWeakInteractionActorBase:InteractRangeDebugComp")]
	public UBGUDebugSectorComponent InteractRangeDebugComp
	{
		get
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAiWeakInteractionActorBase:InteractRangeDebugComp");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, InteractRangeDebugComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAiWeakInteractionActorBase:InteractRangeDebugComp");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, InteractRangeDebugComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		SetRootComponentCS(DefaultRootComp);
		AiWeakInteractComp = initializer.CreateDefaultSubobject<BUS_AiWeakInteractComp>(this, B1GlobalFNames.AiWeakInteractComp);
		InteractRangeDebugComp = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.InteractRangeDebugComp);
		InteractRangeDebugComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		InteractRangeDebugComp.ShapeColor = FColor.Pink;
	}

	[USharpPath("/Script/b1-Managed.BGUAiWeakInteractionActorBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		if (UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			RefreshInteractRange();
		}
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_AiWeakInteractCompImpl());
		base.ActorCompContainerCS.AddComp(new b1.BUS_TickRateLogicSimpleComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_AiWeakInteractionDataComp>(this, B1GlobalFNames.AiWeakInteractionDataComp);
	}

	private void RefreshInteractRange()
	{
		if (AiWeakInteractComp.InteractTriggerRadius <= 0 || AiWeakInteractComp.AiConversationID <= 0)
		{
			InteractRangeDebugComp.SetVisibility(bNewVisibility: false);
			InteractRangeDebugComp.SetActive(bNewActive: false);
			return;
		}
		List<UActorComponent> componentsByTag = GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.GSInteractRangeAnchor);
		if (componentsByTag.Count > 0)
		{
			InteractRangeDebugComp.SetRelativeLocation((componentsByTag[0] as USceneComponent).RelativeLocation, bSweep: false, out var _, bTeleport: true);
		}
		InteractRangeDebugComp.SetSectorRadius(AiWeakInteractComp.InteractTriggerRadius);
		InteractRangeDebugComp.SetSectorMinAngle((float)(-AiWeakInteractComp.InteractTriggerAngle) / 2f);
		InteractRangeDebugComp.SetSectorMaxAngle((float)AiWeakInteractComp.InteractTriggerAngle / 2f);
		if (!InteractRangeDebugComp.IsVisible())
		{
			InteractRangeDebugComp.SetVisibility(bNewVisibility: true);
			InteractRangeDebugComp.SetActive(bNewActive: true);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUAiWeakInteractionActorBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUAiWeakInteractionActorBase bGUAiWeakInteractionActorBase = GCHelper.Find<BGUAiWeakInteractionActorBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUAiWeakInteractionActorBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUAiWeakInteractionActorBase");
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRootComp", Classes.FObjectProperty);
		AiWeakInteractComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "AiWeakInteractComp");
		AiWeakInteractComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AiWeakInteractComp", Classes.FObjectProperty);
		InteractRangeDebugComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractRangeDebugComp");
		InteractRangeDebugComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractRangeDebugComp", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUAiWeakInteractionActorBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUAiWeakInteractionActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUAiWeakInteractionActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUAiWeakInteractionActorBase));
	}
}
