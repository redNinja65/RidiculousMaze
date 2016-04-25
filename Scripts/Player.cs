using UnityEngine;

public class Player : MonoBehaviour {

	private MazeCell currentCell;

	private MazeDirection currentDirection;


	public void SetLocation (MazeCell cell) {
		currentCell = cell;
		transform.localPosition = cell.transform.localPosition;

	}

	private void Move (MazeDirection direction) {
		MazeCellEdge edge = currentCell.GetEdge(direction);
		if (edge is MazePassage) {
			SetLocation(edge.otherCell);
		}
	}

	private void Look (MazeDirection direction) {
		transform.localRotation = direction.ToRotation();
		currentDirection = direction;
	}

	private void Update () {
		if (Input.GetKeyDown(KeyCode.W)) {
			Move(currentDirection);
		}


	}
} 