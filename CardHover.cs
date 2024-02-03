using Godot;
using System;

public partial class CardHover : Area3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("sussy");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	



private void _on_mouse_entered()
{
	// Replace with function body.
	GD.Print("sussy");
}


private void _on_mouse_exited()
{
	// Replace with function body.
	Console.Write("baka");
}
}
