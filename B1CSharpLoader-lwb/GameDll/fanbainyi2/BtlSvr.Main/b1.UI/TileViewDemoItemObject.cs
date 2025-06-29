using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.TileViewDemoItemObject")]
public class TileViewDemoItemObject : UObject
{
	private static bool skillImage_IsValid;

	private static int skillImage_Offset;

	private static bool skillName_IsValid;

	private static int skillName_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TileViewDemoItemObject:skillImage")]
	public UImage skillImage
	{
		get
		{
			CheckDestroyed();
			if (!skillImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoItemObject:skillImage");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, skillImage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!skillImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoItemObject:skillImage");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, skillImage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TileViewDemoItemObject:skillName")]
	public string skillName
	{
		get
		{
			CheckDestroyed();
			if (!skillName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoItemObject:skillName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, skillName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!skillName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoItemObject:skillName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, skillName_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.TileViewDemoItemObject");
		skillImage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "skillImage");
		skillImage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "skillImage", Classes.FObjectProperty);
		skillName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "skillName");
		skillName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "skillName", Classes.FStrProperty);
	}

	static TileViewDemoItemObject()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TileViewDemoItemObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TileViewDemoItemObject));
	}
}
