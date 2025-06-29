using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUMapsymblolocationActor")]
public class BUMapsymblolocationActor : BGUActorBaseCS
{
	private static bool MapsymblolConfigComp_IsValid;

	private static int MapsymblolConfigComp_Offset;

	private static bool UseDebugDraw_IsValid;

	private static int UseDebugDraw_Offset;

	private static FFieldAddress UseDebugDraw_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUMapsymblolocationActor:MapsymblolConfigComp")]
	public BUS_MapSymbolConfigComp MapsymblolConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!MapsymblolConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUMapsymblolocationActor:MapsymblolConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_MapSymbolConfigComp>.FromNative(IntPtr.Add(base.Address, MapsymblolConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapsymblolConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUMapsymblolocationActor:MapsymblolConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_MapSymbolConfigComp>.ToNative(IntPtr.Add(base.Address, MapsymblolConfigComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUMapsymblolocationActor:UseDebugDraw")]
	public bool UseDebugDraw
	{
		get
		{
			CheckDestroyed();
			if (!UseDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUMapsymblolocationActor:UseDebugDraw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseDebugDraw_Offset), 0, UseDebugDraw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUMapsymblolocationActor:UseDebugDraw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseDebugDraw_Offset), 0, UseDebugDraw_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		MapsymblolConfigComp = initializer.CreateDefaultSubobject<BUS_MapSymbolConfigComp>(this, B1GlobalFNames.MapSymbolConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	protected T CreateData<T>(BGW_ECSWorld ECSWorld) where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		ECSWorld.SetObject(base.ECSEntity, val);
		return val;
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUMapsymblolocationActor");
		MapsymblolConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapsymblolConfigComp");
		MapsymblolConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapsymblolConfigComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UseDebugDraw_PropertyAddress, unrealStruct, "UseDebugDraw");
		UseDebugDraw_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseDebugDraw");
		UseDebugDraw_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseDebugDraw", Classes.FBoolProperty);
	}

	static BUMapsymblolocationActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUMapsymblolocationActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUMapsymblolocationActor));
	}
}
