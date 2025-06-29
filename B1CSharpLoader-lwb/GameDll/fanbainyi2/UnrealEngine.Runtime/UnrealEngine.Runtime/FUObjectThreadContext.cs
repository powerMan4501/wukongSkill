using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FUObjectThreadContext
{
	public static bool IsInConstructor => Native_FUObjectThreadContext.Get_IsInConstructor() != 0;

	public static int IsInConstructorCount => Native_FUObjectThreadContext.Get_IsInConstructor();

	public static UObject ConstructedObject => GCHelper.Find<UObject>(Native_FUObjectThreadContext.Get_ConstructedObject());

	public static UObject SerializedObject => GCHelper.Find<UObject>(Native_FUObjectThreadContext.Get_SerializedObject());

	public static void PopInitializer()
	{
		Native_FUObjectThreadContext.PopInitializer();
	}

	public static void PushInitializer(FObjectInitializer initializer)
	{
		Native_FUObjectThreadContext.PushInitializer(initializer.Address);
	}

	public static FObjectInitializer TopInitializer()
	{
		return new FObjectInitializer(Native_FUObjectThreadContext.TopInitializer());
	}
}
