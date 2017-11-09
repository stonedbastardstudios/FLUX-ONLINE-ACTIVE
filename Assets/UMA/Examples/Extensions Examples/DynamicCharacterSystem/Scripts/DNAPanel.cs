using UnityEngine;
using System.Collections.Generic;
using System;

namespace UMA.CharacterSystem
{
	public class DNAPanel : MonoBehaviour
	{
		public List<string> Markers = new List<string>();
		private DynamicCharacterAvatar Avatar;
		public GameObject DnaEditor;
		public Vector3 InitialPos;
		public float YSpacing;
		public bool InvertMarkers;
		public List<GameObject> CreatedObjects = new List<GameObject>();
		public RectTransform ContentArea;

		public class DNAHolder : IComparable<DNAHolder>
		{
			public string name;
			public float  value;
			public int    index;
			public UMADnaBase    dnaBase;
			public DNAHolder(string Name, float Value, int Index, UMADnaBase DNABase)
			{
				name = Name;
				value = Value;
				index = Index;
				dnaBase = DNABase;
			}

			#region IComparable implementation
			public int CompareTo (DNAHolder other)
			{
				return string.Compare(name,other.name);
			}
			#endregion
		}

	public void Initialize (DynamicCharacterAvatar Avatar) 
		{

		foreach(GameObject go in CreatedObjects) UMAUtils.DestroySceneObject(go);
		CreatedObjects.Clear();

			UMADnaBase[] DNA = Avatar.GetAllDNA(); //Grabs dna value from avatar and puts them in an array

			List<DNAHolder> ValidDNA = new List<DNAHolder>(); //creates a list of the class DNAHolder

			foreach (UMADnaBase d in DNA) //itterates through DNA
			{
				string[] names = d.Names; //creates an array of string names for DNA array
				float[] values = d.Values; //creates an array of float values for the dna value

				for (int i=0;i<names.Length;i++) 
				{
					string name = names[i]; //sets name string to current array index with value of i
					if (IsThisCategory(name.ToLower())) //checks to see if this value matchs the defined string names set in editor Markers
					{
						ValidDNA.Add(new DNAHolder(name,values[i],i,d)); //if check passes create a new DNAHolder with dna values
					}
				}

			}

			ValidDNA.Sort( );
			
			foreach(DNAHolder dna in ValidDNA)
			{
				GameObject go = GameObject.Instantiate(DnaEditor); //instantiates dna editor prefab
				go.transform.SetParent(ContentArea.transform); //sets parent to content area
				go.transform.localScale = new Vector3(1f, 1f, 1f);//Set the scale back to 1
				DNAEditor de = go.GetComponentInChildren<DNAEditor>(); //grabs dna editor componenet from DnaEditor prefab
			de.Initialize(dna.name.BreakupCamelCase(),dna.index,dna.dnaBase,Avatar,dna.value); 
				go.SetActive(true);
				CreatedObjects.Add(go);
			}
		}

		bool IsThisCategory(string name)
		{
			bool retval = false;

			foreach(string s in Markers)
			{
				if (name.Contains(s))
				{
					retval = true;
					break;
				}
			}
			if (InvertMarkers)
				return !retval;
			else
				return retval;
		}
	}
}
