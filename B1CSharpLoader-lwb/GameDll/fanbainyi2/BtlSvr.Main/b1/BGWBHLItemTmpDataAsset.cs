using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWBHLItemTmpDataAsset")]
public class BGWBHLItemTmpDataAsset : UBGWDataAsset
{
	private static bool JTItemNumMax_IsValid;

	private static int JTItemNumMax_Offset;

	private static bool JHItemId_IsValid;

	private static int JHItemId_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("祭坛储存精华数量上限")]
	[USharpPath("/Script/b1-Managed.BGWBHLItemTmpDataAsset:JTItemNumMax")]
	public int JTItemNumMax
	{
		get
		{
			CheckDestroyed();
			if (!JTItemNumMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBHLItemTmpDataAsset:JTItemNumMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JTItemNumMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JTItemNumMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBHLItemTmpDataAsset:JTItemNumMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JTItemNumMax_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("精华道具Id")]
	[USharpPath("/Script/b1-Managed.BGWBHLItemTmpDataAsset:JHItemId")]
	public int JHItemId
	{
		get
		{
			CheckDestroyed();
			if (!JHItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBHLItemTmpDataAsset:JHItemId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JHItemId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JHItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBHLItemTmpDataAsset:JHItemId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JHItemId_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWBHLItemTmpDataAsset");
		JTItemNumMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JTItemNumMax");
		JTItemNumMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JTItemNumMax", Classes.FIntProperty);
		JHItemId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JHItemId");
		JHItemId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JHItemId", Classes.FIntProperty);
	}

	static BGWBHLItemTmpDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWBHLItemTmpDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWBHLItemTmpDataAsset));
	}
}
