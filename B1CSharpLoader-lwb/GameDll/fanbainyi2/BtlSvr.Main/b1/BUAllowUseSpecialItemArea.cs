using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAllowUseSpecialItemArea")]
public class BUAllowUseSpecialItemArea : BGUAreaBase
{
	private static bool AllowUseSpecialItemAreaConfigComp_IsValid;

	private static int AllowUseSpecialItemAreaConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAllowUseSpecialItemArea:AllowUseSpecialItemAreaConfigComp")]
	public BUS_AllowUseSpecialItemAreaConfigComp AllowUseSpecialItemAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!AllowUseSpecialItemAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAllowUseSpecialItemArea:AllowUseSpecialItemAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_AllowUseSpecialItemAreaConfigComp>.FromNative(IntPtr.Add(base.Address, AllowUseSpecialItemAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AllowUseSpecialItemAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAllowUseSpecialItemArea:AllowUseSpecialItemAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_AllowUseSpecialItemAreaConfigComp>.ToNative(IntPtr.Add(base.Address, AllowUseSpecialItemAreaConfigComp_Offset), value);
			}
		}
	}

	protected override FName GetRootCompName()
	{
		return B1GlobalFNames.DefaultSceneRoot;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AllowUseSpecialItemAreaConfigComp = initializer.CreateDefaultSubobject<BUS_AllowUseSpecialItemAreaConfigComp>(this, B1GlobalFNames.AllowUseSpecialItemConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_AllowUseSpecialItemAreaComp());
	}

	public List<int> GetAllowUseItemIDS()
	{
		if (AllowUseSpecialItemAreaConfigComp != null)
		{
			return AllowUseSpecialItemAreaConfigComp.AllowUseSpecialItemID.ToList();
		}
		return new List<int>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_AllowUseSpecialItemAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAllowUseSpecialItemArea");
		AllowUseSpecialItemAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AllowUseSpecialItemAreaConfigComp");
		AllowUseSpecialItemAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AllowUseSpecialItemAreaConfigComp", Classes.FObjectProperty);
	}

	static BUAllowUseSpecialItemArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAllowUseSpecialItemArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAllowUseSpecialItemArea));
	}
}
