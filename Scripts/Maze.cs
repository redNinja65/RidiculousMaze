﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Maze : MonoBehaviour {
	
	public  IntVector2 size;


	public static Maze instance = null;

	public MazeCell cellPrefab;
	
	//public float generationStepDelay;
	
	public MazePassage passagePrefab;
	public MazeWall[] wallPrefabs;
	
	private MazeCell[,] cells;
	
	public IntVector2 RandomCoordinates {
	
		get {

			return new IntVector2(0, 18);
			//return new IntVector2(0, 0);
			}

	}


	void Awake () 
	{

		if (instance == null)	//checking that we have a game manager or not,if null then instance(GM) here,become this..that is now it is,
			instance = this;
		else if (instance != this)//if there is any other game manager then destroy that game manager,gameobject
			Destroy (gameObject);

	}


	
	public bool ContainsCoordinates (IntVector2 coordinate) {
		return coordinate.x >= 0 && coordinate.x < size.x && coordinate.z >= 0 && coordinate.z < size.z;
	}
	
	public MazeCell GetCell (IntVector2 coordinates) {
		return cells[coordinates.x, coordinates.z];
		//return cells[0,0];
	}
	
	public void Generate () {

		cells = new MazeCell[size.x, size.z];
		List<MazeCell> activeCells = new List<MazeCell>();
		DoFirstGenerationStep(activeCells);
		while (activeCells.Count > 0) {
			DoNextGenerationStep(activeCells);
		}
	}
	
	private void DoFirstGenerationStep (List<MazeCell> activeCells) {
		activeCells.Add(CreateCell(RandomCoordinates));
	}
	
	private void DoNextGenerationStep (List<MazeCell> activeCells) {
		int currentIndex = activeCells.Count - 1;
		MazeCell currentCell = activeCells[currentIndex];
		if (currentCell.IsFullyInitialized) {
			activeCells.RemoveAt(currentIndex);
			return;
		}
		MazeDirection direction = currentCell.RandomUninitializedDirection;
		IntVector2 coordinates = currentCell.coordinates + direction.ToIntVector2();
		if (ContainsCoordinates(coordinates)) {
			MazeCell neighbor = GetCell(coordinates);
			if (neighbor == null) {
				neighbor = CreateCell(coordinates);
				CreatePassage(currentCell, neighbor, direction);
				activeCells.Add(neighbor);
			}
			else {
				CreateWall(currentCell, neighbor, direction);
			}
		}
		else {
			CreateWall(currentCell, null, direction);
		}
	}
	
	private MazeCell CreateCell (IntVector2 coordinates) {
		MazeCell newCell = Instantiate(cellPrefab) as MazeCell;
		cells[coordinates.x, coordinates.z] = newCell;
		newCell.coordinates = coordinates;
		newCell.name = "Maze Cell " + coordinates.x + ", " + coordinates.z;
		newCell.transform.parent = transform;
		newCell.transform.localPosition = new Vector3(coordinates.x - size.x * 0.5f + 0.5f, 0f, coordinates.z - size.z * 0.5f + 0.5f);
		return newCell;
	}
	
	private void CreatePassage (MazeCell cell, MazeCell otherCell, MazeDirection direction) {
		MazePassage passage = Instantiate(passagePrefab) as MazePassage;
		passage.Initialize(cell, otherCell, direction);
		passage = Instantiate(passagePrefab) as MazePassage;
		passage.Initialize(otherCell, cell, direction.GetOpposite());
	}
	
	private void CreateWall (MazeCell cell, MazeCell otherCell, MazeDirection direction) {
		MazeWall wall = Instantiate(wallPrefabs[Random.Range(0, wallPrefabs.Length)]) as MazeWall;
		wall.Initialize(cell, otherCell, direction);
		if (otherCell != null) {
			wall = Instantiate(wallPrefabs[Random.Range(0, wallPrefabs.Length)]) as MazeWall;
			wall.Initialize(otherCell, cell, direction.GetOpposite());
		}
	}
}