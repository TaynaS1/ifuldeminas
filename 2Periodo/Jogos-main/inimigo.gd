extends CharacterBody2D

const SPEED = 50.0
var direction = -1
@onready var batevolta = $batevolta as RayCast2D

func _physics_process(delta: float) -> void:
	# Add gravity
	if not is_on_floor():
		velocity.y += get_gravity().y * delta

	if batevolta.is_colliding():
		direction *= -1
		$animacao.scale.x *= -1

	if direction:
		velocity.x = direction * SPEED
	
	move_and_slide()
