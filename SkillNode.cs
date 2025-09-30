using Godot;
using System;

[GlobalClass]
public partial class SkillNode : Node
{
	[Export]
	public Godot.Collections.Array<SkillNode> Requirements { get; set; }
}
