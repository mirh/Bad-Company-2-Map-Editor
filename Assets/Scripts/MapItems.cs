﻿using UnityEngine;
using System.Collections;


public class MapItems : MonoBehaviour {
	
	public GameObject emptyGO;
	public GameObject dataholder;
	bool isstarted;
	GameObject go1;
	GameObject go2;
	GameObject go3;
	GameObject go4;
	GameObject go5;
	GameObject go6;
	GameObject go7;
	GameObject go8;
	GameObject go9;
	GameObject go10;
	GameObject go11;
	GameObject go12;
	GameObject go13;
	GameObject go14;
	GameObject go15;
	GameObject go16;
	GameObject go17;
	GameObject go18;
	GameObject go19;
	GameObject go20;
	GameObject go21;
	GameObject go22;
	GameObject go23;
	GameObject go24;
	GameObject go25;
	GameObject go26;
	GameObject go27;
	GameObject go28;
	GameObject go29;
	GameObject go30;
	GameObject go31;
	GameObject go32;
	GameObject go33;
	GameObject go34;
	GameObject go35;
	GameObject go36;
	GameObject go37;
	GameObject go38;
	GameObject go39;
	GameObject go40;
	GameObject go41;
	GameObject go42;
	GameObject go43;
	GameObject go44;
	GameObject go45;
	GameObject go46;
	GameObject go47;
	GameObject go48;
	GameObject go49;
	GameObject go50;
	GameObject go51;
	GameObject go52;
	GameObject go53;
	GameObject go54;
	GameObject go55;
	GameObject go56;
	GameObject go57;
	GameObject go58;
	GameObject go59;
	GameObject go60;
	GameObject go61;
	GameObject go62;
	GameObject go63;
	GameObject go64;
	GameObject go65;
	GameObject go66;
	GameObject go67;
	GameObject go68;
	GameObject go69;
	GameObject go70;

	
	void Inst() {
		go1 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go1.name = "Entity.AreaGeometryEntityData";
		go1.transform.parent = dataholder.transform;
		
		go2 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go2.name = "Entity.ObjectSet";
		go2.transform.parent = dataholder.transform;
		
		go3 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go3.name = "Entity.PingPongRotationVisualTransformModifierData";
		go3.transform.parent = dataholder.transform;
		
		go4 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go4.name = "Entity.ReferenceObjectData";
		go4.transform.parent = dataholder.transform;
		
		go5 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go5.name = "Entity.SequenceData";
		go5.transform.parent = dataholder.transform;
		
		go6 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go6.name = "Entity.WorldObjectListData";
		go6.transform.parent = dataholder.transform;
		
		go7 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go7.name = "GameSharedResources.AlternateSpawnEntityData";
		go7.transform.parent = dataholder.transform;
		
		go8 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go8.name = "GameSharedResources.ArmDisarmAwardEntityData";
		go8.transform.parent = dataholder.transform;
		
		go9 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go9.name = "GameSharedResources.AutoTeamEntityData";
		go9.transform.parent = dataholder.transform;
		
		go10 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go10.name = "GameSharedResources.CapturePointEntityData";
		go10.transform.parent = dataholder.transform;
		
		go11 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go11.name = "GameSharedResources.ChaseCameraData";
		go11.transform.parent = dataholder.transform;
		
		go12 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go12.name = "GameSharedResources.ClearAreaTriggerEntityData";
		go12.transform.parent = dataholder.transform;
		
		go13 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go13.name = "GameSharedResources.CombatAreaTriggerEntityData";
		go13.transform.parent = dataholder.transform;
		
		go14 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go14.name = "GameSharedResources.CutsceneCameraEntityData";
		go14.transform.parent = dataholder.transform;
		
		go15 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go15.name = "GameSharedResources.CutsceneEntityCameraData";
		go15.transform.parent = dataholder.transform;
		
		go16 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go16.name = "GameSharedResources.CutsceneEntityData";
		go16.transform.parent = dataholder.transform;
		
		go17 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go17.name = "GameSharedResources.CutsceneEntityScreenFadeData";
		go17.transform.parent = dataholder.transform;
		
		go18 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go18.name = "GameSharedResources.CutsceneObjectEntityData";
		go18.transform.parent = dataholder.transform;
		
		go19 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go19.name = "GameSharedResources.CutsceneVehicleEntityData";
		go19.transform.parent = dataholder.transform;
		
		go20 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go20.name = "GameSharedResources.DamageAreaTriggerEntityData";
		go20.transform.parent = dataholder.transform;
		
		go21 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go21.name = "GameSharedResources.DelayTriggerEntityData";
		go21.transform.parent = dataholder.transform;
		
		go22 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go22.name = "GameSharedResources.EventSplitterEntityData";
		go22.transform.parent = dataholder.transform;
		
		go23 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go23.name = "GameSharedResources.ForestEntityData";
		go23.transform.parent = dataholder.transform;
		
		go24 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go24.name = "GameSharedResources.GameEffectEntityData";
		go24.transform.parent = dataholder.transform;
		
		go25 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go25.name = "GameSharedResources.GameInteractionEntityData";
		go25.transform.parent = dataholder.transform;
		
		go26 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go26.name = "GameSharedResources.GameSoundEntityData";
		go26.transform.parent = dataholder.transform;
		
		go27 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go27.name = "GameSharedResources.HumanPlayerEntityData";
		go27.transform.parent = dataholder.transform;
		
		go28 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go28.name = "GameSharedResources.InputRestrictionEntityData";
		go28.transform.parent = dataholder.transform;
		
		go29 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go29.name = "GameSharedResources.LevelData";
		go29.transform.parent = dataholder.transform;
		
		go30 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go30.name = "GameSharedResources.LifeCounterEntityData";
		go30.transform.parent = dataholder.transform;
		
		go31 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go31.name = "GameSharedResources.MapMarkerEntityData";
		go31.transform.parent = dataholder.transform;
		
		go32 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go32.name = "GameSharedResources.MenuEntityData";
		go32.transform.parent = dataholder.transform;
		
		go33 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go33.name = "GameSharedResources.MessageEntityData";
		go33.transform.parent = dataholder.transform;
		
		go34 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go34.name = "GameSharedResources.MiddlegrowthModelGroupEntityData";
		go34.transform.parent = dataholder.transform;
		
		go35 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go35.name = "GameSharedResources.MiddlegrowthModelGroupMemberData";
		go35.transform.parent = dataholder.transform;
		
		go36 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go36.name = "GameSharedResources.MissionEntityData";
		go36.transform.parent = dataholder.transform;
		
		go37 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go37.name = "GameSharedResources.MissionObjectiveEntityData";
		go37.transform.parent = dataholder.transform;
		
		go38 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go38.name = "GameSharedResources.MultipleTriggerEntityData";
		go38.transform.parent = dataholder.transform;
		
		go39 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go39.name = "GameSharedResources.PredestructionEntityData";
		go39.transform.parent = dataholder.transform;
		
		go40 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go40.name = "GameSharedResources.PreRoundEntityData";
		go40.transform.parent = dataholder.transform;
		
		go41 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go41.name = "GameSharedResources.RichPresenceConnection";
		go41.transform.parent = dataholder.transform;
		
		go42 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go42.name = "GameSharedResources.SoldierSpawnEntityData";
		go42.transform.parent = dataholder.transform;
		
		go43 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go43.name = "GameSharedResources.SoundAreaEntityData";
		go43.transform.parent = dataholder.transform;
		
		go44 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go44.name = "GameSharedResources.SpectateEntityData";
		go44.transform.parent = dataholder.transform;
		
		go45 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go45.name = "GameSharedResources.SquadData";
		go45.transform.parent = dataholder.transform;
		
		go46 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go46.name = "GameSharedResources.StatEventTriggerEntityData";
		go46.transform.parent = dataholder.transform;
		
		go47 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go47.name = "GameSharedResources.StaticModelGroupEntityData";
		go47.transform.parent = dataholder.transform;
		
		go48 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go48.name = "GameSharedResources.StaticModelGroupMemberData";
		go48.transform.parent = dataholder.transform;
		
		go49 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go49.name = "GameSharedResources.StaticModelTriggerEntityData";
		go49.transform.parent = dataholder.transform;
		
		go50 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go50.name = "GameSharedResources.StaticPositionEntityData";
		go50.transform.parent = dataholder.transform;
		
		go51 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go51.name = "GameSharedResources.TeamEntityData";
		go51.transform.parent = dataholder.transform;
		
		go52 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go52.name = "GameSharedResources.TerrainEntityData";
		go52.transform.parent = dataholder.transform;
		
		go53 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go53.name = "GameSharedResources.TreeMemberData";
		go53.transform.parent = dataholder.transform;
		
		go54 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go54.name = "GameSharedResources.VehicleSpawnEntityData";
		go54.transform.parent = dataholder.transform;
		
		go55 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go55.name = "GameSharedResources.VehicleStateTriggerEntityData";
		go55.transform.parent = dataholder.transform;
		
		go56 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go56.name = "GameSharedResources.VoiceOverEntityData";
		go56.transform.parent = dataholder.transform;
		
		go57 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go57.name = "GameSharedResources.VoiceOverLineAsset";
		go57.transform.parent = dataholder.transform;
		
		go58 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go58.name = "GameSharedResources.WeatherStateEntityData";
		go58.transform.parent = dataholder.transform;
		
		go59 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go59.name = "Overgrowth.TreeMeshEntityData";
		go59.transform.parent = dataholder.transform;
		
		go60 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go60.name = "Physics.HavokAsset";
		go60.transform.parent = dataholder.transform;
		
		go61 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go61.name = "Physics.PhysicsEntityData";
		go61.transform.parent = dataholder.transform;
		
		go62 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go62.name = "Render.CrtAnalogLinkHudFxData";
		go62.transform.parent = dataholder.transform;
		
		go63 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go63.name = "Terrain.TerrainSplineData";
		go63.transform.parent = dataholder.transform;
		
		go64 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go64.name = "Terrain.TerrainSplinePlaneData";
		go64.transform.parent = dataholder.transform;
		
		go65 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go65.name = "Terrain.TerrainSplinePlanePointData";
		go65.transform.parent = dataholder.transform;
		
		go66 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go66.name = "Terrain.TerrainSplinePointData";
		go66.transform.parent = dataholder.transform;
		
		go67 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go67.name = "WorldRender.CompositeMeshEntityData";
		go67.transform.parent = dataholder.transform;
		
		go68 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go68.name = "WorldRender.RigidMeshEntityData";
		go68.transform.parent = dataholder.transform;
		
		go69 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go69.name = "WorldRender.StaticEnvmapEntityData";
		go69.transform.parent = dataholder.transform;
		
		go70 = GameObject.Instantiate(emptyGO.gameObject, Vector3.zero,Quaternion.identity) as GameObject;
		go70.name = "unknown";
		go70.transform.parent = dataholder.transform;

		isstarted = true;
	}

	
	public bool IsObject(int id) {
		if (id == 29 || id == 41 || id == 70 || id == 45 || id == 63 || id == 3 || id == 6 || id == 17 || id == 57 || id == 53 || id == 35 || id == 48 || id == 14 || id == 15 || id == 16 || id == 17 || id == 18 || id == 19) {
			return false;
		} else {
			return true;
		}
		
	}
	
