using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMParserASTSettings", "RigVMDeveloper", UnrealModuleType.Engine)]
public struct FRigVMParserASTSettings
{
	private static bool FRigVMParserASTSettings_IsValid;

	private static int FRigVMParserASTSettings_StructSize;

	public FRigVMParserASTSettings Copy()
	{
		return this;
	}

	public static FRigVMParserASTSettings FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMParserASTSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMParserASTSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMParserASTSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMParserASTSettings(nativeBuffer + arrayIndex * FRigVMParserASTSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMParserASTSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMParserASTSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMParserASTSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMParserASTSettings");
		}
	}

	public FRigVMParserASTSettings(IntPtr nativeStruct)
	{
		if (!FRigVMParserASTSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMParserASTSettings");
		}
	}

	static FRigVMParserASTSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMParserASTSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMParserASTSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVMDeveloper.RigVMParserASTSettings");
		FRigVMParserASTSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigVMParserASTSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/RigVMDeveloper.RigVMParserASTSettings", FRigVMParserASTSettings_IsValid);
	}
}
