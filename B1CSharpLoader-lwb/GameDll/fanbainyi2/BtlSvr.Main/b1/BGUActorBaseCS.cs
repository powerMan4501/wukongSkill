using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUActorBaseCS")]
public abstract class BGUActorBaseCS : BGUSimpleActorBaseCS
{
	private static bool GuidComp_IsValid;

	private static int GuidComp_Offset;

	private static bool SaveInitDataComp_IsValid;

	private static int SaveInitDataComp_Offset;

	private static bool ActorConfigInfoComp_IsValid;

	private static int ActorConfigInfoComp_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool GetActorGuidCS_IsValid;

	private static IntPtr GetActorGuidCS_FunctionAddress;

	private static int GetActorGuidCS_ParamsSize;

	private static bool GetActorGuidCS_OutActorGuid_IsValid;

	private static int GetActorGuidCS_OutActorGuid_Offset;

	private static FFieldAddress GetActorGuidCS_OutActorGuid_PropertyAddress;

	private static bool GetActorGuidCS_ReturnValue_IsValid;

	private static int GetActorGuidCS_ReturnValue_Offset;

	private static FFieldAddress GetActorGuidCS_ReturnValue_PropertyAddress;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUActorBaseCS:GuidComp")]
	public BUS_GuidComp GuidComp
	{
		get
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorBaseCS:GuidComp");
				return null;
			}
			return UObjectMarshaler<BUS_GuidComp>.FromNative(IntPtr.Add(base.Address, GuidComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorBaseCS:GuidComp");
			}
			else
			{
				UObjectMarshaler<BUS_GuidComp>.ToNative(IntPtr.Add(base.Address, GuidComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUActorBaseCS:SaveInitDataComp")]
	private BUS_SaveInitDataComp SaveInitDataComp
	{
		get
		{
			CheckDestroyed();
			if (!SaveInitDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorBaseCS:SaveInitDataComp");
				return null;
			}
			return UObjectMarshaler<BUS_SaveInitDataComp>.FromNative(IntPtr.Add(base.Address, SaveInitDataComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SaveInitDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorBaseCS:SaveInitDataComp");
			}
			else
			{
				UObjectMarshaler<BUS_SaveInitDataComp>.ToNative(IntPtr.Add(base.Address, SaveInitDataComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUActorBaseCS:ActorConfigInfoComp")]
	public BUS_ActorConfigInfoComp ActorConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!ActorConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorBaseCS:ActorConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_ActorConfigInfoComp>.FromNative(IntPtr.Add(base.Address, ActorConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorBaseCS:ActorConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_ActorConfigInfoComp>.ToNative(IntPtr.Add(base.Address, ActorConfigInfoComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		GuidComp = initializer.CreateDefaultSubobject<BUS_GuidComp>(this, B1GlobalFNames.GuidSystem);
		SaveInitDataComp = initializer.CreateDefaultSubobject<BUS_SaveInitDataComp>(this, B1GlobalFNames.SaveInitDataSystem);
		ActorConfigInfoComp = initializer.CreateDefaultSubobject<BUS_ActorConfigInfoComp>(this, B1GlobalFNames.ActorConfigInfoSystem);
	}

	[USharpPath("/Script/b1-Managed.BGUActorBaseCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		UBGUFunctionLibraryForCS.RemoveAllQueriesByQuerier(this);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_GuidCompImpl());
		base.ActorCompContainerCS.AddComp(new b1.BUS_SaveInitDataCompImpl());
		base.ActorCompContainerCS.AddComp(new BUS_QuestRegCollectionCompBase());
		if (DebugConfig.DebugWidget)
		{
			base.ActorCompContainerCS.AddComp(new BUS_DebugInfoComp());
		}
	}

	[USharpPath("/Script/b1-Managed.BGUActorBaseCS:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		GuidComp?.OnActorConstruction();
	}

	[USharpPath("/Script/b1-Managed.BGUActorBaseCS:GetActorGuidCS")]
	protected override bool GetActorGuidCS_Implementation(out string OutActorGuid)
	{
		OutActorGuid = BGU_DataUtil.GetActorGuid(this, bFindFromComponent: true);
		return !string.IsNullOrEmpty(OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUActorBaseCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUActorBaseCS bGUActorBaseCS = GCHelper.Find<BGUActorBaseCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUActorBaseCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUActorBaseCS:GetActorGuidCS")]
	private static void GetActorGuidCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUActorBaseCS bGUActorBaseCS = GCHelper.Find<BGUActorBaseCS>(obj);
		string OutActorGuid;
		bool actorGuidCS_Implementation = bGUActorBaseCS.GetActorGuidCS_Implementation(out OutActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address, actorGuidCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_OutActorGuid_Offset), OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUActorBaseCS:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUActorBaseCS bGUActorBaseCS = GCHelper.Find<BGUActorBaseCS>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUActorBaseCS.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUActorBaseCS");
		GuidComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuidComp");
		GuidComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuidComp", Classes.FObjectProperty);
		SaveInitDataComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SaveInitDataComp");
		SaveInitDataComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SaveInitDataComp", Classes.FObjectProperty);
		ActorConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorConfigInfoComp");
		ActorConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorConfigInfoComp", Classes.FObjectProperty);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUActorBaseCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUActorBaseCS:GetActorGuidCS", GetActorGuidCS_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUActorBaseCS:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUActorBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUActorBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUActorBaseCS));
	}
}
