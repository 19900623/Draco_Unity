using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DracoMeshObject : MonoBehaviour
{
	public string AssetName = "te";

	void Start()
	{
		List<Mesh> meshes = new List<Mesh>();
		DracoMeshLoader dracoLoader = new DracoMeshLoader();

		int numFaces = dracoLoader.LoadMeshFromAsset(AssetName, ref meshes);

		if(numFaces > 0)
		{
			MeshFilter filter = GetComponent<MeshFilter>();
			if(filter == null)
			{
				filter = gameObject.AddComponent<MeshFilter>();
			}
			filter.mesh = meshes[0];
		}

		if(GetComponent<MeshRenderer>() == null)
		{
			MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
			renderer.material = new Material(Shader.Find("Legacy Shaders/Diffuse"));;
		}
	}
}
