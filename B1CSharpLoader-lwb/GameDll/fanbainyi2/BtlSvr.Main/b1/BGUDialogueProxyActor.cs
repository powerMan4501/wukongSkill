using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDialogueProxyActor")]
public class BGUDialogueProxyActor : BGUSimpleActorBaseCS
{
	private static bool AkComp_IsValid;

	private static int AkComp_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDialogueProxyActor:AkComp")]
	public UAkComponent AkComp
	{
		get
		{
			CheckDestroyed();
			if (!AkComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDialogueProxyActor:AkComp");
				return null;
			}
			return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(base.Address, AkComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDialogueProxyActor:AkComp");
			}
			else
			{
				UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(base.Address, AkComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AkComp = initializer.CreateDefaultSubobject<UAkComponent>(this, B1GlobalFNames.Ak);
		AkComp.SetAttenuationScalingFactor(0f);
		SetRootComponentCS(AkComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.bIsNoMoveActor = false;
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_AKMgrComp>(1);
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_UIControlSystemV2>(1);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DialogueProxyDataComp>(this, B1GlobalFNames.DialogueProxyDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUDialogueProxyActor:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDialogueProxyActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDialogueProxyActor bGUDialogueProxyActor = GCHelper.Find<BGUDialogueProxyActor>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUDialogueProxyActor.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDialogueProxyActor");
		AkComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkComp");
		AkComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkComp", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDialogueProxyActor:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUDialogueProxyActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDialogueProxyActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDialogueProxyActor));
	}
}
