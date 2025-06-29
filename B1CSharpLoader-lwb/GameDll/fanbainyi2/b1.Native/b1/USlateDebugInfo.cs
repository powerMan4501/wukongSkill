using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.SlateDebugInfo", "UnrealExtent", UnrealModuleType.Game)]
public class USlateDebugInfo : UUserWidget
{
	private static bool GetStatInfoInterval_IsValid;

	private static int GetStatInfoInterval_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.SlateDebugInfo:GetStatInfoInterval")]
	public float GetStatInfoInterval
	{
		get
		{
			CheckDestroyed();
			if (!GetStatInfoInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.SlateDebugInfo:GetStatInfoInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GetStatInfoInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GetStatInfoInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.SlateDebugInfo:GetStatInfoInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GetStatInfoInterval_Offset), value);
			}
		}
	}

	static USlateDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USlateDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USlateDebugInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.SlateDebugInfo");
		GetStatInfoInterval_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GetStatInfoInterval");
		GetStatInfoInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GetStatInfoInterval", Classes.FFloatProperty);
	}
}
