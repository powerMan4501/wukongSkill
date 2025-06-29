using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCloudMoveRestrictArea")]
public class BGUCloudMoveRestrictArea : BGUAreaBase
{
	private static bool CloudMoveRestrictAreaConfigComp_IsValid;

	private static int CloudMoveRestrictAreaConfigComp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUCloudMoveRestrictArea:CloudMoveRestrictAreaConfigComp")]
	public BUS_CloudMoveRestrictAreaConfigComp CloudMoveRestrictAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!CloudMoveRestrictAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCloudMoveRestrictArea:CloudMoveRestrictAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_CloudMoveRestrictAreaConfigComp>.FromNative(IntPtr.Add(base.Address, CloudMoveRestrictAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudMoveRestrictAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCloudMoveRestrictArea:CloudMoveRestrictAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_CloudMoveRestrictAreaConfigComp>.ToNative(IntPtr.Add(base.Address, CloudMoveRestrictAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
		CloudMoveRestrictAreaConfigComp = initializer.CreateDefaultSubobject<BUS_CloudMoveRestrictAreaConfigComp>(this, B1GlobalFNames.CloudMoveRestrictAreaConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_CloudMoveRestrictAreaLogicComp>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_CloudMoveRestrictAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUCloudMoveRestrictArea");
		CloudMoveRestrictAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudMoveRestrictAreaConfigComp");
		CloudMoveRestrictAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudMoveRestrictAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUCloudMoveRestrictArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCloudMoveRestrictArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCloudMoveRestrictArea));
	}
}
