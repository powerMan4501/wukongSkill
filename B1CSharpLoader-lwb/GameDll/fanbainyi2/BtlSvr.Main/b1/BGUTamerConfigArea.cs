using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTamerConfigArea")]
internal class BGUTamerConfigArea : BGUAreaBase
{
	private static bool TamerStrategyArea_IsValid;

	private static int TamerStrategyArea_Offset;

	private static FFieldAddress TamerStrategyArea_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Tamer区域应用策略")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTamerConfigArea:TamerStrategyArea")]
	public ETamerStrategyArea TamerStrategyArea
	{
		get
		{
			CheckDestroyed();
			if (!TamerStrategyArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTamerConfigArea:TamerStrategyArea");
				return ETamerStrategyArea.None;
			}
			return EnumMarshaler<ETamerStrategyArea>.FromNative(IntPtr.Add(base.Address, TamerStrategyArea_Offset), 0, TamerStrategyArea_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TamerStrategyArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTamerConfigArea:TamerStrategyArea");
			}
			else
			{
				EnumMarshaler<ETamerStrategyArea>.ToNative(IntPtr.Add(base.Address, TamerStrategyArea_Offset), 0, TamerStrategyArea_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_TamerConfigAreaLogicComp());
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUTamerConfigArea");
		NativeReflection.GetPropertyRef(ref TamerStrategyArea_PropertyAddress, unrealStruct, "TamerStrategyArea");
		TamerStrategyArea_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerStrategyArea");
		TamerStrategyArea_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerStrategyArea", Classes.FEnumProperty);
	}

	static BGUTamerConfigArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUTamerConfigArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUTamerConfigArea));
	}
}
