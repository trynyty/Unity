﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SamuraiFiller
{
	[Header("Physics Attributes")]
	public float Speed = 200; 
	public float RotationSpeed = 10; 
	public float JumpForce = 5; 
	public float MaxVelocity = 1000; 
	public float DashForce = 3;
	public float DashTime = 0.5f; 
	public float AdditionalGravity = 1f; 
	public float DragFly = 1f;
	public float DragGround = 1f; 

	[Header("Specific Atrtibutes")]
	public float RotationTowardsEnnemySpeed = 1f;
	public float DodgeImpulsionStrength = 0.5f; 
	public float DodgeImpulsionDuration = 0.1f; 
	public float DodgeImpulsionDelay = 0.1f; 
	public float HitImpulsionStrength = 0.1f; 
	public float HitImpulsionDuration = 0.1f;
	public float HitImpulsionDelay = 0.1f; 

	public float HitCounter = 0.1f; 
	public float DodgeCounter = 0.1f; 


	[Header("Testing")]
	public List<ImpulsionHolder> impulsionHolder = new List<ImpulsionHolder>(); 


	[Header("Special Effects")]
	public bool UseSpecialEffects = true; 
	public List<NamedEffect> FXHolder = new List<NamedEffect>(); 


	public List <AnimationState> AnimationStates = new List<AnimationState>(); 
	public List <CharacterStates> CharacterState = new List<CharacterStates>(); 

}