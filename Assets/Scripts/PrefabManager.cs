using UnityEngine;
public class WorldClockManager : MonoBehaviour {
    // Reference to your clock prefab
    public GameObject Clock;
    private GameObject New_York;
    private GameObject Tokyo;
    private GameObject London;
    private GameObject Rome;
    Renderer ClockRenderer;
    public Material NewYorkLandmark;
    public Material TokyoLandmark;
    public Material LondonLandmark;
    public Material RomeLandmark;

    void Start() {

        // Instantiate the New York clock
        GameObject New_York = Instantiate(Clock, new Vector3(-5, 0, 0), Quaternion.identity);
        Clock New_YorkScript = New_York.GetComponent<Clock>();
        if (New_YorkScript != null)
        {
            New_YorkScript.timeZoneOffset = -4; // New York is UTC-4 (adjust for DST if necessary)
            New_York.GetComponentInChildren<Renderer>().material = NewYorkLandmark;

        }

        // Instantiate the Tokyo clock
        GameObject Tokyo = Instantiate(Clock, new Vector3(5, 0, 0), Quaternion.identity);
        Clock TokyoScript = Tokyo.GetComponent<Clock>();
        if (TokyoScript != null)
        {
            TokyoScript.timeZoneOffset = +9; // Tokyo is UTC +9 (adjust for DST if necessary)
            Tokyo.GetComponentInChildren<Renderer>().material = TokyoLandmark;
        }

                // Instantiate the London clock
        GameObject London = Instantiate(Clock, new Vector3(5, 13, 0), Quaternion.identity);
        Clock LondonScript = London.GetComponent<Clock>();
        if (LondonScript != null)
        {
            LondonScript.timeZoneOffset = +1; // London is UTC +1 (adjust for DST if necessary)
            London.GetComponentInChildren<Renderer>().material = LondonLandmark;
        }

                // Instantiate the Rome clock
        GameObject Rome = Instantiate(Clock, new Vector3(-5, 13, 0), Quaternion.identity);
        Clock RomeScript = Rome.GetComponent<Clock>();
        if (RomeScript != null)
        {
            RomeScript.timeZoneOffset = +2; // Rome is UTC +2 (adjust for DST if necessary)
            Rome.GetComponentInChildren<Renderer>().material = RomeLandmark;
        }
    }
    
}