	public int ItemType(string item) {
		if (isstarted == false) {
			Inst();
		}
		if(item == "Entity.AreaGeometryEntityData") {
			return 1;
		} else if(item == "Entity.ObjectSet") {
			return 2;
		} else if(item == "Entity.PingPongRotationVisualTransformModifierData") {
			return 3;
		} else if(item == "Entity.ReferenceObjectData") {
			return 4;
		} else if(item == "Entity.SequenceData") {
			return 5;
		} else if(item == "Entity.WorldObjectListData") {
			return 6;
		} else if(item == "GameSharedResources.AlternateSpawnEntityData") {
			return 7;
		} else if(item == "GameSharedResources.ArmDisarmAwardEntityData") {
			return 8;
		} else if(item == "GameSharedResources.AutoTeamEntityData") {
			return 9;
		} else if(item == "GameSharedResources.CapturePointEntityData") {
			return 10;
		} else if(item == "GameSharedResources.ChaseCameraData") {
			return 11;
		} else if(item == "GameSharedResources.ClearAreaTriggerEntityData") {
			return 12;
		} else if(item == "GameSharedResources.CombatAreaTriggerEntityData") {
			return 13;
		} else if(item == "GameSharedResources.CutsceneCameraEntityData") {
			return 14;
		} else if(item == "GameSharedResources.CutsceneEntityCameraData") {
			return 15;
		} else if(item == "GameSharedResources.CutsceneEntityData") {
			return 16;
		} else if(item == "GameSharedResources.CutsceneEntityScreenFadeData") {
			return 17;
		} else if(item == "GameSharedResources.CutsceneObjectEntityData") {
			return 18;
		} else if(item == "GameSharedResources.CutsceneVehicleEntityData") {
			return 19;
		} else if(item == "GameSharedResources.DamageAreaTriggerEntityData") {
			return 20;
		} else if(item == "GameSharedResources.DelayTriggerEntityData") {
			return 21;
		} else if(item == "GameSharedResources.EventSplitterEntityData") {
			return 22;
		} else if(item == "GameSharedResources.ForestEntityData") {
			return 23;
		} else if(item == "GameSharedResources.GameEffectEntityData") {
			return 24;
		} else if(item == "GameSharedResources.GameInteractionEntityData") {
			return 25;
		} else if(item == "GameSharedResources.GameSoundEntityData") {
			return 26;
		} else if(item == "GameSharedResources.HumanPlayerEntityData") {
			return 27;
		} else if(item == "GameSharedResources.InputRestrictionEntityData") {
			return 28;
		} else if(item == "GameSharedResources.LevelData") {
			return 29;
		} else if(item == "GameSharedResources.LifeCounterEntityData") {
			return 30;
		} else if(item == "GameSharedResources.MapMarkerEntityData") {
			return 31;
		} else if(item == "GameSharedResources.MenuEntityData") {
			return 32;
		} else if(item == "GameSharedResources.MessageEntityData") {
			return 33;
		} else if(item == "GameSharedResources.MiddlegrowthModelGroupEntityData") {
			return 34;
		} else if(item == "GameSharedResources.MiddlegrowthModelGroupMemberData") {
			return 35;
		} else if(item == "GameSharedResources.MissionEntityData") {
			return 36;
		} else if(item == "GameSharedResources.MissionObjectiveEntityData") {
			return 37;
		} else if(item == "GameSharedResources.MultipleTriggerEntityData") {
			return 38;
		} else if(item == "GameSharedResources.PredestructionEntityData") {
			return 39;
		} else if(item == "GameSharedResources.PreRoundEntityData") {
			return 40;
		} else if(item == "GameSharedResources.RichPresenceConnection") {
			return 41;
		} else if(item == "GameSharedResources.SoldierSpawnEntityData") {
			return 42;
		} else if(item == "GameSharedResources.SoundAreaEntityData") {
			return 43;
		} else if(item == "GameSharedResources.SpectateEntityData") {
			return 44;
		} else if(item == "GameSharedResources.SquadData") {
			return 45;
		} else if(item == "GameSharedResources.StatEventTriggerEntityData") {
			return 46;
		} else if(item == "GameSharedResources.StaticModelGroupEntityData") {
			return 47;
		} else if(item == "GameSharedResources.StaticModelGroupMemberData") {
			return 48;
		} else if(item == "GameSharedResources.StaticModelTriggerEntityData") {
			return 49;
		} else if(item == "GameSharedResources.StaticPositionEntityData") {
			return 50;
		} else if(item == "GameSharedResources.TeamEntityData") {
			return 51;
		} else if(item == "GameSharedResources.TerrainEntityData") {
			return 52;
		} else if(item == "GameSharedResources.TreeMemberData") {
			return 53;
		} else if(item == "GameSharedResources.VehicleSpawnEntityData") {
			return 54;
		} else if(item == "GameSharedResources.VehicleStateTriggerEntityData") {
			return 55;
		} else if(item == "GameSharedResources.VoiceOverEntityData") {
			return 56;
		} else if(item == "GameSharedResources.VoiceOverLineAsset") {
			return 57;
		} else if(item == "GameSharedResources.WeatherStateEntityData") {
			return 58;
		} else if(item == "Overgrowth.TreeMeshEntityData") {
			return 59;
		} else if(item == "Physics.HavokAsset") {
			return 60;
		} else if(item == "Physics.PhysicsEntityData") {
			return 61;
		} else if(item == "Render.CrtAnalogLinkHudFxData") {
			return 62;
		} else if(item == "Terrain.TerrainSplineData") {
			return 63;
		} else if(item == "Terrain.TerrainSplinePlaneData") {
			return 64;
		} else if(item == "Terrain.TerrainSplinePlanePointData") {
			return 65;
		} else if(item == "Terrain.TerrainSplinePointData") {
			return 66;
		} else if(item == "WorldRender.CompositeMeshEntityData") {
			return 67;
		} else if(item == "WorldRender.RigidMeshEntityData") {
			return 68;
		} else if(item == "WorldRender.StaticEnvmapEntityData") {
			return 69;
		} else {
			return 70;
		}
	}

