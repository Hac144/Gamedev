//using Godot;
//using System;
//
//public partial class Slime : Node2D
//{
	//private const float SPEED = 60f;
//
	//public override void _Process(double delta)
	//{
		//Position += new Vector2(direction * (float)(SPEED * delta), 0);
	//}
//}
//using Godot;
//using System;
//
//public partial class Slime : Node2D
//{
	//private const float SPEED = 60f;
	//private int$RayCastRight direction = 1; 
//$RayCastLeft
	//public override void _Process(double delta)
	//{
		//Position += new Vector2(direction * (float)(SPEED * delta), 0);
	//}
//}
//using Godot;
//using System;
//
//public partial class Slime : Node2D
//{
	//private const float SPEED = 60f;
	//private int direction = 1;
//
	//private RayCast2D RayCastRight;   // ✅ added
	//private RayCast2D RayCastLeft;    // ✅ added
//$AnimatedSprite2D
	//public override void _Ready()
	//{
		//RayCastRight = GetNode<RayCast2D>("RayCastRight");   // ✅ added
		//RayCastLeft = GetNode<RayCast2D>("RayCastLeft");     // ✅ added
	//}
//
	//public override void _Process(double delta)
	//{
		//if ray_cost_right.is_colliding():
			//direction =-1
		//if ray_cast_left.is_colloding():
			//direction =1
		//Position += new Vector2(direction * (float)(SPEED * delta), 0);
	//}
//}
using Godot;
using System;

public partial class Slime : Node2D
{
	private const float SPEED = 60f;
	private int direction = 1;

	private RayCast2D RayCastRight;
	private RayCast2D RayCastLeft;
	private AnimatedSprite2D AnimatedSprite2D;

	public override void _Ready()
	{
		RayCastRight = GetNode<RayCast2D>("RayCastRight");
		RayCastLeft = GetNode<RayCast2D>("RayCastLeft");
		AnimatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _Process(double delta)
	{
		if (RayCastRight.IsColliding())
		{
			direction = -1;
			AnimatedSprite2D.FlipH = true;   // ✅ fixed
		}

		if (RayCastLeft.IsColliding())
		{
			direction = 1;
			AnimatedSprite2D.FlipH = false;  // ✅ fixed
		}

		Position += new Vector2(direction * (float)(SPEED * delta), 0);
	}
}
