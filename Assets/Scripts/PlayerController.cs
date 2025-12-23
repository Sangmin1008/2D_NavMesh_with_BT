using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	private	MovementRigidbody2D	_movement2D;
	private PlayerAction _input;
	
	public Vector2 MoveInput { get; private set; }

	private void Awake()
	{
		_movement2D = GetComponent<MovementRigidbody2D>();
		_input = new PlayerAction();
	}

	private void OnEnable()
	{
		_input.Enable();
		
		_input.Player.Move.performed += ctx => MoveInput = ctx.ReadValue<Vector2>();
		_input.Player.Move.canceled += ctx => MoveInput = Vector2.zero;
	}

	private void OnDisable()
	{
		_input.Disable();
	}

	private void Update()
	{
		_movement2D.MoveTo(MoveInput);
	}
}

