using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimDataAsset8Dir")]
public class BUAnimDataAsset8Dir : UDataAsset
{
	private static bool AnimSeqIdle_IsValid;

	private static int AnimSeqIdle_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimDataAsset8Dir:AnimSeqIdle")]
	public UAnimSequence AnimSeqIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimSeqIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimDataAsset8Dir:AnimSeqIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimSeqIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimSeqIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimDataAsset8Dir:AnimSeqIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimSeqIdle_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimDataAsset8Dir");
		AnimSeqIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimSeqIdle");
		AnimSeqIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimSeqIdle", Classes.FObjectProperty);
	}

	static BUAnimDataAsset8Dir()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimDataAsset8Dir)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimDataAsset8Dir));
	}
}
