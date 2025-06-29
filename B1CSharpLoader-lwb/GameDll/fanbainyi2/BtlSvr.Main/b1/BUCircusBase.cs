using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUCircusBase")]
public class BUCircusBase : BGUActorBaseCS
{
	private static bool FamilyTree_IsValid;

	private static int FamilyTree_Offset;

	private static FFieldAddress FamilyTree_PropertyAddress;

	private TArrayReadWriteMarshaler<CircusCollector> FamilyTree_Marshaler;

	private static bool AwakeSync_IsValid;

	private static int AwakeSync_Offset;

	private static FFieldAddress AwakeSync_PropertyAddress;

	private static bool CollectRelativeTamerData_IsValid;

	private static IntPtr CollectRelativeTamerData_FunctionAddress;

	private static int CollectRelativeTamerData_ParamsSize;

	[DisplayName("成员树")]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUCircusBase:FamilyTree")]
	public TArrayReadWrite<CircusCollector> FamilyTree
	{
		get
		{
			CheckDestroyed();
			if (!FamilyTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUCircusBase:FamilyTree");
				return null;
			}
			if (FamilyTree_Marshaler == null)
			{
				FamilyTree_Marshaler = new TArrayReadWriteMarshaler<CircusCollector>(1, FamilyTree_PropertyAddress, CachedMarshalingDelegates<CircusCollector, CircusCollector>.FromNative, CachedMarshalingDelegates<CircusCollector, CircusCollector>.ToNative);
			}
			return FamilyTree_Marshaler.FromNative(IntPtr.Add(base.Address, FamilyTree_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("同步唤醒")]
	[USharpPath("/Script/b1-Managed.BUCircusBase:AwakeSync")]
	public bool AwakeSync
	{
		get
		{
			CheckDestroyed();
			if (!AwakeSync_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUCircusBase:AwakeSync");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AwakeSync_Offset), 0, AwakeSync_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AwakeSync_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUCircusBase:AwakeSync");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AwakeSync_Offset), 0, AwakeSync_PropertyAddress.Address, value);
			}
		}
	}

	public override void InitAllComp()
	{
		base.ActorCompContainerCS.AddComp(new BUS_CircusRegisterSystem());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_CircusDataComp>(this, B1GlobalFNames.DataComp);
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		AwakeSync = false;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("NoneRuntime")]
	[USharpPath("/Script/b1-Managed.BUCircusBase:CollectRelativeTamerData")]
	public void CollectRelativeTamerData()
	{
		GetAttachedActors(out var OutActors, bResetArray: true, bRecursivelyIncludeAttachedActors: true);
		FamilyTree.Clear();
		foreach (AActor item2 in OutActors)
		{
			CircusCollector item = new CircusCollector
			{
				IsRootMember = (item2.GetAttachParentActor() is BUCircusBase),
				SpawnByDefault = true
			};
			BUS_ConfigInfoComp componentByClass = item2.GetComponentByClass<BUS_ConfigInfoComp>();
			if (componentByClass != null)
			{
				item.SpawnByDefault = componentByClass.CircusConfig.SpawnByDefault;
				item.NickName = componentByClass.CircusConfig.NickName;
			}
			BUS_ActorConfigInfoComp componentByClass2 = item2.GetComponentByClass<BUS_ActorConfigInfoComp>();
			if (componentByClass2 != null)
			{
				item.NickName = componentByClass2.CircusConfig.NickName;
			}
			item.Member = item2;
			item.MemberType = CircusMemberType.Unknown;
			if (item2 is BUTamerActor)
			{
				item.MemberType = CircusMemberType.Tamer;
			}
			else if (item2 is BGUInteractiveActorBase)
			{
				item.MemberType = CircusMemberType.InteractiveObj;
			}
			else if (item2 is BGU_QuestActor { QuestActorType: EQuestActorType.SpawnWaves })
			{
				item.MemberType = CircusMemberType.SpawnWaves;
			}
			else if (item2 is BGUOverlapArea)
			{
				item.MemberType = CircusMemberType.Overlap;
			}
			else if (item2 is b1.BGUJJSObstacleBase)
			{
				item.MemberType = CircusMemberType.JJSObstacle;
			}
			else
			{
				if (item2 is AVolume)
				{
					continue;
				}
				FMessage.OpenDialog(GetName() + "\nCircus中包含非法类型单位\n" + item2.GetName());
			}
			if (item2.GetAttachParentSocketName() != FName.None)
			{
				item.Socket = item2.GetAttachParentSocketName();
				if (item2.RootComponent.GetAttachParent().IsEditorOnly)
				{
					item2.RootComponent.AttachToComponent(item2.GetAttachParentActor().RootComponent, item.Socket, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
				}
			}
			item.ChildMembers = new List<AActor>();
			item.ResId = BGU_DataUtil.GetActorResIDInEditor(item2);
			item2.GetAttachedActors(out var OutActors2);
			foreach (AActor item3 in OutActors2)
			{
				if (!(item3 is AVolume))
				{
					item.ChildMembers.Add(item3);
				}
			}
			FamilyTree.Add(item);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUCircusBase:CollectRelativeTamerData")]
	private static void CollectRelativeTamerData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUCircusBase bUCircusBase = GCHelper.Find<BUCircusBase>(obj);
		bUCircusBase.CollectRelativeTamerData();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUCircusBase");
		NativeReflection.GetPropertyRef(ref FamilyTree_PropertyAddress, intPtr, "FamilyTree");
		FamilyTree_Offset = NativeReflection.GetPropertyOffset(intPtr, "FamilyTree");
		FamilyTree_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FamilyTree", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AwakeSync_PropertyAddress, intPtr, "AwakeSync");
		AwakeSync_Offset = NativeReflection.GetPropertyOffset(intPtr, "AwakeSync");
		AwakeSync_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AwakeSync", Classes.FBoolProperty);
		CollectRelativeTamerData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CollectRelativeTamerData");
		CollectRelativeTamerData_ParamsSize = NativeReflection.GetFunctionParamsSize(CollectRelativeTamerData_FunctionAddress);
		CollectRelativeTamerData_IsValid = CollectRelativeTamerData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUCircusBase:CollectRelativeTamerData", CollectRelativeTamerData_IsValid);
	}

	static BUCircusBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUCircusBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUCircusBase));
	}
}
