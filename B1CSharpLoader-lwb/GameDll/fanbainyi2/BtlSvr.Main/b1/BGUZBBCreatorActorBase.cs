using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BGUZBBCreatorActorBase")]
public class BGUZBBCreatorActorBase : BGUActorBaseCS
{
	private static bool UnitDist_IsValid;

	private static int UnitDist_Offset;

	private static bool ZBBConfigs_IsValid;

	private static int ZBBConfigs_Offset;

	private static FFieldAddress ZBBConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<ZBBPreviewConfig> ZBBConfigs_Marshaler;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUZBBCreatorActorBase:UnitDist")]
	public float UnitDist
	{
		get
		{
			CheckDestroyed();
			if (!UnitDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUZBBCreatorActorBase:UnitDist");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnitDist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUZBBCreatorActorBase:UnitDist");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnitDist_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUZBBCreatorActorBase:ZBBConfigs")]
	public TArrayReadWrite<ZBBPreviewConfig> ZBBConfigs
	{
		get
		{
			CheckDestroyed();
			if (!ZBBConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUZBBCreatorActorBase:ZBBConfigs");
				return null;
			}
			if (ZBBConfigs_Marshaler == null)
			{
				ZBBConfigs_Marshaler = new TArrayReadWriteMarshaler<ZBBPreviewConfig>(1, ZBBConfigs_PropertyAddress, CachedMarshalingDelegates<ZBBPreviewConfig, ZBBPreviewConfig>.FromNative, CachedMarshalingDelegates<ZBBPreviewConfig, ZBBPreviewConfig>.ToNative);
			}
			return ZBBConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, ZBBConfigs_Offset));
		}
	}

	public bool ZBBCreateInfoSend { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		UnitDist = 5000f;
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_ZBBCreatorDataComp>(this, B1GlobalFNames.ZBBCreatorDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUZBBCreatorActorBase:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		if (!ZBBCreateInfoSend)
		{
			BGS_EventCollectionCS.Get(this)?.Evt_SendZBBCreationInfo.Invoke(this, UnitDist, ZBBConfigs.ToList());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUZBBCreatorActorBase:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUZBBCreatorActorBase bGUZBBCreatorActorBase = GCHelper.Find<BGUZBBCreatorActorBase>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUZBBCreatorActorBase.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUZBBCreatorActorBase");
		UnitDist_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitDist");
		UnitDist_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitDist", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ZBBConfigs_PropertyAddress, intPtr, "ZBBConfigs");
		ZBBConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZBBConfigs");
		ZBBConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZBBConfigs", Classes.FArrayProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUZBBCreatorActorBase:ReceiveTick", ReceiveTick_IsValid);
	}

	static BGUZBBCreatorActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUZBBCreatorActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUZBBCreatorActorBase));
	}
}
