using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.GameState", "Engine", UnrealModuleType.Engine)]
public class AGameState : AGameStateBase
{
	private static bool MatchState_IsValid;

	private static int MatchState_Offset;

	private static bool PreviousMatchState_IsValid;

	private static int PreviousMatchState_Offset;

	private static bool ElapsedTime_IsValid;

	private static int ElapsedTime_Offset;

	[UProperty(Flags = (PropFlags)11267869249767989uL)]
	[UMetaPath("/Script/Engine.GameState:MatchState")]
	protected FName MatchState
	{
		get
		{
			CheckDestroyed();
			if (!MatchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameState:MatchState");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MatchState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameState:MatchState");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MatchState_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954800661uL)]
	[UMetaPath("/Script/Engine.GameState:PreviousMatchState")]
	protected FName PreviousMatchState
	{
		get
		{
			CheckDestroyed();
			if (!PreviousMatchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameState:PreviousMatchState");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PreviousMatchState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviousMatchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameState:PreviousMatchState");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PreviousMatchState_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755473529242164uL)]
	[UMetaPath("/Script/Engine.GameState:ElapsedTime")]
	public int ElapsedTime
	{
		get
		{
			CheckDestroyed();
			if (!ElapsedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameState:ElapsedTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ElapsedTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ElapsedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameState:ElapsedTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ElapsedTime_Offset), value);
			}
		}
	}

	static AGameState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGameState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGameState));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.GameState");
		MatchState_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MatchState");
		MatchState_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MatchState", Classes.FNameProperty);
		PreviousMatchState_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreviousMatchState");
		PreviousMatchState_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreviousMatchState", Classes.FNameProperty);
		ElapsedTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ElapsedTime");
		ElapsedTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ElapsedTime", Classes.FIntProperty);
	}
}
