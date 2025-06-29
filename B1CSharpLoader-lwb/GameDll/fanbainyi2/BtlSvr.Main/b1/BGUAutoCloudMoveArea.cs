using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUAutoCloudMoveArea")]
public class BGUAutoCloudMoveArea : BGUAreaBase
{
	private static bool AutoCloudMoveAreaConfigComp_IsValid;

	private static int AutoCloudMoveAreaConfigComp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUAutoCloudMoveArea:AutoCloudMoveAreaConfigComp")]
	public BUS_AutoCloudMoveAreaConfigComp AutoCloudMoveAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!AutoCloudMoveAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAutoCloudMoveArea:AutoCloudMoveAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_AutoCloudMoveAreaConfigComp>.FromNative(IntPtr.Add(base.Address, AutoCloudMoveAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoCloudMoveAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAutoCloudMoveArea:AutoCloudMoveAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_AutoCloudMoveAreaConfigComp>.ToNative(IntPtr.Add(base.Address, AutoCloudMoveAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AutoCloudMoveAreaConfigComp = initializer.CreateDefaultSubobject<BUS_AutoCloudMoveAreaConfigComp>(this, B1GlobalFNames.AutoCloudMoveAreaConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_AutoCloudMoveAreaComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_AutoCloudMoveAreaDataComp>(this, B1GlobalFNames.AutoCloudMoveArea);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUAutoCloudMoveArea");
		AutoCloudMoveAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoCloudMoveAreaConfigComp");
		AutoCloudMoveAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoCloudMoveAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUAutoCloudMoveArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUAutoCloudMoveArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUAutoCloudMoveArea));
	}
}
