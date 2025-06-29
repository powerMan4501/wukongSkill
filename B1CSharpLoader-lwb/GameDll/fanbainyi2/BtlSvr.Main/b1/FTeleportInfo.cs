using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FTeleportInfo
{
	public FName TeleportID { get; set; }

	public bool bUseTeleportRotation { get; set; }

	public FVector Location { get; set; }

	public FRotator Rotation { get; set; }

	public bool bOverrideLevelStreamingVolume { get; set; }

	public bool bEnsureRequireLevel { get; set; }

	public List<FName> RequireLevelNames { get; } = new List<FName>();

	public bool IsAsyncLoading { get; set; }

	public override string ToString()
	{
		return $"Teleport ID: {TeleportID}\n" + $"bUseTeleportRotation: {bUseTeleportRotation}" + $"Location: {Location}\n" + $"Rotation: {Rotation}\n" + $"bOverrideLevelStreamingVolume: {bOverrideLevelStreamingVolume}\n" + $"bEnsureRequireLevel: {bEnsureRequireLevel}\n" + "RequireLevelNames: " + string.Join(", ", RequireLevelNames) + "\n" + $"IsAsyncLoading: {IsAsyncLoading}";
	}
}
