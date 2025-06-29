using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

public static class UAutomationLibrary_CsExtensions
{
	public static void TakeAutomationScreenshotOfUI(this UWorld WorldContextObject, FLatentActionInfo LatentInfo, string Name, FAutomationScreenshotOptions Options)
	{
		UAutomationLibrary.TakeAutomationScreenshotOfUI(WorldContextObject, LatentInfo, Name, Options);
	}

	public static void TakeAutomationScreenshotAtCamera(this UWorld WorldContextObject, FLatentActionInfo LatentInfo, ACameraActor Camera, string NameOverride, string Notes, FAutomationScreenshotOptions Options)
	{
		UAutomationLibrary.TakeAutomationScreenshotAtCamera(WorldContextObject, LatentInfo, Camera, NameOverride, Notes, Options);
	}

	public static void TakeAutomationScreenshot(this UWorld WorldContextObject, FLatentActionInfo LatentInfo, string Name, string Notes, FAutomationScreenshotOptions Options)
	{
		UAutomationLibrary.TakeAutomationScreenshot(WorldContextObject, LatentInfo, Name, Notes, Options);
	}

	public static void SetScalabilityQualityToLow(this UWorld WorldContextObject)
	{
		UAutomationLibrary.SetScalabilityQualityToLow(WorldContextObject);
	}

	public static void SetScalabilityQualityToEpic(this UWorld WorldContextObject)
	{
		UAutomationLibrary.SetScalabilityQualityToEpic(WorldContextObject);
	}

	public static void SetScalabilityQualityLevelRelativeToMax(this UWorld WorldContextObject, int Value = 1)
	{
		UAutomationLibrary.SetScalabilityQualityLevelRelativeToMax(WorldContextObject, Value);
	}

	public static void EnableStatGroup(this UWorld WorldContextObject, FName GroupName)
	{
		UAutomationLibrary.EnableStatGroup(WorldContextObject, GroupName);
	}

	public static void DisableStatGroup(this UWorld WorldContextObject, FName GroupName)
	{
		UAutomationLibrary.DisableStatGroup(WorldContextObject, GroupName);
	}

	public static bool CompareImageAgainstReference(this UWorld WorldContextObject, string ImageFilePath, string ComparisonName, EComparisonTolerance ComparisonTolerance, string ComparisonNotes)
	{
		return UAutomationLibrary.CompareImageAgainstReference(ImageFilePath, ComparisonName, ComparisonTolerance, ComparisonNotes, WorldContextObject);
	}

	public static void AutomationWaitForLoading(this UWorld WorldContextObject, FLatentActionInfo LatentInfo, FAutomationWaitForLoadingOptions Options)
	{
		UAutomationLibrary.AutomationWaitForLoading(WorldContextObject, LatentInfo, Options);
	}
}
