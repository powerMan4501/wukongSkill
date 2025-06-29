using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUBirthPoint", "b1", UnrealModuleType.Game)]
public class ABGUBirthPoint : ANavigationObjectBase
{
	private static bool BirthPointID_IsValid;

	private static int BirthPointID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUBirthPoint:BirthPointID")]
	public int BirthPointID
	{
		get
		{
			CheckDestroyed();
			if (!BirthPointID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUBirthPoint:BirthPointID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BirthPointID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BirthPointID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUBirthPoint:BirthPointID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BirthPointID_Offset), value);
			}
		}
	}

	static ABGUBirthPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUBirthPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUBirthPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGUBirthPoint");
		BirthPointID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BirthPointID");
		BirthPointID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BirthPointID", Classes.FIntProperty);
	}
}
