using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUMagicFieldBaseManaged")]
public class BGUMagicFieldBaseManaged : BGUMagicFieldBaseCS
{
	private static bool Datas_IsValid;

	private static int Datas_Offset;

	private static FFieldAddress Datas_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> Datas_Marshaler;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUMagicFieldBaseManaged:Datas")]
	private TArrayReadWrite<UObject> Datas
	{
		get
		{
			CheckDestroyed();
			if (!Datas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMagicFieldBaseManaged:Datas");
				return null;
			}
			if (Datas_Marshaler == null)
			{
				Datas_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, Datas_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Datas_Marshaler.FromNative(IntPtr.Add(base.Address, Datas_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		if (bGW_ECSWorld != null)
		{
			bGW_ECSWorld.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
			USceneComponent rootComponent = GetRootComponent();
			CreateDataClass<BUC_DispLibDBCBaseData>(bGW_ECSWorld).Init(rootComponent, DispLibDBCActorGroup.Projectile);
			CreateDataClass<BUC_DispLibDBCQueueData>(bGW_ECSWorld).Init();
		}
		base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_BulletDispManagedComp());
		if (base.ProjectileConfigInfoComp.bEnable_DBCComp)
		{
			BUC_DispLibUnitRendererBaseData bUC_DispLibUnitRendererBaseData = CreateDataClass<BUC_DispLibUnitRendererBaseData>(bGW_ECSWorld);
			bUC_DispLibUnitRendererBaseData.Init(100f, 100, base.StaticComp);
			CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>(bGW_ECSWorld).Init(bUC_DispLibUnitRendererBaseData);
			base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
		}
	}

	private T CreateData<T>(BGW_ECSWorld ECSWorld) where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		ECSWorld.SetObject(base.ECSEntity, val);
		Datas.Add(val);
		return val;
	}

	protected T CreateDataClass<T>(BGW_ECSWorld ECSWorld) where T : class, new()
	{
		T val = new T();
		ECSWorld?.SetObject(base.ECSEntity, val);
		return val;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUMagicFieldBaseManaged");
		NativeReflection.GetPropertyRef(ref Datas_PropertyAddress, unrealStruct, "Datas");
		Datas_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Datas");
		Datas_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Datas", Classes.FArrayProperty);
	}

	static BGUMagicFieldBaseManaged()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUMagicFieldBaseManaged)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUMagicFieldBaseManaged));
	}
}
