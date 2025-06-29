using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ListViewDemoItemObject")]
public class ListViewDemoItemObject : AActor
{
	private static bool itemText_IsValid;

	private static int itemText_Offset;

	private static bool itemColor_IsValid;

	private static int itemColor_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[ExposeOnSpawn]
	[USharpPath("/Script/b1-Managed.ListViewDemoItemObject:itemText")]
	public string itemText
	{
		get
		{
			CheckDestroyed();
			if (!itemText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoItemObject:itemText");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, itemText_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!itemText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoItemObject:itemText");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, itemText_Offset), value);
			}
		}
	}

	[ExposeOnSpawn]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ListViewDemoItemObject:itemColor")]
	public FLinearColor itemColor
	{
		get
		{
			CheckDestroyed();
			if (!itemColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoItemObject:itemColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, itemColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!itemColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoItemObject:itemColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, itemColor_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.ListViewDemoItemObject");
		itemText_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "itemText");
		itemText_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "itemText", Classes.FStrProperty);
		itemColor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "itemColor");
		itemColor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "itemColor", Classes.FStructProperty);
	}

	static ListViewDemoItemObject()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ListViewDemoItemObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ListViewDemoItemObject));
	}
}
