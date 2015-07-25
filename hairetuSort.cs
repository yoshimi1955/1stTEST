using UnityEngine;
using System.Collections;

public class hairetuSort : MonoBehaviour {

	public int[] sortHairetu ;
	public float work01 ;
	// Use this for initialization
	void Start () {

		h_Sort ();
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	// *******************************************************************************************
	// ********** h_Sort() ********
	void h_Sort() {

		
		for (int i=0; i < 5; i++) {
			
			work01 = 9999999;
			
			for (int j=0; j < 10; j++) {
				
				if( data_01[j,2] < work01){
					
					int k01 = i + 1 ;
					bool chekF = false ;
					
					for (int k=0; k < k01; k++) {
						if (sortHairetu[k] == j){
							
							chekF =true ;
						}					
					}
					
					if(!chekF){
						work01 = data_01[j,2] ;
						sortHairetu[i] =j ;
					}
				}
				
				
			}
			
			
		}

	}

	public float[,] data_01 = {
		// *** あいうえお
		{0,39,33,0},
		{1,16,12,0},
		{2,6,16,0},
		{3,62,6,0},
		{4,39,8,0},
		// *** かきくけこ
		{5,12,38,0},
		{6,39,45,0},
		{7,17,39,0},
		{8,32,16,0},
		{9,30,21,0},
		// *** さしすせそ

		
	};

}
