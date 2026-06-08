## Godot Classic color showcase (GDScript) — illustrative, not functional code.
class_name Player
extends CharacterBody2D

signal example_signal(old_value: int, new_value: int)
enum State { IDLE, RUNNING, DEAD }

const MAX_HEALTH: int = 100
@export var speed: float = 220.5
@export var hud_path: NodePath = ^"../UI/HUD"
@onready var sprite: Sprite2D = $Sprite2D
@onready var hud := get_node_or_null(hud_path)

var state: State = State.IDLE
var health := MAX_HEALTH
var alive := true
var target: Node2D = null
var inventory: Array[String] = ["sword", "shield"]


func _ready() -> void:
	add_to_group(&"players")
	print("Spawned with %d HP\n" % health)


func example_function(amount: int) -> void:
	# Clamp health, then notify listeners
	var previous := health
	health = maxi(0, health - amount)
	example_signal.emit(previous, health)

	if health <= 0:
		alive = false
		state = State.DEAD
		return
	elif health < 25:
		push_warning("Low health: %d\n" % health)

	for index in range(inventory.size()):
		print("slot %d: %s\t" % [index, inventory[index]])
