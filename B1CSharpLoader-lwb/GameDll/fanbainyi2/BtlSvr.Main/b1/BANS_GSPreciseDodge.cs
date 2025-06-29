using System;
using UnrealEngine.Runtime;

namespace b1;

[UMeta(MDProp.DeprecationMessage, "BANS_GSPreciseDodge 已废弃，尽快删除")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSPreciseDodge")]
public class BANS_GSPreciseDodge : BANS_GSBase
{
	private static bool Level_IsValid;

	private static int Level_Offset;

	[Category("精准闪避配置")]
	[DisplayName("技能等级")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPreciseDodge:Level")]
	public int Level
	{
		get
		{
			CheckDestroyed();
			if (!Level_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreciseDodge:Level");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Level_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Level_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreciseDodge:Level");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Level_Offset), value);
			}
		}
	}

	private bool bEnabled { get; set; }

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		Level = 1;
		bEnabled = false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPreciseDodge");
		Level_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Level");
		Level_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Level", Classes.FIntProperty);
	}

	static BANS_GSPreciseDodge()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSPreciseDodge)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSPreciseDodge));
	}
}
