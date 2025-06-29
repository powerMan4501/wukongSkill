using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PlayerStart", "Engine", UnrealModuleType.Engine)]
public class APlayerStart : ANavigationObjectBase
{
	private static bool PlayerStartTag_IsValid;

	private static int PlayerStartTag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerStart:PlayerStartTag")]
	public FName PlayerStartTag
	{
		get
		{
			CheckDestroyed();
			if (!PlayerStartTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerStart:PlayerStartTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PlayerStartTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerStartTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerStart:PlayerStartTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PlayerStartTag_Offset), value);
			}
		}
	}

	static APlayerStart()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APlayerStart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APlayerStart));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PlayerStart");
		PlayerStartTag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PlayerStartTag");
		PlayerStartTag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PlayerStartTag", Classes.FNameProperty);
	}
}
