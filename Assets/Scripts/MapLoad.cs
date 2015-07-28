﻿using UnityEngine;using System.Collections;using System.Collections.Generic;using System;using System.Text;using System.Text.RegularExpressions;public class MapLoad : MonoBehaviour {	//Load all mesh (Grouped objects are missing)	//convert all itexture to dds (some are missing. Fix UV map and find correct texture?)	//load texture based on meshdata-data?	//Allow back-parsing		//Edit items based on guid	//Terrain loading	//	public GameObject placeholder;	public Material material_white;	// Use this for initialization	void Start () {		var InstanceCollection = MapContainer.Load ("Assets/maps/Nam_MP_005CQ.xml");		foreach (Inst inst in InstanceCollection.instance) {			GenerateItem(inst, transform.GetComponent<MapItems>().ItemType(inst.type));		}		//Debug.Log (InstanceCollection.instance.Count);	}	Vector3 CalculatePosition(Inst inst, int id) {		Vector3 pos = Vector3.zero;		if (transform.GetComponent<MapItems>().IsObject(id)) {			if(inst.complex.value != null) {				//Debug.Log("pos val for " + inst.guid + " | " + inst.complex.value);				string coordiantes = inst.complex.value;				string[] coords = coordiantes.Split ('/');				int numcoords = coords.Length;				float z = float.Parse (coords [(numcoords - 4)]);				float y = float.Parse (coords [(numcoords - 3)]);				float x = float.Parse (coords [(numcoords - 2)]);				pos = new Vector3(x,y,z);			}		}		return pos;	}	Vector3 CalculateRotation(Inst inst, int id, string type) {		Vector3 rot = Vector3.zero;		if (transform.GetComponent<MapItems>().IsObject(id) && inst.complex.value != null) {			string coordiantes = inst.complex.value;			string[] coords = coordiantes.Split ('/');			int numcoords = coords.Length;			if(numcoords > 3) { 				float rz = (float.Parse (coords [(0)]));				float ry = (float.Parse (coords [1]));				float rx = (float.Parse (coords [2]));				float uz = (float.Parse (coords [4]));				float uy = (float.Parse (coords [5]));				float ux = (float.Parse (coords [6]));								float fz = (float.Parse (coords [8]));				float fy = (float.Parse (coords [9]));				float fx = (float.Parse (coords [10]));				if(type == "r") {					rot = new Vector3(rx,ry,rz);				} else if(type == "u") {					rot = new Vector3(ux,uz,uy);				} else if(type == "f") {					rot = new Vector3(fx,fy,fz);				}			}		}		return rot;	}	String CleanName(Inst inst, int id) {		string name = "Unknown";		foreach(Field field in inst.field) {			if(transform.GetComponent<MapItems>().IsObject(id) && field.refference != null && field.refference != "null") {				string pattern = "/[0-9a-z]+-[0-9a-z]+-[0-9a-z]+-[0-9a-z]+-[0-9a-z]+";				name = field.refference;				name = Regex.Replace(name,pattern,"");				string pattern2 = "_entity";				name = Regex.Replace(name,pattern2,"");				//Debug.Log(name);			}		}		if (name == "Unknown" || name == "null" || name == null) {						if (inst.type != null) {				name = inst.type + " | " + inst.guid;			}		}		return name;	}				void GenerateItem(Inst inst, int id) {		if (transform.GetComponent<MapItems> ().IsObject (id)) {			//Debug.Log(inst.guid + " | " + id);			Vector3 pos = CalculatePosition (inst, id);			GameObject model;			string actualmodelname = CleanName(inst, id) + "_lod0_data";			string actualmodelname2 = CleanName(inst, id) + "_mesh_lod0_data";			Debug.Log(actualmodelname);			if(Resources.Load(actualmodelname) != null) {				model = Resources.Load(actualmodelname) as GameObject;            } else if(Resources.Load(actualmodelname2) != null) {				model = Resources.Load(actualmodelname2) as GameObject;			} else {				model = placeholder.gameObject;			}			GameObject go = GameObject.Instantiate(model, pos, Quaternion.identity) as GameObject;			//go.AddComponent<ChangeUV>();			AddValues(inst, id, go);			if(id != 63 || id != 64 || id != 65 || id != 66) {				go.name = CleanName (inst, id);			} else {				go.name = "Terrain.TerrainSpline";			}			Debug.Log("Setting parent id to go" + id);			GameObject parent = transform.GetComponent<MapItems>().SelectParents(id);			//Debug.Log(parent.name);			go.transform.parent = parent.transform;			//Debug.Log("ID is set");			//transform.GetComponent<MapItems>().SelectParent();		} else {		//	Debug.Log ("Skipped " + inst.guid);		}		//go.transform.parent = transform.GetComponent<MapItems>().SelectParent(id).gameObject.transform;	}	void AddValues(Inst inst, int id, GameObject instgo) {		if (id == 1) {			AreaGeometryEntityData AGED = instgo.AddComponent<AreaGeometryEntityData>();			foreach(Field field in inst.field) {				if(field.name == "Components" && field.value != null && field.value != "null") {					AGED.Components = field.value;				}				if(field.name == "Enumeration" && field.value != null && field.value != "null") {					AGED.Enumeration = field.value;				}				if(field.name == "Name" && field.refference != null && field.refference != "null") {					AGED.Name = field.refference;				}				if(field.name == "Height" && field.value != null && field.value != "null") {					AGED.Height = field.value;				}				if(field.name == "Weight" && field.value != null && field.value != "null") {					AGED.Weight = field.value;				}				if(field.name == "Next" && field.refference != null && field.refference != "null") {					AGED.Next = field.refference;				}				if(field.name == "Previous" && field.refference != null && field.refference != "null") {					AGED.Previous = field.value;				}			}		}		if (id == 4) {			Vector3 right = CalculateRotation(inst, id, "r");			Vector3 up = CalculateRotation(inst, id, "u");			Vector3 forward = CalculateRotation(inst, id, "f");			RotationSlave rotslave = instgo.AddComponent<RotationSlave>();			rotslave.forward = forward;			rotslave.up = up;			rotslave.right = right;		}	}}