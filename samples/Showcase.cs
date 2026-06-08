// Godot Classic color showcase (C#) — illustrative, not functional code.
// Shows every color the C# grammar can emit.
using System.Collections.Generic;
using Godot;

namespace Game.Entities;

#region Types
public enum State { Idle, Running, Dead }
#endregion

/// <summary>
/// A player with health and movement.
/// </summary>
[GlobalClass]
public partial class Player : CharacterBody2D
{
    private const int MaxHealth = 100;

    [Signal] public delegate void ExampleSignalEventHandler(int oldValue, int newValue);
    [Export] public float Speed { get; set; } = 220.5f;

    private State _state = State.Idle;
    private int _health = MaxHealth;
    private bool _alive = true;
    private Node2D _target = null;
    private readonly List<string> _inventory = new() { "sword", "shield" };

    public void ExampleFunction(int amount)
    {
        // Clamp health, then notify listeners
        int previous = _health;
        _health = Mathf.Max(0, _health - amount);
        EmitSignal(SignalName.ExampleSignal, previous, _health);

        if (_health <= 0)
        {
            _alive = false;
            _state = State.Dead;
            return;
        }
        else if (_health < 25)
            GD.Print($"Low health: {_health}\n");

#if DEBUG
        for (int i = 0; i < _inventory.Count; i++)
            GD.Print($"slot {i}: {_inventory[i]}\t");
#endif
    }
}
