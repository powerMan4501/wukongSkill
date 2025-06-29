using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public static class UBTFunctionLibrary_CsExtensions
{
	public static void SetBlackboardValueAsVector(this UBTNode NodeOwner, FBlackboardKeySelector Key, FVector Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsVector(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsString(this UBTNode NodeOwner, FBlackboardKeySelector Key, string Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsString(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsRotator(this UBTNode NodeOwner, FBlackboardKeySelector Key, FRotator Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsRotator(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsObject(this UBTNode NodeOwner, FBlackboardKeySelector Key, UObject Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsObject(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsName(this UBTNode NodeOwner, FBlackboardKeySelector Key, FName Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsName(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsInt(this UBTNode NodeOwner, FBlackboardKeySelector Key, int Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsInt(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsFloat(this UBTNode NodeOwner, FBlackboardKeySelector Key, float Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsFloat(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsEnum(this UBTNode NodeOwner, FBlackboardKeySelector Key, byte Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsEnum(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsClass(this UBTNode NodeOwner, FBlackboardKeySelector Key, TSubclassOf<UObject> Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsClass(NodeOwner, Key, Value);
	}

	public static void SetBlackboardValueAsBool(this UBTNode NodeOwner, FBlackboardKeySelector Key, bool Value)
	{
		UBTFunctionLibrary.SetBlackboardValueAsBool(NodeOwner, Key, Value);
	}

	public static UBlackboardComponent GetOwnersBlackboard(this UBTNode NodeOwner)
	{
		return UBTFunctionLibrary.GetOwnersBlackboard(NodeOwner);
	}

	public static UBehaviorTreeComponent GetOwnerComponent(this UBTNode NodeOwner)
	{
		return UBTFunctionLibrary.GetOwnerComponent(NodeOwner);
	}

	public static FVector GetBlackboardValueAsVector(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsVector(NodeOwner, Key);
	}

	public static string GetBlackboardValueAsString(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsString(NodeOwner, Key);
	}

	public static FRotator GetBlackboardValueAsRotator(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsRotator(NodeOwner, Key);
	}

	public static UObject GetBlackboardValueAsObject(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsObject(NodeOwner, Key);
	}

	public static FName GetBlackboardValueAsName(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsName(NodeOwner, Key);
	}

	public static int GetBlackboardValueAsInt(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsInt(NodeOwner, Key);
	}

	public static float GetBlackboardValueAsFloat(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsFloat(NodeOwner, Key);
	}

	public static byte GetBlackboardValueAsEnum(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsEnum(NodeOwner, Key);
	}

	public static TSubclassOf<UObject> GetBlackboardValueAsClass(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsClass(NodeOwner, Key);
	}

	public static bool GetBlackboardValueAsBool(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsBool(NodeOwner, Key);
	}

	public static AActor GetBlackboardValueAsActor(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		return UBTFunctionLibrary.GetBlackboardValueAsActor(NodeOwner, Key);
	}

	public static void ClearBlackboardValue(this UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		UBTFunctionLibrary.ClearBlackboardValue(NodeOwner, Key);
	}
}
