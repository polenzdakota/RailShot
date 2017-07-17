using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*  Interface for enemy types
**/
public interface IEnemyBehavior {
	
	void Movement();
	
	void Trigger();
	
	void OnDeath();
	
	void OnSpawn();
}
