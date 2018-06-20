using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DracoMeshObject : MonoBehaviour
{
	public string AssetName = "out";
    // This function will be used when the GameObject is initialized.
    void Start()
	{
        // If the original mesh exceeds the limit of number of verices, the
        // loader will split it to a list of smaller meshes.
        List<Mesh> meshes = new List<Mesh>();
		DracoMeshLoader dracoLoader = new DracoMeshLoader();
        /*
         * Here we use the compressed Bunny model as example.
         * It's in unity/Resources/bunny.drc.bytes.
         * Please see README.md for details.
         */
        int numFaces = dracoLoader.LoadMeshFromAsset(AssetName, ref meshes);


        /* Note: You need to add MeshFilter (and MeshRenderer) to your GameObject.
         * Or you can do something like the following in script:
         * AddComponent<MeshFilter>();
         */
        if (numFaces > 0)
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
