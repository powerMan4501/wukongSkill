using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProceduralSpawnCharacterManaged")]
public class BGUProceduralSpawnCharacterManaged : BGUProceduralSpawnCharacterBase
{
	private static bool Datas_IsValid;

	private static int Datas_Offset;

	private static FFieldAddress Datas_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> Datas_Marshaler;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUProceduralSpawnCharacterManaged:Datas")]
	private TArrayReadWrite<UObject> Datas
	{
		get
		{
			CheckDestroyed();
			if (!Datas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralSpawnCharacterManaged:Datas");
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
		bGW_ECSWorld?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		USceneComponent rootComponent = GetRootComponent();
		if (bGW_ECSWorld != null)
		{
			CreateDataClass<BUC_DispLibDBCBaseData>(bGW_ECSWorld).Init(rootComponent, DispLibDBCActorGroup.BattleUnit);
			CreateDataClass<BUC_DispLibDBCQueueData>(bGW_ECSWorld).Init();
			base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp());
			base.ActorCompContainerCS.AddComp(new b1.BUS_ProceduralSpawnCharacterDispManagedComp());
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
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUProceduralSpawnCharacterManaged");
		NativeReflection.GetPropertyRef(ref Datas_PropertyAddress, unrealStruct, "Datas");
		Datas_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Datas");
		Datas_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Datas", Classes.FArrayProperty);
	}

	static BGUProceduralSpawnCharacterManaged()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUProceduralSpawnCharacterManaged)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUProceduralSpawnCharacterManaged));
	}
}