	public void SelectParent() {

		//return emptyGO;
	}

	public GameObject SelectParents(int id) {
//		Debug.Log ("trying to set id to " + id);
		GameObject ret = go70.gameObject;
		if (id == 1) {
			ret = go1.gameObject;
		} else if (id == 2) {
			ret = go2.gameObject;
		} else if (id == 3) {
			ret = go3.gameObject;
		} else if (id == 4) {
			ret = go4.gameObject;
		} else if (id == 5) {
			ret = go5.gameObject;
		} else if (id == 6) {
			ret = go6.gameObject;
		} else if (id == 7) {
			ret = go7.gameObject;
		} else if (id == 8) {
			ret = go8.gameObject;
		} else if (id == 9) {
			ret = go9.gameObject;
		} else if (id == 10) {
			ret = go10.gameObject;
		} else if (id == 11) {
			ret = go11.gameObject;
		} else if (id == 12) {
			ret = go12.gameObject;
		} else if (id == 13) {
			ret = go13.gameObject;
		} else if (id == 14) {
			ret = go14.gameObject;
		} else if (id == 15) {
			ret = go15.gameObject;
		} else if (id == 16) {
			ret = go16.gameObject;
		} else if (id == 17) {
			ret = go17.gameObject;
		} else if (id == 18) {
			ret = go18.gameObject;
		} else if (id == 19) {
			ret = go19.gameObject;
		} else if (id == 20) {
			ret = go20.gameObject;
		} else if (id == 21) {
			ret = go21.gameObject;
		} else if (id == 22) {
			ret = go22.gameObject;
		} else if (id == 23) {
			ret = go23.gameObject;
		} else if (id == 24) {
			ret = go24.gameObject;
		} else if (id == 25) {
			ret = go25.gameObject;
		} else if (id == 26) {
			ret = go26.gameObject;
		} else if (id == 27) {
			ret = go27.gameObject;
		} else if (id == 28) {
			ret = go28.gameObject;
		} else if (id == 29) {
			ret = go29.gameObject;
		} else if (id == 30) {
			ret = go30.gameObject;
		} else if (id == 31) {
			ret = go31.gameObject;
		} else if (id == 32) {
			ret = go32.gameObject;
		} else if (id == 33) {
			ret = go33.gameObject;
		} else if (id == 34) {
			ret = go34.gameObject;
		} else if (id == 35) {
			ret = go35.gameObject;
		} else if (id == 36) {
			ret = go36.gameObject;
		} else if (id == 37) {
			ret = go37.gameObject;
		} else if (id == 38) {
			ret = go38.gameObject;
		} else if (id == 39) {
			ret = go39.gameObject;
		} else if (id == 40) {
			ret = go40.gameObject;
		} else if (id == 41) {
			ret = go41.gameObject;
		} else if (id == 42) {
			ret = go42.gameObject;
		} else if (id == 43) {
			ret = go43.gameObject;
		} else if (id == 44) {
			ret = go44.gameObject;
		} else if (id == 45) {
			ret = go45.gameObject;
		} else if (id == 46) {
			ret = go46.gameObject;
		} else if (id == 47) {
			ret = go47.gameObject;
		} else if (id == 48) {
			ret = go48.gameObject;
		} else if (id == 49) {
			ret = go49.gameObject;
		} else if (id == 50) {
			ret = go50.gameObject;
		} else if (id == 51) {
			ret = go51.gameObject;
		} else if (id == 52) {
			ret = go52.gameObject;
		} else if (id == 53) {
			ret = go53.gameObject;
		} else if (id == 54) {
			ret = go54.gameObject;
		} else if (id == 55) {
			ret = go55.gameObject;
		} else if (id == 56) {
			ret = go56.gameObject;
		} else if (id == 57) {
			ret = go57.gameObject;
		} else if (id == 58) {
			ret = go58.gameObject;
		} else if (id == 59) {
			ret = go59.gameObject;
		} else if (id == 60) {
			ret = go60.gameObject;
		} else if (id == 61) {
			ret = go61.gameObject;
		} else if (id == 62) {
			ret = go62.gameObject;
		} else if (id == 63) {
			ret = go63.gameObject;
		} else if (id == 64) {
			ret = go64.gameObject;
		} else if (id == 65) {
			ret = go65.gameObject;
		} else if (id == 66) {
			ret = go66.gameObject;
		} else if (id == 67) {
			ret = go67.gameObject;
		} else if (id == 68) {
			ret = go68.gameObject;
		} else if (id == 69) {
			ret = go69.gameObject;
		} else {
			ret = go70.gameObject;
		}
		return ret.gameObject;
	}
}

