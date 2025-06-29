using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.ScreenshotFunctionalTest", "FunctionalTesting", UnrealModuleType.Engine)]
public class AScreenshotFunctionalTest : AScreenshotFunctionalTestBase
{
	private static bool CameraCutOnScreenshotPrep_IsValid;

	private static FFieldAddress CameraCutOnScreenshotPrep_PropertyAddress;

	private static int CameraCutOnScreenshotPrep_Offset;

	[UProperty(Flags = (PropFlags)6757668257530373uL)]
	[UMetaPath("/Script/FunctionalTesting.ScreenshotFunctionalTest:bCameraCutOnScreenshotPrep")]
	public bool CameraCutOnScreenshotPrep
	{
		get
		{
			CheckDestroyed();
			if (!CameraCutOnScreenshotPrep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTest:bCameraCutOnScreenshotPrep");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CameraCutOnScreenshotPrep_Offset), 0, CameraCutOnScreenshotPrep_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraCutOnScreenshotPrep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTest:bCameraCutOnScreenshotPrep");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CameraCutOnScreenshotPrep_Offset), 0, CameraCutOnScreenshotPrep_PropertyAddress.Address, value);
			}
		}
	}

	static AScreenshotFunctionalTest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AScreenshotFunctionalTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AScreenshotFunctionalTest));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FunctionalTesting.ScreenshotFunctionalTest");
		NativeReflectionCached.GetPropertyRef(ref CameraCutOnScreenshotPrep_PropertyAddress, unrealStruct, "bCameraCutOnScreenshotPrep");
		CameraCutOnScreenshotPrep_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCameraCutOnScreenshotPrep");
		CameraCutOnScreenshotPrep_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCameraCutOnScreenshotPrep", Classes.FBoolProperty);
	}
}
