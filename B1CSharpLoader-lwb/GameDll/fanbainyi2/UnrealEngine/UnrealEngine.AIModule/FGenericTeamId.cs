using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.GenericTeamId", "AIModule", UnrealModuleType.Engine)]
public struct FGenericTeamId
{
	private static bool TeamID_IsValid;

	private static int TeamID_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/AIModule.GenericTeamId:TeamID")]
	public byte TeamID;

	private static bool FGenericTeamId_IsValid;

	private static int FGenericTeamId_StructSize;

	public FGenericTeamId Copy()
	{
		return this;
	}

	public static FGenericTeamId FromNative(IntPtr nativeBuffer)
	{
		return new FGenericTeamId(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGenericTeamId value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGenericTeamId FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGenericTeamId(nativeBuffer + arrayIndex * FGenericTeamId_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGenericTeamId value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGenericTeamId_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGenericTeamId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.GenericTeamId");
		}
		else
		{
			BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, TeamID_Offset), TeamID);
		}
	}

	public FGenericTeamId(IntPtr nativeStruct)
	{
		if (!FGenericTeamId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.GenericTeamId");
			TeamID = 0;
		}
		else
		{
			TeamID = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, TeamID_Offset));
		}
	}

	static FGenericTeamId()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGenericTeamId)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGenericTeamId));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.GenericTeamId");
		FGenericTeamId_StructSize = NativeReflection.GetStructSize(intPtr);
		TeamID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeamID");
		TeamID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeamID", Classes.FByteProperty);
		FGenericTeamId_IsValid = intPtr != IntPtr.Zero && TeamID_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.GenericTeamId", FGenericTeamId_IsValid);
	}
}
