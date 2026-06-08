//! Godot Classic color showcase (godot-rust) — illustrative, not functional code.
use godot::classes::CharacterBody2D;
use godot::prelude::*;

const MAX_HEALTH: i32 = 100;

/// A player with health and movement.
#[derive(GodotClass)]
#[class(base = CharacterBody2D)]
pub struct Player {
    #[export]
    speed: f32,
    #[var]
    health: i32,
    alive: bool,
    inventory: Vec<GString>,
    base: Base<CharacterBody2D>,
}

#[godot_api]
impl Player {
    #[signal]
    fn example_signal(old_value: i32, new_value: i32);

    #[func]
    fn example_function(&mut self, amount: i32) {
        // Clamp health, then notify listeners
        let previous = self.health;
        self.health = (self.health - amount).max(0);
        self.signals().example_signal().emit(previous, self.health);

        if self.health <= 0 {
            self.alive = false;
            godot_warn!("Player died\n");
            return;
        }

        for (index, item) in self.inventory.iter().enumerate() {
            godot_print!("slot {index}: {item}\t");
        }
    }
}
