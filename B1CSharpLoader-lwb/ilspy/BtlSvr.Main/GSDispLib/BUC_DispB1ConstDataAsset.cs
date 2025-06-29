using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispB1ConstDataAsset")]
public class BUC_DispB1ConstDataAsset : BGW_DispLibConstDataAsset
{
	private static bool DBCDefaultCamOffset_IsValid;

	private static int DBCDefaultCamOffset_Offset;

	[DisplayName("朝向摄像机偏移值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispB1ConstDataAsset:DBCDefaultCamOffset")]
	public float DBCDefaultCamOffset
	{
		get
		{
			CheckDestroyed();
			if (!DBCDefaultCamOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispB1ConstDataAsset:DBCDefaultCamOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCDefaultCamOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCDefaultCamOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispB1ConstDataAsset:DBCDefaultCamOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCDefaultCamOffset_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_DispB1ConstDataAsset");
		DBCDefaultCamOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCDefaultCamOffset");
		DBCDefaultCamOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCDefaultCamOffset", Classes.FFloatProperty);
	}

	static BUC_DispB1ConstDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispB1ConstDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispB1ConstDataAsset));
	}
}
