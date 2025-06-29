using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.PlayerDirectionInput", "MM", UnrealModuleType.GamePlugin)]
public struct FPlayerDirectionInput
{
	private static bool CurrentRefTransform_IsValid;

	private static int CurrentRefTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/MM.PlayerDirectionInput:CurrentRefTransform")]
	public FTransform CurrentRefTransform;

	private static bool AllowedTimeOffset_IsValid;

	private static int AllowedTimeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.PlayerDirectionInput:AllowedTimeOffset")]
	public float AllowedTimeOffset;

	private static bool FPlayerDirectionInput_IsValid;

	private static int FPlayerDirectionInput_StructSize;

	public FPlayerDirectionInput Copy()
	{
		return this;
	}

	public static FPlayerDirectionInput FromNative(IntPtr nativeBuffer)
	{
		return new FPlayerDirectionInput(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPlayerDirectionInput value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPlayerDirectionInput FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPlayerDirectionInput(nativeBuffer + arrayIndex * FPlayerDirectionInput_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPlayerDirectionInput value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPlayerDirectionInput_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPlayerDirectionInput_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.PlayerDirectionInput");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, CurrentRefTransform_Offset), CurrentRefTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AllowedTimeOffset_Offset), AllowedTimeOffset);
	}

	public FPlayerDirectionInput(IntPtr nativeStruct)
	{
		if (!FPlayerDirectionInput_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.PlayerDirectionInput");
			CurrentRefTransform = default(FTransform);
			AllowedTimeOffset = 0f;
		}
		else
		{
			CurrentRefTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, CurrentRefTransform_Offset));
			AllowedTimeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AllowedTimeOffset_Offset));
		}
	}

	static FPlayerDirectionInput()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPlayerDirectionInput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPlayerDirectionInput));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.PlayerDirectionInput");
		FPlayerDirectionInput_StructSize = NativeReflection.GetStructSize(intPtr);
		CurrentRefTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentRefTransform");
		CurrentRefTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentRefTransform", Classes.FStructProperty);
		AllowedTimeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AllowedTimeOffset");
		AllowedTimeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AllowedTimeOffset", Classes.FFloatProperty);
		FPlayerDirectionInput_IsValid = intPtr != IntPtr.Zero && CurrentRefTransform_IsValid && AllowedTimeOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.PlayerDirectionInput", FPlayerDirectionInput_IsValid);
	}
}
