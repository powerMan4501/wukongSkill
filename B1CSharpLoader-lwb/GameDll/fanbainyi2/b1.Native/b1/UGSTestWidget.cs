using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSTestWidget", "UnrealExtent", UnrealModuleType.Game)]
public class UGSTestWidget : UUserWidget
{
	private static bool TestNum_IsValid;

	private static int TestNum_Offset;

	private static bool TestImage_IsValid;

	private static int TestImage_Offset;

	private static bool TestAudioEvent_IsValid;

	private static int TestAudioEvent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSTestWidget:TestNum")]
	public int TestNum
	{
		get
		{
			CheckDestroyed();
			if (!TestNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTestWidget:TestNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TestNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTestWidget:TestNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TestNum_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/UnrealExtent.GSTestWidget:TestImage")]
	public UImage TestImage
	{
		get
		{
			CheckDestroyed();
			if (!TestImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTestWidget:TestImage");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, TestImage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTestWidget:TestImage");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, TestImage_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSTestWidget:TestAudioEvent")]
	public UAkAudioEvent TestAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!TestAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTestWidget:TestAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, TestAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTestWidget:TestAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, TestAudioEvent_Offset), value);
			}
		}
	}

	static UGSTestWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSTestWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSTestWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSTestWidget");
		TestNum_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TestNum");
		TestNum_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TestNum", Classes.FIntProperty);
		TestImage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TestImage");
		TestImage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TestImage", Classes.FObjectProperty);
		TestAudioEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TestAudioEvent");
		TestAudioEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TestAudioEvent", Classes.FObjectProperty);
	}
}
