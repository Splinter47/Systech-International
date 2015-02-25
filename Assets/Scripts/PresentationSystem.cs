using UnityEngine;
using System.Collections;

//Public enumerator which shows all The Services
public enum Service
{
	Commercial,
	Planning,
	Risk,
	Turnaround,
	Claims,
	Dispute,
	Witness,
	Legal,
	Visualisations,
	Training
};

//Public enumerator which shows all The Services
public enum Sector
{
	//Construction
	Building,
	Civil,
	MechanicalElectrical,
	//Transportation
	Rail,
	Air,
	Highways,
	//Energy
	OilGas,
	Power,
	Mining,
	//the Rest
	Defence,
	Telecoms,
	Shipping,
	Industrial,
	Facilities
};



//Public enumerator which shows all The Office Locations
public enum Office
{
	//UK
	LondonHQ,
	Birmingham,
	Leeds,
	Manchester,
	Liverpool,
	//Europe
	Paris,
	Dublin,
	//Middle East
	DohaHQ,
	Dubai,
	AbuDhabi,
	Dammam,
	Riyadh,
	//Africa
	Johannesburg,
	//Asia
	SingaporeHQ,
	Yokohama,
	Kobe,
	Seoul,
	HongKong,
	//Pacific
	Brisbane,
	Perth,
	Sydney,
	//Americas
	AtlantaGAHQ,
	HoustonTX,
	IrvineCA,
	Toronto,
	RioDeJaneiro
};

//Public Enumerator showing the regions
public enum Region
{
	UK,
	Europe,
	Americas,
	MiddleEast,
	AsiaPacific,
	Africa
};

//The Level of Director
public enum Level 
{
	Managing,
	Service,
	Regional
};

//The main Menu
public enum Menu
{
	About = 0,
	People = 1,
	Services = 2,
	Sectors = 3,
	Projects = 4,
	Offices = 5,
	Clients = 6
};

public class PresentationSystem : MonoBehaviour {
	static public string[] MenuTitle = {
		"About",
		"People",
		"Services",
		"Sectors",
		"Projects",
		"Offices",
		"Clients"
	};

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
