using Godot;
using System;

[GlobalClass]
public partial class SkillNode : Node
{
	[Export]
	// Limit setting to true only if all requirements are met. Use a custom setter and/or a method
	public bool Active { get; set; }

	[Export]
	public Godot.Collections.Array<SkillNode> Requirements { get; set; }
}
