using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class UBGUFunctionLibrary_CsExtensions
{
	public static ACharacter GetPlayerCharacter(this UWorld WorldContextObject)
	{
		return UBGUFunctionLibrary.GetPlayerCharacter(WorldContextObject);
	}

	public static void DrawDebugString(this UWorld WorldContextObject, FVector TextLocation, string Text, AActor TestBaseActor, FLinearColor TextColor, float Duration)
	{
		UBGUFunctionLibrary.DrawDebugString(WorldContextObject, TextLocation, Text, TestBaseActor, TextColor, Duration);
	}
}
