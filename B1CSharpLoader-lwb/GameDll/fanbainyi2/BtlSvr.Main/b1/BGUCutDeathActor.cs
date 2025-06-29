using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCutDeathActor")]
public class BGUCutDeathActor : BGUActorBaseCS
{
	private static bool CapsuleComp_IsValid;

	private static int CapsuleComp_Offset;

	private static bool EffectAttackSocket_IsValid;

	private static int EffectAttackSocket_Offset;

	private static bool PreviewPhy_IsValid;

	private static IntPtr PreviewPhy_FunctionAddress;

	private static int PreviewPhy_ParamsSize;

	private static bool PreviewPhy_OwnerChar_IsValid;

	private static int PreviewPhy_OwnerChar_Offset;

	public BUS_CutDeathComp CutDeathComp { get; set; }

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUCutDeathActor:CapsuleComp")]
	public UCapsuleComponent CapsuleComp
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCutDeathActor:CapsuleComp");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCutDeathActor:CapsuleComp");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("元素叠加特效挂点")]
	[USharpPath("/Script/b1-Managed.BGUCutDeathActor:EffectAttackSocket")]
	public FName EffectAttackSocket
	{
		get
		{
			CheckDestroyed();
			if (!EffectAttackSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCutDeathActor:EffectAttackSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EffectAttackSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectAttackSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCutDeathActor:EffectAttackSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EffectAttackSocket_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CapsuleComp = initializer.CreateDefaultSubobject<UCapsuleComponent>(this, B1GlobalFNames.CapsuleComp);
		base.RootComponent = CapsuleComp;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUCutDeathActor:PreviewPhy")]
	public void PreviewPhy(BGUCharacterCS OwnerChar)
	{
		BUS_EventCollectionCS.Get(this)?.Evt_OnPerformCutDeath.Invoke(OwnerChar, 0f, 100f);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld.Get(this)?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		base.ActorCompContainerCS.AddComp(new BUS_ABPHelperComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitArtFresnelComp());
		CutDeathComp = base.ActorCompContainerCS.AddComp(new BUS_CutDeathComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_CutDeathDataComp>(this, B1GlobalFNames.CutDeathDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCutDeathActor:PreviewPhy")]
	private static void PreviewPhy__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCutDeathActor bGUCutDeathActor = GCHelper.Find<BGUCutDeathActor>(obj);
		BGUCharacterCS ownerChar = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, PreviewPhy_OwnerChar_Offset));
		bGUCutDeathActor.PreviewPhy(ownerChar);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUCutDeathActor");
		CapsuleComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleComp");
		CapsuleComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleComp", Classes.FObjectProperty);
		EffectAttackSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectAttackSocket");
		EffectAttackSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectAttackSocket", Classes.FNameProperty);
		PreviewPhy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreviewPhy");
		PreviewPhy_ParamsSize = NativeReflection.GetFunctionParamsSize(PreviewPhy_FunctionAddress);
		PreviewPhy_OwnerChar_Offset = NativeReflection.GetPropertyOffset(PreviewPhy_FunctionAddress, "OwnerChar");
		PreviewPhy_OwnerChar_IsValid = NativeReflection.ValidatePropertyClass(PreviewPhy_FunctionAddress, "OwnerChar", Classes.FObjectProperty);
		PreviewPhy_IsValid = PreviewPhy_FunctionAddress != IntPtr.Zero && PreviewPhy_OwnerChar_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCutDeathActor:PreviewPhy", PreviewPhy_IsValid);
	}

	static BGUCutDeathActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCutDeathActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCutDeathActor));
	}
}
