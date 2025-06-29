using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUSpiderMovementComponent", "b1", UnrealModuleType.Game)]
public class UBGUSpiderMovementComponent : UBGUCharacterMovementComponent
{
	private static bool IsOnPlatform_IsValid;

	private static FFieldAddress IsOnPlatform_PropertyAddress;

	private static int IsOnPlatform_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpiderMovementComponent:bIsOnPlatform")]
	public bool IsOnPlatform
	{
		get
		{
			CheckDestroyed();
			if (!IsOnPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpiderMovementComponent:bIsOnPlatform");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOnPlatform_Offset), 0, IsOnPlatform_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOnPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpiderMovementComponent:bIsOnPlatform");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOnPlatform_Offset), 0, IsOnPlatform_PropertyAddress.Address, value);
			}
		}
	}

	static UBGUSpiderMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUSpiderMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUSpiderMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGUSpiderMovementComponent");
		NativeReflectionCached.GetPropertyRef(ref IsOnPlatform_PropertyAddress, unrealStruct, "bIsOnPlatform");
		IsOnPlatform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsOnPlatform");
		IsOnPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsOnPlatform", Classes.FBoolProperty);
	}
}
