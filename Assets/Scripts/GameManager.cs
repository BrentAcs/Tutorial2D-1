using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Token;
    public GameObject Canvas;

    private bool _dealt;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    public void CreateTokens(int count)
    {
        if (_dealt)
            return;
        
        for( int i=0; i<count; i++)
        {
            Canvas = GameObject.Find("Main Canvas");
            GameObject token = Instantiate(Token, new Vector2(-400 +( i * 150), -400), quaternion.identity);
            token.GetComponent<DebugScript>().LogToDebug();
            token.GetComponent<Transform>().SetParent(Canvas.transform, false);
        }

        _dealt = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
