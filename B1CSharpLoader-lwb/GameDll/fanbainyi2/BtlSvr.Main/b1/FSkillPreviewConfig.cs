using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SkillPreviewConfig")]
public struct FSkillPreviewConfig
{
	public bool bDrawSweepCheckSphere;

	public bool bDrawSkillEffectArea;

	public bool bDrawBuffArea;

	public bool bDrawBulletCollision;

	public bool bDrawBulletDestroyPos;

	private static int SkillPreviewConfig_StructSize;

	private static int SkillPreviewConfig_IsValid;

	public FSkillPreviewConfig Copy()
	{
		return this;
	}

	public static FSkillPreviewConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSkillPreviewConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkillPreviewConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkillPreviewConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkillPreviewConfig(IntPtr.Add(nativeBuffer, arrayIndex * SkillPreviewConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkillPreviewConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SkillPreviewConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SkillPreviewConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillPreviewConfig");
		}
	}

	public FSkillPreviewConfig(IntPtr nativeStruct)
	{
		if (SkillPreviewConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillPreviewConfig");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SkillPreviewConfig");
		SkillPreviewConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		SkillPreviewConfig_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SkillPreviewConfig", (byte)SkillPreviewConfig_IsValid != 0);
	}

	static FSkillPreviewConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSkillPreviewConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkillPreviewConfig));
	}
}
