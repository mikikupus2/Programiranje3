extends KinematicBody2D

var speed = 700
var velocity = Vector2.ZERO
var gravity = 20
var dir = 0
var jump = -400
func _physics_process(delta):
	var levo = int(Input.is_action_pressed("levo"))
	var desno = int(Input.is_action_pressed("desno"))
	var dir = desno-levo	
	velocity.x = dir*speed

	if is_on_ceiling():
		velocity.y = velocity.y-1
	if is_on_ceiling():
		if Input.is_action_pressed("dole"):
					velocity.y += gravity
	else:
		velocity.y += gravity
	if is_on_floor():
		velocity.y = 0
		if Input.is_action_pressed("jump"):
			velocity.y = jump
	move_and_slide(velocity,Vector2.UP)


func _on_Area2D_body_entered(body):
	get_tree().reload_current_scene()
