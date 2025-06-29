using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_PlayEverySequence")]
internal class AutoTest_PlayEverySequence : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		List<int> mapIDs = new List<int> { BGUFuncLibMap.GetCurLevelId(base.WorldContext) };
		StateStack.Push(new AutoTestNodeLib.TestState_PlayEverySequence(base.WorldContext, mapIDs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_PlayEverySequence");
	}

	static AutoTest_PlayEverySequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_PlayEverySequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_PlayEverySequence));
	}
}
