using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MatchResults", "MM", UnrealModuleType.GamePlugin)]
public struct FMatchResults
{
	private static bool PlayersInputData_IsValid;

	private static int PlayersInputData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MM.MatchResults:PlayersInputData")]
	public FInputPlayerDirectionData PlayersInputData;

	private static bool PlayersPredictedInputData_IsValid;

	private static int PlayersPredictedInputData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MM.MatchResults:PlayersPredictedInputData")]
	public FInputPlayerDirectionData PlayersPredictedInputData;

	private static bool FMatchResults_IsValid;

	private static int FMatchResults_StructSize;

	public FMatchResults Copy()
	{
		return this;
	}

	public static FMatchResults FromNative(IntPtr nativeBuffer)
	{
		return new FMatchResults(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMatchResults value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMatchResults FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMatchResults(nativeBuffer + arrayIndex * FMatchResults_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMatchResults value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMatchResults_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMatchResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MatchResults");
			return;
		}
		FInputPlayerDirectionData.ToNative(IntPtr.Add(nativeStruct, PlayersInputData_Offset), PlayersInputData);
		FInputPlayerDirectionData.ToNative(IntPtr.Add(nativeStruct, PlayersPredictedInputData_Offset), PlayersPredictedInputData);
	}

	public FMatchResults(IntPtr nativeStruct)
	{
		if (!FMatchResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MatchResults");
			PlayersInputData = default(FInputPlayerDirectionData);
			PlayersPredictedInputData = default(FInputPlayerDirectionData);
		}
		else
		{
			PlayersInputData = FInputPlayerDirectionData.FromNative(IntPtr.Add(nativeStruct, PlayersInputData_Offset));
			PlayersPredictedInputData = FInputPlayerDirectionData.FromNative(IntPtr.Add(nativeStruct, PlayersPredictedInputData_Offset));
		}
	}

	static FMatchResults()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMatchResults)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMatchResults));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MatchResults");
		FMatchResults_StructSize = NativeReflection.GetStructSize(intPtr);
		PlayersInputData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayersInputData");
		PlayersInputData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayersInputData", Classes.FStructProperty);
		PlayersPredictedInputData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayersPredictedInputData");
		PlayersPredictedInputData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayersPredictedInputData", Classes.FStructProperty);
		FMatchResults_IsValid = intPtr != IntPtr.Zero && PlayersInputData_IsValid && PlayersPredictedInputData_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MatchResults", FMatchResults_IsValid);
	}
}
