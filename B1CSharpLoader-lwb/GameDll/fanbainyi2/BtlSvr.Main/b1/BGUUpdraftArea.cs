using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUUpdraftArea")]
internal class BGUUpdraftArea : BGUAreaBase
{
	private static bool UpdraftConfigInfoComp_IsValid;

	private static int UpdraftConfigInfoComp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("上升气流配置组件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUUpdraftArea:UpdraftConfigInfoComp")]
	public BUS_UpdraftConfigInfoComp UpdraftConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!UpdraftConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftArea:UpdraftConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_UpdraftConfigInfoComp>.FromNative(IntPtr.Add(base.Address, UpdraftConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdraftConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftArea:UpdraftConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_UpdraftConfigInfoComp>.ToNative(IntPtr.Add(base.Address, UpdraftConfigInfoComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		UpdraftConfigInfoComp = initializer.CreateDefaultSubobject<BUS_UpdraftConfigInfoComp>(this, B1GlobalFNames.UpdraftConfigInfoComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_UpdraftLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_UpdraftAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUUpdraftArea");
		UpdraftConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpdraftConfigInfoComp");
		UpdraftConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpdraftConfigInfoComp", Classes.FObjectProperty);
	}

	static BGUUpdraftArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUUpdraftArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUUpdraftArea));
	}
}
